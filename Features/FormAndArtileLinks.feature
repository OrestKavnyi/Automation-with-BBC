Feature: FormAndArtileLinks
	To successfully submit my question to BBC
	all the required fields of the form must be filled in

  Background:
	Given the BBC home page is open

  Scenario: Check that article page provides correct article link
	When i go to News
	And click on Entertainment & Arts tab
	And click the first article
	And click Share
	And copy the Link
	And navigate the link
	Then the same article is open

  Scenario: Submit question to BBC with wrong input data
	When i go to News
	And click on Coronavirus tab
	And click on Your Coronavirus Stories tab
	And go to How to Share with BBC News
	And fill in the information on the bottom
	| Key            | Value                                   |
	| story          | Lorem ipsum                             |
	| Name           | Test                                    |
	| Email address  | test@test.test                          |
	| Contact number |                                         |
	| Location       | 4 Privet Drive, Little Whinging, Surrey |
	And click Submit
	Then the story is not sent