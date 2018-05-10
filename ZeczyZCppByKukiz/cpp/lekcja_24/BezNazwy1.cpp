#include <iostream>
#include <ctime>
#include <cstdlib>
#include <windows.h>
#include <math.h> 
#include <sstream> 
#include <fstream> 
#include <algorithm>
#include <stdlib.h>
#include <string>


using namespace std;
void zeroj_tablice(int*p, int n){
	while (n-->0){
		*p=0;
		p++;
	}
}
int main (int agrc, char** argv){
	
	int rozmiar;
	cout<<"rozmiar tab";
	cin>> rozmiar;
	
	int *wskaznik;
	wskaznik=new int [rozmiar];
	cout<<"adres tablicy "<<wskaznik<<endl;




return 0 ;
}
