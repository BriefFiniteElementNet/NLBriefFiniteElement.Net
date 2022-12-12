using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BriefFiniteElement.NonLinear
{
    /// <summary>
    /// Represents an elemental load (load applied to element's body, like distributed load)
    /// </summary>
    public class ElementalLoad : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}