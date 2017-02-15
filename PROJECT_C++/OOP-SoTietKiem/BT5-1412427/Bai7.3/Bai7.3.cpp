// Bai7.3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Source.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int chon;
	Xe xe(20,2);
	XeMay xemay(200,4);
	XeTai xetai(5000,30);
	do
	{
		chon = xe.deBai();
		cout<<endl;
		switch(chon)
		{
		case 1:
			{
				cout<<"XE MAY:"<<endl;
				float tHang = xemay.themLuongHang(50);
				cout<<tHang<<endl;
				cout<<"XE TAI:"<<endl;
				float tHang1 = xetai.themLuongHang(500);
				cout<<tHang1<<endl;
				break;
			}
		case 2:
			{
				cout<<"XE MAY:"<<endl;
				float tHang = xemay.botLuongHang(50);
				cout<<tHang<<endl;
				cout<<"XE TAI:"<<endl;
				float tHang1 = xetai.botLuongHang(500);
				cout<<tHang1<<endl;
				break;
			}
		case 3:
			{
				cout<<"XE MAY:"<<endl;
				float tXang = xemay.themLuongXang(5);
				cout<<tXang<<endl;
				cout<<"XE TAI:"<<endl;
				float tXang1 = xetai.themLuongXang(10);
				cout<<tXang1<<endl;
				break;
			}
		case 4:
			{
				cout<<"XE MAY:"<<endl;
				float tKM = xemay.choXeChay(250);
				cout<<tKM<<endl;
				cout<<"XE TAI:"<<endl;
				float tKM1 = xetai.choXeChay(400);
				cout<<tKM1<<endl;
				break;
			}
		case 5:
			{
				cout<<"XE MAY:"<<endl;
				if(xemay.kiemTraXang())
					cout<<"HET XANG:"<<endl;
				else
					cout<<"CHUA HET XANG:"<<endl;
				
				cout<<"XE TAI:"<<endl;
				if(xetai.kiemTraXang())
					cout<<"HET XANG:"<<endl;
				else
					cout<<"CHUA HET XANG:"<<endl;
				break;
			
			}
		case 6:
			{
				cout<<"XE MAY:"<<endl;
				float tXang = xemay.baoXang();
				cout<<tXang<<endl;
				cout<<"XE TAI:"<<endl;
				float tXang1 = xetai.baoXang();
				cout<<tXang1<<endl;
				break;
			}
			default:
				cout<<" Ban vua lua chon sai, vui long chon lai tu 1 -> 6"<<endl;
		}
	}
	while(chon!=6);
	return 0;
}

