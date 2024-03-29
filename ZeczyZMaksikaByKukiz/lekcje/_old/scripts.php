<?php
/*----------------------------------------------------------------------------------
	require_once();
	1. laczenie z baza danych
	2. licznik
	3. z mysql to tabeli
	4. array to html table
	5. filtrowanie kodu
----------------------------------------------------------------------------------*/

/*
	1. laczenie z baza danych
	$connect = polacz_db([baza])
*/
function polacz_db($db_name = 'd14_kukiz_krzysztof'){
	include('pasy.php');
	$wynik = @new MySqli('localhost', $db_user, $db_password, $db_name);
	if(mysqli_connect_errno()){
		echo 'Brak polaczenia z baza, prosze wrucic puźniej<br>'.mysqli_connect_error();
		exit();
	}else{//polaczono sie

		$wynik -> set_charset("utf8");
		$wynik -> query ('SET CHARACTER_SET utf8_polish_ci');	
		$wynik -> query ('SET NAMES "utf8" [COLLATE "utf8_polish_ci"]');
		return $wynik;
	}
}

/*
	2.licznik
	$ile = licznik();
*/
function licznik(){
	$connect = polacz_db();
	$adres = $_SERVER['HTTP_HOST'].$_SERVER['SCRIPT_NAME'];

	$sql = "SELECT ile FROM liczniki WHERE adres = '$adres'";
	if($result = $connect->query($sql)){
		$rows = (int)$result->num_rows;
		if($rows){//ten adres juz jest
			$row = $result->fetch_assoc();
			$ile = $row['ile'];
		}else{//nie ma tego adresu
			$sql = "INSERT INTO `d14_kukiz_krzysztof`.`liczniki` (`licznik_id`, `adres`, `ile`) VALUES (NULL, '$adres', '0');";
			$connect->query($sql);
			$ile = 0;
		}
		$ile++;
	}
	//zapis licznika
	$sql = "UPDATE liczniki SET ile = $ile WHERE adres = '$adres'";
	$result = $connect->query($sql);
	return $ile;
}


/*
	3. z mysql to tabeli
	$arr = sql2array($sql [, &mod]);
*/
function sql2array($sql, $mod = 'byRow'){
	switch($mod){
		case 'byRow':
			if($connect = polacz_db()){
				if($result = $connect->query($sql)){
					$rows = $result->num_rows;
					for($i = 0; $i < $rows; $i++){
						$row = $result->fetch_assoc();
						foreach ($row as $key => $value) {
							$array[$i][$key] = $value;
						}
					}
				}else die('błąd w zapytaniu');
			}else die('prak połaczenia z sql');
			break;
			
		case 'byName':
			$arr = sql2array($sql);
			$ileRow = sizeof($arr);
			for($i = 0; $i < $ileRow; $i++){
				foreach($arr[$i] as $n => $v){
					$array[$n][$i] = $v;
				}
			}
			break;
			
		default:
			return false;
			break;
	}
	return @ $array;
}

/*
	4. array to html table
	$HTMLtable = array2HTMLtable(array [, class [, id [, border]]])
*/
function array2HTMLtable($array, $class='', $id='', $border='0'){
	$html = '';
	$html .= '<table class="'.$class.'", id="'.$id.'", border="'.$border.'">';
		//thead
		$html .= '<thead>';
			$html .= '<tr>';
			foreach ($array[0] as $key => $value) {
				$html .= '<th>'.$key.'</th>';
			}
			$html .= '</tr>';
		$html .= '</thead>';
		//thead END
		//tbody
		$html .= '<tbody>';
		foreach($array as $values) {
			$html .= '<tr>';
				foreach ($values as $key => $value) {
					$html .= '<td>'.$value.'</td>';
				}
			$html .= '</tr>';
		}
		$html .= '</tbody>';
		//tbody END
	$html .= '</table>';
	return $html;
}

/*
	5. filtrowanie kodu
	$output = filtruj(string);
*/
function filtruj($string){
	$connect = polacz_db();
	if(get_magic_quotes_gpc())
		$string = stripslashes($string);
	$string = $connect->real_escape_string(htmlspecialchars(trim($string)));
	return $string;
}
?>