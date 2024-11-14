Feature: Posts

Scenario Outline: Create a new Post
	Given user creates a new post using id '<id>' title '<title>' and author '<views>'
	Then a post is created with id '<id>' title '<title>' and author '<views>'
Examples:
	| id | title       | views |
	| 3  | third title | 300   |

Scenario Outline: Get a Post
	Given user retrives a post using id '<id>'
	Then verify the response for id '<id>' title '<title>' and author '<views>'
Examples:
	| id | title       | views |
	| 3  | third title | 300   |

Scenario Outline: Create a new Post with only id and title
	Given user creates a new post using id '<id>' and title '<title>'
	Then verify the response
Examples:
	| id | title        |
	| 4  | fourth title |