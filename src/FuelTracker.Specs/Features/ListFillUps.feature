Feature: List Fillups
	In order to keep track of my vehicle's consumption
	As a car owner
	I want to be able to list my fillups

Scenario: List fillups with only one fillup
	Given I added the following fillup
	| Field           | Value |
	| OdometerReading | 1000  |
	| Gallons         | 20    |
	| TotalCost       | 4000  |
	When I list my fillups
	Then I should see the following fillups
	| OdometerReading | Gallons | TotalCost | PricePerGallon |
	| 1000            | 20      | 4000      | 200            |
