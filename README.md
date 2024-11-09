# Assignment-14
 
Basic Programming in C# (OOP 1)
1) Create a Base Class (Character):
● Create a class called Character that will be a base (or parent) class.
● This class will have two properties:
○ string Name: The character's name (for example, "Subhi" or
"Zarifeh").
○ int Health: The character's health (max is 100).
● Use getters and setters for both properties to control and protect the
information stored in them.
● Make a constructor to set up the character's Name and Health when
the character is created.
2) Create a Player Class:
● Make a Player class that inherits from the Character class.
● Add a Heal() method that increases (or "heals") the player’s Health
by a certain amount.
3) Create an Enemy Class:
● Make an Enemy class that also inherits from the Character class.
● Add an Attack() method that lowers (or "attacks") the Health of
another character by a specific amount.

4) Testing the Code in Unity:
In Unity, create another script GameManager (which inherits from
MonoBehavior) that will:
● Create a Player and an Enemy character.
● Print their Name and Health in the Unity Console.
● Test the Heal() method on the player to increase their health (and
print them).
● Test the Attack() method on the enemy to reduce the player’s health
(and print them).
