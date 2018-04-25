Memory Game

April 24, 2018

Small Description:
This memory game is being created as an assignment 2 requuirement for class.
User can Login, View High Schore, and Play the Game.


Getting Started:
No updates or patches needed to play this game. 
Just install the .exe file and your are good to go.

System Requirements:
Windows Operating System
Windows XP, 8, 8.1, 10
Minimum 64 MB of RAM
Screen resolution 800x600 or higher
Minimum 64 MB RAM

What You Will Find In This Game.

Log In Page:
In the login page we are allowing the user to log into their account. 
Default Account: (User name: user1 Password: password1).
Add Player: (User name and Password of your choosing).
On the click of the Login button a call is sent the the Local DB where it will search to see if there is a 
user name and password there.
If the user does not provide the proper user name, password combination we are returning a message letting 
them know to "Please provide both correct UserName and Password".

Home Page:
The first thing you may notice in the HomePage is the big High scores list in the right. 
We used a dataGridView, right under the view we have a button, If clicked will connect to the database and 
retrieve high scores. We also have a how to play button which takes us to the how to play page.
Next we have a start new game button in which when clicked takes us to our difficulty select screen.
Under the start new game button we have an image inserted.

How to Play Page:
Here we show the basic instructions on how to play, score big and avoid losing points. We also have a return to home page button.

Select Difficulty Page:
On this screen we have five(5) buttons in which when clicked takes you to the game with its corresponding difficulty.
Super Easy: 95 seconds to complete the puzzle
Easy: 85 seconds to complete the puzzle
Medium: 75 seconds to complete the puzzle
Hard: 60 seconds to complete the puzzle
Super Hard: 30 seconds to complete the puzzle

The Actual Matching Game Page:
We start off by setting a list for our icons. We then set the icons random images and locations to they could be scattered every
 time we start a new game. We then initiate our clicks to turn the cards showing the random image in the front. After we go into 
 scoring, first up if the jackals match we are awarding the player five (5) seconds and 200 points. Next we have the regular scoring, 
 each match is 100 points. Last but not least we have the jackals not matching which will cause the score to drop 100 points and 
 the player will be discarded five (5) seconds. We then check if the player wins when all the pairs are matched and set a Winning 
 message, while simultaneously adding the reward points for completing the game fast. We then give the player the option to play 
 again. We do the same thing if time runs out and check if the player finished if not we give them a fail to complete 
 message and prompt the play again message.

Play Again Page:
Play Again gives the user the option to play the game again if they choose yes, if no it will take them back to the home page.

Built With:
Visual Studio 2013: Windows Form Application using C#

Authors:
S. Gregory
C. Abad

Versioning:
This is the V1.0

License:
No licenses available for this game.

Technical Support:
Email: cabad007@fiu.edu, sgreg026@fiu.edu