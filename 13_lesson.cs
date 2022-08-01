using System;
using System.Runtime.Intrinsics.Arm;
using Internal;



int i = 1;
while (i <= 5)
{
    Console.Write(i);
    i++;
}


//for loop
for (int i = 1; i <= 5; i++)
{
    Console.Write(i);

}


//
int[] nums = { 1, 2, 3, 4, 5 };
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i]);//1,2,3,4,5
}
