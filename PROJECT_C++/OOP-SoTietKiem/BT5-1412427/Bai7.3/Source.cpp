#include "stdafx.h"
#include "Source.h"
#include <iostream>
using namespace std;

Xe::Xe()
{
	m_hang = 0;
	m_tieuThu = 0;
	m_xang = 0;
}
Xe::Xe(float hang,float xang)
{
	m_hang = hang;
	m_xang = xang;
}

float Xe::themLuongHang(float hang)
{
	m_hang+=hang;
	return m_hang;
}
float Xe::botLuongHang(float hang)
{
	if(hang <= m_hang)
		m_hang-=hang;
	return m_hang;
}
float Xe::themLuongXang(float xang)
{
	m_xang+=xang;
	return m_xang;
}

float Xe::choXeChay(float km)
{
	float tieuThu = (km /100)*m_tieuThu;//tiêu thụ tùy vào lượng tiêu thụ của mỗi loại xe
	if(tieuThu <= m_xang)
		m_xang -= tieuThu;
	return m_xang;
}

bool Xe::kiemTraXang()
{
	return m_xang == 0;
}

float Xe::baoXang()
{
	return m_xang;
}
int Xe::deBai()
{
	 cout<<endl<<"+------+------------------------------------+----------+-------+-----+-------+";
     cout<<endl<<"+------+----[               MENU LUA CHON                        ]---+-------+";
     cout<<endl<<"+------+------------------------------------+----------+-------+-----+-------+";
     cout<<endl<<"|----- + ----->          1. CHAT HANG LEN XE                     <-----------|";
     cout<<endl<<"|----- + ----->          2. BO BOT HANG XUONG XE                   <-----------|";
	 cout<<endl<<"|----- + ----->          3. DO LUONG XANG                  <-----------|";
	 cout<<endl<<"|----- + ----->          4. CHO XE CHAY KM                  <-----------|";
	 cout<<endl<<"|----- + ----->          5. KIEM TRA XANG                  <-----------|";
	 cout<<endl<<"|----- + ----->          6. LUONG XANG CON LAI                  <-----------|";
	 cout<<endl<<"+------+------------------------------------+----------+-------+-----+-------+";
	 int chon;
     cin>>chon;
	 return chon;
}
//////XE MÁY

XeMay::XeMay():Xe()
{
	m_tieuThu = 2;
}
XeMay::XeMay(float hang,float xang):Xe(hang,xang)
{
	m_tieuThu = 2 + (m_hang * 10.0)/0.1;
}
float XeMay::themLuongHang(float hang)
{
	//*this = XeMay(hang + this->m_hang,m_xang);
	m_hang = Xe::themLuongHang(hang);
	m_tieuThu = 2 + (m_hang*10.0)/0.1;
	return m_hang;
	
}

float XeMay::botLuongHang(float hang)
{
	//*this = XeMay(this->m_hang - hang,m_xang);
	m_hang = Xe::botLuongHang(hang);
	m_tieuThu = 2 + (m_hang*10.0)/0.1;
	return m_hang;
}
/////XE TẢI

XeTai::XeTai():Xe()
{
	m_tieuThu = 20;
}
XeTai::XeTai(float hang,float xang):Xe(hang,xang)
{
	m_tieuThu = 20 + (m_hang * 1000.0)/1;
}
float XeTai::themLuongHang(float hang)
{
	//*this = XeTai(hang + this->m_hang,m_xang);
	m_hang = Xe::themLuongHang(hang);
	m_tieuThu = 20 + (m_hang*1000.0)/1;
	return m_hang;
}

float XeTai::botLuongHang(float hang)
{
	//*this = XeTai(this->m_hang - hang,m_xang);
	m_hang = Xe::botLuongHang(hang);
	m_tieuThu = 20 + (m_hang*1000.0)/1;
	return m_hang;
}