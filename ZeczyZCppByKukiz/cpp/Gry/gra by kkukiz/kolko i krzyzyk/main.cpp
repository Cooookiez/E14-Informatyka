#include <iostream>
#include <windows.h>

/*kolko i krzyszuk .v01
  powrut .v03*/

using namespace std;

void kolejka(char);
int licznik_main1=0, licznik_main2=0, licznik_x, licznik_o;
char wzur[3][3][3];    //[o/x/ox][a/b/c][1/2/3]
                       //[0/1/2] [0/1/2][0/1/2]
int main()
{

    system("cls");
    char ktury_wzur;

    if(licznik_main1==0){
        licznik_main1++;
        int licznik1=0, licznik2=0, licznik3=0;
        while(licznik1<3)                           //zeruje wzur
        {
            while(licznik2<3)
            {
                while(licznik3<3){
                    wzur[licznik1][licznik2][licznik3]=' ';
                    licznik3++;
                }
                licznik3=0;
                licznik2++;
            }
            licznik2=0;
            licznik1++;
        }
    }

    cout << "kolko i krzyzyk the game.  by K.Kukiz  .v01" << endl;

    cout << endl;
    cout << "     1   2   3  " << endl << endl;
    cout << "   -------------" << endl;
    cout << "   |" << wzur[2][0][0] << wzur[0][0][0] << wzur[2][0][0] << "|" << wzur[2][0][1] << wzur[0][0][1] << wzur[2][0][1] << "|" << wzur[2][0][2] << wzur[0][0][2] << wzur[2][0][2] << "|" << endl;
    cout << " A |" << wzur[0][0][0] << wzur[1][0][0] << wzur[0][0][0] << "|" << wzur[0][0][1] << wzur[1][0][1] << wzur[0][0][1] << "|" << wzur[0][0][2] << wzur[1][0][2] << wzur[0][0][2] << "|" << endl;
    cout << "   |" << wzur[2][0][0] << wzur[0][0][0] << wzur[2][0][0] << "|" << wzur[2][0][1] << wzur[0][0][1] << wzur[2][0][1] << "|" << wzur[2][0][2] << wzur[0][0][2] << wzur[2][0][2] << "|" << endl;
    cout << "   -------------" << endl;
    cout << "   |" << wzur[2][1][0] << wzur[0][1][0] << wzur[2][1][0] << "|" << wzur[2][1][1] << wzur[0][1][1] << wzur[2][1][1] << "|" << wzur[2][1][2] << wzur[0][1][2] << wzur[2][1][2] << "|" << endl;
    cout << " B |" << wzur[0][1][0] << wzur[1][1][0] << wzur[0][1][0] << "|" << wzur[0][1][1] << wzur[1][1][1] << wzur[0][1][1] << "|" << wzur[0][1][2] << wzur[1][1][2] << wzur[0][1][2] << "|" << endl;
    cout << "   |" << wzur[2][1][0] << wzur[0][1][0] << wzur[2][1][0] << "|" << wzur[2][1][1] << wzur[0][1][1] << wzur[2][1][1] << "|" << wzur[2][1][2] << wzur[0][1][2] << wzur[2][1][2] << "|" << endl;
    cout << "   -------------" << endl;
    cout << "   |" << wzur[2][2][0] << wzur[0][2][0] << wzur[2][2][0] << "|" << wzur[2][2][1] << wzur[0][2][1] << wzur[2][2][1] << "|" << wzur[2][2][2] << wzur[0][2][2] << wzur[2][2][2] << "|" << endl;
    cout << " C |" << wzur[0][2][0] << wzur[1][2][0] << wzur[0][2][0] << "|" << wzur[0][2][1] << wzur[1][2][1] << wzur[0][2][1] << "|" << wzur[0][2][2] << wzur[1][2][2] << wzur[0][2][2] << "|" << endl;
    cout << "   |" << wzur[2][2][0] << wzur[0][2][0] << wzur[2][2][0] << "|" << wzur[2][2][1] << wzur[0][2][1] << wzur[2][2][1] << "|" << wzur[2][2][2] << wzur[0][2][2] << wzur[2][2][2] << "|" << endl;
    cout << "   -------------" << endl << endl;

    int licznik, rzad_licznik, koluman_licznik;
    if(licznik_main2==0){
        licznik_main2++;
        char zaczyna;
        cout << "Podaj kto zaczyna o/x : ";
        do{
            cin.clear();
            cin.sync();
            cin >> zaczyna;
            cin.good();
            if(cin.good()==0||zaczyna!='o'&&zaczyna!='O'&&zaczyna!='x'&&zaczyna!='X'){
                cout << "Err0r" << endl;
                cout << "Podaj kto zaczyna o/x : ";
            }
        }while(cin.good()==0||zaczyna!='o'&&zaczyna!='O'&&zaczyna!='x'&&zaczyna!='X');
        if(zaczyna=='x'||zaczyna=='X'){
            licznik_o=1;
            licznik_x=0;
        }
        if(zaczyna=='o'||zaczyna=='O'){
            licznik_o=0;
            licznik_x=1;
        }
        licznik=0;
        main();
    }
    do{
        while(licznik_o==0){//kolko
            licznik_o=1;
            licznik_x=0;
            char rzad=' ';
            int kolumna=0;
            cout << "  ###" << endl;
            cout << "  # #" << endl;
            cout << "  ###" << endl << endl;
            cout << "Podaj rzad (a/b/c):";
            do{// bobiera liczbe
                cin.clear();
                cin.sync();
                cin >> rzad;
                cin.good();
                if(cin.good()==0||rzad!='a'&&rzad!='b'&&rzad!='c'&&rzad!='A'&&rzad!='B'&&rzad!='C'){
                    cout << "Podaj(a/b/c)! : ";
                }
            }while(cin.good()==0||rzad!='a'&&rzad!='b'&&rzad!='c'&&rzad!='A'&&rzad!='B'&&rzad!='C');

            cout << "(0 - by cofnoc)" << endl;
            cout << "Podaj kolumne (1/2/3) : ";
            do{// bobiera liczbe
                cin.clear();
                cin.sync();
                cin >> kolumna;
                cin.good();
                if(cin.good()==0||kolumna>3||kolumna<0){
                    cout << "(0 - by cofnoc)" << endl;
                    cout << "Podaj(1/2/3)! : ";
                }
            }while(cin.good()==0||kolumna>3||kolumna<0);
            if(kolumna==0){
                licznik_x=1;
                licznik_o=0;
                main();
            }

            if(rzad=='a'||rzad=='A'){
                rzad_licznik=0;
            }
            else if(rzad=='b'||rzad=='B'){
                rzad_licznik=1;
            }
            else if(rzad=='c'||rzad=='C'){
                rzad_licznik=2;
            }

            if(kolumna==1){
                koluman_licznik=0;
            }
            else if(kolumna==2){
                koluman_licznik=1;
            }
            else if(kolumna==3){
                koluman_licznik=2;
            }

            wzur[0][rzad_licznik][koluman_licznik]='#';
            wzur[1][rzad_licznik][koluman_licznik]=' ';
            wzur[2][rzad_licznik][koluman_licznik]='#';
            licznik++;
            main();
        }
        while(licznik_x==0){//krzyzyk
            licznik_x=1;
            licznik_o=0;
            char rzad=' ';
            int kolumna=0;
            cout << "  # #" << endl;
            cout << "   # " << endl;
            cout << "  # #" << endl << endl;
            cout << "Podaj rzad (a/b/c):";
            do{// bobiera liczbe
                cin.clear();
                cin.sync();
                cin >> rzad;
                cin.good();
                if(cin.good()==0||rzad!='a'&&rzad!='b'&&rzad!='c'&&rzad!='A'&&rzad!='B'&&rzad!='C'){
                    cout << "Podaj(a/b/c)! : ";
                }
            }while(cin.good()==0||rzad!='a'&&rzad!='b'&&rzad!='c'&&rzad!='A'&&rzad!='B'&&rzad!='C');
            cout << "(0 - by cofnoc)" << endl;
            cout << "Podaj kolumne (1/2/3/0):";
            do{// bobiera liczbe
                cin.clear();
                cin.sync();
                cin >> kolumna;
                cin.good();
                if(cin.good()==0||kolumna>3||kolumna<0){
                    cout << "(0 - by cofnoc)" << endl;
                    cout << "Podaj(1/2/3/0)! : ";
                }
            }while(cin.good()==0||kolumna>3||kolumna<0);
            if(kolumna==0){
                licznik_x=0;
                licznik_o=1;
                main();
            }

            if(rzad=='a'||rzad=='A'){
                rzad_licznik=0;
            }
            else if(rzad=='b'||rzad=='B'){
                rzad_licznik=1;
            }
            else if(rzad=='c'||rzad=='C'){
                rzad_licznik=2;
            }

            if(kolumna==1){
                koluman_licznik=0;
            }
            else if(kolumna==2){
                koluman_licznik=1;
            }
            else if(kolumna==3){
                koluman_licznik=2;
            }
            if(wzur[2][rzad_licznik][koluman_licznik]=='#'){
                cout << "To pole jest jusz zajete!, sprubuj gdzie indziej" << endl;
                system("pause");
                licznik_x=0;
                licznik_o=1;
                main();
            }
            else{
                wzur[0][rzad_licznik][koluman_licznik]=' ';
                wzur[1][rzad_licznik][koluman_licznik]='#';
                wzur[2][rzad_licznik][koluman_licznik]='#';
                licznik++;
                main();
            }
        }
    }while(licznik>9);































    return 0;
}
