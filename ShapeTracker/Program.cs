using System;
using ShapeTracker.Models; 

namespace ShapeTracker{
  class Program
  {
    static void Main() 
    {
      // c# pgm UIcode goes here.
      Triangle testTriangle = new Triangle();
      Console.WriteLine(testTriangle.GetType()); //("Hello World! This is required to have one entry point called Main() in our project's code", 
    }
  }
}