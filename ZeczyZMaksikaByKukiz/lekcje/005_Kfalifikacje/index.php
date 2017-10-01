<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	<style type="text/css">
	*{
		box-sizing: border-box;
	}
	body{
		background-color: black;
	}
	table{
		width: 800px;
		height: 500px;
	}
	td{
		width: 20%;
		cursor: pointer;
		padding: 5px;
		color: yellow;
		border: 1px solid black;
		background-color: green;
	}
	td:hover{
		background-color: darkgreen;
	}
	</style>
	<script src="../../../scripts/jq.js"></script>
	<script type="text/javascript">
		var lp = 0;
		$(function(){
			$('td').click(function(){
				var name = $(this).text();
				var kol = parseInt($(this).attr('data-nr')[0]);
					kol++;
				var row = parseInt($(this).attr('data-nr').substr(1,2));
				var row = Math.ceil(row / 2);
				var data_nr = kol + '' + row;
				$('td[data-nr='+data_nr+']').text(name);
			});
		});//jq
	</script>
</head>
<body>
	<table>
		<tr>
			<td data-nr="11">Ziomek Michał</td>
			<td data-nr="21" rowspan="2"></td>
			<td data-nr="31" rowspan="4"></td>
			<td data-nr="41" rowspan="8"></td>
			<td data-nr="51" rowspan="16"></td>
		</tr>
		<tr>
			<td data-nr="12">Sokołowski Grzegorz</td>
		</tr>
		<tr>
			<td data-nr="13">Piesyk Grzegorz</td>
			<td data-nr="22" rowspan="2"></td>
		</tr>
		<tr>
			<td data-nr="14">Dera Daniel</td>
		</tr>
		<tr>
			<td data-nr="15">Wolszczak Gabriel</td>
			<td data-nr="23" rowspan="2"></td>
			<td data-nr="32" rowspan="4"></td>
		</tr>
		<tr>
			<td data-nr="16">Maciejczak Grzegorz</td>
		</tr>
		<tr>
			<td data-nr="17">Matus Krystian</td>
			<td data-nr="24" rowspan="2"></td>
		</tr>
		<tr>
			<td data-nr="18">Dutkowski Michał</td>
		</tr>
		<tr>
			<td data-nr="19">Chmielewski Mariusz</td>
			<td data-nr="25" rowspan="2"></td>
			<td data-nr="33" rowspan="4"></td>
			<td data-nr="42" rowspan="8"></td>
		</tr>
		<tr>
			<td data-nr="110">Kiłoczko Rafał</td>
		</tr>
		<tr>
			<td data-nr="111">Szymaniak Rafał</td>
			<td data-nr="26" rowspan="2"></td>
		</tr>
		<tr>
			<td data-nr="112">Baszak Mateusz</td>
		</tr>
		<tr>
			<td data-nr="113">Scisłowski Dawid</td>
			<td data-nr="27" rowspan="2"></td>
			<td data-nr="34" rowspan="4"></td>
		</tr>
		<tr>
			<td data-nr="114">Szamszur Piotr</td>
		</tr>
		<tr>
			<td data-nr="115">-</td>
			<td data-nr="28" rowspan="2"></td>

		</tr>
		<tr>
			<td data-nr="116">Piesyk Mateusz</td>
		</tr>
	</table>
</body>
</html>