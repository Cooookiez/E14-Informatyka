#include <iostream>
#include <cstdlib>
#include <sstream> //dolacznie strumienia napisow
#include <ctime>

using namespace std;

void podstawa(){
	time_t czas;	//przechowuje czas
	time(&czas);	//pobiera aktualny czas
	cout << "\nCzas NIEskonwertowany:\t" << czas << endl;
	cout << "Czas skonwertowany:\t" << ctime(&czas) << endl;
}

void czas2string(){
	
	time_t czas;	//przechowuje czas
	time(&czas);
	
	string day;
	string s_czas(ctime(&czas));
	stringstream D;
	cout << "s_czas: " << s_czas << endl;
	D << s_czas;
	D >> day;
	cout << "day: " << day << endl;
	cout << "sek: " << s_czas[17] << s_czas[18] << endl;
	
	stringstream F;
	F << s_czas[11] << s_czas[12] << " " << s_czas[14] << s_czas[15] << " " << s_czas[17] << s_czas[18];
	int gdz, min, sec;
	F >> gdz >> min >> sec;	
	cout << "aktualna godzina: " << gdz << " : " << min << " : " << sec << endl;

	
}

int main(){
	
//	podstawa();
//	czas2string();
	
	return 0;
}
