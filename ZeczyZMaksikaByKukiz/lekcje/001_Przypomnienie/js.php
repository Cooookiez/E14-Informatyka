<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	<style type="text/css">
	body,
	input{
		font-size: 48px;
	}
	label{
		display: inline-block;
		width: 150px;
	}
	</style>
	<script src="../../../scripts/jq.js"></script>
	<script type="text/javascript">
		function wyswietl(){

			var imie = document.getElementById('imie').value;
			var comunicat = '';
			imie = imie.toLowerCase();
			imie = imie.charAt(0).toUpperCase()+imie.slice(1);
			var plec = imie.charAt(imie.length-1);
			var color = plec == 'a' ? 'darkred':'darkblue';

			var wiek = document.getElementById('wiek').value;
			if(wiek != parseInt(wiek)) wiek = 0;

			var isEla = false;
			if(imie == "Ela" && wiek == 19) isEla = true;


			comunicat += '<br>imie: '+imie;
			comunicat += '<br>wiek: '+wiek;
			comunicat += '<br>is Ela, 19? '+isEla;
			document.getElementById("comunicat").innerHTML = comunicat;
			document.getElementById("comunicat").style.color = color;
		}
	</script>
</head>
<body>
<form id="imie_wiek">
	<div>
		<label for="imie">Imie</label>
		<input id="imie" type="text" value="kRzYsZtOf" placeholder="Wpisz swoje imie" autofocus></input>
	</div>
	<div>
		<label for="wiek">Wiek</label>
		<input id="wiek" type="number" value="19" placeholder="Wpisz swój wiek" min="0"></input>
	</div>
	<div>
		<input type="button" value="wyślij" onclick="wyswietl()">
		<span id="comunicat"></span>
	</div>
</form>
</body>
</html>