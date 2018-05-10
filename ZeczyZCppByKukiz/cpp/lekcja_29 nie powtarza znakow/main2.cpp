#include <iostream>

using namespace std;


string distinct(string slowo){
		
	string bez_powturzen = "";
	int slowo_dl = slowo.length();
	int index= 0;
	
	
	char znak[slowo_dl];
	for(int i = 0; i < slowo_dl; i++){//powtarza sie tyle razy ile jest znakow w zdaniu
		
		if(i == 0){
			bez_powturzen += slowo[i];
			znak[index] += slowo[i];
			cout << slowo[i] << " | ";
			cout << endl;
			
			index++;
		}else{
			cout << slowo[i] << " | ";
			//patrzy czy juz bylo
			bool nie_powtarza_sie = true;
			for(int j = 0; j < index-1; j++){
					cout << znak[j];
				if(znak[j] == slowo[i]){
					nie_powtarza_sie = false;
				}
			}
			cout << endl;
			
			
			if(nie_powtarza_sie){//nie powtarza sie
				bez_powturzen += slowo[i];
				znak[index] += slowo[i];
				index++;
			}
			
		}
		
		
	}
	
	return bez_powturzen;
}

int main()
{
	string slowo;
	//cout << "Podaj jakies slowo: ";
	//cin >> slowo;
	slowo = "matematyka";
	
	cout << distinct(slowo);
	
	
	return 0;
}
