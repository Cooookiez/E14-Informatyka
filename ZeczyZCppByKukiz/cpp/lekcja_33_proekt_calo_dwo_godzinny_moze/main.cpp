#include <iostream>
#include <cstdlib>
#include <string>
#include <windows.h>
#include <cmath>
#include <math.h>
#include <ctime>

using namespace std;

void kalkulator(){
	system("cls");
	int a, b;
	cout << "Podaj pierwsza liczbe:\t";
	cin >> a;
	cout << "Podaj druga liczbe:\t";
	cin >> b;
	cout << a << " + " << b << " = " << a+b << endl;
	cout << a << " - " << b << " = " << a-b << endl;
	cout << a << " * " << b << " = " << a*b << endl;
	cout << a << " / " << b << " = " << a/b << endl;
	cout << a << " ^ " << b << " = " << pow(a,b) << endl;
	
	system("pause");
	
}


void kwadratowe(){
	system("cls");
	int a, b, c;
	cout << "ax^2 + bx + c" << endl;
	cout << "- - - - - - - - - -" << endl;
	cout << "Podaj a: ";
	cin >> a;
	
	system("cls");
	cout << a << "x^2 + bx + c" << endl;
	cout << "- - - - - - - - - -" << endl;
	cout << "Podaj b: ";
	cin >> b;
	
	system("cls");
	cout << a << "x^2 + " << b <<"x + c" << endl;
	cout << "- - - - - - - - - -" << endl;
	cout << "Podaj c: ";
	cin >> c;
	
	system("cls");
	cout << a << "x^2 + " << b <<"x + " << c << endl;
	cout << "- - - - - - - - - -" << endl << endl;
	double delta = pow(b,2) - (4*a*c);
	cout << "delta: " << delta << endl;
	if(delta > 0){
		cout << "x1 = " << (b*(-1) - pow(delta, 1/2))/(2*a) << endl;
		cout << "x2 = " << (b*(-1) + pow(delta, 1/2))/(2*a) << endl;
	}else if(delta == 0){
		cout << "x0 = " << (b*(-1))/(2*a) << endl;
	}else{
		cout << "Delta mniejsza od zera wiec brak 'x'." << endl;
	}
	system("pause");
}


void lotto(){
	system("cls");
	srand(time(NULL));
	int los_min, los_max;
	cout << "Los min: ";
	cin >> los_min;
	
	cout << "Los max: ";
	do{
		cin >> los_max;
		if(los_max <= los_min){
			cout << "los max nie moze byc mniejszy lub rowny los min" << endl << "jeszcze raz: ";
		}
	}while(los_max <= los_min);
	
	int los[6];
	cout << endl;
	for (int i = 0; i < 6; i++){
		los[i] = los_min + rand()%(los_max - los_min + 1);
		cout << "los nr" << i+1 << ": " << los[i] << endl;
	}
	system("pause");
}

void odw_wyraz(){
	
	system("cls");
	string wyraz;
	
	cout << "Podaj wyraz: ";
	cin >> wyraz;
	int wy_length = wyraz.length();
	
	cout << "Twoj wyraz na odwrot: ";
	for (int i = wy_length-1; i >= 0; i--){
		cout << wyraz[i];
	}
	cout << endl;
	
	
	system("pause");
}

int main(){
	system("cls");
	cout << "- - - - - - - - - - - - - - - - - - - -" << endl;
	cout << "1. Prosty kalkulator" << endl;						//jest
	cout << "2. Obliczanie 'x' z funkcji kwadratowej" << endl;	//jest
	cout << "3. Lotto" << endl;									//jest
	cout << "4. Odwruc wyraz" << endl;							//
	cout << "0. Zakoncz" << endl;
	cout << "- - - - - - - - - - - - - - - - - - - -" << endl;
	cout << "Wybor: ";
	
	int wyb;
	cin >> wyb;
	switch(wyb){
		case 0:
			break;
		case 1:
			kalkulator();
			main();
			break;
		case 2:
			kwadratowe();
			main();
			break;
		case 3:
			lotto();
			main();
			break;
		case 4:
			odw_wyraz();
			main();
			break;
		default:
			cout << "cos zle :/" << endl << endl;
			system("pause");
			main();
			break;
	}
	return 0;
}
