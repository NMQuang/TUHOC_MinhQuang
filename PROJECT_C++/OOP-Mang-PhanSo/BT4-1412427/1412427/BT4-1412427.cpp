// BT4-1412427.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "PhanSo.h"
#include "DonThuc.h"
#include "Mang.h"

int _tmain(int argc, _TCHAR* argv[])
{
	int bai;
	cout<<"Nhap bai:";//nhập bài thầy muốn kiểm tra.
	cin>>bai;
	switch (bai)
	{
	case 1:
		{
			PhanSo pCong,pNhan,p1(1,5),p2(2,7);
			cout<<"PHAN SO P1:"<<endl;
			cout<<p1;//xuất p1
			cout<<"PHAN SO P2:"<<endl;
			cout<<p2;//xuất p2

			pCong = p1 + p2;//dùng toán tử cộng 2 phân số
			cout<<pCong;

			pNhan = p1 * p2;//dùng toán tử nhân cộng hai phân số
			cout<<pNhan;

			if(p1 > p2)//trường hợp này có thể thay toán > bằng các toán tử khác
				cout<<"P1 > P2"<<endl;
			else
				cout<<"P1 < P2"<<endl;
			pCong +=pCong;
			cout<<pCong;

			pNhan*=pNhan;
			cout<<pNhan;

			p1 ++;//toán tử tăng lên 1 đơn vị phân số
			cout<<p1;

			p2 --;//toán tử giảm xuống 1 đơn vị phân số
			cout<<p2;
			break;
		}
	case 2:
		{
			//Lưu ý: bậc của các đơn thức là cùng bậc.
			DonThuc dCong,dNhan,d1(2,3),d2(5,3);
			cout<<"DON THUC D1:"<<endl;
			cout<<d1;//xuất đơn thức d1

			cout<<"DON THUC D2:"<<endl;
			cout<<d2;//xuất đơn thức d2

			dCong = d1 + d2;//dùng toán tử cộng để cộng 2 đơn thức
			cout<<dCong;

			dNhan = d1*d2;//dùng toán tử nhân để nhân 2 đơn thức
			cout<<dNhan;

			if(d1 > d2)//trường hợp này có thể thay toán > bằng các toán tử khác
				cout<<"D1 > D2"<<endl;
			else
				cout<<"D1 < D2"<<endl;
			dCong+= dCong;
			cout<<dCong;

			dNhan*= dNhan;
			cout<<dNhan;

			dCong ++;//dùng toán tử ++ để tăng đơn thức lên 1 đơn vị đơn thức
			cout<<dCong;

			dCong = !dCong;//dùng toán tử ! để tính đạo hàm của đơn thức dCong.
			cout<<dCong;
			break;
		}
	case 3:
		{
			
			Mang<int> mangA(4),mangB;//khởi tạo mảng A và B
			cout<<"Kich thuoc cua mangA:"<<mangA.layKichThuoc();
			cout<<"Kich thuoc mangB:"<<mangB.layKichThuoc();

			cout<<"Nhap phan tu:";
			cin>>mangA;
			cin>>mangB;//nhập phần tử.

			cout<<"MANGA[]:"<<mangA<<endl;
			cout<<"MANGB[]:"<<mangB<<endl;

			Mang<int> mangC(mangA);
			cout<<"Kich thuoc mangC:"<<mangC.layKichThuoc();

			mangA = mangB;//gán mảng B bằng mảng A.

			break;

		}
	default:
		break;
	}
	 system("PAUSE");
	return 0;
}

