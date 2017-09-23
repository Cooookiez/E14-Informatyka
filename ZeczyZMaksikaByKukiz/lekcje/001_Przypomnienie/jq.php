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
		var lp = 0;
		$(function(){
			$('#imie_wiek').submit(function(){
				lp++;
				var imie = $(this).find('#imie').val();
				imie = imie.toLowerCase();
				imie = imie.charAt(0).toUpperCase()+imie.slice(1);

				var plec = imie.charAt(imie.length-1);
				var color = plec == 'a' ? 'darkred':'darkblue';

				var wiek = $(this).find('#wiek').val();
				if(wiek != parseInt(wiek)) wiek = 0;

				var isEla = false;
				if(imie == "Ela" && wiek == 19) isEla = true;
				isEla = isEla?'Tak':'Nie';

				$('#dane_tabela tbody').append('<tr style="color:'+color+'"><td>'+lp+'</td><td>'+imie+'</td><td>'+wiek+'</td><td>'+isEla+'</td></tr>');

				return false;
			});
			$('#imie_wiek #reset').click(function(){
				$('#dane_tabela tbody').html('');
			});
		});//jq
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
			<input type="submit" value="wyślij">
			<input type="reset" id="reset">
			<span id="comunicat"></span>
		</div>
	</form>
	<table id="dane_tabela" border="1">
		<thead>
			<tr>
				<th>lp.</th>
				<th>Imie</th>
				<th>Wiek</th>
				<th>czy Ela, lat 19?</th>
			</tr>
		</thead>
		<tbody></tbody>
	</table>
</body>
</html>