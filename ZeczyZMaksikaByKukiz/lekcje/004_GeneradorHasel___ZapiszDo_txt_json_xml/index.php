<!DOCTYPE html>
<html lang="pl">
<head>
	<meta charset="utf-8">
	<title>Witam</title>
	<style type="text/css">
		body{
			background-color: black;
			color: lightgrey;
		}
		form#hasla{
			width: 300px;
			margin: 50px auto;
			background-color: black;
			border: 1px solid darkgrey;
			padding-bottom: 2px;
		}
		h1{
			text-align: center;
		}
		label{
			display: inline-block;
			width: 100px;
		}
		input[type=number]{
			width: 100px;
		}
		a{
			color: white;
		}
	</style>
	<script src="../../../scripts/jq.js"></script>
	<script type="text/javascript">
		$(function(){
			$('form#hasla').submit(function(){
				//jakie rodzjae znaków
				var male	= $('#male:checked').val();
				male		= male ? true:false;

				var duze	= $('#duze:checked').val();
				duze		= duze ? true:false;

				var cyfry	= $('#cyfry:checked').val();
				cyfry		= cyfry ? true:false;

				var inne	= $('#inne:checked').val();
				inne		= inne ? true:false;

				//ile znakow ile hasle
				ileZnakow	= $('#ileZnakow').val();
				ileHasel	= $('#ileHasel').val();

				//cz zapisac do pliku
				var doPliku	= $('#doPliku:checked').val();
				doPliku		= doPliku ? true:false;

				$.post('scripts.php',{
					op:			'hasla',
					male:		male,
					duze:		duze,
					cyfry:		cyfry,
					inne:		inne,
					ileZnakow:	ileZnakow,
					ileHasel:	ileHasel,
					doPliku:	doPliku
				}).fail(function(){
					$('#wygHasla').text('Błąd w POST');
				}).done(function(hasla){
					$('#wygHasla').html(hasla);
				});


				return false;
			})
			$('#czysc').click(function(){
				$('#wygHasla').text('')
			});
		});//jQ
	</script>
</head>
<body>
	<form id="hasla">
		<h1>Generator Haseł</h1>
		<fieldset>
			<legend>Znaki</legend>
			<div>
				<input type="checkbox" name="znaki" id="male" checked>
				<label for="male">Małe</label>
			</div>
			<div>
				<input type="checkbox" name="znaki" id="duze" checked>
				<label for="duze">Duże</label>
			</div>
			<div>
				<input type="checkbox" name="znaki" id="cyfry" checked>
				<label for="cyfry">Cyfry</label>
			</div>
			<div>
				<input type="checkbox" name="znaki" id="inne">
				<label for="inne">Inne</label>
			</div>
		</fieldset>
		<fieldset>
			<legend>Ilość</legend>
			<div>
				<label for="ileZnakow">Ile znaków</label>
				<input type="number" name="ileZnakow" id="ileZnakow" placeholder="5 - 28" min="5" max="28" required>
			</div>
			<div>
				<label for="ileHasel">Ile haseł</label>
				<input type="number" name="ileHasel" id="ileHasel" placeholder="1 - 100" min="1" max="100" required>
			</div>
			<div>
				<input type="checkbox" name="doPliku" id="doPliku">
				<label for="doPliku">Zapisz to pliku</label>
			</div>
			<div>
				<input type="submit" name="generuj" id="generuj" value="Generuj">
			</div>
			<div><a href="hasla.txt" target="_blank">hasla.txt</a></div>
			<div><a href="hasla.json" target="_blank">hasla.json</a></div>
			<div><a href="hasla.xml" target="_blank">hasla.xml</a></div>
		</fieldset>
		<fieldset>
			<legend>Hasła</legend>
			<div id="wygHasla">
				
			</div>
			<div>
				<input type="reset" name="czysc" id="czysc" value="Czyść">
			</div>
		</fieldset>
	</form>
</body>
</html>