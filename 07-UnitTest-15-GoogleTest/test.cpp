#include "pch.h"
#include "07-UnitTest-13-Lib2/MyMathLib.h"

TEST(MyMathClass, AddFunction) 
{
	ASSERT_EQ(11, MyMathLib::Add(5, 6));
}