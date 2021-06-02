﻿using System;
using System.Linq;
using System.Collections.Generic;
namespace EXERCISE_01___LINQ {
    class Program {
        static void Main(string[] args) {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            List<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10).ToList();

            // Execute the query
            foreach (int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}
