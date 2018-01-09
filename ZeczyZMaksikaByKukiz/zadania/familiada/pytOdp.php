<?php
echo '<pre>';
$table = '<tr><td colspan="3">Błąd</td></tr>';
if($connect = mysqli_connect('localhost','d14_5cc698','#Maselko123','d14_kukiz_krzysztof')){
	$connect -> set_charset("utf8");
	$sql = "SELECT pyt_tresc pyt, odp_tresc odp, odp_pkt pkt FROM fml_pytania NATURAL JOIN fml_odpowiedzi ORDER BY pyt_tresc ASC, odp_pkt DESC";
	if($result = mysqli_query($connect, $sql)){
		$table = '';
		$index = 1;
		while($a = mysqli_fetch_assoc($result)){
			$pyt = $a['pyt'];
			$odp = $a['odp'];
			$pkt = $a['pkt'];
			$table .= "<tr>";
			if($index == 1) $table .= 	"<td rowspan='6'>$pyt</td>";
			$table .= 	"<td>$odp</td>";
			$table .= 	"<td>$pkt</td>";
			$table .= "</tr>";
			$index++;
			if($index > 6) $index = 1;
		}
	}else echo 'error 2';
	mysqli_close($connect);
}else echo 'error 1';
echo '</pre>';
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>pytania i odpowiedziu w bazie</title>
</head>
<body>
	<table border="1">
		<tr>
			<th>Pytanie</th>
			<th>Odpowiedź</th>
			<th>Punkty</th>
		</tr>
		<?php echo $table; ?>
	</table>
</body>
</html>