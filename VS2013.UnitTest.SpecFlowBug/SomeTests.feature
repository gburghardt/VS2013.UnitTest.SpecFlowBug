Feature: SomeTests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given everything is right with the world

Scenario: True is true
	Then true is true
	And false is not true
	And false is false

Scenario: False is not true
	Then true is true
	And false is not true
	And false is false
