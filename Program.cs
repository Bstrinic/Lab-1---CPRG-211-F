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

//Changing the favorite colour to white.
public void ChangeFavoriteColour()
{
    ChangeFavoriteColour = "White";
}

//Get the age after 10 years.
public int GetAgeInTenYears()
{
    return age + 10;
}

//Overiding the ToString method to display the details of the information.
public override string ToString()
{
    return $"Person Id: {personId}\nFirst Name: {firstName}\nLast Name: {lastName}\nFavorite Colour: {favoriteColour}\nAge: {age}\nIs Working: {IsWorking}";
}
