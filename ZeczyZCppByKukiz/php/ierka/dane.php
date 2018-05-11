<?php
	if( isset($_POST['imie'])		&&
		isset($_POST['nazwisko'])	&&
		isset($_POST['plec'])		){

		$imie = $_POST['imie'];
		$nazwisko = $_POST['nazwisko'];
		$plec = $_POST['plec'] == 'm'?'mężczyzna':'kobieta';
	}else{
		//header('Location: index.php');
	}

	echo '<pre>';
	print_r($_POST);
	echo '<pre>';

?>