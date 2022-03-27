//Method for the Point of Intersection of two lines
// this method returns the point of intersection of the lines a1x + b1y = c1 and a2x + b2y = c2 . Aka standard form of the equations of the lines
private static Point PointOfIntersection (double a1, double b1, double c1, double a2, double b2, double c2) //parameters for the method 
{
    double x = 0, y = 0;
    // To get the point of Intersection I am appplying the method of elimination 

    x = (c1 * b2 - c2 * b1) / (b2 * a1 - b1 * a2); //re-arranging to eliminate y 
    y = (c1 * a2 - c2 * a1) / (b1 * a2 - b2 * a1); //re-arranging to emiminate x

    // These values for x and y are found by isolationg and sloving for x & y in the standard form equation of ax + by = c

    return new Point((int)x, (int)y)

    //'Point' objects only support 'int' values for the co-ordinates.
    //Therefore, a conversion to 'int' must be performed before returning the result.
    // point is a constructor which can hold the reslot of two values. It is usually used to store the X and Y values for a coordinate
    // This also makes things simpler in the sense there is only one returned value in the method


}