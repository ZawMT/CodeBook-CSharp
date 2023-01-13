// 08-CodeSnippets-Cpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

#include "Snippets.h"

/*
* In this project, varioud code snippets which come into handy quite often are implemented for easy and quick reference. 
* The implementation can be found in other file for detail. Here is the brief information:
* 
* ByteArrayToInt
* This function will change byte array to integer. 
* If the byte series is too long (i.e. the resulted number might be more than an integer value), then the result will be unpredictable.
*/

void Test_ByteArrToInt();

int main()
{
    // To test any snippet, copy and paste the calling function here
    // E.g. To try ByteArrToInt function:
    // Test_ByteArrToInt();

    Snippets::clearVectorOfAMap();
}

void Test_ByteArrToInt()
{
    // 43981 => 1010 1011 - 1100 1101 => Byte by byte: ABCD
    // Little endian
    std::vector<BYTE> vByt1 = { 0xCD, 0xAB }; 
    // Big endian
    std::vector<BYTE> vByt2 = { 0xAB, 0xCD };
    int iAns1 = Snippets::ByteArrToInt<int>(vByt1);
    int iAns2 = Snippets::ByteArrToInt<int>(vByt2, true);
    std::cout << "Ans 1: " << iAns1 << std::endl;
    std::cout << "Ans 2: " << iAns2 << std::endl;
}