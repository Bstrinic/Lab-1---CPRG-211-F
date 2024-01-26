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
}

//Defining the Relation class 
class Relation
{
    //Defining the relationship type attribute.
    public string RelationshipType;

    //Showing the relationship between the two persons
    public void ShowRelationShip(Person person1, Person person2)
    {
        Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {RelationshipType});
    }
}

//Defining the Main class
class mainClass
{
    //Entry point of the program
    public static void Main(string[] args);

    // Create Person objects
    Person person1 = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
    Person person2 = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
    Person person3 = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
    Person person4 = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };
}