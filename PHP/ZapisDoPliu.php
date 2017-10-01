<?php

//	Do pliku .txt
	//r, r+ - tylko odczyt
	//w, w+ - nadpisywanie
	//a, a+ - dopisywanie,
	// + - odczytywanie

	//blokaty
	//LOCK_SH lub 1 - blokata dzielona
	//LOCK_EX lub 2 - dla pierwszej
	//LOCK_UN lub 3 - zdejmuje blkade
	$fileLocation = "plik.txt";

	//otczyt
	if(is_readable($fileLocation)){
		$content = file_get_contents($fileLocation);
	}else{
		echo 'Nie ma takiego pliku';
	}
	
	//zapis
	if(is_writable($fileLocation) && $handle = fopen($fileLocation, 'w+')){
		if(flock($handle, 2)){ //2 lub LOCK_EX
			fwrite($handle, 'Witaj Świecie');
			flock($handle, 3); //3 lub LOCK_UN
		}else{
			echo 'Plik jest zablokoany';
		}
		fclose($handle);
	}else{
		echo 'Nie ma takiego pliku';
	}


//	Do pliku .json
	$fileLocation = "plik.json";
	if(is_readable($fileLocation)){
		
		//pobranie i dodanie do json
		$json = file_get_contents($fileLocation);
		$json = json_decode($json, true);
		array_push($json['wygenerowaneHasla'], ['data'=>date('Y.m.d H:i:s'), 'hasla' => $haslaDoPliku]);
		$json = json_encode($json);

		//zapisanie do json
		if(is_writable($fileLocation) && $file = fopen($fileLocation, 'w')){
			if(flock($file, 2)){
				if(!fwrite($file, $json)) echo 'Błąd w zapisaniu danych';
				flock($file, 3);
			}else echo 'plik zablokowany'; //flocks
			fclose($file);
		}else echo 'Błąd w otworzeniu pliku';//iswritable


	}else echo 'Błąd w otczytaniu';//is_readable

//do .xml
	$fileLocation = "plik.xml";
	if(is_readable($fileLocation)){
		$xml = simplexml_load_file($fileLocation);
		echo '<pre>';
		$xml->addChild('element');
		$element_dl = $xml->count();
		$xml->element[$element_dl-1]->addChild('data', date('Y.m.d H:i:s'));
		foreach($haslaDoPliku as $haslo){
			$haslo = htmlspecialchars($haslo, ENT_QUOTES);
			$xml->element[$element_dl-1]->addChild('hasla', $haslo);
		}
		$xml->asXml($fileLocation);
		echo '</pre>';

	}else echo 'Błąd w otczytaniu';




?>