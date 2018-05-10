#include <iostream>
#include <windows.h>

using namespace std;




int main(){
	string haslo = "Ala ma kota";
	string widoczne = "";
	
	while(int dl = haslo.size()){
		for(int i = dl-1; i >= 0; i--){
			system("cls");
			cout << widoczne << haslo[i];
			if(i == 0){
				widoczne += haslo[i];
				haslo.erase(i, 1);
			}
			Sleep(10);;
		}
	}
	
	return 0;
}
