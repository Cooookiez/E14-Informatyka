#include <iostream>
#include <ctime>
#include <cstdlib>

using namespace std;

int main(int argc, char** argv)
{
	srand(time(NULL));
	string zn="abcdefghijkl³mnoprstuwyzABCDEFGHIJKL£MNOPRSTUWYZ1234567890!@#$%^&*./,-=[]";
	int ilosc_zn=zn.size(), haslo_dl, haslo_ilosc;
	cout << "ilosc hasel : ";
	cin >> haslo_ilosc;
	cout << "ile cyfer w haslie? : ";
	cin >> haslo_dl;
	cout << endl << "wygenerowane haslo : " << endl;
	for(int licznik=0; licznik<haslo_ilosc; licznik++){
		cout << endl << "---- " << licznik+1 << " ----" << endl << endl;
		cout << " ";
		for(int i=0; i<haslo_dl; i++){
			cout << zn[rand()%ilosc_zn];
		}
		cout << endl;
	}
	if(haslo_ilosc>=10)
		cout << endl << "------------" << endl;
	else
		cout << endl << "-----------" << endl;
	cout << endl;
	system("pause");
	system("cls");
	main(argc, argv);
	return 0;
}
