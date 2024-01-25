using System;
using System.Collections.Generic;

//Defining the Person class. 
class Person
{
    //Defining the attributes.
    public int personID;
    public string firstName;
    public string lastName;
    public string favoriteColour;
    public int age;
    public bool isWorking;
}

//Displaying information about the person. 
public void DisplayPersonalInfo()
{
    Console.WriteLine($"Name= {firstName} {lastName}\npersonId: {personID} Name's favorite colour is {favoriteColour}");
}

//Changing the favorite colour to white
public void ChangeFavoriteColour()
{
    ChangeFavoriteColour = "White";
}

