#pragma once

class TaiKhoan
{
private:
	_int64 m_soDu;
public:
	TaiKhoan();
	TaiKhoan(_int64 soDu);
	int debai();
	_int64 baoSoDu();
	_int64 napTien(_int64 soTien);
	_int64 rutTien(_int64 soTien);
};


class TaiKhoanTietKiem:public TaiKhoan
{
private:
	int m_kiHan;
	_int64 m_laiSuat;
	int m_soThang;
public:
	TaiKhoanTietKiem(_int64,int,_int64,int);
	_int64 napTien(_int64 soTien);
	_int64 rutTien(_int64 soTien);
	void tangSoThangGui(int);
};