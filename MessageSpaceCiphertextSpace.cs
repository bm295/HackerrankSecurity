using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string input = Console.ReadLine();
        foreach(char c in input) {
            var digit = Convert.ToInt32(c.ToString());
            digit = (digit == 9) ? 0 : digit + 1;
            Console.Write(digit);
        }
    }
}
