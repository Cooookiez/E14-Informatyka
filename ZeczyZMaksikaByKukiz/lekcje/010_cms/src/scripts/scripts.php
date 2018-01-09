<?php

@ session_start();

require_once("../../../../../scripts/scripts.php");

if(isset($_POST['op']) && !empty($_POST['op'])) $op = $_POST['op'];
else if (isset($_GET['op']) && !empty($_GET['op'])) $op = $_GET['op'];
else $op = null;

switch($op){
	case 'login':		logIn($_POST['username'], $_POST['password']); break;
	case 'logOut':		logOut(); break;
	case 'imgChange':	imgChange($_POST, $_GET, $_FILES); break;
	default: break;
}


function logIn($u, $p)
{
	if($connect = connect2db()){
		$sql = "SELECT usr_id, usr_password, usr_typ FROM cms_user WHERE usr_name = '$u';";
		if($result = $connect->query($sql)){
			if($result->num_rows > 0){
				$res = $result->fetch_assoc();
				if($p == $res['usr_password']){
					$_SESSION['user_logIn'] = true;
					$_SESSION['user_id'] = $res['usr_id'];
					$_SESSION['user_typ'] = $res['usr_typ'];
					$_SESSION['user_name'] = $u;
					echo 1;
				}else echo "Błędny user lub Hasło";
			}else echo "Błędny User lub hasło";
		}else echo "Błędne zapytanie";
	}else echo "Brak połączenia z bazą";
}

function logOut()
{
	$_SESSION['user_logIn'] = false;
	$_SESSION['user_id'] = null;
	$_SESSION['user_typ'] = null;
	$_SESSION['user_name'] = null;
}

function imgChange($p, $g, $f)
{
	$file_type = $f['img']['type'];
	$file_name = $f['img']['name'];
	$file_tmpName = $f['img']['tmp_name'];
	
	$toNieKoniec = true;
	$file_type = $file_name;
	do
	{	
		if($where = strpos($file_type, '.'))
		{
			$file_type = substr($file_type, ($where + 1));
		}
		else
		{
			$toNieKoniec = false;
		}
		
	}
	while($toNieKoniec);
	//usuniecie wsyzstkiego z folderu logo
	@ array_map('unlink', glob("../img/logo/*"));
	//
	$newPach = '/~d14.kukiz.krzysztof/bin/contnet/lekcje/010_cms/src/img/logo/';
	$jsonFile = 'config.json';
	$alt = '';
	switch($file_type){
		case 'png':
		case 'gif':
		case 'jpg':
		case 'jpeg':
			//kopjowanie pliku do folderu z zdjeciem
			copy($file_tmpName, "../img/logo/logo.$file_type");
			$newPach .= 'logo.'.$file_type;
			$alt = 'logo';
			break;
			
		default:
			$newPach .= 'logo';
			$alt = 'Błąd';
			break;
	}
	
	//pobiera dotychczasowego jsona
	$json = file_get_contents($jsonFile);
	$json = json_decode($json, true);
	if(is_writable($jsonFile) && $file = fopen($jsonFile, "w"))
	{
		if(flock($file, 2)){
			//podmienia zmienna
			$json['img-logo']['src'] = $newPach;
			$json['img-logo']['alt'] = $alt;
			//zapisuje nowego jsona
			$json = json_encode($json);
			fwrite($file, $json);
			flock($file, 3);
		}
		fclose($file);
	}
	header('Location: ../../');
}



?>