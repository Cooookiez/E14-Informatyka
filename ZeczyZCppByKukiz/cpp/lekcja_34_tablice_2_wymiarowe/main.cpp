#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(int argc, char** argv){
	
	srand(time(NULL));
	
	
	int tab[6][5];
	
	for(int i = 0; i < 6; i++){
		for(int j = 0; j < 5; j++){
			tab[i][j] = rand()%101;
		}
	}
	
	for(int i = 0; i < 6; i++){
		for(int j = 0; j < 5; j++){
			//cout << "tab[" << i << "][" << j << "] = " << tab[i][j] << endl;
			if(tab[i][j]%2==0 && tab[i][j]){
				cout << "["<< tab[i][j] << "]\t";
			}else{
				cout << tab[i][j] << "\t";
			}
		}
		cout << endl;
	}
	
	return 0;
}
