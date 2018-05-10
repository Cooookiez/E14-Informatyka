#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;

class Punkt{
private:
	int x, y;
		
public:
	void przypisz(int nx, int ny){
		x = nx;
		y = ny;
	}
	int takeX(){ return x; }
	int takeY(){ return y; }
	void up(int ile)	{ y+=ile; }
	void down(int ile)	{ y-=ile; }
	void left(int ile)	{ x+=ile; }
	void right(int ile)	{ x-=ile; }
	void p(){
		cout << "P("<<x<<", "<<y<<")";
	}
};

int main(){
	Punkt p1;
	p1.przypisz(0, 0);
	
	p1.P(); cout << endl;
	
	p1.up(15);
	p1.down(5);
	p1.left(28);
	p1.right(7);
	
	p1.P();
	
	return 0;
}
