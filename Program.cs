using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0, min = arr[0], max = arr[0];

        foreach (var n in arr)
        {
            sum += n;
            if (n < min)
            {
                min = n;
            }
            if (n > max)
            {
                max = n;
            }
        }

        long minSum = sum - max;
        long maxSum = sum - min;

        Console.Write(minSum + " " + maxSum);

        // other solution
        /*arr.Sort(); long sum = arr.Sum(); long max = arr.Max(); long min = arr.Min();
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
