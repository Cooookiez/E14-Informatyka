#include <iostream>
#include <cstdlib>

using namespace std;

int main(int argc, char** argv)
{
	string zdanie;
	cout << "podaj slowo : ";
	getline(cin, zdanie);
	
	cout << endl << zdanie << endl;
	for(int i=zdanie.size()-1; i>=0; i--){
		for(int ii=0; ii<i; ii++){
			cout << zdanie[ii];
		}
		cout << endl;
	}
	return 0;
}
