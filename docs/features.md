# Planned Features for new library
This file contains features which will be integrated into new library.

Name|Description or hyperlink|
--- | --- |
Geometric nonlinearity | Considering Geometric Nonlinearity of structures, i.e. P-Δ (P-big-Delta) effect
Material nonlinearity | Considering material nonlinearity in the library
composite 1-d Element | Composite means traditional RC circuit, rainforced concrete and steel rebar, or steel tube of section, with or without fiber polymer coating. Element's sections are represented as a class with 2d polygonal parts. Will call this BarElement very similar to BFE
2-d Element | like shells etc.
Concentrated elemental loads | concentrate load and distributed load applied to element, load direction can vary when geometry changes. for example a beam bends and if force is set to perpendicuar to the beam, then load direction also changes
Very precise error description | when an error occures, like "non pos def", more user friendly message be shown.
CLS Compliant | for using with other .NET based languages
Streamable Objects | object should be serializable for binary writing into files.
Expanded Analysis Classes | Unlike BFE, which all analysis codes where inside 1-2 files and was tangled and reduce the code quality, in the new library analysis codes should be expanded to several classes, like domain etc. which is used by OpenSEES and others

# Grey areas (to be discussed)

MPC elements (like RigidElement in bfe) : what formulation etc.

Remove of loadcase and loadcombination: sinse stiffness matrix cannot be reused for each load case then better to remove complexity

Initial Displacements or settlements: How to apply them? at inital stage or step by step?


# Limitations of new library

## Only static analysis
Since it is somehow hard to integrate the dynamic nonlinearity and (like hystersis etc.) we (I) do not have enough knowledge , thus will aim for only static analysis for this library.
