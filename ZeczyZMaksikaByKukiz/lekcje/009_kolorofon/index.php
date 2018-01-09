<!DOCTYPE html>
<html>
	<head>
		<title>Kolorofon</title>
		<style"></style>
		<link rel="stylesheet" type="text/css" href="style.css">
		<script src="../../../scripts/jq.js"></script>
		<script>
			var ile_x = 20;
			var ile_y = 10;

			$(function(){
				dajdivy();
				zmien_kolor();
			});//jq

			function animujJajo(){
				
			}

			function dajdivy(){
				var html = '';
				var ile = ile_x*ile_y;
				for(i = 0; i < ile; i++){
					html += '<div class="bl">s</div>';
				}
				$('main').html(html);
			}

			function zmien_kolor(){
				var colors = [];
				var ile = ile_x*ile_y;
				var colorR;
				var colorG;
				var colorB;
				var h_div;
				for(i = 0; i < ile; i++){
					do{
						colorR =  Math.floor(Math.random()*256);
						colorG =  Math.floor(Math.random()*256);
						colorB =  Math.floor(Math.random()*256);
						h_div = 'rgb('+colorR+','+colorG+','+colorB+')';
					}while($.inArray(h_div, colors) != -1)
					console.log($.inArray(h_div, colors));
					$('div').eq(i).css('background-color',h_div);
					colors[i] = h_div;
				}
				setTimeout(function(){zmien_kolor()}, 100)
			}

		</script>
	</head>
	<body>
		<main></main>
		<img id="jajo" src="jajo.png" alt="jajo">
	</body>
</html>