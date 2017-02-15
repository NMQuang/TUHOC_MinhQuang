#pragma once
#include "Catalogue.h"

class CPaper:public Catalogue
{
private:
	string m_Journal;
	
public:
	CPaper(string,string,string,int,string,string);
	string getJournal();
	
	~CPaper(void);
};