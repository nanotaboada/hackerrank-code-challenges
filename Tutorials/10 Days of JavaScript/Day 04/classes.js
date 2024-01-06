/*
 * Implement a Polygon class with the following properties:
 * 1. A constructor that takes an array of integer side lengths.
 * 2. A 'perimeter' method that returns the sum of the Polygon's side lengths.
 */

// Class
class Polygon {
    // Constructor
    constructor(sides) {
    this.sides = sides;
    }
    // Method
    perimeter() {
        let perimeter = 0;
        for (const side of this.sides)
        {
            perimeter += side;   
        }
        return perimeter;
    }
}
