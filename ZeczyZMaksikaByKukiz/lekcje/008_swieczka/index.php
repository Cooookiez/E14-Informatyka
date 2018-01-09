<?php

function uklad($html){
	$file = "swieczki.html";
	if(is_writable($file) && $handle = fopen($file, 'w')){
		if(flock($handle, 2)){
			fwrite($handle, $html);
			flock($handle, 3);
		}
		fclose($handle);
	}
}

if(isset($_POST['op']) && !empty($_POST['op'])){
	switch ($_POST['op']) {
		case 'zapiszUklad': uklad($_POST['html']); break;
		
		default:
		break;
	}
}else{
?>
<!DOCTYPE html>
<html lang="pl">
<head>
	<meta charset="utf-8">
	<title>008_swieczki</title>
	<link rel="stylesheet" type="text/css" href="style.css">
	<script src="http://code.jquery.com/jquery-2.1.3.min.js"></script>
	<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
	<script>
		function zapisz(){
			var main = $('main').html();
			$.post('?',{
				op: 'zapiszUklad',
				html: main
			});
		}

		var heightMin = 40;
		var heightMax = 100;
		$(function(){
			$('.swieczka')
				.mouseup(function(){
					zapisz();
				})
				.draggable();

			$('body > nav')
				.click(function(){
					//ktura swieczka
					var nr = Math.random() * 8;
					nr = parseInt(nr);

					//wielkosc img
					var height = heightMin + Math.random()*(heightMax - heightMin + 1);
					height = parseInt(height);

					//wielkosc ekranu
					var mW = $('main').width();
					var mH = $('main').height();
					mH -= height;

					//
					var posT = parseInt(Math.random()*mH);
					var posl = parseInt(Math.random()*mW);



					var img = '<img src="img/swiecki/'+nr+'.gif" alt="'+nr+'.gif" class="swieczka" style="height: '+height+'px; top: '+posT+'px; left: '+posl+'px;">';
					$('main').append(img);
					$('.swieczka').draggable();
					console.log('click');
					zapisz();
				})
				.dblclick(function(){
					$('main').html("");
					console.log('dbclick');
					zapisz();
				});

		});//jq
	</script>
</head>
<body>
	<main>
		<?php
			$file = "swieczki.html";
			if(is_readable($file)){
				$html = file_get_contents($file);
				echo $html;
			}
		?>
	</main>
	<nav>
		<img src="img/dodatki/czaszka.png" alt="czaszka">
	</nav>
</body>
</html>
<?php } ?>