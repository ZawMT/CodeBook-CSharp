#pragma once

#include <vector>
#include "Windows.h"

class Snippets
{
public:
	template <typename IntegerType>
	static IntegerType ByteArrToInt(std::vector<BYTE> vByt, bool bBigEndian = false)
	{
		IntegerType result = 0;
		if (!bBigEndian)
			for (int i = 0; i < vByt.size(); i++)
				result |= ((IntegerType)vByt[i]) << (8 * i);
		else
			for (int i = vByt.size() - 1; i >= 0 ; i--)
				result |= ((IntegerType)vByt[i]) << 8 * (vByt.size() - i - 1);

		return result;
	}

	static void clearVectorOfAMap();
};