<?php
if($connect = mysqli_connect('localhost', 'root', '', 'komis')){

	//skrypt 1
	$skrypt1 = '';
	$sql = "SELECT id, marka, model FROM `samochody`";
	if($result = mysqli_query($connect, $sql)){
		while($row = mysqli_fetch_row($result)){
			$id = $row[0];
			$marka = $row[1];
			$model = $row[2];
			$skrypt1 .= "<li>$id $marka $model</li>";
		}
	}

	//skrypt 2
	$skrypt2 = '';
	$sql = "SELECT Samochody_id, Klient FROM `zamowienia`";
	if($result = mysqli_query($connect, $sql)){
		while($row = mysqli_fetch_row($result)){
			$id = $row[0];
			$os = $row[1];
			$skrypt2 .= "<li>$id $os</li>";
		}
	}

	//skrypt 3
	$skrypt3 = '';
	$sql = "SELECT * FROM `samochody` WHERE marka = 'fiat'";
	if($result = mysqli_query($connect, $sql)){
		while($row = mysqli_fetch_row($result)){
			$id = $row[0];
			$marka = $row[1];
			$model = $row[2];
			$rocznik = $row[3];
			$kolor = $row[4];
			$stan = $row[5];
			$skrypt3 .= "$id / $marka / $model / $rocznik / $kolor / $stan<br>";
		}
	}
	mysqli_close($connect);
}
?>
<!DOCTYPE html>
<html lang="pl">
<head>
	<meta charset="utf-8">
	<title>Komis Samochodowy</title>
	<link rel="stylesheet" type="text/css" href="auta.css">
</head>
<body>


	<header id="baner">
		<h1>SAMOCHODY</h1>
	</header>


	<article id="panelL">
		<h2>Wykaz samochodów</h2>
		<ul><?php echo $skrypt1; ?></ul>
		<h2>Zamówienia</h2>
		<ul><?php echo $skrypt2; ?></ul>
	</article>

	<article id="panelR">
		<h2>Pełne dane: Fiat</h2>
		<span><?php echo $skrypt3; ?></span>
	</article>


	<footer id="stopka">
		<table>
			<tr>
				<td><a href="kwerendy.txt">Kwerendy</a></td>
				<td>Autor: [MójNumerPESEL]</td>
				<td><img src="auto.png" alt="komis samochodowy"></td>
			</tr>
		</table>
	</footer>


</body>
</html>