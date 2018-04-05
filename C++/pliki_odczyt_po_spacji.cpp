#include <iostream>
#include <fstream>

using namespace std;

void odczytPoSapcji(){
	ifstream ifile;
	ifile.open("informatycy.txt");
	string tmp;
	
	while(ifile >> tmp){
		cout << tmp << endl;
	}
	
	ifile.close();
}

void odczytPoLinijce(){
	ifstream ifile;
	ifile.open("informatycy.txt");
	string tmp;
	
	while(!ifile.eof()){
		getline(ifile, tmp);
		cout << tmp << endl;
	}
	
	ifile.close();
}

void nadpisywaniePliku(){
	ofstream ofile;
	ofile.open("nadpisywanie.txt", ios::out);
	if(ofile){
		cout << "Zapis START" << endl;
		for(int i = 0; i < 20; i++){
			ofile << i << ", ";
		}
		cout << "Zapis END" << endl;
		ofile.close();
	}else{
		cout << "coœ nie pyk³o" << endl;
	}
}

void nadpisywanieLinijekPliku(){
	ofstream ofile;
	ofile.open("nadpisywanie2.txt", ios::in);
	if(ofile){
		cout << "Zapis START" << endl;
		for(int i = 0; i < 20; i++){
			ofile << i << ", ";
		}
		cout << "Zapis END" << endl;
		ofile.close();
	}else{
		cout << "coœ nie pyk³o" << endl;
	}
}

void dopisywanieDoPliku(){
	ofstream ofile;
	ofile.open("dopisywane.txt", ios::app);
	if(ofile){
		cout << "Zapis ŒTART" << endl;
		for(int i = 0; i < 20; i++){
			ofile << i << ", ";
		}
		cout << "Zapis END" << endl;
		ofile.close();
	}else{
		cout << "coœ nie pyk³o" << endl;
	}
}


int main(){
	setlocale (LC_ALL,"");
//	odczytPoSapcji();
//	odczytPoLinijce();
//	nadpisywaniePliku();
//	nadpisywanieLinijekPliku();
//	dopisywanieDoPliku();

	return 0;
}
