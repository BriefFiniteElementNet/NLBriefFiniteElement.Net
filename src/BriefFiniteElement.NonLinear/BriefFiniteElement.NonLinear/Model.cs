using System;
using System.Collections.Generic;
using System.Text;

namespace BriefFiniteElement.NonLinear
{
 
    /// <summary>
    /// Represents a finite element model
    /// </summary>
    public class Model
    {
        public ElementCollection Elements
        {
            get;
            set;
        }

        public NodeCollection Nodes
        {
            get;
            set;
        }
    }
}