Feature: Posts

A short summary of the feature

@tag1
Scenario Outline: Create a new Post
	Given user creates a new post using id '<id>' title '<title>' and author '<author>'
	Then a post is created with id '<id>' title <title> and author <author>
Examples:
	| id | title   | author   |
	| 61 | title61 | author61 |