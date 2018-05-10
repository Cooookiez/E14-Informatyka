#include <iostream>
#include <cstdlib>

using namespace std;

int main(int argc, char** argv)
{
	cout << "Obliczanie pola powierzchni i obwotu prostokata" << endl << endl;
	float bok_a, bok_b;
	cout << "Podaj bok \"a\" : ";
	do
	{
		cin.clear();
		cin.sync();
		cin >> bok_a;
		cin.good();
		if(cin.good()==0||bok_a<=0)
		{
			cout << "meh, popraw sie : ";
		}
	}while(cin.good()==0||bok_a<=0);
	cout << "Podaj bok \"b\" : ";
	do
	{
		cin.clear();
		cin.sync();
		cin >> bok_b;
		cin.good();
		if(cin.good()==0||bok_b<=0)
		{
			cout << "meh, popraw sie : ";
		}
	}while(cin.good()==0||bok_b<=0);
	cout << endl << "POLE POWIERZCHNI" << endl;
	cout << bok_a << "*" << bok_b << "=" << bok_a*bok_b << " jednostek^2" << endl;
	cout << endl << "OBWUT" << endl;
	cout << "2*" << bok_a << "+2*" << bok_b << "=" << 2*bok_a+2*bok_b << " jednostek" << endl;
	cout << "--------------------------------------------------------------------------" << endl << endl;
	main(argc, argv);
	return 0;
}
