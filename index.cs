    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public int Factorial(int n){
                if(n == 0){
                    return 1;
                } else {
                    return n * Factorial(n -1);
                }
            }
        }
    }