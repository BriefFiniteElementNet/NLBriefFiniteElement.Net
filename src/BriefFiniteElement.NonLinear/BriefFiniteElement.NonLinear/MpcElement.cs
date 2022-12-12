using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BriefFiniteElement.NonLinear
{
    /// <summary>
    /// Represents a base class for MPC (Multy Point Constraint) element.
    /// </summary>
    public class MpcElement : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}