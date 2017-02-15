#pragma once
#include "stdafx.h"
#include <iostream>

using namespace std;

template <class T>
class Mang
{
private:
	T* m_duLieu;
	int m_size;
public:
	Mang();
	Mang(int size);
	Mang(const Mang&duLieu);
	int layKichThuoc();
	Mang& operator=(const Mang&m);
	int& operator[](int);
	//Mang& operator T*()
	friend ostream& operator<<(ostream&,const Mang&);
	friend istream& operator>>(istream&, Mang&);
	~Mang();
};
template<class T>
ostream& operator<<(ostream&,const Mang<T>&);
template<class T>
istream& operator>>(istream&, Mang<T>&);

