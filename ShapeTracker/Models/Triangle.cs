using System.Collections.Generic;

namespace ShapeTracker.Models 
{
  public class Triangle 
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }

    public int Side2 { get; set; }
    private int _side3; 
    private static List<Triangle> _instances = new List<Triangle> {};
    // auto-implemented property (like Side2)
    
    // public string Guess { get; set; }
    
    // Data type of parameters: If we want to allow users to enter an open-ended guess, like entering the string "isosceles", or make a selection from a predefined list, like choosing the char 'a' or 'b', we can add overloaded constructors to account for different type of data. Note that you will need separate properties/fields for each type of data you want to store.
    public string OpenGuess { get; set; }
    public char MultipleChoiceGuess { get; set; }
    public Triangle(int length1, int length2, int length3)
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
      _instances.Add(this);
    }

    // Flexibility of parameters: We can choose to have a different number of parameters (as seen in the example we use above) or even no parameters at all. To include no parameters, add an empty constructor like this:
    // this may also be written as: 
    public Triangle() {}

    // DRY up constructor overload
    public Triangle(int length1, int length2, int length3, string userGuess): this (length1, length2, length3)
    {
      // _side1 = length1; 
      // Side2 = length2;
      // _side3 = length3;
      // Guess = userGuess; 
      // _instances.Add(this);

      OpenGuess = userGuess; 

    }

    public Triangle(int length1, int length2, int length3, char userGuess) : this(length1, length2, length3)
    {
      MultipleChoiceGuess = userGuess; 
    }
    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int newValue)
    {
      _side3 = newValue;
    }

    public string CheckType()
    {
      if ((Side1 > (Side2 + _side3)) || (Side2 > (Side1 + _side3)) || (_side3 > (Side1 + Side2))) 
      {
        return "not a triangle";
      } 
      else if ((Side1 != Side2) && ((Side1 != _side3)) && ((Side2 != _side3))) 
      {
        return "scalene triangle";
      }
      else if ((Side1 == Side2) && (Side1 == _side3)) 
      {
        return "equilateral triangle";
      } 
      else
      {
        return "isosceles triangle";
      }
    }

    public static List<Triangle> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}