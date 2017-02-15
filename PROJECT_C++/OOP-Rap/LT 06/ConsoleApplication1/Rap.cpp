#include "stdafx.h"
#include "Rap.h"
#define M1 3000

bool RapPhim::GheTaiConTrong(int M, int N) 
{ 
    return m_HangGhe[M][N]; 
} 

float RapPhim::getDoanhThu() 
{ 
    return m_DoanhThu; 
} 

float RapPhim::GiaVeTai(int M, int N) 
{ 
    return m_Gia-M*M1; 
} 

void RapPhim::DatVe(int M, int N, int Date) 
{ 
    if(m_HangGhe[M][N]==false) 
    { 
        m_HangGhe[M][N]=true; 
        if(Date==5) 
            m_DoanhThu += 0.2*(m_Gia-M*M1); 
        else 
            m_DoanhThu += (m_Gia-M*M1); 
    } 
    else 
    { 
        cout<<"Xin loi ! Vi tri nay da co nguoi dang ki."<<endl; 
    } 
} 

int RapPhim::SoGheConTrong() 
{ 
    int dem = 0; 
    for(int i=0; i<m_M; i++) 
        for(int j=0; j<m_N; j++) 
            if(m_HangGhe[i][j]==false) 
                dem++; 
    return dem; 

} 

