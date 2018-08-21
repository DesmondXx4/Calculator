#include "test.h"
#include<iostream>
using namespace std;

void Square::setup(double sl)
{ sideLength = sl; }
double Square::area() const
{
	return sideLength * sideLength;
}

