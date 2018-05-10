#include <iostream>
#include <cstdlib>

using namespace std;

int main(int argc, char** argv) 
{
	int liczba;
	cout << "Podaj liczbe : ";
	cin >> liczba;
	
	if((liczba<10||(liczba>=20&&liczba<30)||(liczba>50&&liczba<100)||liczba>120||liczba==45)&&liczba!=25&&liczba!=75)
		cout << "Liczba jest fajna" << endl;
	else
		cout << "Liczba NIE jest fajna" << endl;
	
	cout << endl;
	system("pause");
	system("cls");
	main(argc, argv);
	return 0;
}
