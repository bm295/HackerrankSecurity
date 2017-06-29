using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var n = Convert.ToInt32(Console.ReadLine());
        string[] secondLine = Console.ReadLine().Split(' ');
        int[] input = Array.ConvertAll(secondLine, Int32.Parse);        
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                if (input[j] == (i + 1)) {
                    Console.WriteLine(j + 1);
                    break;
                }                    
            }
        }
    }
}
