using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BriefFiniteElement.NonLinear
{
    /// <summary>
    /// Represents an finite elements
    /// </summary>
    public class Element : ISerializable
    {
        /// <summary> Gets or sets label of element </summary>
        public string Label { get; set; }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}