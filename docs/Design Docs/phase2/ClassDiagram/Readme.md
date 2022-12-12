Class List
=====

Model
	*Elements*: `ElementCollection`
	*Nodes*: `NodeCollection`
	

Element
	*Loads* : `LoadCollection`
	*Nodes* : `Node[]`
	*GetTrialEndForces()*: `Force[]`
	
BarElement
	*Section* : `CompositeSection`
	*Behaviour* : Truss or Beam (maybe this property not required)
	
Node
	*Location* : `Point`
	*TrialDisplacement*: `Common.Displacement`
	*Loads*: `LoadCollection`
	*Constraints*: `Common.Constraint`
	*Settlement*: `Common.Displacement`
	*Index*: `int`

ElementCollection

NodeCollection

NodalLoad
	*Force*: Common.Force
	
Loads.ConcentratedLoad
	*Magnitude*: `Common.Force`
	*Location* : `Isoparametric`
	*CoordinationSystem* : Local or global
	
Loads.UniformLoad
	*Magnitude* : `double`
	*Direction*: `Common.Vector`
	*CoordinationSystem*: Local or global
	
Loads.PartialNonuniformLoad
	*Magnitude* : `double`
	*Direction*: `Common.Vector`
	*CoordinationSystem*: Local or global
	
CompositeSection
	`Directly use form CompositeSectionPackage. not worth to write a wrapper around CompositeSection.`
	
MpcElements.RigidElement

MpcElements.Hing


Notes:
- BarElement: have section property for CompositeSection
- Get End Forces due to trial displacements of connected nodes (GetTrialEndForces)
- Partial element connections how are handled
- How MPC elements are handled

