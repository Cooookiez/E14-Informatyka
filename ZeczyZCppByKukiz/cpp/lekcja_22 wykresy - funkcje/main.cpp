#include <iostream>
#include <cstdlib>

using namespace std;


void f_liniowa()
{
	float b, c;
	
	cout << "=== config ===" << endl << endl;
	cout << "f(x) = bx+c" << endl << endl;
	cout << "b = ";
	cin >> b;
	system("cls");
	
	
	cout << "=== config ===" << endl << endl;
	cout << "f(x) = "<< b <<"x+c" << endl << endl;
	cout << "c = ";
	cin >> c;
	system("cls");
	
	cout << "f(x) = "<< b <<"(x) + ("<< c <<")" << endl << endl;
	
	cout << "x\t| ";
	for (int i = -8; i <= 8; i+=2)
	{
		cout << i << "\t| ";
	}
	cout << endl;
	cout << "f(x)\t| ";
	for (int i = -8; i <= 8; i+=2)
	{
		//f(x) = b(x) + (c)
		cout << b * (i) + (c) << "\t| ";
	}	
}
void f_kwadratowa()
{
	float a, b, c;
	
	cout << "=== config ===" << endl << endl;
	cout << "f(x) = ax^2+bx+c" << endl << endl;
	cout << "a = ";
	cin >> a;
	system("cls");
	
	cout << "=== config ===" << endl << endl;
	cout << "f(x) = "<<a<<"x^2+bx+c" << endl << endl;
	cout << "b = ";
	cin >> b;
	system("cls");
	
	
	cout << "=== config ===" << endl << endl;
	cout << "f(x) = "<<a<<"x^2+"<< b <<"x+c" << endl << endl;
	cout << "c = ";
	cin >> c;
	system("cls");
	
	//f(x) = ax^2+bx+c
	cout << "f(x) = " << a << "x^2+" << b << "x+" << c <<endl << endl;
	
	cout << "x\t|";
	for (int i = -8; i <= 8; i+=2)
	{
		cout << i << "\t|";
	}
	cout << endl;
	cout << "f(x)\t|";
	for (int i = -8; i <= 8; i+=2)
	{
		//ax^2+bx+c
		cout << a*(i*i)+b*(i)+c << "\t|";
	}
}
void f_try()
{
	float a, b, c;
	
	cout << "=== config ===" << endl << endl;
	cout << "a = ";
	cin >> a;
	system("cls");
	
	cout << "=== config ===" << endl << endl;
	cout << "b = ";
	cin >> b;
	system("cls");
	
	cout << "=== config ===" << endl << endl;
	cout << "c = ";
	cin >> c;
	system("cls");
	
	cout << "=== dane ===" << endl;
	cout << "a = " << a << endl;
	cout << "b = " << b << endl;
	cout << "c = " << c << endl;
	
	cout << "=== info ===" << endl;
	cout << "alfa: miedzy b i c" << endl;
	cout << "beta: miedzy a i c" << endl;
	for(int i = 0; i < 10; i++)
	{
		if(i == 5)
			cout << 'a';
		if(i == 1)
			cout << "beta";
		cout << "\t";// << char(219);
		for (int j = 0; j < i; j++)
		{
			cout <<char(219);
		}
		
		if(i == 5)
			cout << "\tc";
		if(i == 9)
			cout << " alfa";
		cout << endl;
	}
	cout << "\t b";
	
	cout << endl;
	cout << "=== alfa ===" << endl;
	cout << "sin:\t" << a/c << endl;
	cout << "cos:\t" << b/c << endl;
	cout << "tg:\t" << a/b 	<< endl;
	cout << "ctg:\t" << b/a << endl;
		
	cout << "=== beta ===" << endl;
	cout << "sin:\t" << b/c << endl;
	cout << "cos:\t" << a/c << endl;
	cout << "tg:\t" << b/a 	<< endl;
	cout << "ctg:\t" << a/b << endl;
	
}
void mainMenu()
{
	cout << "=== Menu ===" << endl << endl;
	int indexOpc = 1;
	cout << indexOpc++ << ". Funkcja Liniowa" << endl;
	cout << indexOpc++ << ". Funkcja Kwadratowa" << endl;
	cout << indexOpc++ << ". Funkcja Trygonometryczna" << endl;
	cout << "- - - - - - - - -" << endl;
	cout << "Wybierz: ";
	int nrOpc;
	cin >> nrOpc;
	system("cls");
	switch(nrOpc)
	{
		default:
		case 1:
			f_liniowa();
			break;
		case 2:
			f_kwadratowa();
			break;
		case 3:
			f_try();
			break;
	}
}
int main()
{
	mainMenu();
	cout << endl << endl << endl << "========================" << endl;
	cout << "0. koniec" << endl;
	cout << "1. ponow" << endl;
	cout << "- - - - -" << endl;
	cout << "wybierz: ";
	int nrOpc;
	cin >> nrOpc;
	switch(nrOpc)
	{
		default:
		case 0:
			break;
		case 1:
			system("cls");
			main();
			break;
	}
	return 0;
}
