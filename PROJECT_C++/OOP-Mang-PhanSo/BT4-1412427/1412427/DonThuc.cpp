#include "stdafx.h"
#include "DonThuc.h"

DonThuc::DonThuc()
{
	m_heSo = 1;
	m_soMu = 0;
}
DonThuc::DonThuc(int heSo,int soMu)
{
	m_heSo = heSo;
	m_soMu = soMu;
}
DonThuc :: DonThuc(const DonThuc&d)
{
	m_heSo = d.m_heSo;
	m_soMu = d.m_soMu;
}

DonThuc DonThuc::operator+(const DonThuc&d)
{
	DonThuc temp;
	temp.m_heSo = m_heSo + d.m_heSo;
	return temp;
}
DonThuc DonThuc::operator*(const DonThuc& d)
{
	DonThuc temp;
	temp.m_heSo = m_heSo * d.m_heSo;
	temp.m_soMu = m_soMu + d.m_soMu;
	return temp;
}
bool DonThuc::operator>(const DonThuc&d)
{
	return((m_heSo > d.m_heSo&& m_soMu == d.m_soMu)||m_soMu > d.m_soMu);
}
bool DonThuc::operator<(const DonThuc&d)
{
	return((m_heSo < d.m_heSo && m_soMu == d.m_soMu)||m_soMu < d.m_soMu);
}

bool DonThuc::operator<=(const DonThuc&d)
{
	return ((m_heSo < d.m_heSo && m_soMu == d.m_soMu)||m_soMu < d.m_soMu || (m_heSo == d.m_heSo)&&(m_soMu == d.m_soMu));
}
bool DonThuc::operator>=(const DonThuc&d)
{
	return((m_heSo > d.m_heSo&& m_soMu == d.m_soMu)||m_soMu > d.m_soMu||(m_heSo == d.m_heSo)&&(m_soMu == d.m_soMu));
}

bool DonThuc::operator==(const DonThuc&d)
{
	return ((m_heSo == d.m_heSo)&&(m_soMu == d.m_soMu));
}
bool DonThuc::operator!=(const DonThuc&d)
{
	return !((m_heSo == d.m_heSo)&&(m_soMu == d.m_soMu));
}
DonThuc DonThuc::operator=(const DonThuc&d)
{
	m_heSo = d.m_heSo;
	m_soMu = d.m_soMu;
	return *this;
}
DonThuc& DonThuc::operator+=(const DonThuc&d)
{
	m_heSo = m_heSo+d.m_heSo;
	
	return *this;
}
DonThuc& DonThuc::operator*=(const DonThuc&d)
{
	m_heSo =m_heSo* d.m_heSo;
	m_soMu =m_soMu + d.m_soMu;
	return *this;
}
DonThuc& DonThuc::operator++()
{
	m_heSo = m_heSo +1;
	return *this;
}
DonThuc& DonThuc::operator--()
{
	m_heSo = m_heSo -1;
	return *this;
}

DonThuc& DonThuc::operator!()
{
	m_heSo = m_heSo * m_soMu;
	m_soMu = m_soMu - 1;
	return *this;
}
ostream &operator<<(ostream& out,DonThuc&d)
{
	out<<d.m_heSo<<"X"<<"^"<<d.m_soMu;
	return out;
}
istream &operator>>(istream& in,DonThuc& d)
{
	in>>d.m_heSo>>d.m_soMu;
	return in;
}