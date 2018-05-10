#include <iostream>
#include <cstdlib>
#include <sstream> //dolacznie strumienia napisow
#include <ctime>

using namespace std;

int random(int nMax, int nMin)
{
	return nMin + rand() % (nMax - nMin + 1);
}

int main()
{
	srand(time(NULL));
	time_t czas; //przechowuje czas
	time(&czas); //pobiera do niej czas
	cout << ctime(&czas) << " -> " << czas << endl << endl;
	
	time(&czas);
	string s_czas(ctime(&czas));
	stringstream D;
	cout << "s_czas: " << s_czas << endl;
	D << s_czas;
	
	string day;
	D >> day;
	cout << "day: " << day << endl;
	
	cout << "sek: " << s_czas[17] << s_czas[18] << endl;
	
	stringstream F;
	F << s_czas[11] << s_czas[12] << " " << s_czas[14] << s_czas[15] << " " << s_czas[17] << s_czas[18];
	int gdz, min, sec;
	F >> gdz >> min >> sec;
	
	cout << "aktualna godzina: " << gdz << " : " << min << " : " << sec << endl;
	
	cout << "wylosowana liczba to : " << random(1,6) << endl;
	
	string dni[7] = {"poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela"};
	string days[7] = {"Mon", "tue", "Wed", "Thu", "Fre", "Sat", "Sun"};
	
	string dzien;
	
	for (int i = 0; i < 7; i++)
		if (day == days[i])
		{
			dzien = dni[i];
			break;
		}
	cout << "dzis jest " << dzien << endl;
	cout << endl << endl;
	system("PAUSE");
	
	
	
	return EXIT_SUCCESS;
}
