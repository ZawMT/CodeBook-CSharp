#include "Snippets.h"
#include <iostream>
#include <map>
#include <string>
#include <vector>
/* 
	This function is to check -
	while looping through an iterator, a vector in a map is passed like a reference or value => Answer: Reference
*/
void Snippets::clearVectorOfAMap()
{
	std::map<std::string, std::vector<std::string>> mpTest;
	mpTest["TEST1"] = {"ABC", "DEF"};
	mpTest["TEST2"] = { "One", "Two", "Three" };
	std::map<std::string, std::vector<std::string>>::iterator itTmp;
	for (itTmp = mpTest.begin(); itTmp != mpTest.end(); itTmp++)
	{
		itTmp->second.clear();
	}

	// Checking if the iterator can be simply reused as follows => Answer: YES
	for (itTmp = mpTest.begin(); itTmp != mpTest.end(); itTmp++)
	{
		itTmp->second.push_back("THIS IS A TEST");
		break;
	}

	std::map<std::string, bool> mpBool;
	mpBool["TEST1"] = true;
	if (mpBool["TEST1"])
		std::cout << "\r\nTEST1 is true";
	else
		std::cout << "\r\nTEST1 is false";

	// Checking what will happen if a non-existing entry is checked like this => Answer: OK to do so, and it is not true
	if (mpBool["TEST2"])
		std::cout << "\r\nTEST2 is true";
	else
		std::cout << "\r\nTEST2 is false";
}