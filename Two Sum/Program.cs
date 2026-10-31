using System.Collections.Generic;
using System.IO.Pipes;

/**Given an integer array and a target, return the indices 
 * of the two numbers that add up to the target. 
 * Exactly one solution exists; you cannot use the same element twice.**/

//Example: nums = [2, 7, 11, 15], target = 9 -> [0, 1]

/**Pattern: hash map of value -> index; for each number, 
 * check if its complement was already seen.**/
int target = 9;

int[] nums = new int[4];
nums = [2, 7, 11, 15];

var seen = new Dictionary<int, int>();

for (int i = 0; i <= nums.Length; i++)
{
    if (!seen.TryGetValue(2, out int index))
    {
        index = i;
        seen.Add(index, 2);
    }
    else
    {
        
    }
}
foreach (var pair in seen)
{
    Console.WriteLine(pair);
}










