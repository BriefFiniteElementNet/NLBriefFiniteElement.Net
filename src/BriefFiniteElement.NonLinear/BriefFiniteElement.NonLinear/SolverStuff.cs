using System;
using System.Collections.Generic;
using System.Text;
using Linear = BriefFiniteElementNet;
using Nonlinear = BriefFiniteElement.NonLinear;

namespace BriefFiniteElement.NonLinear
{
    public class SolverStuff
    {
        public SolverResult Solve(Model model)
        {
            model.Nodes.ForEach(i => i.TrialDisplacement = Linear.Displacement.Zero);

            var n = model.Nodes.Count;

            var trialForces = new Linear.Force[n];//forces from elements to nodes
            var externalForces = new Linear.Force[n];//forces from external loads to nodes, like distributed loads

            var nlmodel = model;


            var lmodel = new Linear.Model();

            {
                foreach (var nde in nlmodel.Nodes)
                {
                    var n2 = new Linear.Node(nde.Location);
                    n2.Constraints = nde.Constraints;
                    lmodel.Nodes.Add(n2);
                }

                {
                    for (var i = 0; i < nlmodel.Nodes.Count; i++)
                        nlmodel.Nodes[i].Index = i;

                    lmodel.ReIndexNodes();
                    lmodel.ReIndexElements();
                }

                foreach (var nlelm in nlmodel.Elements)
                {
                    var lelm = GetEquivalentElement(nlelm);

                    for (var i = 0; i < nlelm.Nodes.Length; i++)
                        lelm.Nodes[i] = lmodel.Nodes[nlelm.Nodes[i].Index];
                }
            }

            while (true)
            {
                lmodel.LastResult.Clear();

                for (var i = 0; i < nlmodel.Elements.Count; i++)
                {
                    var nlElm = nlmodel.Elements[i];

                    var lElm = lmodel.Elements[i];

                    nlElm.ApplyMaterialNonlinearity(lElm);
                }

                for (var i = 0; i < n; i++)
                    trialForces[i] = Linear.Force.Zero;

                foreach (var nlelm in nlmodel.Elements)
                {
                    var n2 = nlelm.Nodes.Length;

                    var forces = nlelm.GetInternalForces();

                    for (var j = 0; j < n2; j++)
                    {
                        var globalIdx = nlelm.Nodes[j].Index;

                        trialForces[globalIdx] += forces[j];
                    }
                }


            }

            throw new NotImplementedException();
        }


        private Linear.Element GetEquivalentElement(NonLinear.Element elm)
        {
            if (elm is NonLinear.Elements.BarElement)
                return new Linear.Elements.BarElement();

            if (elm is NonLinear.Elements.TriangleElement)
                return new Linear.Elements.TriangleElement();

            if (elm is NonLinear.Elements.TetrahedronElement)
                return new Linear.Elements.TetrahedronElement();

            throw new NotImplementedException("Ëlement not supported");
        }
    }
}
