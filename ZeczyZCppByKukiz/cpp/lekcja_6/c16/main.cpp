#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(int argc, char** argv)
{srand(time(NULL));
	int max_liczba_losuj, losuj;
	cout << "maksymalna iczba lsowania : ";
	do{
		cin.clear();
		cin.sync();
		cin >> max_liczba_losuj;
		cin.good();
		if(cin.good()==0||max_liczba_losuj<0)
			cout << "jescze raz : ";
	}while(cin.good()==0||max_liczba_losuj<0);
	losuj=rand()%++max_liczba_losuj;
	cout << endl << "twoja iczba to : " << losuj << endl;
	if(losuj==0)
		cout << "tak w sumie to trudno owiedziec czy parzysta czy nie" << endl;
	else if(losuj%2==0)
		cout << "twoja losowa liczba jest parzysta." << endl;
	else
		cout << "twoja losowa liczba nie jest parzysta." << endl;
	cout << endl;
	system("pause");
	system("cls");
	main(argc, argv);return 0;
}
