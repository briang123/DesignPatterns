# Factory pattern 

https://www.tutorialspoint.com/design_pattern/factory_pattern.htm

Factory pattern comes under creational pattern as this pattern provides one of the best ways to create an object.

In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.

# Implementation
We're going to create a Shape interface and concrete classes implementing the Shape interface. A factory class ShapeFactory is defined as a next step.

Program, our demo class will use ShapeFactory to get a Shape object. It will pass information (RECTANGLE / SQUARE) to ShapeFactory to get the type of object it needs.