<?php
if( isset($_POST['op']) && !empty($_POST['op'])){
	switch ($_POST['op']) {
		case 'dopisz':
			$file				= 'ocena.json';
			$nr_zamowienia_duga	= $_POST['nr_zamowinia'];
			$usluga				= $_POST['usluga'];
			$realizacja			= $_POST['realizacja'];
			$zgodnosc			= $_POST['zgodnosc'];
			$cena				= $_POST['cena'];
			$y					= substr($nr_zamowienia_duga, 0, 4);
			$m					= substr($nr_zamowienia_duga, 5, 2);
			$d					= substr($nr_zamowienia_duga, 8, 2);
			$data				= "$y-$m-$d";
			$nr_zamowinia		= substr($nr_zamowienia_duga, 11, 4);

			if(is_readable($file) && is_writable($file)){
				$json = file_get_contents($file);
				$json = json_decode($json, true);

				//czy jyst jest ten produkt
				if(!isset($json['produkt_id']["#$nr_zamowinia"][$data]) ){
					$json['produkt_id']["#$nr_zamowinia"][$data]['usluga']		= $usluga;
					$json['produkt_id']["#$nr_zamowinia"][$data]['realizacja']	= $realizacja;
					$json['produkt_id']["#$nr_zamowinia"][$data]['zgodnosc']	= $zgodnosc;
					$json['produkt_id']["#$nr_zamowinia"][$data]['cena']		= $cena;
					$json = json_encode($json);
					if($handle = fopen($file, 'w')){
						if(flock($handle, 2)){
							fwrite($handle, $json);
							flock($handle, 3);
						}else die("Brak dostępu do pliku.");
						fclose($handle);
					}else die("Brak dostępu do pliku.");
				}else die('Ten numer zamówienia już istnieje');
			}else die("Brak dostępu do pliku.");
			die("Zapisano!");
			break;

		case 'wyniki':
			break;

		default: break;
	}
}else{
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	<link rel="stylesheet" type="text/css" href="screen.css">
	<script src="../../../scripts/jq.js"></script>
	<script src="../../../scripts/jquery.cookie.js"></script>
	<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
	<script src="scripts.js"></script>
</head>
<body>
	<article id="wynik" draggable="true">
		<section id="buttons2"><div id="drag"></div><div id="close">x</div></section>
		<section id="chart">d</section>
	</article>
	<form id="uslugi">
		<header>Ankieta</header>
		<fieldset>
			<legend>Oceń naszą usługę</legend>
			<article id="nr-zamowienia">
				<label for="nr-zam">Numer zamówienia</label>
				<input type="text" name="nr-zam" id="nr-zam" pattern="[0-9]{4}-[0-9]{2}-[0-9]{2}#[0-9]{4}" placeholder="yyyy-mm-dd#0000" value="2017-10-05#0001">
			</article>
			<article id="ocena">
				<section>
					<header>Jakość usługi</header>
					<input type="radio" name="usluga" id="usluga-0" value="0" required>
					<label for="usluga-0">0</label>
					<input type="radio" name="usluga" id="usluga-5" value="5" required checked>
					<label for="usluga-5">5</label>
					<input type="radio" name="usluga" id="usluga-10" value="10" required>
					<label for="usluga-10">10</label>
				</section>
				<section>
					<header>Szybkość realizacji</header>
					<input type="radio" name="realizacja" id="realizacja-0" value="0" required>
					<label for="realizacja-0">0</label>
					<input type="radio" name="realizacja" id="realizacja-5" value="5" required checked>
					<label for="realizacja-5">5</label>
					<input type="radio" name="realizacja" id="realizacja-10" value="10" required>
					<label for="realizacja-10">10</label>
				</section>
				<section>
					<header>Zgodność zamówienia</header>
					<input type="radio" name="zgodnosc" id="zgodnosc-0" value="0" required>
					<label for="zgodnosc-0">0</label>
					<input type="radio" name="zgodnosc" id="zgodnosc-5" value="5" required checked>
					<label for="zgodnosc-5">5</label>
					<input type="radio" name="zgodnosc" id="zgodnosc-10" value="10" required>
					<label for="zgodnosc-10">10</label>
				</section>
				<section>
					<header>Cena zamówienia</header>
					<input type="radio" name="cena" id="cena-0" value="0" required >
					<label for="cena-0">0</label>
					<input type="radio" name="cena" id="cena-5" value="5" required checked>
					<label for="cena-5">5</label>
					<input type="radio" name="cena" id="cena-10" value="10" required>
					<label for="cena-10">10</label>
				</section>
			</article>
			<article id="legenda">
				0 - słaba<br>
				5 - średnia<br>
				10 - Bardzo dobra
			</article>
			<article id="buttons">
				<input type="button" value="Wynik">
				<input type="submit">
			</article>
		</fieldset>
		<footer id="communicate"></footer>
	</form>
	<div id="cookies" style="display: none">Ta strona Użwya plików cookies, wchodząc na tą strone <span>zgadzasz się</span> na ich używanie.</div>
</body>
</html>
<?php } ?>