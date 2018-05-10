#include <iostream>

using namespace std;

int main(int argc, char** argv)
{
	cout << "Ktora liczba jest wieksza?" << endl;
	float liczba_a, liczba_b;
	cout << "Liczba a : ";
	cin >> liczba_a;
	cout << "Liczba b : ";
	cin >> liczba_b;
	
	if(liczba_a>liczba_b)
		cout << liczba_b << "(b) jest mniejsza od " << liczba_a << "(a)" << endl;
	else if(liczba_b>liczba_a)
		cout << liczba_a << "(a) jest miejsza od " << liczba_b << "(b)" << endl;
	else(liczba_a==liczba_b)
		cout << "liczby " << liczba_a << "(a), i " << liczba_b << "(b) sa rowne" << endl;
	
	
	cout << endl << "-----------------------------------------" << endl << endl;
	main(argc, argv);
	return 0;
}
