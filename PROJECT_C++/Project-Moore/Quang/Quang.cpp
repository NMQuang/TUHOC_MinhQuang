// Quang.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <vector>
#include <fstream>
#include <sstream>
#include <iostream>
using namespace std;



struct Node
{
	string data;
	Node* left;
	Node* right;
};
typedef Node* Tree;

Node* creatNode()
{
	Node *ptr = new Node;
	ptr->data = "";
	ptr->left = ptr->right = NULL;
	return ptr;
}


void addNode(Tree &T, string str, string s)
{
	Node* cur = T;
	for (int i = 0; i < str.length(); i++)
	{
		if (str[i] == '.'){
			if (cur->left == NULL)
				cur->left = creatNode();
			cur = cur->left;
		}
		if (str[i] == '-')
		{
			if (cur->right == NULL)
				cur->right = creatNode();
			cur = cur->right;
		}

	}
	cur->data = s;
}


struct Code{
	string letter;
	string morse;
};

Code convert[] = {
	{ "A", ".- " }, { "B", "-... " }, { "C", "-.-. " },
	{ "D", "-.. " }, { "E", ". " }, { "F", "..-. " },
	{ "G", "--. " }, { "H", ".... " }, { "I", ".. " },
	{ "J", ".--- " }, { "K", "-.- ", }, { "L", ".-.. " },
	{ "M", "-- " }, { "N", "-. " }, { "O", "--- ", },
	{ "P", ".--." }, { "Q", "--.- " }, { "R", ".-. " },
	{ "S", "... " }, { "T", "- " }, { "U", "..- " },
	{ "V", "...- " }, { "W", ".-- " }, { "X", "-..- " },
	{ "Y", "-.-- " }, { "Z", "--.. " }, { "0", "-----" },
	{ "1", ".----" }, { "2", "..---" }, { "3", "...--" },
	{ "4", "....-" }, { "5", "....." }, { "6", "-...." },
	{ "7", "--..." }, { "8", "---.." }, { "9", "----." }

};

string timKiTu(Tree T, string str)
{
	Node* current = T;
	for (int i = 0; i < str.length(); i++)
	{
		if (str[i] == '.')
			current = current->left;

		if (str[i] == '-')
			current = current->right;

	}
	return current->data;
}

string timMaMorse(string str)
{
	string strmorse = "";
	for (int i = 0; i < str.length(); i++)
	{
		string s(1, str[i]);
		for (int j = 0; j < 37; j++)
		{
			if (s == convert[j].letter)
			{
				strmorse += convert[j].morse;
				strmorse += " ";
			}
		}
	}
	return strmorse;
}



string MorseToEng(Tree T, string str)
{
	string strmorse = "";
	string buf;
	stringstream ss(str);

	while (ss >> buf)
	{
		if (buf != "|")
		{
			strmorse += timKiTu(T, buf);
		}
		else
		{
			strmorse += " ";
		}
	}
	return strmorse;
}

string EngToMorse(string str)
{
	string strmorse = "";
	string buf;
	stringstream s(str);
	while (s >> buf)
	{
		strmorse += timMaMorse(buf);
		strmorse += "| ";
	}
	strmorse = strmorse.substr(0, strmorse.length() - 2);
	return strmorse;
}



void doc_ghiFile(Tree T, string a, string b)
{
	ifstream input(a);
	ofstream output(b);
	/*if (input == NULL)
		cout << "KHONG DU BO NHO." << endl;
	if (output == NULL)
		cout << "BO NHO KHONG DU." << endl;*/
	int x, y, j = 0;
	input >> x >> y;
	vector<string> list;

	while (!input.eof())
	{
		string data;
		getline(input, data);
		if (data != "")
			list.push_back(data);
	}


	for (int i = 0; i < x; i++)
	{
		output << EngToMorse(list[j]) << endl;
		j++;
	}
	for (int i = 0; i < y; i++)
	{
		output << MorseToEng(T, list[j]) << endl;
		j++;
	}
	input.close();
	output.close();

}
int _tmain(int argc, _TCHAR* argv[])
{
	Tree T = creatNode();
	for (int i = 0; i < 37; i++)
	{
		addNode(T, convert[i].morse, convert[i].letter);
	}
	doc_ghiFile(T, "input.txt", "1412427.txt");

	system("pause");
	return 0;
}


