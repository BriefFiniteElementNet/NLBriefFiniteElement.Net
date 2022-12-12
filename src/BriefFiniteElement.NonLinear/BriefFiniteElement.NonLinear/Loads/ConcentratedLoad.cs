using System;
using System.Collections.Generic;
using System.Text;
using BriefFiniteElementNet;

namespace BriefFiniteElement.NonLinear.Loads
{
    /// <summary>
    /// Represents a concentrated load applied to an element's body
    /// </summary>
    public class ConcentratedLoad : ElementalLoad
    {
        /// <summary>
        /// Sets or gets the direction of load
        /// </summary>
        public Vector Direction { get; set; }

        /// <summary>
        /// Sets or gets the Isoparametric location of force which is applied to the element
        /// </summary>
        public double[] IsoLocaton { get; set; }

        /// <summary>
        /// Gets or sets the coordination system that <see cref="Direction"/> is defined in.
        /// </summary>
        /// <value>
        /// The coordination system.
        /// </value>
        public CoordinationSystem CoordinationSystem { get; set; }
    }
}
