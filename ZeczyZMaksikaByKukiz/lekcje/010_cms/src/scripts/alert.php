<?php
if(isset($_GET['op']) && !empty($_GET['op'])){
	switch($_GET['op']){
		case "login": loginHTML(); break;
		case "img": imgChange(); break;
	}
}



function loginHTML(){
?>
<form action="?" id="login" method="post">
	<article>
		<header>Logowanie</header>
		<section>
			<div>
				<p id="log"></p>
			</div>
			<div>
				<input type="text" id="username" name="username" placeholder="Username" required value="root">
			</div>
			<div>
				<input type="password" id="password" name="password" placeholder="Hasło" required value="root">
			</div>
		</section>
		<footer>
			<input id="cancel" type="button" value="Cancel">
			<input type="submit" value="Loguj">
		</footer>
	</article>
</form>
<?php
}



function imgChange(){
?>
<form action="src/scripts/scripts.php?op=imgChange" id="imgChange" method="post" enctype="multipart/form-data">
	<article>
		<header>Zmień logo</header>
		<section>
			<div>
				<p id="log"></p>
			</div>
			<div>
				<input type="file" id="img" name="img" required>
			</div>
		</section>
		<footer>
			<input id="cancel" type="button" value="Cancel">
			<input type="submit" value="Zmień">
		</footer>
	</article>
</form>
<?php
}













?>