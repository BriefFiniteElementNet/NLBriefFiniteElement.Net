using System;
using System.Collections.Generic;
using System.Text;
using BriefFiniteElementNet;

namespace BriefFiniteElement.NonLinear.Loads
{
    /// <summary>
    /// Represents a uniform load applied to an element's body
    /// </summary>
    public class UniformLoad : ElementalLoad
    {
        /// <summary>
        /// Sets or gets the direction of load
        /// </summary>
        public Vector Direction { get; set; }

        /// <summary>
        /// Sets or gets the magnitude of load
        /// </summary>
        public double Magnitude { get; set; }

        /// <summary>
        /// Gets or sets the coordination system that <see cref="Direction"/> is defined in.
        /// </summary>
        /// <value>
        /// The coordination system.
        /// </value>
        public CoordinationSystem CoordinationSystem { get; set; }


    }
}
