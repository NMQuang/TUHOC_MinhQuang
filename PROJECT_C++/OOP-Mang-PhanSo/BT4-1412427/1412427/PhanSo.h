#pragma once
#include "stdafx.h"
#include <iostream>

using namespace std;

class PhanSo
{
private:
	int m_tu;
	int m_mau;
	
public:
	PhanSo();
	PhanSo(int ,int );
	PhanSo(const PhanSo&);
	PhanSo operator+(const PhanSo&);
	PhanSo operator*(const PhanSo&);
	bool operator>(const PhanSo&);
	bool operator<(const PhanSo&);
	bool operator>=(const PhanSo&);
	bool operator<=(const PhanSo&);
	bool operator==(const PhanSo&);
	bool operator!=(const PhanSo&);
	PhanSo operator =(const PhanSo&);
	PhanSo& operator +=(const PhanSo&);
	PhanSo& operator *=(const PhanSo&);
	PhanSo& operator++();
	PhanSo& operator--();
	operator int()const;
	friend ostream& operator<<(ostream& ,const PhanSo&);
	friend istream& operator>>(istream& , PhanSo&);
};

ostream& operator<<(ostream& ,const PhanSo&);
istream& operator>>(istream& , PhanSo&);