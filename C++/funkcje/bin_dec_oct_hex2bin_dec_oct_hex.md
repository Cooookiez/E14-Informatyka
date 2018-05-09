# bin2dec
```c++
int bin2dec(string bin){
	int dl = bin.length();
	int lvl = 0;
	int dec = 0;
	for (int i = dl-1; i >= 0; i--){
		if(bin[i] == '1'){
			dec += pow(2,lvl);
		}
		lvl++;
	}
	return dec;
}
```

# oct2dec
```c++
int oct2dec(string oct){
	int dl = oct.length();
	int lvl = 0;
	int dec = 0;
	for (int i = dl-1; i >= 0; i--){
		switch(oct[i]){
			case '0':
				dec += 0;
				break;
			case '1':
				dec += 1*pow(8,lvl);
				break;
			case '2':
				dec += 2*pow(8,lvl);
				break;
			case '3':
				dec += 3*pow(8,lvl);
				break;
			case '4':
				dec += 4*pow(8,lvl);
				break;
			case '5':
				dec += 5*pow(8,lvl);
				break;
			case '6':
				dec += 6*pow(8,lvl);
				break;
			case '7':
				dec += 7*pow(8,lvl);
				break;
			default:
				dec = -1;
				break;
		}
		lvl++;
	}
	return dec;
}
```

# hex2dec
```c++
int hex2dec(string hex){
	int dl = hex.length();
	int lvl = 0;
	int dec = 0;
	for (int i = dl-1; i >= 0; i--){
		switch(hex[i]){
			case '0':
				dec += 0;
				break;
			case '1':
				dec += 1*pow(16,lvl);
				break;
			case '2':
				dec += 2*pow(16,lvl);
				break;
			case '3':
				dec += 3*pow(16,lvl);
				break;
			case '4':
				dec += 4*pow(16,lvl);
				break;
			case '5':
				dec += 5*pow(16,lvl);
				break;
			case '6':
				dec += 6*pow(16,lvl);
				break;
			case '7':
				dec += 7*pow(16,lvl);
				break;
			case '8':
				dec += 8*pow(16,lvl);
				break;
			case '9':
				dec += 9*pow(16,lvl);
				break;
			case 'A':
			case 'a':
				dec += 10*pow(16,lvl);
				break;
			case 'B':
			case 'b':
				dec += 11*pow(16,lvl);
				break;
			case 'C':
			case 'c':
				dec += 12*pow(16,lvl);
				break;
			case 'D':
			case 'd':
				dec += 13*pow(16,lvl);
				break;
			case 'E':
			case 'e':
				dec += 14*pow(16,lvl);
				break;
			case 'F':
			case 'f':
				dec += 15*pow(16,lvl);
				break;
			default:
				dec = -1;
				break;
		}
		lvl++;
	}
	return dec;
}
```

# dec2bin
```c++
string dec2bin(int dec){
	string bin = "";
    while(dec!=0){
    	bin = (dec%2==0 ? "0":"1") + bin;
    	dec/=2;
	}
    return bin;
}
```

# dec2oct
```c++
string dec2oct(int dec){
	string oct;
	while(dec!=0){
		switch(dec%8){
			case 0: oct = "0"+oct; break;
			case 1: oct = "1"+oct; break;
			case 2: oct = "2"+oct; break;
			case 3: oct = "3"+oct; break;
			case 4: oct = "4"+oct; break;
			case 5: oct = "5"+oct; break;
			case 6: oct = "6"+oct; break;
			case 7: oct = "7"+oct; break;
			default: oct = "-1"; break;
		}
		dec/=8;
	}
	return oct;
}
```

# dec2hex
```c++
string dec2hex(int dec){
	string hex;
	while(dec!=0){
		switch(dec%16){
			case 0: hex = "0"+hex; break;
			case 1: hex = "1"+hex; break;
			case 2: hex = "2"+hex; break;
			case 3: hex = "3"+hex; break;
			case 4: hex = "4"+hex; break;
			case 5: hex = "5"+hex; break;
			case 6: hex = "6"+hex; break;
			case 7: hex = "7"+hex; break;
			case 8: hex = "8"+hex; break;
			case 9: hex = "9"+hex; break;
			case 10: hex = "A"+hex; break;
			case 11: hex = "B"+hex; break;
			case 12: hex = "C"+hex; break;
			case 13: hex = "D"+hex; break;
			case 14: hex = "E"+hex; break;
			case 15: hex = "F"+hex; break;
			default: hex = "-1"; break;
		}
		dec/=16;
	}
	return hex;
}
```