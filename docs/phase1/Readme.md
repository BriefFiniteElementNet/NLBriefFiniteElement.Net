class-diagram

use here to render digram:
https://mermaid-js.github.io/mermaid-live-editor/edit

# Overal architecture

Architecture from calculation and computation aspect is intended to be layered and organized like this

![Architecture](arch.png)

NLBfe sits on top of BFE and ArcLength controller. It uses arclength to generate each step as a linear model.
Note that to scape from nonlinear traps will use ArcLength method along with newton raphson method. 
both BFE and ArcLength know the CSparse.NET, so there is little direct contact between NLBFE and CSparse (if any at all), most contact with CSparse is done with BFE.

To use NLBFE, user is not interfaced to BFE or ArcLength, sort of encapsulation.

The Csparse will handle sparse matrix stuff, like factorization and equation system solving by direct or itterative methods.
CSparse can solve to wellknown softwares like MKL or EIGEN or others through CsparseExtensions repository on the github.

This layered organization is good. not to the writer, but to the maintainer. I whish i did same for BFE :)
Except top layer, other layers are done and tested at the time.
