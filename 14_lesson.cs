using System;
using System.Runtime.Intrinsics.Arm;
using Internal;



//Two dimensional Arrays
int[,] nums = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Console.Write(nums[0, 0]);//1

//
int[,] num = new int[3, 4]; //3 rows and 4 columns
num[0, 0] = 3;
num[0, 1] = 4;

//
int[,] nums = {
    {{ 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }}
};

int[,,] num = new int[3, 4, 6]; //3 rows and 4 columns
num[0, 0] = 3;
num[0, 1] = 4;