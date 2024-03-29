﻿using System;
using System.Collections.Generic;
using System.Text;
using BriefFiniteElementNet;

namespace BriefFiniteElement.NonLinear.Elements
{
    /// <summary>
    /// Represents a bar element who may act as truss, beam, shaft, or combination
    /// </summary>
    public class BarElement : Element
    {
        public override void ApplyMaterialNonlinearity(BriefFiniteElementNet.Element lElm)
        {
            throw new NotImplementedException();
        }

        public override Force[] GetInternalForces()
        {
            throw new NotImplementedException();
        }
    }
}