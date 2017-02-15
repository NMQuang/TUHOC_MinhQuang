#include "stdafx.h"
#include "Book.h"

CBook::CBook(string ID,string Title,string Author,int Count,string Year,string Publisher,string Version):Catalogue(ID,Title,Author,Count,Year)
{
	m_Publisher = Publisher;
	m_Version = Version;
}
string CBook::getPublisher()
{
	return m_Publisher;
}
string CBook::getVersion()
{
	return m_Version;
}

CBook::~CBook(void)
{

}