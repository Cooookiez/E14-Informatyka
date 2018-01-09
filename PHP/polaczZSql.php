<pre>
<?php

$db_host    = "localhost";
$db_user    = "root";				//w xampp'ie podstawowym userem jest root
$db_pass    = "";					//w xampp'ie podstawowym hasłem jest puste pole
$db_name    = "d14_kukiz_krzysztof";//twoja nazwa bazy danych

if( $connect = mysqli_connect($db_host, $db_user, $db_pass, $db_name) ){
	echo "<h1>Połączono z bazą</h1>";
	
	
	echo '<h3 style="background-color: black; color: yellow">wysłanie zapytania</h3>';
	$sql = "SELECT * FROM `filrezyser`";
	if( $result = mysqli_query($connect, $sql) ){
		
		echo '<h4 style="background-color: black; color: yellow">Zawartość $result</h4>';
		print_r($result);
		echo 'ilość wierszy: '.$result->num_rows;//ilość zwruconych wierszy
		
		
		echo '<h4 style="background-color: black; color: yellow">da</h4>';
		while( $row = mysqli_fetch_assoc($result) ){
			print_r($row); // row jest ttablicą associacyjną zawirające dane wiersza
		}
		
	}else{
		echo "<h3 style='background-color: black; color: yellow'>Błędne zapytanie</h3>";
	}
	
	mysqli_close($connect);//pamiętaj by zamknąć połączenie na koniec!
	echo "<h1>rozłączono z bazą</h1>";
}else{
	echo "<h1 style='background-color: black; color: yellow'>NIE połączono z bazą</h1>";
}

?>
</pre>