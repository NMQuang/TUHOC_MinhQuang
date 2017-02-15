// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Rap.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	cout<<"Nhap SO DAY GHE va SO GHE MOI DAY:\n"; 
    int M, N; 
    cin>>M>>N; 
    RapThuong*RT = new RapThuong(M, N, 80000); 
    RapCaoCap*RCC = new RapCaoCap(M, N, 120000); 
    int choice; 
    do 
    { 
        cout<<"Ban chon loai rap nao RAP THUONG (0) hay RAP CAO CAP (1) hay THOAT (2) ?"; 
        cin>>choice; 
        //Rap thuong 
        if(choice==0) 
        { 
            int m, n, d; 
            cout<<"\nRAP THUONG:\n"; 
            cout<<"Chon vi tri can dat (hang|cot) va ngay dat:\n"; 
            cin>>m>>n>>d; 
            RT->DatVe(m, n, d); 
        } 

        //Rap cao cap 
        if(choice==1) 
        { 
            int m, n, d; 
            cout<<"\nRAP CAO CAP:\n"; 
            cout<<"Chon vi tri can dat (hang|cot) va ngay dat:\n"; 
            cin>>m>>n>>d; 
            RCC->DatVe(m, n, d); 
        } 
    }while(choice!=2); 

    cout<<"\n=========DOANH THU==========\n"; 
    cout<<"\n+RAP THUONG:\n"; 
    cout<<RT->getDoanhThu(); 
    cout<<"\n+RAP CAO CAP:\n"; 
    cout<<RCC->getDoanhThu(); 

    cout<<"\n===========GHE TRONG=========\n"; 
    cout<<"\n+RAP THUONG:\n"; 
    cout<<RT->SoGheConTrong(); 
    cout<<"\n+RAP CAO CAP:\n"; 
    cout<<RCC->SoGheConTrong(); 

    cout<<"\n================KIEM TRA VI TRI TRONG===============\n"; 
    do 
    { 
        cout<<"Ban cho loai rap nao RAP THUONG (0) hay RAP CAO CAP (1) hay THOAT (2) ?"; 
        cin>>choice; 
        //Rap thuong 
        if(choice==0) 
        { 
            int m, n; 
            cout<<"\nRAP THUONG:\n"; 
            cout<<"Chon vi tri can kiem tra (hang|cot):\n"; 
            cin>>m>>n; 
            if(RT->GheTaiConTrong(m, n)==true) 
                cout<<"Ban !"<<endl; 
            else 
                cout<<"Trong !"<<endl; 
        } 

        //Rap cao cap 
        if(choice==1) 
        { 
            int m, n; 
            cout<<"\nRAP CAO CAP:\n"; 
            cout<<"Chon vi tri can kiem tra (hang|cot):\n"; 
            cin>>m>>n; 
            if(RCC->GheTaiConTrong(m, n)==true) 
                cout<<"Ban !"; 
            else 
                cout<<"Trong !"; 
        } 
    }while(choice!=2); 
	return 0;
}

