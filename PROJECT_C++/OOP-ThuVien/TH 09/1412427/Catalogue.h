#pragma once
#include <string>
#include <iostream>
using namespace std;
class Catalogue
{
protected:
	string m_ID;
	string m_Title;
	string m_Author;
	int m_Count;
	string m_Year;
public:
	Catalogue(string,string,string,int,string);
	string getID();
	string getTitle();
	string getAuthor();
	int getCount();
	string getYear();
	~Catalogue(void);
};

