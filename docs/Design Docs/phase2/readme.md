Solve procedure and residual force etc
======

For linear FEM there is simple procedure. create nodal load vector, stiffness matrix and simply solve the equation and find the displacement vector.
Hoewer for the nonlinear models there is different procedure. we use itterative method so should itteratively solve model in several steps. 
Imagine simple console beam under load `F` at free end:

IMAGE HERE

There should be a `Δ` related to `F`, and we want to find the `Δ` while `F` is known. in linear model we can simple reverse the stiffness matrix and multiply with force vector in order to find displacement matrix eg `Δ`. 

stiffness matrix is simmetric so will have:

```
         |12  6L    -12    6L    |
         |.   4L^2  -6L    2L^2  |
k = EI/L |.   .     12     -6l   |
         |.   .     .      4L^2  |

```
and force vector is:

```
f = {0  0  F  0}
```

simply remove lines related to fixed DoFs, we call k' and f' :

```

k' = EI/L | 12 -6l  |
         | -6l 4L^2|
         
f' = {F 0}
```

For this example we are searching for only 'Δ' and not searching for theta of tip of element. finding `Δ` is simple as reversing `k'` and multiply by `f'`. this is for linear model where model behaves perfectly linear. or at least we think they are so :)

Hoewer for nonlinear models there is a different procedure. for nonlinear models we assume a trial displacement vector. trial means some sort of augmented. 

Lets consider a random value for `Δ` (we call it `Δ_trial`). we can find the end forces which this `Δ_trial` can cause on our model. we will cover the finding end force in next sections.
So we have a known `Δ_trial` and can find the trial end forces (`F_trial`, `M1_trial` and `M2_trial`) relate to this trial displacement vector. Easy yet.

Next we need to find out how much it is different from original `F` applied to the original model. If `F_trial` and `F` are equal, or at least very near, we can consider `Δ_trial` as our solution. but usualy at first steps there is a large difference between `F` and `F_trial`. so for next step we should consider another force vector, named `F-residual` which is equal to `F - F_trial`.
if the `F` and `F_trial` are equal, this `F-residual` is zero, or if they are very close, this `F_residual` will be very close to zero which is what we need.

But if they are not close, then we need another guess for the `Δ_trial`, and then do above steps again, as this method is itterative.

To find next guess for `Δ_trial`, we should solve the model for `F_residual`. node that model's geometry is changed and new locations of nodes is moved by `Δ_trial`. this way we can apply the geometric nonlinearity. also we have some strains at the begining of the step. those strains will cause some initial strains to the elements, and when we are calculating the stiffness matrix we should consider those strains, and that way we could consider material nonlinearity.
