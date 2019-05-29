Feature: HotelBooking
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Book a hotel
	Given I have entered Ubatuba into the hotel destiny 
	And I have salected date 26/06 into the start date
	And I have salected date 30/06 into the end date
	When I press the search icon
	Then the result should be a list of hotels
