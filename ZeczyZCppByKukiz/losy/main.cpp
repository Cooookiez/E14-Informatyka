#include <iostream>
#include <ctime>
#include <cstdlib>
#include <fstream>

using namespace std;

int losP, prob = 3,losU;
char sprCo = 'n';

void pierwszy(){
	int liczba;
	//pobiera
	ifstream zPliku("first.txt");
	if(zPliku){
		zPliku >> liczba;
	}
	zPliku.close();
	
	liczba++;
	//wysyla
	ofstream doPliku("first.txt", ios::out);
	if(doPliku){
		doPliku << liczba;
	}
	doPliku.close();
}
void games(){
	int liczba;
	//pobiera
	ifstream zPliku("games.txt");
	if(zPliku){
		zPliku >> liczba;
	}
	zPliku.close();
	
	liczba++;
	//wysyla
	ofstream doPliku("games.txt", ios::out);
	if(doPliku){
		doPliku << liczba;
	}
	doPliku.close();
}

void info(){
	system("cls");
	int games, first;
	
	ifstream zPliku1("first.txt");
	if(zPliku1){
		zPliku1 >> first;
	}
	zPliku1.close();
	
	ifstream zPliku2("games.txt");
	if(zPliku2){
		zPliku2 >> games;
	}
	zPliku2.close();
	
	cout << "Liczba rozegranych gier: " << games << endl;
	cout << "Uzytkownik wygral za pierzym razem: " << first << " razy" << endl << endl;
	system("pause");
}

void spr(int losU,int i){
	if(losU > losP){
		sprCo = 'd';//duzo
	}else if(losU < losP){
		sprCo = 'm';//malo
	}else if(losU == losP){
		if(i == 3){
			sprCo = 'f';//rowne i pierwsze
		}else{
			sprCo = 'r';//rowne
		}
	}
}

void game(){
	games();
	srand(time(NULL));
	losP = 1+rand()%10;
	for(int i = prob; i >= 0; i--){
		system("cls");
		if(!i && sprCo != 'r'){
			cout << "Przegrana :/" << endl;
			sprCo = 'n';
			system("pause");
		}else{
			cout << "Pozostalych prob: " << i << endl;
			/*za duzo / za malo / pierwszy widok / wygrana*/
			if(sprCo == 'd'){
				cout << "Poprzednia liczba jest za duza." << endl;
			}else if(sprCo == 'm'){
				cout << "Poprzednia liczba jest za mala." << endl;
			}else if(sprCo == 'f'){
				cout << "Brawo, zgadles za pierwszym razme!" << endl;
				system("pause");
				sprCo = 'n';
				pierwszy();
				break;
			}else if(sprCo == 'r'){
				cout << "Brawo, zgadles!" << endl;
				system("pause");
				sprCo = 'n';
				break;
			}
			
			/*podaj liczbe*/
			int losU;
			if(sprCo == 'd' || sprCo == 'm' || sprCo == 'n'){
				do{
					cout << "Podaj liczbe (1-10): ";
					cin.clear();
					cin.sync();
					cin >> losU;
					cin.good();
				}while(!cin.good() || losU > 10 || losU < 1);
				spr(losU,i);
			}
		}	
	}
}	

int main(){
	bool run = true;
	do{
		system("cls");
		int wyb = 0;
		cout << "1. Zacznij Gre" << endl;
		cout << "2. Zobacz Info" << endl;
		cout << "9. zakoncz" << endl;
		cout << "wybierz: "; cin >> wyb;
		switch(wyb){
			case 1:
				game();
				break;
			case 2:
				info();
				break;
			case 9:
				run = false;
				break;
			default:
				break;		
		}
	}while(run);
}
