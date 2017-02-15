#pragma once
#include <fstream>
#include <iostream>
using namespace std;
class RapPhim 
{ 
    protected: 
        int m_M; 
        int m_N; 
        int m_Gia; 
        bool**m_HangGhe; 
        float m_DoanhThu; 
    public: 
        int SoGheConTrong(); //kiểm tra coi còn bao nhieu ghế còn trống
        void DatVe(int, int, int);//Cột, Dòng và Ngày đặt vé (ngày thứ mấy) 
        float GiaVeTai(int, int);//giá vé của vị trí tại cột int và hàng int 
        float getDoanhThu(); //tổng doanh thu của rạp
        bool GheTaiConTrong(int, int); //kiểm tra ghế đang muốn đặt có còn trống hay không
}; 

class RapThuong:public RapPhim 
{ 
    public: 
		RapThuong(int M,int N,int Gia)
		{
			m_DoanhThu = 0; 
			m_M = M; 
			m_N = N; 
			m_Gia = Gia; 
			m_HangGhe = new bool*[M]; 
			for(int i=0; i<N; i++) 
				m_HangGhe[i] = new bool[N]; 
			for(int i=0; i<M; i++) 
			for(int j=0; j<N; j++) 
				m_HangGhe[i][j] = false; 
		}
		
}; 

class RapCaoCap:public RapPhim 
{ 
    public: 
		RapCaoCap(int M, int N, int Gia)
		{
			 m_DoanhThu = 0; 
			m_M = M; 
			m_N = N; 
			m_Gia = Gia; 
			m_HangGhe = new bool*[M]; 
			for(int i=0; i<N; i++) 
				m_HangGhe[i] = new bool[N]; 
			for(int i=0; i<M; i++) 
			for(int j=0; j<N; j++) 
				m_HangGhe[i][j] = false; 
		}

}; 