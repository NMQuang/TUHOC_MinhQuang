#include "stdafx.h"
#include "Mang.h"
template<class T>
Mang<T>::Mang()
{
	m_size = 0;
}
template<class T>
Mang<T>::Mang(int size)
{
	m_size = size;
	for(int i=0 ; i < m_size; i++)
	{
		m_duLieu[i] = 0;
	}
}
template<class T>
Mang<T>::Mang(const Mang&duLieu)
{
	m_size = duLieu.m_size;
	m_duLieu = new T[m_size];
	for(int i = 0 ; i < m_size; i++)
	{
		m_duLieu[i] = duLieu.m_duLieu[i];
	}
}
template<class T>
int Mang<T>::layKichThuoc()
{
	return m_size;
}
template<class T>
int& Mang<T>::operator [](int i)
{
	return*(m_duLieu + i);
}
template<class T>
Mang<T>::~Mang()
{
	delete[]m_duLieu;
}
template<class T>
Mang<T>& Mang<T>::operator=(const Mang<T>&m)
{
	m_size = m.m_size;
	m_duLieu = new T[m_size];
	for(int i = 0; i < m_size; i++)
	{
		m_duLieu[i] = m.m_duLieu[i];
	}
	return *this;
}
template<class T>
ostream& operator<<(ostream&out,const Mang<T>&m)
{
	for(int i = 0; i< m_size; i++)
	{
		out<<m.m_duLieu[i];
	}
	return out;
}
template<class T>
istream& operator>>(istream&in, Mang<T>&m)
{
	for(int i = 0; i < m.m_size; i++)
	{
		in>>m.m_duLieu[i];
	}
	return in;
}