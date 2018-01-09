<?php
	echo 123;
if(isset($_GET['op']) && !empty($_GET['op'])){
	switch($_GET['op']){
		case 'login': loginHTML(); break;
	}
}

function loginHTML(){
?>
<form action="?log=error" id="login">
	<article>
		<header>Logowanie</header>
		<section>
			<div>
				<p id="log"></p>
			</div>
			<div>
				<!--<label for="username"></label>-->
				<input type="text" id="username" name="username" placeholder="Username" required value="root">
			</div>
			<div>
				<!--<label for=""></label>-->
				<input type="password" id="password" name="password" placeholder="Hasło" required value="root">
			</div>
		</section>
		<footer>
			<input id="cancel" type="button" value="Cancel">
			<input type="submit" value="Loguj">
		</footer>
	</article>
</form>
<?
}

?>