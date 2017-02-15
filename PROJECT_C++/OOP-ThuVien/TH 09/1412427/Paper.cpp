#include "stdafx.h"
#include "Paper.h"

CPaper::CPaper(string ID,string Title,string Author,int Count,string Year,string Journal):Catalogue(ID,Title,Author,Count,Year)
{
	m_Journal = Journal;

}
string CPaper::getJournal()
{
	return m_Journal;
}

CPaper::~CPaper(void)
{

}
