#include <iostream>

using namespace std;

int main(int argc, char** argv)
{
	int wiek;
	cout << "Podaj swoj wiek : ";
	cin >> wiek;
	cout << endl;
	
	if(wiek<=3)
		cout << "Dzieciatko" << endl;
	else if(wiek<=13)
		cout << "Dziecko" << endl;
	else if(wiek<=17)
		cout << "Mlodziez" << endl;
	else if(wiek<=65)
		cout << "Dorosly" << endl;
	else
		cout << "Babcia/Dziatek" << endl;
		
	cout << endl << endl;
	main(argc, argv);
	return 0;
}
