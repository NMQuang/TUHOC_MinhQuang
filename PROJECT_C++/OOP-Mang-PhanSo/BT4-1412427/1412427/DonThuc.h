#pragma once

#include "stdafx.h"
#include <iostream>

using namespace std;

class DonThuc
{
private:
	int m_heSo;
	int m_soMu;
public:
	DonThuc();
	DonThuc(int ,int );
	DonThuc(const DonThuc& );
	DonThuc operator+(const DonThuc&);
	DonThuc operator*(const DonThuc&);
	bool operator>(const DonThuc& );
	bool operator<(const DonThuc& );
	bool operator>=(const DonThuc& );
	bool operator<=(const DonThuc& );
	bool operator==(const DonThuc& );
	bool operator!=(const DonThuc& );
	DonThuc operator=(const DonThuc&);
	DonThuc& operator+=(const DonThuc&);
	DonThuc& operator*=(const DonThuc&);
	DonThuc& operator++();
	DonThuc& operator--();
	DonThuc& operator!();
	friend ostream &operator<<(ostream& , DonThuc&);
	friend istream &operator>>(istream& , DonThuc& );
};

ostream &operator<<(ostream& , const DonThuc&);
istream &operator>>(istream& , DonThuc& );



