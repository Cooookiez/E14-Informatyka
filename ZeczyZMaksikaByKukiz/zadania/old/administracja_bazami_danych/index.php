<!DOCTYPE html>
<html lang="pl">
<head>
	<meta charset="UTF-8">
	<meta name="author" content="Krzysztof Kukiz kukizk@gmail.com">
	<!--<meta name="Keywords" content="">-->
	<!--<meta name="Description" content="">-->
	<title>Bazy danych - instrukcja</title>
	<!--<link href="" rel="icon" type="image/x-icon">-->
	<link rel="stylesheet" href="bin/style/screen.css">
 	<script src="../../script/jq.js"></script>
	<script>
		$(function(){
			$('a').click(function(){
				
				$('li.checked').removeClass('checked');
				$(this).parent().addClass('checked');
				
				var name = $(this).attr('href');
				name = delete_hash(name);
				var top = $('a[name='+name+']').offset().top;
//				alert(top);
				top *= 1;
				top -= 80;
				$('html, body').stop().animate({scrollTop: top},400);
				
				return false;
			});
		})//jq END
		
		function delete_hash(str){
			var dl = str.length;
			var strO = '';
			for(i = 1; i < dl; i++){
				strO += str[i];
			}
			return strO;
		}
	</script> 
	
</head>
<body>
	<header>Bazy danych - instrukcja</header>
	<nav>
		<ul>
			<li class="checked"><a href="#baz">Bazy</a></li>
			<li><a href="#tab">Tabele</a></li>
			<li><a href="#php">PHP</a></li>
			<li><a href="#fnc">Funkcie SQL</a></li>
			<li><a href="#sql">Zapytania</a></li>
		</ul>
	</nav>
	<main>
	
		<article>
			<a name="baz"></a>
			<header>Bazy</header>
			<section>
				<table border="0">
					<tr>
						<th>Akcja</th>
						<th>Konsola</th>
						<th>phpMyAdmin</th>
					</tr>
					
					<tr>
						<th >Logowanie</th>
						<td>mysql -u USER -p</td>
						<td><img src="bin/src/base-login-pmya.png" alt=""></td>
					</tr>
					
					<tr>
						<th>Podgląd dostępnych baz danych</th>
						<td>show databases;</td>
						<td><img src="bin/src/base-show databases(klik)-pmya.png" alt=""></td>
					</tr>
					
					<tr>
						<th>Wejście do bazy</th>
						<td>use TABELA</td>
						<td><img src="bin/src/base-use d14-pmya.png" alt=""></td>
					</tr>
					
				</table>
			</section>
		</article>
	
		<article>
			<a name="tab"></a>
			<header>Tabele</header>
			<section>
				<table border="0">
					<tr>
						<th>Akcja</th>
						<th>Konsola</th>
						<th>phpMyAdmin</th>
					</tr>
					
					<tr>
						<th>Wyświtlenie tabel</th>
						<td>show tables;</td>
						<td><img src="bin/src/table-show-pmya.png" alt=""></td>
					</tr>
					
					<tr>
						<th>Dodawanie tabeli</th>
						<td><pre>
create table znajomi(
	id int auto_increment,
	imie varchar(20),
	PRIMARY KEY(id)
);
						</pre></td>
						<td><video autoplay loop><source src="bin/src/table-create-pmya.mp4"></video></td>
					</tr>
					
					<tr>
						<th>Edycja</th>
						<td>
							<table border="0">
								<tr>
									<th>Dodawanie po ostatnim</th>
									<td rowspan="6">alert table TABELA</td>
									<td>ADD e_mail varchar(30)</td>
								</tr>
								<tr>
									<th>Dodawanie po czymś/jako pierwsze</th>
									<td>ADD e_mail varchar(30) FIRST/AFTER nazwisko</td>
								</tr>
								<tr>
									<th>Zmiana nazwy i typu</th>
									<td>CHANGE e_mail mail varchar(40)</td>
								</tr>
								<tr>
									<th>Zmiana TYLKO typu</th>
									<td>MODIFY e_mail varchar(40)</td>
								</tr>
								<tr>
									<th>Zmiana Tylko nazwy</th>
									<td>RENAME e_mail mail</td>
								</tr>
								<tr>
									<th>Usunięcie</th>
									<td>DROP COLUMN mail</td>
								</tr>
							</table>
						</td>
						<td><video autoplay loop><source src="bin/src/table-edit-pmya.mp4"></video></td>
					</tr>
					
				</table>
			</section>
		</article>
	
		<article>
			<a name="php"></a>
			<header>Połączenie się do SQL za pomocą php</header>
			<section>
			<h3>Połączenie się</h3>
			<pre>
function polacz_db($db = 'd14_kukiz_krzysztof'){
	$wynik = @new MySqli('localhost', 'login', 'haslo', $db);
		if(mysqli_connect_errno()){
			echo 'Brak polaczenia z baza, prosze wrucic puźniej'.mysqli_connect_error();
			exit();
		}else{//polaczono sie
		$wynik->query("set name 'utf-8'");
		return $wynik;
	}
}
			</pre>
			<h3>zwrucenie wartosci z bazy</h3>
			<pre>
$connect = polacz_db();
$sql = "SELECT wartosc1, wartosc2 FORM table";
if($result = $connect->query($sql)){
	while($row = $result->fetch_assoc()){
		$wartosc1 = $row['wartosc1'];
		$wartosc2 = $row['wartosc2'];
	}
}
		</pre>
			</section>
		</article>
	
		<article>
			<a name="fnc"></a>
			<header>Funkcje sql</header>
			<section>
			<ul>
				<li>Tekstowe<ul>
					<li>CONCAT() - laczy znaki</li>
					<li>CONCAT_WS("znak", ...) - laczy znaki i daje przerywnik jako zdefiniowany znak</li>
					<li>LOWER() / UPPER() - zmiana na wielkie / male litery</li>
					<li>LEFT(rekord, ile) - bierze od lewej iles znakow</li>
					<li>RIGHT - to samo co wyzej</li>
					<li>TRIM() / LTRIM() / RTRIM() - usuwa spacje lewej i prawej / tylko z lewej / tylko z prawej</li>
					<li>EPLACE(rekord, co, na co) - zamienia</li>
					<li>REVERSE() - odwraca (nie działa z "kajak" xD)</li>
					<li>SUBSTRING(rekord, od kiedy, ile) - wycina znaki (index od 0)</li>
					<li>LENGTH() - ile znakow</li>
					<li>INSTR(rekord, co) - szuka znaku</li>
				</ul></li>
				<li>Liczbowe<ul>
					<li>ROUND(rekord, ile) - zaokragla do ilus miejsc po przecinku</li>
					<li>TRUNCATE(rekord, ile) - to samo co wyzej tylko zawsze w dol</li>
					<li>ABS() pozbywa sie "+" i "-"POW(2, 3) - pierwiastkuje (23)</li>
					<li>POW(2, 3) - pierwiastkuje (2<sup>3</sup>)</li>
					<li>MOD(7,2) - modulo (reszta z dzielenia)(w tmy przypadku wynik = 1)</li>
					<li>sqrt(25) - pierwiastkowanie (w tmy przypadkuwynik = 5)</li>
					<li>count() - liczy ile jest wzróconych wartośći</li>
				</ul></li>
				<li>Data i czas<ul>
					<li>CURDATE() - aktualna data</li>
					<li>CURTIME() - aktualna godzina</li>
					<li>NOW() - obie powyrzsze</li>
					<li>DAYOF[week / month / year]() - dzien w tygodniu / miesiadzu / roku</li>
					<li>[DAY / MONTH / YEAR / HOUR / MINUTE / SECEND]()</li>
				</ul></li>
				<li>szyfry<ul>
					<li>ENCODE() - szyfruje/li>
					<li>DECODE() - deszyfruje</li>
					<li>SHA1() / PASSWORD() - szfruje bez odkodywania</li>
				</ul></li>
			</ul>
			</section>
		</article>
	
		<article>
			<a name="sql"></a>
			<header>Funkcje sql</header>
			<section>
			<h3>Teoria</h3>
			<hr>
			
			<h4>
				<span>SELECT</span>
				<span style="color: blue">*</span>
				<span>FROM</span>
				<span>tabela</span>
				<span>WHERE</span>
				<span style="color: green">warunek</span>
			</h4>
			<ul>
				<li style="color: blue">* - wszystko</li>
				<li style="color: blue">kolumna, innakolumna - wybrane kolumny</li>
				<li style="color: blue">kolumna [AS (opcjonalnie)] MojaNowaNazwa - własna nazwa dla kolumny</li>
				<li style="color: green">1=1</li>
				<li style="color: green">imie = 'Aneta'</li>
				<li style="color: green">imie LIKE 'An%'</li>
				<li style="color: green">koluna LIKE '%12_' - (pasuje: 123, 3123, 22125)</li>
			</ul>
			
			<h4>
				<span>INSERT INTO</span>
				<span>tabela</span>
				<span>VALUES(</span>
				<span style="color: red">null</span>
				<span style="color: green">, 'wartosc'</span>
				<span style="color: blue">, 'nth'</span>
				<span>)</span>
			</h4>
			<ul>
				<li style="color: red">null - jesli kolumna ma AUTO_INCREMENT</li>
				<li style="color: green">wartość (ciągi znaków między ' ', liczby nie muszą być między ' ')</li>
				<li style="color: blue">każda kolejna wartość (tyle wartości ile kolumn)</li>
			</ul>

			<h3>Przykłady</h3>
			<hr>
			SELECT COUNT(*) AS Ile FROM `z101_osoby` WHERE `Id_uzytkownika;Nazwisko;Imie;Plec` LIKE '%;%la%;_';<br>
			SELECT COUNT(*) "Ile Kobiet" FROM `z101_osoby` WHERE `Id_uzytkownika;Nazwisko;Imie;Plec` LIKE '%k';
		
			</section>
		</article>
		
	</main>
	<footer></footer>
</body>
</html>