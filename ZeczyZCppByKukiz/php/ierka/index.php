<?php

$losMin = 0;
$losMax = 5;
/* liczba z kolei*/
	if(isset($_COOKIE['liczba_z_kolei'])){
		$liczba_z_kolei = (int)$_COOKIE['liczba_z_kolei'];
	}else{
		$liczba_z_kolei = 1;
	}

/*wylosowana liczba*/
	if(isset($_COOKIE['los'])){
		$los = (int)$_COOKIE['los'];
	}else{
		$los = rand($losMin, $losMax);
		setcookie('los', $los);
	}

/*czy jest liczba podana rzez usera*/
	if(isset($_POST['liczba'])){
		$liczba = (int)$_POST['liczba'];
	}else{
		if(isset($_COOKIE['liczba'])){
			$liczba = $_COOKIE['liczba'];
		}else{
			$liczba = '';
		}
	}
/*los prev*/
	if(isset($_COOKIE['liczba_pre'])){
		$liczba_pre = $_COOKIE['liczba_pre'];
	}else{
		$liczba_pre = 'd';
	}

	if($liczba == $los){//wygrana
		echo '<h1>Wygrales</h1>';
		echo '<h3>liczba to: '.$los.'</h3';
		$los = rand($losMin, $losMax);
		setcookie('los', $los);
		$alert = 'Koniec :)';

		setcookie('liczba_z_kolei', 1);
	}else if($liczba > $los){
		$alert = 'Liczba jest za duza';

		setcookie('liczba_z_kolei', $liczba_z_kolei+1);
	}else if($liczba < $los){
		$alert = 'Liczba jest za mala';

		setcookie('liczba_z_kolei', $liczba_z_kolei+1);
	}else{

		setcookie('liczba_z_kolei', $liczba_z_kolei+1);
	}


?>

<form action="index.php" method="POST">
	przedział od <?php echo $losMin; ?> do <?php echo $losMax; ?><br>
	Podaj liczbe: <input type="number" name="liczba" autofocus><br>
	<input type="submit"> (próba nr <?php echo $liczba_z_kolei; ?>, <?php echo $alert ?>)
</form>