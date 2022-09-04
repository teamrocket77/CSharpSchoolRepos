# Concept Summary:

## CSE1322L - Lab 5
 1. Object Oriented programming concepts
 2. Abstract classes
 3. Polymorphism

## Objective:
 In this Lab you will need to create three classes and a driver program. The first class, the parent, should be an abstract class called Item. The other two classes, the children, should inherit from the parent class and be called Book and Periodicals. Finally, create a test class called myCollection.
 Using IntelliJ/Visual Studio create a ​UML diagram ​for this Lab.
Item ​abstract class
### Create an abstract class called Item. It must have:
- title - A private attribute of type string.
- A getter/setter for title
- A constructor that takes no arguments and sets title to empty string
- A constructor which takes a title and sets the title attribute.
- getListing() is an abstract method that returns a string and is implemented in classes Book
and Periodicals.
- An override of toString/ToString which returns the title.
Book ​child class
### Create a Book class which inherits from Item. It must have:
- isbn_number - A private attribute which holds an ISBN number (13 digits) to identify the book
- author - A private attribute which holds the authors name (string)
- getters/setters for the attributes in this class.
- A constructor which takes no arguments
- An overloaded constructor which sets all the attributes in the Book class as well as the
Item class.
- A concrete version of the getListing() method which should return a string that contains
the following:
   
### Periodical child class
Book Name - Title Author - Author
ISBN # - ISBN number
Periodical ​child class
Create a Periodical class which inherits from Item. It must have:
- issueNum - A private attribute which holds the issue number (e.g. 103)
- getter/setter for issueNum
- A constructor which takes no arguments
- An overloaded constructor which sets all the attributes in the Periodical class as well as
the Item class.
- A concrete version of the getListing() method which should return a string that contains
the following:
Periodical Title - Title
Issue # - Issue number
