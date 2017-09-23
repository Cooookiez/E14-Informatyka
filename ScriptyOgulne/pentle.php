<?php
	/*
		Pętal for(){}
	*/
	for($i = 0; $i < 5; $i++){
		echo "$i\n";
	}
	echo "\n";
	//Wynik:	0	1	2	3	4
	
	
	/*
		Pętal while(){}
		Wykonuje się TYLKO jeżli parametr jest prawdziwy
	*/
	$index = 5;
	while(index > 2){
		cout << index << "\t";
		index--;
	}
	echo "\n";
	//wynik:	5	4	3
	
	
	/*
		do{}while()
		Wykona się ZAWSZE choć jeden raz, a dobiero sprawdza warunek i jeśli jest prawdziwy to się powtarza
	*/
	$index = 5;
	do{
		echo "$index\n";
		$index--;
	}while($index > 8);
	echo "\n";
	//wynik:	5
?>