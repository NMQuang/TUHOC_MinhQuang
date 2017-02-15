#include "stdafx.h"
#include "PhanSo.h"

PhanSo::PhanSo()
{
	m_tu = 0;
	m_mau = 1;
}
PhanSo::PhanSo(int tu,int mau)
{
	m_tu = tu;
	m_mau = mau;
}
PhanSo::PhanSo(const PhanSo&p)
{
	m_tu = p.m_tu;
	m_mau = p.m_mau;
}
PhanSo PhanSo::operator+(const PhanSo&p)
{
	PhanSo temp;
	temp.m_tu = m_tu * p.m_mau + m_mau * p.m_tu;
	temp.m_mau = m_mau * p.m_mau;
	return temp;
}
PhanSo PhanSo::operator*(const PhanSo&p)
{
	PhanSo temp;
	temp.m_tu = m_tu*p.m_tu;
	temp.m_mau = m_mau*p.m_mau;
	return temp;
}
bool PhanSo::operator<(const PhanSo&p)
{
	return (m_tu*p.m_mau - m_mau*p.m_tu);
}
bool PhanSo::operator>(const PhanSo&p)
{
	return (p.m_tu*m_mau - p.m_mau*m_tu);
}
bool PhanSo::operator==(const PhanSo&p)
{
	return ((m_tu == p.m_tu)&&(m_mau == p.m_mau));
}

bool PhanSo::operator>=(const PhanSo&p)
{
	return (p.m_tu*m_mau - p.m_mau*m_tu)||((m_tu == p.m_tu)&&(m_mau == p.m_mau));
}
bool PhanSo::operator<=(const PhanSo&p)
{
	return (m_tu*p.m_mau - m_mau*p.m_tu)||((m_tu == p.m_tu)&&(m_mau == p.m_mau));
}
bool PhanSo::operator!=(const PhanSo&p)
{
	return (!(p.m_tu*m_mau == p.m_mau*m_tu));
}
PhanSo PhanSo::operator=(const PhanSo&p)
{
	PhanSo temp;
	temp.m_tu = p.m_tu;
	temp.m_mau = p.m_mau;
	return temp;
}
PhanSo& PhanSo::operator*=(const PhanSo&p)
{
	m_tu = m_tu*p.m_tu;
	m_mau = m_mau*p.m_mau;
	return *this;
}
PhanSo& PhanSo::operator+=(const PhanSo&p)
{
	m_tu = m_tu*p.m_mau + m_mau*p.m_tu;
	m_mau = m_mau*p.m_mau;
	return *this;
}
PhanSo& PhanSo::operator++()
{
	m_tu = m_tu + m_mau;
	return *this;
}
PhanSo& PhanSo::operator--()
{
	m_tu = m_tu - m_mau;
	return *this;
}
PhanSo::operator int()const
{
	return m_tu/m_mau;
}
ostream& operator<<(ostream&out, const PhanSo&p)
{
	out<<p.m_tu<<"/"<<p.m_mau;
	return out;
}
istream& operator>>(istream& in, PhanSo&p)
{
	in >>p.m_tu>>p.m_mau;
	return in;
}