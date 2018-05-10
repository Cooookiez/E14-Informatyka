#include <iostream>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) 
{
	string imie_nazwisko, kolor, odpowiedz, gry;
	cout << "  -Podaj imie i nazwisko : " << endl << "ty-";
	getline(cin, imie_nazwisko);
	cout << "  -hej " << imie_nazwisko << ", jak sie masz? :>" << endl;
	cout << "   Jaki jest wtoj ulubiony kolor? : " << endl << "ty-";
	getline(cin, kolor);
	if(kolor=="niebieski"||kolor=="Niebieski"){
		cout << "  -Serio?! Niebieski?! Moj tez!!" << endl;
	}
	else{
		cout << "  -" << kolor << "? Meh ja wole niebieki." << endl;
	}
	cout << "   A grasz w jakies gry?(tak/nie)" << endl << "ty-";
	cin >> odpowiedz;
	if(odpowiedz=="tak"||odpowiedz=="Tak"||odpowiedz=="TAK"){
		cout << "  -Serio? napszyklad w co?" << endl << "ty-";
		cin >> gry;
		if(gry=="cs"||gry=="csgo"||gry=="CS"||gry=="CSGO"||gry=="cs:go"||gry=="CS:GO"){
			cout << "  -WOW! tez grasz w cs'a?! zagrajmy kiedys!" << endl << "   ja narazie spadam. nq" << endl;
		}
		else{
			cout << "  -na pewno musi byc ciekawe." << endl << "   ja narazie spadam. nq" << endl;
		}
	}
	else if(odpowiedz=="nie"||odpowiedz=="Nie"||odpowiedz=="NIE"){
		cout << "  -cuz, nie znajdziemy wsplnych tematow. Zegnam..." << endl;
	}
	else{
		cout << "  -chyba sie nie zrozumielismy..." << endl << "   i tak musze konczyc. nq" << endl;
	}
	
	
	
	
	cout << endl << "------------------------------------------------------------------------" << endl << endl << endl;
	main(argc,argv);
	return 0;
}
