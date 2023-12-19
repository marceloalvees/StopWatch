Stopwatch Console App
This simple console application allows you to set a countdown timer in either seconds or minutes. When the timer reaches zero, it displays a "Stop Stopwatch" message. The user can interact with the program through a menu system.

How to Use
Run the application.
Choose the time duration format:
Enter time in seconds: 10s for 10 seconds.
Enter time in minutes: 1m for 1 minute.
Enter 0 to exit the application.
The program will provide a countdown with a "Ready," "Set," and "Go" sequence before starting the timer.
The timer will count down to zero, and a "Stop Stopwatch" message will be displayed.
Code Structure
Menu()
Clears the console.
Displays the welcome message and instructions.
Takes user input for the desired time duration.
Parses the input to determine the time and type (seconds/minutes).
Calls PreStart() or exits the application based on user input.
PreStart(int time)
Clears the console.
Displays a "Ready," "Set," "Go" sequence with 1-second delays.
Calls Start(int time) to initiate the countdown.
Start(int time)
Runs a loop to countdown from the specified time.
Clears the console and displays the current countdown value.
Pauses for 1 second between each count.
Displays a "Stop Stopwatch" message when the countdown reaches zero.
