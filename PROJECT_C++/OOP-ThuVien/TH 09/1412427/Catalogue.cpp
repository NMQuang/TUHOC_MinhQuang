#include "stdafx.h"
#include "Catalogue.h"

Catalogue::Catalogue(string ID,string Title,string Author,int Count,string Year)
{
	m_ID = ID;
	m_Title = Title;
	m_Author = Author;
	m_Count = Count;
	m_Year = Year;
}
string Catalogue::getID()
{
	return m_ID;
}
string Catalogue::getTitle()
{
	return m_Title;
}
string Catalogue::getAuthor()
{
	return m_Author;
}
int Catalogue::getCount()
{
	return m_Count;
}
string Catalogue::getYear()
{
	return m_Year;
}
Catalogue::~Catalogue(void)
{

}
