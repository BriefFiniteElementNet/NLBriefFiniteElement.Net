using System;
using System.Collections.Generic;
using System.Text;

namespace BriefFiniteElement.NonLinear
{
    public class SolverResult
    {
        public enum SolverResultStatus
        {
            Undefined,
            Successfull,
            Failed
        }

        public SolverResultStatus Status;

    }
}