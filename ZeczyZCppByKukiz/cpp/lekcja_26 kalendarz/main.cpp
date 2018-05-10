#include <iostream>
#include <cstdlib>
#include <sstream>	//dolacznie strumienia napisow
#include <ctime>
#include <windows.h>
#include <ctime>	// atoi example 
#include <stdio.h>	// printf, fgets 
#include <stdlib.h>	// atoi 
#include <time.h>

using namespace std;

bool run = true;
int day,
	month,
	year;
	
void setup(){
	time_t  czas;	//przechowuje czas
	time(&czas);	//pobiera czas
	cout << ctime(&czas) << endl;	//wyswieta dzisijsza dade
	cout << "- - - - - - - - -" << endl << endl;
	string s_czas(ctime(&czas));
	
	//dzien w int
	day = ((int)s_czas[8] - 48)*10 + (int)s_czas[9] - 48;
	//miesiac w int
	string sMonth = "123";
	sMonth[0] = s_czas[4];
	sMonth[1] = s_czas[5];
	sMonth[2] = s_czas[6];
	//month = sMonth == "Jun"? 1:0;
		if (sMonth == "Jan"){month = 1;}
	else if(sMonth == "Feb"){month = 2;}
	else if(sMonth == "Mar"){month = 3;}
	else if(sMonth == "Apr"){month = 4;}
	else if(sMonth == "May"){month = 5;}
	else if(sMonth == "Jun"){month = 6;}
	else if(sMonth == "Jul"){month = 7;}
	else if(sMonth == "Aug"){month = 8;}
	else if(sMonth == "Sep"){month = 9;}
	else if(sMonth == "Oct"){month = 10;}
	else if(sMonth == "Nov"){month = 11;}
	else if(sMonth == "Dec"){month = 12;}
	
	//rok w int
	year =	
	( (int)s_czas[20] - 48 )*1000 + 
	( (int)s_czas[21] - 48 )*100 + 
	( (int)s_czas[22] - 48 )*10 + 
	( (int)s_czas[23] - 48 )*1;
	
	cout << day << " " << sMonth << " " << year << endl;
	cout << day << " " << month << " " << year << endl;
	
	system("pause");
}

void draw(){
	system("cls");
	
	string miesac;
	switch(month){
		case 1:
			miesac = "Styczen";
			break;
		case 2:
			miesac = "Luty";
			break;
		case 3:
			miesac = "Marzec";
			break;
		case 4:
			miesac = "Kwiecien";
			break;
		case 5:
			miesac = "Maj";
			break;
		case 6:
			miesac = "Czerwiec";
			break;
		case 7:
			miesac = "Lipiec";
			break;
		case 8:
			miesac = "Sierpien";
			break;
		case 9:
			miesac = "Wrzesien";
			break;
		case 10:
			miesac = "Pazdziernik";
			break;
		case 11:
			miesac = "Listopad";
			break;
		case 12:
			miesac = "Grudzien";
			break;
		default:
			miesac = "Miesac";
	}
	
	cout << " <<\t";
	cout << day << " ";
	cout << miesac << " ";
	cout << year;
	cout << "\t>>";
	
	
	Sleep(250);
}

void logick(){
	unsigned char znak = getch();
    switch( znak )
    {
    case 0: //klawisze specjalne (czasem zero czasem 224 - zale¿ne od pc'ta chyba)
    case 224: //klawisze specjalne
        znak = getch();
        switch( znak )
        {
        case 75: //strza³ka w lewo
        	day -= 1;
            break;
        case 77: //strza³ka w prawo
        	day += 1;
            break;
        }
        znak = 0;
        break;
    case 13: //ENTER
        break;
    case 27: //ESC
        run = false;
        break;
    }
}

int main(){
	
	setup();
	
	do{
		draw();
		logick();
	}while(run);
	
	return 0;
}
