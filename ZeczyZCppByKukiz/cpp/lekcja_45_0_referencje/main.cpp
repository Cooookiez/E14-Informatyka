#include <iostream>

using namespace std;

void zwieksz_c(int *i){
	(*i)++;
}
void zwieksz_cpp(int &i){	//referencja
	i++;
}

void zamien(double &a, double &b){
//	10 = 7+3
	b = b+a;
//	7 = 1-3
	a = b-a;
//  3 = 10 - 7
	b = b-a;
}

int main(){
	int i = 0;
	cout << i << endl;
	zwieksz_c(&i);
	cout << i << endl;
	zwieksz_cpp(i);
	cout << i << endl;
	
	cout << endl << endl;
	double a = 3.4, b = 6.6;
	cout << "a: " << a <<
	endl << "b: " << b << endl;
	zamien(a, b);
	cout << "a: " << a <<
	endl << "b: " << b << endl;
	
	
	return 0;
}
