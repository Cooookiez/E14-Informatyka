<?php
@ session_start();
if(
	isset($_POST['op']) &&
	!empty($_POST['op'])
){
	$typ = @ (int)$_POST['typ'];
	$par = 		@ $_POST['par'];
	$haslo = 	@ $_POST['haslo'];
	switch($_POST['op']){
		case "pok_inp":
			switch($typ){
				case 0: by_file($par); break;
				case 1: by_sql($par); break;
			}
		break;
		case "loguj":
			switch($typ){
				case 0: loguj_file($par, $haslo); break;
				case 1: loguj_sql($par, $haslo); break;
			}
		break;
		case "logOut_file":
			$_SESSION['login_file'] = false;
			echo "<h1>Wylogowano z m2</h1>";
		break;
		case "logOut_sql":
			$_SESSION['login_sql'] = false;
			echo "<h1>Wylogowano z m3</h1>";
		break;
	}

}else die();

function by_file($par){
	if(!isset($_SESSION['login_file'])) $_SESSION['login_file'] = false;
	if(!$_SESSION['login_file']){
		pokaz_do_zalogowania(0, $par);
	}else{
		echo "Zalogowano $par";
	}
}

function by_sql($par){
	if(!isset($_SESSION['login_sql'])) $_SESSION['login_sql'] = false;
	if(!$_SESSION['login_sql']){
		pokaz_do_zalogowania(1, $par);
	}else{
		echo "Zalogowano $par";
	}

}

function pokaz_do_zalogowania($typ, $par){
?>
<script type="text/javascript">
	$('#zaloguj-do-php_cl').click(function(){
		$.post('scripts.php',{
			op: 'loguj',
			typ: '<?php $typ ?>',
			par: '<?php $par ?>',
			haslo: $('#zaloguj-do-php').val()
		}).done(function(data){
			$('main').html(data);
		});
	});
</script>
<input id="zaloguj-do-php" type="password" name="haslo" placeholder="haslo"><input id="zaloguj-do-php_cl" type="button" value="Zaloguj się">
<?php
}

function loguj_file($par, $haslo = ""){
	$file = "hasla.json";
	if(is_readable($file)){
		$json = file_get_contents($file);
		$json = json_decode($json, true);
		//var_dump($json['hasla']);
		foreach ($json['hasla'] as $hasloJson) {
			if($haslo == $hasloJson){
				$_SESSION['login_file'] = true;
				break;
			}
		}

		if($_SESSION['login_file'] == true){
			by_file($par);
		}else{
			pokaz_do_zalogowania(0, $par);
		}
	}
}

function loguj_sql($typ, $haslo){
	
}
?>