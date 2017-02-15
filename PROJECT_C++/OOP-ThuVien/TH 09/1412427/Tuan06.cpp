// 1412427.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Book.h"
#include "Catalogue.h"
#include "Paper.h"
#include "Thesis.h"
#include <vector>
#include <fstream>
#include <iostream>
using namespace std;

//vector<string> TachChuoi(string data)
//{
//	vector<string> List;
//	string str="";
//	for(int i =0; i < data.length();i++)
//	{
//
//	}
//}
vector<Catalogue*> Input(string tenFIle)
{
	vector<Catalogue*> Cata;
	ifstream in(tenFIle);
	
	string data;
	Catalogue *pCatalogue;
	vector<string> tmp;
	while(!in.eof())
	{
		getline(in,data);
		tmp.push_back(data);//đọc file, lưu dữ liệu vào vector.
	}
	int temp,t1,t2;
	for(int i =0; i < tmp.size();i++)
	{
		if(i == 0 && tmp[i][0] == 'B')//TRƯỜNG HỢP ID LÀ "B"
			//nếu chữ cái đầu của ID là 'B'
		{
			temp = atoi(tmp[i+3].c_str());
			pCatalogue = new CBook(tmp[i],tmp[i+1],tmp[i+2],temp,tmp[i+4],tmp[i+5],tmp[i+6]);
			Cata.push_back(pCatalogue);
			if(tmp[i+7][0] == 'T')//nếu là 'T'
			{
				t1 = atoi(tmp[i+10].c_str());
				pCatalogue = new CThesis(tmp[i+7],tmp[i+8],tmp[i+9],t1,tmp[i+11],tmp[i+12],tmp[i+13]);
				Cata.push_back(pCatalogue);
			}
			
			if(tmp[i+14][0] == 'P')
			{
				t2 = atoi(tmp[i+17].c_str());
				pCatalogue = new CPaper(tmp[i+14],tmp[i+15],tmp[i+16],t2,tmp[i+18],tmp[i+19]);
				Cata.push_back(pCatalogue);
			}
			
		}else
		{
			break;
		}
		//else
		//{
		//	if(i == 0 && tmp[i][0] == 'T')//TRƯỜNG HỢP ID LÀ "T"
		//			//nếu chữ cái đầu của ID là 'T'
		//	{
		//		temp = atoi(tmp[i+3].c_str());
		//		pCatalogue = new CThesis(tmp[i],tmp[i+1],tmp[i+2],temp,tmp[i+4],tmp[i+5],tmp[i+6]);
		//		Cata.push_back(pCatalogue);
		//		if(tmp[i+7][0] == 'B')//nếu là 'B'
		//		{
		//			t1 = atoi(tmp[i+10].c_str());
		//			pCatalogue = new CBook(tmp[i+7],tmp[i+8],tmp[i+9],t1,tmp[i+11],tmp[i+12],tmp[i+13]);
		//			Cata.push_back(pCatalogue);
		//		}
		//		else
		//		{
		//			t2 = atoi(tmp[i+17].c_str());
		//			pCatalogue = new CPaper(tmp[i+14],tmp[i+15],tmp[i+16],t2,tmp[i+18],tmp[i+19]);
		//			Cata.push_back(pCatalogue);
		//		}
		//	
		//	}else
		//	{
		//		if(i == 0 && tmp[i][0] == 'P')//TRƯỜNG HỢP ID LÀ "P"
		//				//nếu là 'P'.
		//		{
		//			temp = atoi(tmp[i+3].c_str());
		//			pCatalogue = new CPaper(tmp[i],tmp[i+1],tmp[i+2],temp,tmp[i+4],tmp[i+5]);
		//			Cata.push_back(pCatalogue);
		//			if(tmp[i+6][0] == 'B')
		//			{

		//			}
		//		}
		//	}
		//}
	}

	in.close();
	return Cata;
}

void Output(string tenFile,vector<Catalogue*>Cata)
{
	ofstream output(tenFile);
	
	output<<Cata.size()<<endl;
	for(int i =0; i < Cata.size();i++)
	{
		output<<i+1<<"."<<Cata[i]->getID()<<","<<Cata[i]->getTitle()<<","<<Cata[i]->getAuthor()<<","<<Cata[i]->getCount()<<","<<Cata[i]->getYear()<<endl;
	}
	output.close();
}
int tinhYear(string year)
{
	string s = year.substr(year.size() - 4,year.size() - 1); 
	return 2015 - stoi(s);
}

void SwapYear(string tenFile,vector<Catalogue*>&Cata)
{
	for(int i =0; i < Cata.size();i++)
	{
		for(int j =0; j < Cata.size();j++)
		{
			if(tinhYear(Cata[i]->getYear()) > tinhYear(Cata[j]->getYear()))
			{
				Catalogue* temp = Cata[i];
				Cata[i] = Cata[j];
				Cata[j] = temp;
			}
		}
	}
	Output(tenFile,Cata);
}


void SwapCount(string tenFile,vector<Catalogue*>&Cata)
{
	for(int i =0; i < Cata.size();i++)
	{
		for(int j =0; j < Cata.size();j++)
		{
			if(Cata[i]->getCount() < Cata[j]->getCount())
			{
				Catalogue* temp = Cata[i];
				Cata[i] = Cata[j];
				Cata[j] = temp;
			}
		}
	}
	Output(tenFile,Cata);
}
void Delete(string tenFile,vector<Catalogue*>&Cata)
{
	ifstream in(tenFile);
	string data;
	//vector<string> temp;
	while(!in.eof())
	{
		getline(in,data);
		//temp.push_back(data);
		for(int i =0; i < Cata.size(); i++)
		{
			if(data == Cata[i]->getID())
			{
				Cata.pop_back();
			}
		}
	}
	in.close();
}

int _tmain(int argc, _TCHAR* argv[])
{
	vector<Catalogue*> List = Input("input.txt");
	Output("output.txt",List);//xuất file
	int choice;
	cout<<"NHAP BAI MUON CHON:";
	cin>>choice;
	switch(choice)
	{
	case 1:
		{
			SwapYear("sortyear.txt",List);//xuất file sáp xếp năm theo thứ tự cũ -> mới
			break;
		}
	case 2:
		{
			SwapCount("sortcount.txt",List);//xuất file sắp xếp theo số lần mượn tăng dần
			break;
		}
	case 3:
		{
			Delete("delete.txt",List);
			Output("outputdelete.txt",List);
			break;
		}
	
	default:
		cout<<"XIN HAY NHAP LAI BAI!"<<endl;
	}
	
	system("pause");
	return 0;
}

