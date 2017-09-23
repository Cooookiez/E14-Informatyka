<!DOCTYPE html>
<html lang="pl">
<head>
	<meta charset="UTF-8">
	<meta name="author" content="Krzysztof Kukiz kukizk@gmail.com">
	<!--<meta name="Keywords" content="">-->
	<!--<meta name="Description" content="">-->
	<title>Viteo tutorial</title>
	<!--<link href="" rel="icon" type="image/x-icon">-->
	<link rel="stylesheet" href="bin/style/fontello.css">
	<link rel="stylesheet" href="bin/style/screen.css">
	<script src="../../script/jq.js"></script>
	<script>
		var videoNr = 0;
		var film = [
			[ "bin/src/video/0.mp4", "Wycinanie, kopjowanie i wklejanie fragmentów video"],
			[ "bin/src/video/1.mp4", "Edycja ścieszki dzwiękowej"],
			[ "bin/src/video/2.mp4", "Efekty (przejścia)"],
			[ "bin/src/video/3.mp4", "Efekt PiP (obraz w obrazie)"],
			[ "bin/src/video/4.mp4", "Wstawianie tekstów"],
			[ "bin/src/video/5.mp4", "Wstawianie zdięć"]
		];
		
		$(function(){
			zmienVideo();
			$('#prev').click(function(){
				videoNr--;
				zmienVideo();
			});
			$('#next').click(function(){
				videoNr++;
				zmienVideo();
			});
			$('.vv-c').click(function(){
				videoNr = parseInt($(this).attr('data-v-nr'));
				zmienVideo();
			});
		});//jq END
		function zmienVideo(){
			if (videoNr > 5) videoNr = 0;
			if (videoNr < 0) videoNr = 5;
			$html = '';
			$html += '<span id="v-bgc"></span>';
			$html += '<video autoplay loop muted controls>';
			$html += '<source src="'+film[videoNr][0]+'">';
			$html += '</video>';
			$html += '<span class="icon-television"></span>';
			$('#box > header').text(film[videoNr][1]);
			$('#video').html($html);
			$('.vv-c.checked').removeClass('checked');;
			$('.vv-c[data-v-nr='+videoNr+']').addClass('checked');;
		}
	</script>
	
</head>
<body>
<div id="box">
	<nav>
		<span id="prev" class="icon-left-open"></span>
		<span id="next" class="icon-right-open"></span>
	</nav>
	<header>1. tra</header>
	<article>
		<section id="video">
			<!--<span id="v-bgc"></span>
			<video autoplay loop muted controls>
				<source src="bin/src/video/poObrupce/1. Wycinanie i kopiowanie fragmentów filmu.mp4">
			</video>
			<span class="icon-television"></span>-->
		</section>
	</article>
	<footer>
		<span class="vv-c checked" data-v-nr="0"></span>
		<span class="vv-c" data-v-nr="1"></span>
		<span class="vv-c" data-v-nr="2"></span>
		<span class="vv-c" data-v-nr="3"></span>
		<span class="vv-c" data-v-nr="4"></span>
		<span class="vv-c" data-v-nr="5"></span>
	</footer>
</div>
</body>
</html>