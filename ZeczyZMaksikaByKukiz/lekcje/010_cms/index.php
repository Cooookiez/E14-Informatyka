<?php
@ session_start();

/*echo '<pre>';
print_r($_SESSION);
echo '</pre>';*/

//config
$jsonFile = "src/scripts/config.json";
$json = file_get_contents($jsonFile);
$json = json_decode($json, true);



//usery / dostępy
$usr_logIn = @ (bool)$_SESSION['user_logIn'];
$usr_id = @ $_SESSION['user_id'];
$usr_typ = @ $_SESSION['user_typ'];
$usr_name = @ $_SESSION['user_name'];

if(isset($_GET['alert']) && $_GET['alert'] == true){
	$boxClass = 'br';
	$alertClass = 'showed';
}else{
	$boxClass = '';
	$alertClass = '';
}
if(isset($_GET['log'])) $s_log = $_GET['log'];
if(isset($_GET['log_c'])) $s_log_c = $_GET['log_c'];
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>010_cms</title>
	<link rel="stylesheet" type="text/css" href="src/style/style.css">
	<script src="http://code.jquery.com/jquery-2.1.3.min.js"></script>
	<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
	<script>
		$(function(){
			//get json config
			$.getJSON('src/scripts/config.json', function(data){
				//logo
				console.log(data);
				var src = data['img-logo']['src'];
				var alt = data['img-logo']['alt'];
				console.log(data['img-logo']['src']);
				$('#box > header > img').attr('alt', alt).attr('src', src);
			});
			
			
			
			
			$('footer > span#logIn').click(function(){
				$.post('src/scripts/alert.php?op=login')
				.done(function(html){
					$('#alert').html(html);
				})
				.fail(function(){
					$('#alert').html("<h1 style=\"text-align: center; margin-top: 10%;\">Błąd</h1>");
				})
				.always(function(){
					pokAlert();
				});
			});
			$('#logOut').click(function(){
				$.post("src/scripts/scripts.php?op=logOut").done(function(data){
					location.reload();
				});
			});
			$('body')
				.delegate('#alert input#cancel', 'click', function(){
					chowajAlert();
				})
				.delegate('#alert form#login', 'submit', function(){
					var $th = $(this);
					var username = $th.find('#username').val();
					var password = $th.find('#password').val();
					$.post("src/scripts/scripts.php",{
						op: 'login',
						username: username,
						password: password
					}).done(function(data){
						if(parseInt(data) == 1){
							location.reload();
						}else{
							$th.find('#log').html(data);
						}
					});
					return false;
				})
				;
			
			
			
			<?php if($usr_typ == 1){ ?>
			$('#box > header > img').click(function(){
				$.post('src/scripts/alert.php?op=img')
					.done(function(html){
						$('#alert').html(html);
					})
					.fail(function(){
						$('#alert').html("<h1 style=\"text-align: center; margin-top: 10%;\">Błąd</h1>");
					})
					.always(function(){
						pokAlert();
					});
			});
			<?php } ?>
		});//jq
		
		function chowajAlert(){
			$('#alert').removeClass('showed');
			$('#box').removeClass('br');
		}
		function pokAlert(){
			$('#alert').addClass('showed');
			$('#box').addClass('br');
		}
	</script>
</head>
<body>
	<div id="alert"></div>
	<div id="box" class="">
		<header>
			<img src="" alt="L0G0">
		</header><nav>
			<ul>
				<li><a href="#a">a mea mea mea mea mea mea me</a></li>
				<li><a href="#a">a me</a></li>
				<li><a href="#a">a me</a></li>
			</ul>
		</nav><main>
			3
		</main><footer>
			<?php 
			if($usr_logIn == true){
				echo '<span id="logOut">2k17 &copy; kkukiz IVI (wyloguj)</span>';
			}else{
				echo '<span id="logIn">2k17 &copy; kkukiz IVI</span>';
			}
			?>
		</footer>
	</div>
</body>
</html>