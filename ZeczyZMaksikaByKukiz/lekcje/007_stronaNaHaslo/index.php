<!DOCTYPE html>
<html>
<head lang="pl">
	<meta charset="utf-8">
	<title>Hasla</title>
	<link rel="stylesheet" type="text/css" href="style.css">
	<script src="../../../scripts/jq.js"></script>
	<script src="scripts.js"></script>
	<script type="text/javascript">
		$(function(){
			$('.paragraf').click(function(){
				var par = $(this).attr('href');
				var par2 = par.slice(5);
				switch(par){
					case "#par-m1":		js(par2); 		break;
					case "#par-m1a":	js(par2); 		break;
					case "#par-m2":		php(0, par2);	break;
					case "#par-m2a":	php(0, par2);	break;
					case "#par-m3":		php(1, par2);	break;
					case "#par-m3a":	php(1, par2);	break;
					case "#logOut-js":	logOut_js();	break;
					case "#logOut-file":logOut_file();	break;
					case "#logOut-sql":	logOut_sql();	break;

				}
			});
		})//jq
		var js_zalogowany = false;
		var js_hasla = [
			"haselko123",
			"pomidory",
			"qwerty"
		];
		js_hasla_dl = js_hasla.length;
		function js(par){
			if(!js_zalogowany){
				var haslo = prompt("Podaj haslo:");
				var is_haslo = false; 
				for(i = 0; i < js_hasla_dl; i++){
					if(haslo == js_hasla[i]){
						is_haslo = true;
						break;
					}
				}
				if(is_haslo){
					js_zalogowany = true;
					js(par);
				}else{
					$('main').html("<h1>Błędne hasło, spróbuj wpisać: qwerty</h1>");
				}
			}else{
				$('main').html("<h1>"+par+"</h1>");
			}
		}
		function logOut_js(){
			js_zalogowany = false;
			$('main').html("<h1>Wylogowano</h1>");
		}
		function logOut_file(){
			$.post("scripts.php",{
				op: "logOut_file"
			}).done(function(data){
				$('main').html(data);
			});
		}
		function logOut_sql(){
			$.post("scripts.php",{
				op: "logOut_sql"
			}).done(function(data){
				$('main').html(data);
			});
		}
		function php(typ, par){
			$.post("scripts.php",{
				op: "pok_inp",
				typ: typ,
				par: par
			}).done(function(data){
				$('main').html(data);
			});
		}
	</script>
</head>
<body>
	<div id="box">
		<header>Logo</header>
		<div>
			<main>
				
			</main><!-- 
		  --><nav>
		  		<h1>Menu</h1>
		  		<hr>
		  		<ul>
		  			<li><a class="paragraf" href="#par-wstep">Wstęp</a></li>
		  			<li><a class="paragraf" href="#par-m1">m1</a></li>
		  			<li><a class="paragraf" href="#par-m1a">m1a</a></li>
		  			<li><a class="paragraf" href="#logOut-js">wyloguj z m1</a></li>
		  			<li><a class="paragraf" href="#par-m2">m2</a></li>
		  			<li><a class="paragraf" href="#par-m2a">m2a</a></li>
		  			<li><a class="paragraf" href="#logOut-file">wyloguj z m2</a></li>
		  			<li><a class="paragraf" href="#par-m3">m3</a></li>
		  			<li><a class="paragraf" href="#par-m3a">m3a</a></li>
		  			<li><a class="paragraf" href="#logOut-sql">wyloguj z m3</a></li>
		  		</ul>
		    </nav>
		</div>
	</div>
</body>
</html>