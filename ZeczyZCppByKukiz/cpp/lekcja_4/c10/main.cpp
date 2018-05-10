#include <iostream>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
const float LICZBA_PI=3.14;

int main(int argc, char** argv) 
{
	float promien;
	cout << "KULA" << endl << endl;
	cout << "Podaj promien kuli : ";
	do
	{
		cin.clear();
		cin.sync();
		cin >> promien;
		cin.good();
		if(cin.good()==0||promien<=0)
		{
			cout << "meh, popraw sie : ";
		}
	}while(cin.good()==0||promien<=0);
	
	cout << endl << "objetosc" << endl;
	//v=(4/3)*pi*r^3
	cout << "(4/3)*" << LICZBA_PI <<"*"<<promien << "^3" << " = " << (4/3)*LICZBA_PI*(promien*promien*promien) << " jednostek^3" << endl;
	cout << endl << "pole powierchni" << endl;
	//p=4*pi*r^2
	cout << "4*" << LICZBA_PI << "*" << promien << "^2 = " << 4*LICZBA_PI*(promien*promien) << " jednostek^2" << endl;
	
	return 0;
}
