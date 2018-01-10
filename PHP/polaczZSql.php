<?php

$db_host    = "localhost";
$db_user    = "root";				//w xampp'ie podstawowym userem jest "root"
$db_pass    = "";					//w xampp'ie podstawowym hasłem jest puste pole
$db_name    = "d14_kukiz_krzysztof";//twoja nazwa bazy danych

if( $connect = mysqli_connect($db_host, $db_user, $db_pass, $db_name) ){
	//połączono z bazą
	$sql = "SELECT * FROM `filrezyser`";
	if( $result = mysqli_query($connect, $sql) ){
		
		echo 'ilość wierszy: '.$result->num_rows;//ilość zwruconych wierszy
		//(żeby sprawdzić wszystkie parametry: print_r($result);)
		
		//zwrucone dane
		while( $row = mysqli_fetch_assoc($result) ){
			print_r($row); // row jest tablicą associacyjną zawirające dane wiersza
		}
		
	}else{
		//błędne zapytanie
	}
	
	mysqli_close($connect);//pamiętaj by zamknąć połączenie na koniec
}else{
	//brak połączenia z bazą danych
}

?>