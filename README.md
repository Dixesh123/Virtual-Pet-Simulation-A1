[Zoom video link of Code output working](https://conestogac.zoom.us/rec/share/sW2q0ZYlBhtxqs8NZ6qSA7oUBJ1RVsNLRMbW1vR40SjuFTpWQUioIYpS_FFNVdoF.rxdhtVr7w_dDTJi3?startTime=1717092893000)


summary:
With the help of this program, a user can feed, play, and take breaks from their virtual pet. Based on these behaviors and the passage of time, the pet's state (happy, hunger, and health) varies. The application allows for console-based user interaction and is written in C#.


Class Pet Characteristics:-
-Name: What is the pet's name?
-Kind: The animal type of the pet (goat, lion, tiger, etc.).
-Hunger: The level of hunger (privately set, starting at 5) of the pet.
-Contentment: The degree of contentment of the animal (privately determined, starting at 5).
-Health: The degree of health of the animal (private set, starting at 5).
 
-Constructor Pet: assigns the name and kind of the new pet as well as initial hunger, happiness, and health values.

Method:-
-void Feedinganimal(): Reduces hunger by 2 (minimum of 1) and increases health by 1 (maximum of 10). Displays a message about the feeding  action.

-void Playwithanimal(): Increases happiness by 2 (maximum of 10) and increases hunger by 1 (maximum of 10). If the pet is too full (hunger >= 7), it will not play and displays a message. Otherwise, it displays a message about playing.

-void animalinrest(): Increases health by 2 (maximum of 10) and decreases happiness by 1 (minimum of 1). Displays a message about the pet resting.

-void ShowStatus(): Displays the current status of the pet, including hunger, happiness, and health levels. Alerts are shown if any level is critical (hunger >= 8, happiness <= 2, health <= 2).

-void TimePasses(): Simulates the passage of time, increasing hunger by 1 (maximum of 10) and decreasing happiness by 1 (minimum of 1). If hunger or happiness is at a critical level, health decreases by 1 (minimum of 1).

"For class Program"

Main Method:-
The main method begins by welcoming the user and prompting them to choose a pet type and name.

-A new Pet object is created with the user's inputs.

-The program enters a loop where it displays the pet's status and provides a menu of actions (feed, play, rest, exit).

-Based on the user's choice, the corresponding method on the Pet object is called.

-The TimePasses method is called after each action to simulate the passage of time.

-The loop continues until the user chooses to exit the program.
