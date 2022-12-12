using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BriefFiniteElementNet;
using BriefFiniteElementNet.Common;

namespace BriefFiniteElement.NonLinear
{
    /// <summary>
    /// Represents a Node
    /// </summary>
    public class Node : ISerializable
    {

        /// <summary>Gets or sets the location of the node in 3d space</summary>
        public Point Location { get; set; }

        /// <summary>Gets or sets the DoF constrains of the node</summary>
        public Constraint Constraint { get; set; }

        /// <summary> Gets or sets the load collection of Node </summary>
        public NodalLoadCollection Loads { get; set; }

        /// <summary> Gets or sets the settlement of Node </summary>
        public Displacement Settlement { get; set; }

        /// <summary> Gets or sets the trial displacement of Node </summary>
        public Displacement TrialDisplacement { get; set; }

        /// <summary> Gets or sets label of node </summary>
        public string Label { get; set; }

        /// <summary> Gets or internally sets the index of node </summary>
        public int Index { get; internal set; }



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}