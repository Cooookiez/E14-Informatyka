#include <iostream>

using namespace std;

int main(int argc, char** argv)
{
	cout << endl << "podaj co zrobic : " << endl;
	cout << "1. dodawanie" << endl;
	cout << "2. odejmowanie" << endl;
	cout << "3. mnozenie" << endl;
	cout << "4. dzielenie" << endl;
	cout << "wybierz: ";
	int opcja;
	cin >> opcja;
	cout << endl;
	float liczba_a, liczba_b;
	cout << "podaj liczbe a : "; 
	cin >> liczba_a;
	cout << "podaj liczbe b : "; 
	cin >> liczba_b;
	
	switch(opcja){
		case 1:
			cout << liczba_a << " + " << liczba_b << " = " << liczba_a + liczba_b << endl;
			break;
		case 2:
			cout << liczba_a << " - " << liczba_b << " = " << liczba_a - liczba_b << endl;
			break;
		case 3:
			cout << liczba_a << " * " << liczba_b << " = " << liczba_a * liczba_b << endl;
			break;
		case 4:
			if(liczba_b)
				cout << liczba_a << " / " << liczba_b << " = " << liczba_a / liczba_b << endl;
			else
				cout << "nie dzieli sie przez zero" << endl;
			break;
		default:
			cout << "nie odpowiedni wybor" << endl;
	}
	main(argc, argv);
	return 0;
}
