public static double GeometricMean(list<double> l)
{
    double geometricMean = double.Nan

    // Initalize the value of Geometric mean to double.Nan --> this should be the returned value if the list is empty

            // If the numbers in 'l' are large enough, the product l[0] x l[1] x ... x l[n-1], where n=l.Count, could 
            // result in numeric overflow. To prevent this from happening, it is better to calculate the geometric
            // mean by exploiting properties of logarithms: (1) log(x^n) = nlog(x)    (2) log(xy) = log(x) + log(y)
            //
            // GM = nth root of (l[0] x l[1] x ... x l[n-1])  (GM = geometric mean)
            //    = (l[0] x l[1] x ... x l[n-1])^(1/n)
            //
            // Therefore, log(GM) = log((l[0] x l[1] x ... x l[n-1])^(1/n))
            //                    = (1/n)log(l[0] x l[1] x ... x l[n-1])
            //                    = (1/n)(log(l[0]) + log(l[1]) + ... + log(l[n-1]))
            //                    = (log(l[0]) + log(l[1]) + ... + log(l[n-1])) / n
            // Then GM = base^((log(l[0]) + log(l[1]) + ... + log(l[n-1])) / n), where 'base' is the base used for log.
            //
            // Although this method prevents overflow, it could be susceptible to other problems such as 
            // (1) UNDERFLOW (i.e. produce values that are taken to be zero because they are smaller than the
            //     smallest value that can be represented as a 'double').
            // (2) Evaluating the logarithm is an "expensive" operation for the CPU
            //
            // double.Epsilon = 4.94065645841247E-324 = 4.94065645841247 x 10^(-324) = smallest positive value that
            // can be represented as a 'double'
            // -double.Epsilon = -4.94065645841247E-324 = -4.94065645841247 x 10^(-324) = largest negative value 
            // (i.e. closest to zero) that can be represented as a 'double'.
            // Any value between -double.Epsilon and double.Epsilon is taken to be zero


     if (l.Count > 0) // checks if the given list is empty ()
     {
         double Product = 1;
         for (int i = 0; i < l.Count; i++) // loop counter to iterate through the loop

         {
            // Since the Geometric Mean is only defined for positive integers double.Positive infinity is returned if a negative number is in the list
            if (l[i] < 0)
            {
                geometricMean = double.PositiveInfinity; 
                break;
            } 
            product *= l[i]; //if it isn't negative the item in the list is going to be multiplied to produce the product 
         }

         if (geometricMean != double.PositiveInfinity)
         {
             geometricMean = Math.Pow(product, 1/ (double)l.Count);
         }
     }

     return geometricMean;
}