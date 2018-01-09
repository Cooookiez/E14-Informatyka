google.charts.load('current', {'packages':['corechart']});
//google.charts.setOnLoadCallback(drawChart);
var tab = [];
var min_x = -8;
var max_x = 8;
var term = .125;
var term2 = 1 / term;

function drawChart(tab) {
	console.log(tab);

	//wypisuje x i y w tabeli
	var line0 = '<th>x</th>';
	var line1 = '<th>y</th>';
	var tab_dl = tab.length;
	for(i = 4*term2+1; i <= (tab_dl-(4*term2+1)); i+=term2){
		var tmp_0 = Math.round(tab[i][0] * 1000) / 1000;
		var tmp_1 = Math.round(tab[i][1] * 1000) / 1000;
		line0 += '<td>'+tmp_0+'</td>';
		line1 += '<td>'+tmp_1+'</td>';
	}
	$('#functio-range table').html('<tr>'+line0+'</tr><tr>'+line1+'</tr>');



	var data = google.visualization.arrayToDataTable(tab);

	var options = {
		title: 'Age vs. Weight comparison',
		hAxis: {title: 'Age', minValue: -32, maxValue: 32},
		vAxis: {title: 'Weight', minValue: -32, maxValue: 32},
		legend: 'none',
		hAxis: { minValue: 0, maxValue: 9 },
		curveType: 'function',
		pointSize: 0,
		backgroundColor: 'lightgrey'
	};

	var chart = new google.visualization.LineChart(document.getElementById('function-draw'));

	chart.draw(data, options);
}//drawChart()

$(function(){
	//wykladnicze();
	//zmienia a, b, c na wybrana liczbe
	$('#box[data_funkcjia=wykladnicza] #function-var input').change(function(){
		var val = $(this).val();
		var id = $(this).attr('id');
		var which = id[id.length - 1];
		$('#function-write-'+which).text(val);
		wykladnicze();
	});
	$('#box[data_funkcjia=wykladnicza]').submit(function(){
		wykladnicze();
		return false;
	});
	//oblicza
})//jq
function wykladnicze(){
	var a = parseFloat($('#function-var-a').val()); if(isNaN(a)) a = 2;
	var b = parseFloat($('#function-var-b').val()); if(isNaN(b)) b = 0;
	var c = parseFloat($('#function-var-c').val()); if(isNaN(c)) c = 0;

	tab = [];
	var s_x;
	tab.push(['x', 'y']);
	for(x = min_x; x <= max_x; x += term){
		tab.push([(x-b), (wykladniczeGetY(x, a)+c)])
	}

	drawChart(tab);
}

function wykladniczeGetY(x, a){
	var znak = 1;
	if(a < 0){
		a *= -1;
		znak *= -1;
	}
	var wynik = 0;
		wynik = Math.pow(a, x);
		wynik *= znak;
	return wynik;
}