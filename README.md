# idea-networks

Develop interface between ProQuote and TigerPaw.

## Use Cases
1. User can create a service order in TigerPaw via a ProQuote quote having status of "accepted".
	a) By execute console app, and
	b) Providing the unique identifier of the quote as the single input (command line argument)
	c) Where status of quote is "accepted"
	d) Validation:
		1) Provided the quote exists, and
		2) The quote has status of "Accepted", and
		3) There is not an existing, viable (not been voided), service order that references the quote
		4) Then the service order will be created
	e) The contents of the service order will be derived from the quote item manifest (details to be expanded here)
