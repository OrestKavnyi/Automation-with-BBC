  Feature: ArticlesTitles
	In order to be sure that all articles are extracted correctly from DB
	We should verify their titles against expected ones

  Scenario: Check main article title
  	When i get to News page
	Then main article title should be 'Trump contradicts health chief on masks and vaccine'

  Scenario: Check secondary articles titles
  	When i get to News page
	Then secondary articles titles should be
	| Title                                               |
	| Trump contradicts health chief on masks and vaccine |
	| Greece moves migrants to new camp after fire        |
	| Biden warning for UK over post-Brexit trade deal    |
	| Protesters topple conquistador statue in Colombia   |
	| What happened to Nujeen Mustafa?                    |
	| Heat ray 'was sought'  for protest near White House |

  Scenario: Check that search result contains keyword
    When i get to News page
  	And i put category name of main article in search bar
	Then title of first found article should be 'World's End: World's End'