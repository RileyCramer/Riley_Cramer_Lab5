# Riley_Cramer_Lab5

Problems:
Had a problem initially with taking the data and turning the output into an object so that it could be manipulated 
(created new classes to pull the data into)


Had a problem with my initial object creation method because I was pulling some of the data without pulling the “Results” layer forcing me to not be able to pull in the data because it could not manipulate all of it
(Brought the ToString from the “Thing” class over so that it could put the data into there and then used inheritance between “Spells” and “Thing” so that it could read the information)


Had a problem with the deserializer because it used the “Spells” class but I tried to make it run through the “Thing” class to pull the data I wanted and to give a better structure, but I ran into an error where it was having trouble converting from one class to the other using the list  
(Currently working on this step will update when fixed)
(Fixed: Had help from instructor William Rochelle. The list I initialized at the top of my Program class was not needed and was just an empty list that I was using. So it was removed and the code worked fine after)

The next step was adding the search function which was straight forward with a simple .Where addition in my for each loop for the specific search function that goes off the starting of the word. (It uses .StartsWith for the search.)

I went back through and changed up my search function so that it could do a contains function rather than a starts with function to pull more knowledge. I also changed it to search for index so that I won't have to worry about some answers not getting p[ulled because the first ;letter in the name isn't capitalized.

