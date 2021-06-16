A non-linear model should be solved in several steps, each step the nonlinear model is assumed as a linear model.
For linear solve (each step) we could use linear BFE, with PCG (Preconditioned Conjugate Gradient ).
Solver can be preconditioned with answer from last step.
