using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        string input = Console.ReadLine();
        int places = Convert.ToInt32(Console.ReadLine());
        StringBuilder output = new StringBuilder();
        foreach(char c in input) {
            int number = Convert.ToInt32(c.ToString());
            number += places;
            if (number >= 10) {
                number -= 10;
            }                
            output.Append(number);
        }
        Console.WriteLine(output);
    }
}
