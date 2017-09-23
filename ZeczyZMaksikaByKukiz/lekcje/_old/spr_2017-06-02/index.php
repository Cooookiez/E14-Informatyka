<?php
require_once('../scripts.php');
?>
<!DOCTYPE html>
<html lang="pl">
<head>
	<title>spr_2017-06-02</title>
	<meta charset="UTF-8">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
	<script>
		$(function(){
			$('#show').click(function(){
				$.post('scripts.php',{
					op: 'show'
				}).done(function(d){
					$('#pokaz').html(d);
				}).fail(function(){
				});
			});
			$('#form').submit(function(){
				var numC = $('[name=numC]').val();
				var km = $('[name=km]').val();
				var time = $('[name=time]').val();
				var date1 = $('[name=date1]').val();
				var date2 = $('[name=date2]').val();
				var numE = $('[name=numE]').val();
				$.post('scripts.php',{
					op: 'send',
					numC: numC,
					km: km,
					time: time,
					date1: date1,
					date2: date2,
					numE: numE
				}).done(function(d){
					if(d == 1 || d == '1'){
						$('#konsola').text("Wysłano").css('color', 'green');
					}else{
						$('#konsola').html(d).css('color', 'red');
					}
				}).fail(function(){
					$('#konsola').text('Błąd w wysłaniu danych postem').css('color', 'red');
				});
				return false;
			});
		})//jq END
	</script>
	<style>
		#box{
		}
		#box > header{
			width: 700px;
			margin: 0 auto;
			font-size: 2em;
			box-sizing: border-box;
			text-align: center;
			border-bottom: 3px solid black;
			padding: 10px;
		}
		#box > article{
			width: 600px;
			margin: 0 auto;
			background-color: lightblue;
		}
		#form{
			margin-top: 15px;
			padding: 5px;
		}
		#form > p{
			width: 100%;
		}
		#form > p > span{
			display: inline-block;
			width: 230px;
			box-sizing: border-box;
			padding-left: 10px;
		}
		#konsola{
			color: red;
			font-weight: 900;
		}
		table{
			width: 100%;
		}
	</style>
</head>
<body>
<div id="box">
	<header>System rozloczeń autowypożyczeń</header>
	<article>
		<form id="form">
			<p>
				<span>Numer auta</span>
				<label> <input type="text" name="numC"></label>
			</p>
			<p>
				<span>Ilość Przejechanych kilometrów</span>
				<label> <input type="number" name="km"></label>
			</p>
			<p>
				<span>Czas wyporzyczenia</span>
				<label> <input type="time" name="time"></label>
			</p>
			<p>
				<span>Data wyporzyczenia</span>
				<label> <input type="date" name="date1"></label>
				<label> <input type="time" name="date2"></label>
			</p>
			<p>
				<span>Numer pracownika</span>
				<label> <input type="text" name="numE"></label>
			</p>
			<p>
				<span id="konsola"></span>
			</p>
			<p>
				<input type="submit" value="Zapisz">
				<input type="reset" value="Reset">
				<input type="button" id="show" name="show" value="Pokaż">
			</p>
		</form>
	</article>
	<article id="pokaz">
		
	</article>
</div>
</body>
</html>