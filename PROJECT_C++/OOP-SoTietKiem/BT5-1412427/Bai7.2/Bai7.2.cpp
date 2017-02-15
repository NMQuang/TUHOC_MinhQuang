// LT05.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Source.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int chon;
	TaiKhoan tk(10000000);
	TaiKhoanTietKiem tktk(2000000,9,0.06,12);
	do
	{
		chon = tk.debai();
		cout<<endl;
		switch(chon)
		{
		case 1:
			{
				_int64 baoTien,napTien,rutTien;
				baoTien = tk.baoSoDu();
				cout<<"SO DU:"<<baoTien<<endl;
				napTien = tk.napTien(500000);
				cout<<"TAI KHOAN SAU KHI NAP:"<<napTien<<endl;
				rutTien = tk.rutTien(500000);
				cout<<"TAI KHOAN SAU KHI RUT:"<<rutTien<<endl;
				break;
			}
		case 2:
			{
				_int64 napTien,rutTien,baoTien;
				baoTien = tktk.baoSoDu();
				cout<<"SO DU"<<baoTien<<endl;
				napTien = tktk.napTien(700000);
				cout<<"TAI KHOAN TIET KIEM SAU KHI NAP:"<<napTien<<endl;
				rutTien = tktk.rutTien(1000000);
				cout<<"TAI KHOAN SAU KHI RUT:"<<rutTien<<endl;
				break;
			}
		default:
				cout<<" Ban vua lua chon sai, vui long chon lai tu 1 hoac 2"<<endl;
		}
		
	}while(chon!=2);
	
	

	return 0;
}

