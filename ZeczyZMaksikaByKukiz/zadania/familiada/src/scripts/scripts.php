<?php
if(isset($_POST['op']) && !empty($_POST['op'])) $op = $_POST['op'];
else if(isset($_GET['op']) && !empty($_GET['op'])) $op = $_GET['op'];
else die('Brak wartości op');

switch($op){
	case 'pokPytanie': pokPytanie($_POST); break;
	case 'sprawcOdp': sprawcOdp($_POST); break;
}


function pokPytanie($p){
	@ require('../../../../../scripts/acces.php');
	$return['error']['exist'] = false;
	
	//wybranie sql do pokazania wszystkiego lub zwrucenie błedu jak juz nic nie zostało
	if(isset($p['uzyte'])){
		$idIle = count($p['uzyte']);
		$uzyte = '';
		for($i = 0; $i < $idIle; $i++){
			if($i) $uzyte.=', ';
			$uzyte.=$p['uzyte'][$i];
		}
		$sql = "SELECT pyt_id, pyt_tresc FROM fml_pytania WHERE pyt_id not in ($uzyte)";
	}else{
		$sql = "SELECT pyt_id, pyt_tresc FROM fml_pytania";
	}
	
	if($connect = @ mysqli_connect($db_host, $db_user, $db_password, 'd14_kukiz_krzysztof')){
		$connect -> set_charset("utf8");
		
		//zwrucenie liczny pozostałych pytań i dodanie do sql wylosowango limitu
		if($result = @ mysqli_query($connect, $sql)){
			$num_rows = $result->num_rows;
			if($num_rows>0){
				$rand = rand(1, $num_rows) - 1;
				$sql .= " LIMIT $rand,1";
			}else{ $return['error']=['exist'=>true,'kod'=>3,'msg'=>'Prak pytań']; die(json_encode($return)); }
		}else{ $return['error']=['exist'=>true,'kod'=>2,'msg'=>'Błędne zapytanie']; die(json_encode($return)); }
		
		//zwrucenie tylo wylosowanego sqla
		if($result = @ mysqli_query($connect, $sql)){
			if($r = @ mysqli_fetch_assoc($result)){
				$return['pyt_id'] = $pyt_id = $r['pyt_id'];
				$return['pyt_tresc'] = $r['pyt_tresc'];
			}else{ $return['error']=['exist'=>true,'kod'=>4,'msg'=>'Brak zwruconej wartość']; die(json_encode($return)); }
		}else{ $return['error']=['exist'=>true,'kod'=>2,'msg'=>'Błędne zapytanie 2']; die(json_encode($return)); }
		
		//wybranie odpowiedzi
		$sql = "SELECT odp_nth, odp_pkt FROM fml_odpowiedzi WHERE pyt_id = $pyt_id ORDER BY odp_nth ASC";
		if($result = @ mysqli_query($connect, $sql)){
			$return['pkt'] = [];
			while($r = @ mysqli_fetch_assoc($result)){
				//$return['pkt'][$r['odp_nth']] = $r['odp_pkt'];
				array_push($return['pkt'], $r['odp_pkt']);
			}
		}else{ $return['error']=['exist'=>true,'kod'=>2,'msg'=>'Błędne zapytanie 3']; die(json_encode($return)); }
		
		mysqli_close($connect);
	}else{ $return['error']=['exist'=>true,'kod'=>1,'msg'=>'Brak połączenia z bazą']; die(json_encode($return)); }
	die(json_encode($return));
}

function sprawcOdp($p){
	@ require('../../../../../scripts/acces.php');
	$return['error'] = false;
	$pyt_id = (int)$p['pytId'];
	$odp_tresc = $p['val'];
	
	if($connect = @ mysqli_connect($db_host, $db_user, $db_password, 'd14_kukiz_krzysztof')){
		$connect -> set_charset("utf8");
		
		//wybranie sql do pokazania wszystkiego lub zwrucenie błedu jak juz nic nie zostało
		if(isset($p['uzyte'])){
			$idIle = count($p['uzyte']);
			$uzyte = '';
			for($i = 0; $i < $idIle; $i++){
				if($i) $uzyte.=', ';
				$uzyte.=$p['uzyte'][$i];
			}
			$sql = "SELECT odp_id, CONCAT(UPPER(LEFT(odp_tresc, 1)), LOWER(SUBSTRING(odp_tresc, 2))) odp_tresc, odp_pkt, odp_nth FROM fml_odpowiedzi where pyt_id = $pyt_id AND LOWER(odp_tresc) = LOWER('$odp_tresc') AND odp_id not in ($uzyte)";
		}else{
			$sql = "SELECT odp_id, CONCAT(UPPER(LEFT(odp_tresc, 1)), LOWER(SUBSTRING(odp_tresc, 2))) odp_tresc, odp_pkt, odp_nth FROM fml_odpowiedzi where pyt_id = $pyt_id AND LOWER(odp_tresc) = LOWER('$odp_tresc')";
		}
		$return['sql'] = $sql;
		
		if($result = @ mysqli_query($connect, $sql)){
			$return['num_rows'] = $result->num_rows;
			$r = mysqli_fetch_assoc($result);
			$return['odp_tresc'] = $r['odp_tresc'];
			$return['odp_pkt'] = (int)$r['odp_pkt'];
			$return['odp_nth'] = (int)$r['odp_nth'];
			$return['odp_id'] = (int)$r['odp_id'];
		}else{$return['error'] = true; $return['errorMsg'] = 'Błędne zapytanie';}
	}else{$return['error'] = true; $return['errorMsg'] = 'Brak połączenia z bazą';}
	
	//print_r($return);
	die(json_encode($return));
}

?>