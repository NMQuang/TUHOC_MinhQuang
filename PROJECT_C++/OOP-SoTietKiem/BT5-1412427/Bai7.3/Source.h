#pragma once

class Xe
{
protected:
	float m_hang;
	float m_xang;
	float m_tieuThu;
public:
	Xe();
	Xe(float,float);
	float themLuongHang(float hang);
	float botLuongHang(float hang);
	float themLuongXang(float xang);
	float choXeChay(float km);
	bool kiemTraXang();
	float baoXang();
	int deBai();
};

class XeMay:public Xe
{
public:
	XeMay();
	XeMay(float hang,float xang);
	float themLuongHang(float);
	float botLuongHang(float);
};

class XeTai:public Xe
{
public:
	public:
	XeTai();
	XeTai(float hang,float xang);
	float themLuongHang(float);
	float botLuongHang(float);
};
	