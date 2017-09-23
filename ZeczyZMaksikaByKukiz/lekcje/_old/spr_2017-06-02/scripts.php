<?php
require_once('../scripts.php');
if(isset($_POST['op'])){
	switch ($_POST['op']) {
		case 'send':
			send($_POST);
			break;
		case 'show':
			show();
			break;
		
		default:
			# code...
			break;
	}
}

function send($p){
	$numC = $p['numC'];
	$km = $p['km'];
	$time = $p['time'];
	$date1 = $p['date1'];
	$date2 = $p['date2'];
	$numE = $p['numE'];
	$sql = "INSERT INTO spr_2017_06_02 VALUES(null, '$numC', '$km', '$time', '$date1', '$date2', '$numE')";
	$connect = polacz_db();
	if($connect->query($sql)) echo 1;
	else echo 'Blad w wyslaniu';
}
function show(){
	$arr = sql2array("SELECT numC 'numer auta', km 'ilosc km', time 'naile', date1 kiedyD, date2 kiedyH, numE 'numer pracownika' FROM spr_2017_06_02");
	$HTMLtable = array2HTMLtable($arr , '', '', 1);
	echo $HTMLtable;
}
?>