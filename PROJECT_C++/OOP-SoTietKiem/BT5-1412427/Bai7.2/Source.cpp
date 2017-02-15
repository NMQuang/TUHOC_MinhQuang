#include "stdafx.h"
#include "Source.h"
//Tài khoản
#include <iostream>
using namespace std;
TaiKhoan::TaiKhoan()
{
	m_soDu = 0;
}
TaiKhoan::TaiKhoan(_int64 soDu)
{
	m_soDu = soDu;
}
_int64 TaiKhoan::baoSoDu()
{
	return m_soDu;
}
_int64 TaiKhoan::napTien(_int64 soTien)
{
	 m_soDu += soTien;
	 return m_soDu;
}
_int64 TaiKhoan::rutTien(_int64 soTien)
{
	if(soTien <= m_soDu)
	{
		m_soDu -= soTien;
	}
	return m_soDu;
}

//Tài khoản tiết kiệm
TaiKhoanTietKiem::TaiKhoanTietKiem(_int64 soDu,int kiHan,_int64 laiSuat,int soThang): TaiKhoan(soDu)
{
	//m_soDu = soDu;
	m_kiHan = kiHan;
	m_laiSuat = laiSuat;
	m_soThang = soThang;

}

_int64 TaiKhoanTietKiem::napTien(_int64 soTien)
{
	_int64 tienLai;
	if(m_soThang < m_kiHan){//nếu nạp tiền mà số tháng đã gửi < kì hạn thì lãi suất < 1%, trong code này mặc định là 0
		tienLai = TaiKhoan::napTien(soTien)/12;
		m_soThang = 0;
	}
	else
	{
		if(m_soThang == m_kiHan)
		{
			tienLai = TaiKhoan::napTien(soTien)*m_laiSuat*m_kiHan/12;
			m_soThang = 0;
		}else
		{
			tienLai = TaiKhoan::napTien(soTien)*m_laiSuat*m_kiHan/12 + TaiKhoan::napTien(soTien)/12;
			m_soThang = 0;
		}

	}
	return tienLai;
}

_int64 TaiKhoanTietKiem::rutTien(_int64 soTien)
{
	_int64 tienLai;
	if(m_soThang < m_kiHan){//nếu rút tiền trc kì hạn thì mặc định lãi suất là 0%
		tienLai = TaiKhoan::rutTien(soTien)/12;
		m_soThang = 0;
	}
	else
	{
		if(m_soThang == m_kiHan)
		{
			tienLai = TaiKhoan::rutTien(soTien)*m_laiSuat*m_kiHan/12;
			m_soThang = 0;
		}else
		{
			tienLai = TaiKhoan::rutTien(soTien)*m_laiSuat*m_kiHan/12 + TaiKhoan::rutTien(soTien)/12;
			m_soThang = 0;
		}
	}
	return tienLai;
}

void TaiKhoanTietKiem::tangSoThangGui(int soThang)
{
	m_soThang+= soThang;
}

int TaiKhoan::debai()
{
	 cout<<endl<<"+------+------------------------------------+----------+-------+-----+-------+";
     cout<<endl<<"+------+----[               MENU LUA CHON                        ]---+-------+";
     cout<<endl<<"+------+------------------------------------+----------+-------+-----+-------+";
     cout<<endl<<"|----- + ----->          1. TAI KHOAN                      <-----------|";
     cout<<endl<<"|----- + ----->          2. TAI KHOAN TIET KIEM                   <-----------|";
	 cout<<endl<<"+------+------------------------------------+----------+-------+-----+-------+";
	 int chon;
     cin>>chon;
	 return chon;
}