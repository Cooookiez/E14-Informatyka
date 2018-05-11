<?php

?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>ksiega gosci</title>
	<style type="text/css" media="screen">
		body{
			background-color: black;
			color: black;
		}
		#wpisSie{
			margin: 0 auto;
			margin-top: 50px;
			background-color: white;
			box-shadow: inset 0 0 10px black;
			height: 300px;
			width: 300px;
			border-radius: 50%;
		}
		form{
			position: relative;
			left: 20px;
			margin: 0 auto;
			margin-top: 50px;
			width: 210px;
		}
		#head{
			position: relative;
			top: 30px;
			padding-top: 10px;
			padding-bottom: 10px;
			background-color: red;
			text-align: center;
			box-shadow: 0 0 10px black;
			background-color: black;
			color: white;
			font-weight: 900;
		}
	</style>
	<script src="http://code.jquery.com/jquery-2.1.1.min.js"></script>
	<script>
		$(function(){
			$('form').submit(function(){
				var nick =  $("input[name=nick]").val();
				var email = $("input[name=email]").val();
				var plec = $("input[name=plec]:checked").val();
				var area = $("textarea[name=trescWpisu]").val();
				var ok = true;
				var komunikat = '';
				if(area.length > 100){
					ok = fales;
					komunikat += "Za długa tresś, ";
				}
				if(plec != 'm' || plec!= 'k'){
					ok = fales;
					komunikat += "tu nie gender";
				}
				var eMialLike = /^$/
				if(email.length > 50){
					ok = fales;
					komunikat += "Za długi email, ";
				}
				if(nick.length > 20){
					ok = fales;
					komunikat += "Za długi nick, ";
				}
				
				$.ajax({
					url: "wyslij.php?nick="+nick+"&email="+email+"&plec="+plec+"&area="+area,
					success: function(data){
						alert(data);
					}
				});
				return false;
			});
		});
	</script>
</head>
<body>
	<div id="wpisSie">
		<div id="head">Księga Gości</div>
		<form>
			<label for="nick"><input type="text" name="nick" required autofocus placeholder="Nick"></label><br>
			<label for="email"><input type="text" name="email" required autofocus placeholder="E-mail"></label><br>

			Płeć:
			<label><input type="radio" name="plec" value="m" checked>Mężczyzna</label>
			<label><input type="radio" name="plec" value="k">Kobieta</label><br>

			treść:<br>
			<textarea name="trescWpisu"></textarea><br>

			<input type="submit" value="Zapisz">
			<input type="button" name="wpisy" value="Zobacz wpisy">
		</form>
	</div>
</body>
</html>