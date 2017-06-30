using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var n = Convert.ToInt32(Console.ReadLine());
        string[] temp = Console.ReadLine().Split(' ');
        int[] f = Array.ConvertAll(temp, Int32.Parse);
        var isBijective = "YES";
        for(int i = 0; i < n; i++) {
            var found = false;
            for(int j = 0; j < n; j++) {
                if (f[j] == (i + 1)) {
                    found = true;
                    break;
                }
            }
            if (!found) {
                isBijective = "NO";
                break;
            }
        }
        Console.WriteLine(isBijective);
    }
}
