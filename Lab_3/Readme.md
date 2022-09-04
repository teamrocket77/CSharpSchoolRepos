# Objective:
In this lab, you’ll create a program which allows us to administer a quiz. A user will be able to add questions, remove questions and modify questions. In addition, a user will be able to take a quiz and get a score.
## Classes:
You’ll be creating two classes. A Question Class and a Quiz Class.
<br>
Question class
<br>
Each object created from the Question Class will hold one question. Objects created from the Question class should have the following attributes:
All attributes should be private, and there should be getters/setters for all attributes. It should have a constructor that sets all 3 attributes.
<br>
1. The question text (string)
1. The question answer (string)
1. Level of difficulty (integer 1-3, 1 being easy, 3 being difficult)
<br>
<br>
## Quiz class
The Quiz class must contain an arraylist or list of objects that should be created from the Question Class. The Quiz class should have the following methods:
1. `add_question()` Method should prompt the user for a new question, answer and difficulty, and then create a Question object with that data and add it to the arraylist/list.
2. `remove_question()` Method should present the user with a list of all the question texts, and ask which one to remove. When the user indicates the question to remove, it should remove that question from the arraylist/list.
3. `modify_question()` Method should present the user with a list of all the question texts, and ask which one to change. Then it should prompt the user for the new question text, the new question answer, and the new difficulty, and update the appropriate question in the arraylist.
4. `give_quiz()` Method should present each question to the user, accept an answer (string) for each question. It should then tell the user if they are correct or wrong (if the string the user typed in exactly matches the correct answer stored in the question object they are correct). Keep track of their score. At the end of the quiz, tell the user how many they got correct.

