#include "stdafx.h"
#include "Thesis.h"

CThesis::CThesis(string ID,string Title,string Author,int Count,string Year,string School,string Faltury):Catalogue(ID,Title,Author,Count,Year)
{
	m_School = School;
	m_Faculty = Faltury;
	
}
string CThesis::getSchool()
{
	return m_School;
}
string CThesis::getFaculty()
{
	return m_Faculty;
}

CThesis::~CThesis(void)
{

}