# Losowanie liczb
## Losowanie liczb od 0 do x
```cpp
#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int main(){
    srand(time(NULL));

    int x = 10
    cout << rand()%(x+1) << endl;

    return 0;
}
```
wynikiem może być liczba od 0 do 10

## Losowanie liczb od min do max
```cpp
#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int main(){
    srand(time(NULL));

    int min = -10;
    int max = 20;
    cout << rand()%(max-min+1) + min << endl;

    return 0;
}
```
wynikiem może być liczba od -10 do 20
