#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(int argc, char** argv)
{
	srand(time(NULL));
	int liczba[3], robo, licznik;
	licznik=0;
	while(licznik<=2)
	{
		liczba[licznik]=100+rand()%(200-100+1);
		licznik++;
	}
	
	while(liczba[0]>liczba[1]||liczba[0]>liczba[2])
	{
		robo=liczba[0];
		liczba[0]=liczba[1];
		liczba[1]=liczba[2];
		liczba[2]=robo;
	}
	while(liczba[1]>liczba[2])
	{
		robo=liczba[1];
		liczba[1]=liczba[2];
		liczba[2]=robo;
	}
	cout << liczba[0] << endl;
	cout << liczba[1] << endl;
	cout << liczba[2] << endl << endl;
	system("pause");
	system("cls");
	main(argc, argv);
	return 0;
}
