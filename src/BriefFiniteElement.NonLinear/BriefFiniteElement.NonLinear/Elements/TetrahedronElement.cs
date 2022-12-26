using System;
using System.Collections.Generic;
using System.Text;
using BriefFiniteElementNet;

namespace BriefFiniteElement.NonLinear.Elements
{
    public class TetrahedronElement : Element
    {
        public override void ApplyMaterialNonlinearity(BriefFiniteElementNet.Element lElm)
        {
            throw new NotImplementedException();
        }

        public override Force[] GetInternalForces()
        {
            throw new NotImplementedException();
        }
    }
}
