<!DOCTYPE html>
<html lang="pl"><head>
	<meta charset="UTF-8">
	<title>Familiada</title>
	
	<link rel="stylesheet" href="src/style/css/screen.css">
	<link rel="stylesheet" href="../../../style/css/fontawesome-pro-core.css">
	<link rel="stylesheet" href="../../../style/css/fontawesome-pro-solid.css">
	
	<script src="../../../scripts/jq.js"></script>
	<script>
		var keyLocket = true;
		var activeTeam = '';
		var nthRed = 0;
		var nthBlue = 0;
		var uzytePytaniaId = [];
		var uzyteOdpId = [];
		var ileXRed = 0;
		var ileXBlue = 0;
		var odpGood = 0;
		$(function(){
			
			//Start
			//red();
			
			$('#btt_start').click(function(){
				$('body > header').addClass('inGame');
				$('body > main').addClass('inGame');
				odliczaj(4);
			});//$('#btt_start').click
			
			
			$('.key.r').click(function(){
				red();
			});
			$('.key.b').click(function(){
				blue();
			});
			
			$('html').keydown(function(e){
				switch(e['key']){
					case 'q':case 'Q':$('#Q.key').addClass('pressed');red();break;
					case 'w':case 'W':$('#W.key').addClass('pressed');red();break;
					case 'e':case 'E':$('#E.key').addClass('pressed');red();break;
					case 'r':case 'R':$('#R.key').addClass('pressed');red();break;
					case 't':case 'T':$('#T.key').addClass('pressed');red();break;
						
					case 'y':case 'Y':$('#Y.key').addClass('pressed');blue();break;
					case 'u':case 'U':$('#U.key').addClass('pressed');blue();break;
					case 'i':case 'I':$('#I.key').addClass('pressed');blue();break;
					case 'o':case 'O':$('#O.key').addClass('pressed');blue();break;
					case 'p':case 'P':$('#P.key').addClass('pressed');blue();break;
						
						
					case 'a':case 'A':$('#A.key').addClass('pressed');red();break;
					case 's':case 'S':$('#S.key').addClass('pressed');red();break;
					case 'd':case 'D':$('#D.key').addClass('pressed');red();break;
					case 'f':case 'F':$('#F.key').addClass('pressed');red();break;
						
					case 'h':case 'H':$('#H.key').addClass('pressed');blue();break;
					case 'j':case 'J':$('#J.key').addClass('pressed');blue();break;
					case 'k':case 'K':$('#K.key').addClass('pressed');blue();break;
					case 'l':case 'L':$('#L.key').addClass('pressed');blue();break;
						
						
					case 'z':case 'Z':$('#Z.key').addClass('pressed');red();break;
					case 'x':case 'X':$('#X.key').addClass('pressed');red();break;
					case 'c':case 'C':$('#C.key').addClass('pressed');red();break;
						
					case 'b':case 'B':$('#B.key').addClass('pressed');blue();break;
					case 'n':case 'N':$('#N.key').addClass('pressed');blue();break;
					case 'm':case 'M':$('#M.key').addClass('pressed');blue();break;
			  	}
			});
			$('html').keyup(function(e){
				switch(e['key']){
					case 'q':case 'Q':$('#Q.key').removeClass('pressed');break;
					case 'w':case 'W':$('#W.key').removeClass('pressed');break;
					case 'e':case 'E':$('#E.key').removeClass('pressed');break;
					case 'r':case 'R':$('#R.key').removeClass('pressed');break;
					case 't':case 'T':$('#T.key').removeClass('pressed');break;
					case 'y':case 'Y':$('#Y.key').removeClass('pressed');break;
					case 'u':case 'U':$('#U.key').removeClass('pressed');break;
					case 'i':case 'I':$('#I.key').removeClass('pressed');break;
					case 'o':case 'O':$('#O.key').removeClass('pressed');break;
					case 'p':case 'P':$('#P.key').removeClass('pressed');break;
						
						
					case 'a':case 'A':$('#A.key').removeClass('pressed');break;
					case 's':case 'S':$('#S.key').removeClass('pressed');break;
					case 'd':case 'D':$('#D.key').removeClass('pressed');break;
					case 'f':case 'F':$('#F.key').removeClass('pressed');break;
						
					case 'h':case 'H':$('#H.key').removeClass('pressed');break;
					case 'j':case 'J':$('#J.key').removeClass('pressed');break;
					case 'k':case 'K':$('#K.key').removeClass('pressed');break;
					case 'l':case 'L':$('#L.key').removeClass('pressed');break;
						
						
					case 'z':case 'Z':$('#Z.key').removeClass('pressed');break;
					case 'x':case 'X':$('#X.key').removeClass('pressed');break;
					case 'c':case 'C':$('#C.key').removeClass('pressed');break;
						
					case 'b':case 'B':$('#B.key').removeClass('pressed');break;
					case 'n':case 'N':$('#N.key').removeClass('pressed');break;
					case 'm':case 'M':$('#M.key').removeClass('pressed');break;
			  	}
			});
			
			//sprawdza pytania
			$('#pisz').submit(function(){
				
				var $th = $(this);
				var val = $th.find('#txt_odpowiedz').val();
				var pytId = parseInt($('#pytania').attr('data-pyt-id'));
				
				$th.find('#txt_odpowiedz').val("").focus();;
				
				$.post('src/scripts/scripts.php',{
					op: 'sprawcOdp',
					val: val,
					pytId: pytId,
					uzyte: uzyteOdpId
				}).done(function(data){
					console.log(data);
					data = JSON.parse(data);
					console.log(data);
					if(data['num_rows']>0){
						var newPkt = parseInt($('#pktIle').attr('data-ile'));
						newPkt += parseInt(data['odp_pkt']);
						uzyteOdpId.push(data['odp_id']);
						$('#pktIle')
							.attr('data-ile', newPkt)
							.text('pkt: '+newPkt);
						
						$('#odp .p'+data['odp_pkt'])
							.find('.tresc')
							.text(data['odp_nth']+'. '+data['odp_tresc']);
						
						odpGood++;
						if(odpGood >= 6){
							dodajPkt();
							//nowaTura
							nowaTura();
						}
					}else{
						addX();
					}
				});
				
				nextOs();
				
				return false;
			});
			
			//do usunieica
			$('.osTeam').click(function(){
				var $i = $(this).find('i');
				if($i.attr('class').search('activePerson') >= 0){
					$i.removeClass('activePerson');
				}else{
					$i.addClass('activePerson');
				}
			});
			
		})//jq
		
		
		function nowaTura(){
			console.log('nowaTura');
			keyLocket = true;
			activeTeam = '';
			ileXRed = 0;
			ileXBlue = 0;
			odpGood = 0;
			
			var index = 0;
			$('#odp .tresc').each(function(){
				index++;
				$(this).text(index+". . . . . . . . . . . . . . . . .");
			});
			
			$('.x.active').each(function(){
				$(this).removeClass('active');
			});
			
			$('.x.activePerson').each(function(){
				$(this).removeClass('activePerson');
			});
			
			$('#tresc').removeClass('hide');
			$('#pisz')
				.addClass('hide')
				.find('div')
				.removeClass('toRed')
				.removeClass('toBlue');
			
			odliczaj(4);
		}	
			
		function dodajPkt(){
			console.log('dodajPkt');
			var pktNew = parseInt($('#pktIle').attr('data-ile')) * parseInt($('#pktMnoznik').attr('data-mnoznik'));
			if(activeTeam == 'red' || activeTeam == 'Red'){
				var pkt = parseInt($('#pktRed').attr('data-pkt'));
				pkt += pktNew;
				$('#pktRed').attr('data-pkt', pkt).text('pkt: '+pkt);
			}else if(activeTeam == 'blue' || activeTeam == 'Blue'){
				var pkt = parseInt($('#pktBlue').attr('data-pkt'));
				pkt += pktNew;
				$('#pktBlue').attr('data-pkt', pkt).text('pkt: '+pkt);
			}
		}
		
		function changeTeam(){
			if(ileXRed>=3 && ileXBlue>=3){
				//nowa tura
			}else{
				$('.activePerson').each(function(){
					$(this).removeClass('activePerson')
				});
				if(activeTeam == 'red' || activeTeam == 'Red'){
					activeTeam = 'blue';
					nthBlue = -1;
					nextOs();
				}else if(activeTeam == 'blue' || activeTeam == 'Blue'){
					activeTeam = 'red';
					nthRed = -1;
					nextOs();
				}
			}
		}
			
		function nextOs(){
			if(activeTeam == 'red' || activeTeam == 'Red'){
				nthRed++;
				if(nthRed >= 5) nthRed = 0;
				$('#teamRed').find('.activePerson').each(function(){
					$(this).removeClass('activePerson')
				});
				$('#teamRed .osTeam').eq(nthRed).find('i').addClass('activePerson');
			}else if(activeTeam == 'blue' || activeTeam == 'Blue'){
				nthBlue++;
				if(nthBlue >= 5) nthBlue = 0;
				$('#teamBlue').find('.activePerson').each(function(){
					$(this).removeClass('activePerson')
				});
				$('#teamBlue .osTeam').eq(nthBlue).find('i').addClass('activePerson');
			}
		}
			
		function addX(){
			if(activeTeam == 'red' || activeTeam == 'Red'){
				$('#errRed').find('.x').eq(ileXRed).addClass('active');
				ileXRed++;
				console.log(ileXRed);
				if(ileXRed>=3) changeTeam();
			}else if(activeTeam == 'blue' || activeTeam == 'Blue'){
				$('#errBlue').find('.x').eq(ileXBlue).addClass('active');
				ileXBlue++;
				if(ileXBlue>=3) changeTeam();
			}
		}
		
		function pokPytanie(){
			$.post('src/scripts/scripts.php',{
				op: 'pokPytanie',
				uzyte: uzytePytaniaId,
			}).done(function(data){
				data = JSON.parse(data);
				console.log(data);
				data['pkt'].forEach(function(item, key){
					$('#odp .odp').eq(key).addClass('p'+item).find('.pkt').text(item);
				});
				uzytePytaniaId.push(parseInt(data['pyt_id']));
				$('#pytania').text(data['pyt_tresc']).attr('data-pyt-id', data['pyt_id']);
			});
		}
		
		function odliczaj(ile){
			if(ile == 0){
				keyLocket = false;
				pokPytanie();
				$('#odliczaj').text("START");
			}else{
				$('#odliczaj').text("Start za: "+ile);
				setTimeout(function(){odliczaj(ile-1)},1000);
			}
		}
		
		function start(){
				keyLocket = true;
				$('#tablica #tresc').addClass('hide');
				$('#pisz').removeClass('hide');
				$('#timer #prc').addClass('p0');
				setTimeout(function(){$('#pisz > div > input[type=text]').focus();},50);//zaznacz
				setTimeout(function(){
					$('#timer #prc').removeClass('p0');
					setTimeout(function(){start();},50);//zaznacz
				},5000);
		}
		
		
		//kto zaczyna
		function red(){
			if(!keyLocket){
				$('.osTeamRed > .nth1').addClass('activePerson');
				activeTeam = 'red';
				$('#pisz > div').removeClass('toBlue').addClass('toRed');
				start();
			}
		}
		function blue(){
			if(!keyLocket){
				$('.osTeamBlue > .nth1').addClass('activePerson');
				activeTeam = 'blue';
				$('#pisz > div').removeClass('toRed').addClass('toBlue');
				start();
			}
		}
		
	</script>
</head>
<body>
	<header class="">
		<h1>Familiada</h1>
		<input type="button" id="btt_start" value="Naciśnij by zacząć gre!">
	</header>
	<main>
		<section id="teamRed">
			<div>
				<div class="osTeam osTeamRed"><i class="nth1 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamRed"><i class="nth2 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamRed"><i class="nth3 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamRed"><i class="nth4 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamRed"><i class="nth5 fa fa-user" aria-hidden="true"></i></div>
			</div>
		</section><!--
	 --><section id="tablica">
			<article id="panel">
				<header id="pytania"></header>
				<aside id="errRed">
					<div data-id="1" class="x">x</div>
					<div data-id="2" class="x">x</div>
					<div data-id="3" class="x">x</div>
				</aside>
				<aside id="odp">
					<div class="odp">
						<section class="tresc">1. . . . . . . . . . . . . . . . .</section>
						<section class="pkt"></section>
					</div>
					<div class="odp">
						<section class="tresc">2. . . . . . . . . . . . . . . . .</section>
						<section class="pkt"></section>
					</div>
					<div class="odp">
						<section class="tresc">3. . . . . . . . . . . . . . . . .</section>
						<section class="pkt"></section>
					</div>
					<div class="odp">
						<section class="tresc">4. . . . . . . . . . . . . . . . .</section>
						<section class="pkt"></section>
					</div>
					<div class="odp">
						<section class="tresc">5. . . . . . . . . . . . . . . . .</section>
						<section class="pkt"></section>
					</div>
					<div class="odp">
						<section class="tresc">6. . . . . . . . . . . . . . . . .</section>
						<section class="pkt"></section>
					</div>
				</aside>
				<aside id="errBlue">
					<div data-id="1" class="x">x</div>
					<div data-id="2" class="x">x</div>
					<div data-id="3" class="x">x</div>
				</aside>
				<footer id="pktSum">
					<div id="pktIle" data-ile="0">pkt: 0</div>
					<div id="pktMnoznik" data-mnoznik="1">x1</div>
				</footer>
			</article>
			<article id="tresc" class="">
				<header id="odliczaj"></header>
				<header id="tip">Kto pierwszy naciśnie, ten zaczyna odpowiadać.</header>
				<section id="keyboard">
					
					<div class="keyRow">
						<div id="Q" class="key r">Q</div>
						<div id="W" class="key r">W</div>
						<div id="E" class="key r">E</div>
						<div id="R" class="key r">R</div>
						<div id="T" class="key r">T</div>
						<div id="Y" class="key b">Y</div>
						<div id="U" class="key b">U</div>
						<div id="I" class="key b">I</div>
						<div id="O" class="key b">O</div>
						<div id="P" class="key b">P</div>
					</div>
					
					<div class="keyRow">
						<div id="A" class="key r">A</div>
						<div id="S" class="key r">S</div>
						<div id="D" class="key r">D</div>
						<div id="F" class="key r">F</div>
						<div id="G" class="key n">G</div>
						<div id="H" class="key b">H</div>
						<div id="J" class="key b">J</div>
						<div id="K" class="key b">K</div>
						<div id="L" class="key b">L</div>
					</div>
					
					<div class="keyRow">
						<div id="Z" class="key r">Z</div>
						<div id="X" class="key r">X</div>
						<div id="C" class="key r">C</div>
						<div id="V" class="key n">V</div>
						<div id="B" class="key b">B</div>
						<div id="N" class="key b">N</div>
						<div id="M" class="key b">M</div>
					</div>
					
				</section>
			</article>
			<form id="pisz" class="hide">
				<div class="">
					<input type="submit" value="Sprawdź" class="red">
					<input type="text" placeholder="Odpowiedz tutaj" id="txt_odpowiedz">
					<input type="submit" value="Sprawdź" class="blue">
				</div>
			</form>
		</section><!--
	 --><section id="teamBlue">
			<div>
				<div class="osTeam osTeamBlue"><i class="nth1 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamBlue"><i class="nth2 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamBlue"><i class="nth3 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamBlue"><i class="nth4 fa fa-user" aria-hidden="true"></i></div>
				<div class="osTeam osTeamBlue"><i class="nth5 fa fa-user" aria-hidden="true"></i></div>
			</div>
		</section>
	</main>
	<footer>
		<section id="pktRed" data-pkt="0">pkt: 0</section><!--
	 --><section id="stopkaTresc"><a href="pytOdp.php" target="_blank">odpowiedzi</a></section><!--
	 --><section id="pktBlue" data-pkt="0">pkt: 0</section>
	</footer>
</body>
</html>