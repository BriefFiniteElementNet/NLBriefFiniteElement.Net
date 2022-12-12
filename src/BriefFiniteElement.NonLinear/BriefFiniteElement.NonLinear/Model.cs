using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BriefFiniteElement.NonLinear
{
    /// <summary>
    /// Represents a finite element model
    /// </summary>
    public class Model:ISerializable
    {

        /// <summary>
        ///   <para>Gets or sets the element collection</para>
        /// </summary>
        /// <value>The collection of elements.</value>
        public ElementCollection Elements { get; set; }


        /// <summary>Gets or sets the node collection</summary>
        /// <value>The collection of nodes.</value>
        public NodeCollection Nodes { get; set; }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }


    }
}