using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BriefFiniteElementNet;

namespace BriefFiniteElement.NonLinear
{
    /// <summary>
    /// Represents an finite elements
    /// </summary>
    public abstract class Element : ISerializable
    {
        /// <summary> Gets or sets label of element </summary>
        public string Label { get; set; }

        public NonLinear.Node[] Nodes { get; private set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Applies the material nonlinearity to the target element regarding TrialDisplacements.
        /// </summary>
        /// <param name="lElm">The l elm.</param>
        public abstract void ApplyMaterialNonlinearity(BriefFiniteElementNet.Element lElm);


        /// <summary>
        /// Gets the internal forces, forces applied from element to connecting nodes
        /// </summary>
        /// <param name="lElm">The l elm.</param>
        /// <returns></returns>
        public abstract Force[] GetInternalForces();
    }
}