#pragma once
#include "Catalogue.h"

class CThesis:public Catalogue
{
private:
	string m_School;
	string m_Faculty;
	
public:
	CThesis(string,string,string,int,string,string,string);
	string getSchool();
	string getFaculty();
	
	~CThesis(void);
};
