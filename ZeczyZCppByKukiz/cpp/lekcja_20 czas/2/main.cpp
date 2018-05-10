#include <iostream>
#include <iomanip>
#include <ctime>
#include <cstdlib>

using namespace std;

const int N = 1564333656546546546546540000;

int main()
{
	clock_t start, stop;
	
	int d[N],i,j;
	cout << "sortowanie babelkowe\n"
			"    Wersja NR 1\n"
			"--------------------\n"
			"przed posortwoaniem : \n\n";
	srand(time(NULL));
	
	for (int i = 0; i < N; i++)
	{
		d[i] = rand()%100000;
	}
/*	for (int i = 0; i < N; i++)
	{
		cout << setw(4) << d[i];
	}*/
	
	cout << "\n\npo posortwoaniu : \n\n";
	start = clock();
	for (int j = 0; j < N - 1; j++)
		for (int i = 0; i < N - 1; i++)
			if(d[i] > d[i+1])
				swap(d[i], d[i+1]);
	stop = clock();
	
/*	for (int i = 0; i < N; i++)
	{
		cout << setw(4) << d[i];
	}*/
	cout << endl << "liczby sortowaly sie : " << (double)(stop-start) / CLOCKS_PER_SEC;
	
	
	return 0;
}
