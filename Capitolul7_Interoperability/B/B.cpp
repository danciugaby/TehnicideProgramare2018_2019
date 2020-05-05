#include "stdafx.h"

#include "B.h"

double B::Bridge::DoubleMyValCaller(double param)
{
	AClass obj;

	Double val = obj.DoubleMyVal(param);

	//transformari de tipuri de date

	return val;
}
