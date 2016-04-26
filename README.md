#**_CarRacers-4-Year-Final-Project_**
###**_Project Name_**: _CarRacers
###**_College_**: GMIT
###**Student Name**: Julien Yaho
###**Student ID**: G00280658
###**Software Used**: Unity3D

####**_Introduction_**
I chose to do my final project on unity3D because i want to learn a new software and langue and also 
challange myself. I choose this project because nowadays games have become parts of our daily life, chrildren and adult 
both play games in their spart times. I believe that some people spent more time on there mobile phone playing games, because 
of this I decied to create my final year project on a 3D game which will allow user to play my game.

### **_Code_**
This code allow the user to collect the coin and after it Destroy the coin.
```python
void OnTriggerEnter(Collider collider)
	{
		switch (collider.gameObject.name) 
		{

		case "Car":
			CoinController.coinCount++;

			Destroy (this.gameObject);
			break;
		}
	}
````
### **_How to Runner this Program_**

https://github.com/julienyaho/CarRace-4-Year-Final-Project/blob/master/Start%20up.PNG

**_start up_**:- This give the user an option either to Play the game or Exit the game.

https://github.com/julienyaho/CarRace-4-Year-Final-Project/blob/master/System%20Design.PNG

**_Exit Option_**:- if the user choice to Exit the the game it would ask the 
user if he/she is sure they want to Exit the game and they can pick yes or no.

####**_Problems Face_**
I face alot of problem when doing the project some of the problems are:-
* couldn't not get a code to work on my project.
* I run out of time.
* I couldn't achieve my goal because i run out of time and i couldn't find the right code to suit my project.
* hard problem with camera in unity3d.

####**_Conclusion_**
What I have learn when doing project is that a successful project is when people come together and communicate often.
I also when that when doing a project on you own make sure you do research early before you start to use the software 
or start coding and make sure you get the equipment or check for codes that you think it would be good for your project.
what I learn from this project is that never give up when things are not going to plan keep try still you get it working and 
I notice that you will always run into Errors, to go about this you would have to research and keep try different code.


