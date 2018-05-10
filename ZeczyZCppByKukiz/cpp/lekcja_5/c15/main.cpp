#include <iostream>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv)
{
	cout << "LOSOWANIE" << endl;
	int losuj;
	losuj = rand()%101;
	cout << losuj;
	return 0;
}
