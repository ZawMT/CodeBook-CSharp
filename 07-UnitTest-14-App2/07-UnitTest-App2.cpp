// 07-UnitTest-App2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "07-UnitTest-13-Lib2/MyMathLib.h"

/*
* To create unit test cases for a C++ project, it's better to have a separate library 
* where the codes to test are provided. This project 07-UnitTest-14-App2 is just to show
* how the library (07-UnitTest-13-Lib2) can be used, so it is not very important.
* Only after having this library, we can link it up from the Google Test project.
* 
* Running the test cases is the same - from 'Test' menu.
* 
* Creating unit test cases using Google Test can be tricky when we want to test the classes which are not exported.
* The situation is like this:
* If the classes are not exported, they cannot be referred from the Test project.
* If the classes are exported, the purpose of hiding the unnecessary defintions from the user will fail.
* In that case, the target class to test can be referred by using obj file (see in the project settings of 07-UnitTest-15-GoggleTest)
*/

int main()
{
    int iN1, iN2;
    std::cout << "Enter a number:";
    std::cin >> iN1;
    std::cout << "Enter one more number:";
    std::cin >> iN2;
    std::cout << "Addition is " << MyMathLib::Add(iN1, iN2);
}
