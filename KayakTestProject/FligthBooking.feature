Feature: FligthBooking
	Quiero buscar vuelos
	

@mytag
Scenario: Search for Flights
	Given I am in the Kayak Flight Page
	And I have entered current date in IDA
	And I have entered "10" plus days from current date in VUELTA
	And I have entered "Buenos Aires" city in ORIGEN
	And I have entered "Sao Paulo" city as DESTINO
	When I click on the Search Icon
	Then the result should be a list of flights for those date
	



