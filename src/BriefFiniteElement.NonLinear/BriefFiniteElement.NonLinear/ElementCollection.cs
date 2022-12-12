using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BriefFiniteElement.NonLinear
{
    /// <summary>
    /// Represents a collection of elements
    /// </summary>
    public class ElementCollection : List<Element>, ISerializable
    {
        /// <summary>Gets the Nodes with specified label as an array</summary>
        /// <param name="label">specified label</param>
        public Element[] this[string label]
        {
            get { return this.Where(i => i.Label == label).ToArray(); }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}