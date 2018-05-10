#include <iostream>

using namespace std;

int main(int argc, char** argv)
{
	cout << "\"fajnosc liczb\"" << endl;
	float liczba_1;
	cout << "Podaj liczbe : ";
	cin >> liczba_1;
	if(((liczba_1>=0&&liczba_1<10)||(liczba_1>=13&&liczba_1<=21)||liczba_1==11)&&liczba_1!=17)
		cout << "ta liczba jest fajna" << endl;
	else
		cout << "ta liczba nie jest fajna" << endl;
	cout << endl << "----------------------------------------" << endl << endl;
	main(argc, argv);
	return 0;
}
