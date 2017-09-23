<?php
if(isset($_POST['op']) && !empty($_POST['op'])){
	$op = $_POST['op'];
}else if(isset($_GET['op']) && !empty($_GET['op'])){
	$op = $_GET['op'];
}
switch($op){
	case 'hasla': hasla($_POST); break;
}

function hasla($p){
	$znaki['male']	= 'qwertyuiopasdfghjklzxcvbnm';
	$znaki['duze']	= 'QWERTYUIOPASDFGHJKLZXCVBNM';
	$znaki['cyfry']	= '1234567890';
	$znaki['inne']	= '!@#$%^&*()';
	$znakiDoGeneracji = '';

	$male = filter_var($p['male'], FILTER_VALIDATE_BOOLEAN);
	$duze = filter_var($p['duze'], FILTER_VALIDATE_BOOLEAN);
	$cyfry = filter_var($p['cyfry'], FILTER_VALIDATE_BOOLEAN);
	$inne = filter_var($p['inne'], FILTER_VALIDATE_BOOLEAN);
	$doPliku = filter_var($p['doPliku'], FILTER_VALIDATE_BOOLEAN);

	if($male) $znakiDoGeneracji .= $znaki['male'];
	if($duze) $znakiDoGeneracji .= $znaki['duze'];
	if($cyfry) $znakiDoGeneracji .= $znaki['cyfry'];
	if($inne) $znakiDoGeneracji .= $znaki['inne'];

	$znakiDoGeneracji = str_shuffle($znakiDoGeneracji);
	$znakiDoGeneracji_dl = strlen($znakiDoGeneracji);

	for($i = 0; $i < $p['ileHasel']; $i++){
		$hasloTmp = '';
		for($j = 0; $j < $p['ileZnakow']; $j++){
			$hasloTmp .= @ $znakiDoGeneracji[rand(0, $znakiDoGeneracji_dl-1)];
		}//ileZnakow
		echo '<p>'.$hasloTmp.'</p>';
		if($doPliku) @ $haslaDoPliku[$i] = $hasloTmp;
	}//ileHasel

	if($doPliku){
		toTxt($haslaDoPliku);
		toJson($haslaDoPliku);
		toXml($haslaDoPliku);
	}//doPliku

}

function toTxt($haslaDoPliku){
		$fileLocation = 'hasla.txt';
		if(is_writable($fileLocation) && $file = fopen($fileLocation, 'a')){
			if(flock($file, 2)){
				$haslaData = '======== '.date('Y.m.d H:i:s')." ========\n";
				foreach ($haslaDoPliku as $haslo) {
					$haslaData .= $haslo."\n";
				}
				if(!fwrite($file, $haslaData)) echo 'Błąd w zapisaniu danych';
				flock($file, 3);
			}else echo 'plik zablokowany'; //flocks
			fclose($file);
		}else echo 'Błąd w otworzeniu pliku';//iswritable
}

function toJson($haslaDoPliku){
	$fileLocation = 'hasla.json';
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
}

function toXml($haslaDoPliku){

}

?>