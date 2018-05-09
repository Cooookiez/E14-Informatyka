#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

class Punkt{
	public:
		float x;
		float y;
		Punkt(float x = 0, float y = 0){
			this->x = x;
			this->y = y;
		}
		void ustawPunkt(float x = 0, float y = 0){
			this->x = x;
			this->y = y;
		}
		void wyswietlPunkt(){
			cout << "P("<< this->x << ", "<< this->y <<")" << endl;
		}
};

int main() {
	setlocale(LC_ALL, "");
	
	Punkt pkt1;
	pkt1.wyswietlPunkt();
	pkt1.ustawPunkt(2.5,4.6);
	pkt1.wyswietlPunkt();
	
	Punkt pkt2(12.34,43.21);
	pkt2.wyswietlPunkt();
	
	
	
	return 0;
}



