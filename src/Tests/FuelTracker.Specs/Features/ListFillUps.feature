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

Scenario: List fillups with two fillups
	Given I added the following fillup
		| Field           | Value |
		| OdometerReading | 1000  |
		| Gallons         | 20    |
		| TotalCost       | 4000  |
	Given I added the following fillup
		| Field           | Value |
		| OdometerReading | 1100  |
		| Gallons         | 10    |
		| TotalCost       | 2000  |
	When I list my fillups
	Then I should see the following fillups
		| OdometerReading | Gallons | TotalCost | PricePerGallon |
		| 1000            | 20      | 4000      | 200            |
		| 1100            | 10      | 2000      | 200            |
