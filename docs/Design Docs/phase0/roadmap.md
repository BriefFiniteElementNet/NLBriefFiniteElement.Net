A non-linear model should be solved in several steps, each step the nonlinear model is assumed as a linear model.
For linear solve (each step) we could use linear BFE, with PCG (Preconditioned Conjugate Gradient ).
Solver can be preconditioned with answer from last step. so complexity is reduced. In new library, underlying linear BFE model is hidden, so need to build another layer on top of the old bfe.

Model
