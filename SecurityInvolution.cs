using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] line = Console.ReadLine().Split(' ');
        int[] f = Array.ConvertAll(line, Int32.Parse);
        bool result = true;
        for(int i = 0; i < n; i++) {
            if (f[f[i] - 1] != i + 1) {
                result = false;
                break;
            }                
        }
        Console.WriteLine(result ? "YES" : "NO");
    }
}
