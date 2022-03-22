public static double harmonicMean = (list<double> l)
{
    double harmonicMean = double.Nan; // the returned value if the list is empty 

         // harmonic mean is a special type of average wich is the reciprocial of the average of reciprocials 

            // Let n = l.Count and HM stand for "Harmonic Mean"
            // Then HM = n/(1/l[0] + 1/l[1] + ... + 1/l[n-1]) = n/(sum of reciprocals of values)
            // Overflow and underflow can be an issue for harmonic mean but it's less likely than
            // it is for geometric mean. If the values in the list are very large, then their reciprocals
            // are very small, making the sum of the reciprocals small. Dividing 'n' by a small value
            // can cause overflow in theory but only if 'n' is extremely large. In practice, 'n' has to be 
            // relatively small because of memory limitations. Overflow is more likely to happen if the 
            // values in 'l' are extremely small. For example, if one of the values in the list is double.Epsilon,
            // then 1/double.Epsilon = 1/(4.94065645841247E-324) = [4.94065645841247 x 10^(-324)]^(-1)
            // = (4.94065645841247)^(-1) x 10^[(-324)(-1)] > 5^(-1) x 10^324 = 0.2 x 10^324 = 2 x 10^323, which is
            // far greater than the largest 'double' value.

            if (l.count > 0) // checks if the list is empty
            {
                double ReciprocialSum = 0; // the sum of the reciprocial values in the list 
                for (int i = 0; i < l.Count; i++) // for loop iterates through all the items in the list in ascending order 
                {
                    if (l[i]< 0)
                    // Since the harmonic mean is not defined by negative numbers, the program will return double.PostiveInfinity if a nonpositive number is in the list
                    {
                        harmonicMean = double.PositiveInfinity;
                        break;
                    }
                    else ReciprocialSum += 1 / l[i];
                }
                
                if (harmonicMean != double.PositiveInfinity) //will filter out the negative result 
                {
                    harmonicMean = l.Count / ReciprocialSum; // Calculate the Harmonic Mean
                }
            }
            return harmonicMean;


}


