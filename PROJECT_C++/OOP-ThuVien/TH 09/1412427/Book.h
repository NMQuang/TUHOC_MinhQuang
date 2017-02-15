#pragma once
#include "Catalogue.h"

class CBook:public Catalogue
{
private:
	string m_Publisher;
	string m_Version;
	
public:
	CBook(string,string,string,int,string,string,string);
	string getPublisher();
	string getVersion();
	
	~CBook(void);
};
