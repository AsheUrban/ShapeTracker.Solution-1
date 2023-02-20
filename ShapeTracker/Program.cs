using System;
using ShapeTracker.Models; 

namespace ShapeTracker{
  class Program
  {
    static void Main() 
    {
      // c# pgm UIcode goes here.
      Triangle testTriangle = new Triangle();
      Console.WriteLine(testTriangle.GetType()); //
      
      testTriangle.Side1 = 65; 
      testTriangle.Side3 = 88; 

      Console.WriteLine($"Side one of the triangle: {testTriangle.Side1}");
      Console.WriteLine($"Side two of the triangle: {testTriangle.Side2}");
      Console.WriteLine($"Side three of the triangle: {testTriangle.Side3}");
    }
  }
}