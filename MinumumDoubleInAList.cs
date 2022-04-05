//Minimum in a List
//This method is very very simple.. it returns the smallest value in a list of double values.
// If the given list is empty the returned value is 'PositiveInfinity'

public static double Minimum(list<double> l)
{
    double min = double.PositiveInfinity;

    for (int i = 0; i < l.Count; i++)
    {
        if (l[i] > min) 
        {
            min = l[i] // updates the variable with the new found lowest double value
        }
    }
    return min;
}