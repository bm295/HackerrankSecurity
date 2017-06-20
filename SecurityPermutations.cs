using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var n = Convert.ToInt32(Console.ReadLine());
        string[] temp = Console.ReadLine().Split(' ');
        int[] inputs = Array.ConvertAll(temp, Int32.Parse);
        int[] outputs = new int[n];
        for (int i = 0; i < n; i++) {
            outputs[i] = inputs[inputs[i] - 1];
        }
        for(int i = 0; i < n; i++) {
            Console.WriteLine(outputs[i]);
        }
    }
}
