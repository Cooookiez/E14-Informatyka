$(function(){
	if($.cookie('zgoda')){
		var kture_wejscie = $.cookie('kture_wejscie');
		if(!kture_wejscie) kture_wejscie = 1;
		kture_wejscie++;
		$.cookie('kture_wejscie', kture_wejscie);
		$('#communicate').html("Jesteś tu "+kture_wejscie+" raz.");
	}else{
		$('#communicate').text("Zaakceptuj cookies");
		$('#cookies').css('display', 'block');
	}

	$('div#cookies span').click(function(){
		$.cookie('zgoda', true);
		$.cookie('kture_wejscie', 1);
		$('#communicate').html("Ciasteczka zaakceptowane,<br> Jesteś tu pierwszy raz");
		$('#cookies').css('display', 'none');
	});

	$('#uslugi').submit(function(){
		var nr_zamowinia	= $('#nr-zam').val();
		var usluga			= $('[name=usluga]:checked').val();
		var realizacja		= $('[name=realizacja]:checked').val();
		var zgodnosc		= $('[name=zgodnosc]:checked').val();
		var cena			= $('[name=cena]:checked').val();
		$.post('?',{
			op:				'dopisz',
			nr_zamowinia:	nr_zamowinia,
			usluga:			usluga,
			realizacja:		realizacja,
			zgodnosc:		zgodnosc,
			cena:			cena
		}).done(function(data){
			$('#communicate').text(data);
		}).fail(function(){
			console.log('Błędny post');
		});
		return false;
	});

	$('#wynik').fadeOut(0);
	$('#uslugi #buttons [type=button]').click(function(){
		$('#wynik').css('opacity', '1').fadeIn(400);
		$('#uslugi').addClass('blure');
		drawChart();
	});
	$('#close').click(function(){
		$('#wynik').fadeOut(400);
		$('#uslugi').removeClass('blure');
	});

	//draw chart
	google.charts.load('current', {'packages':['bar']});
    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {
		var dane = [];
		dane.push(['ggProdukt', 'Usługa', 'Realizacja', 'Zgodność', 'Cena']);
		console.log(dane);
    	$.getJSON('ocena.json', function(dataa){
    		console.log(dataa);
    		var usluga = 0;
    		var realizacja = 0;
    		var zgodnosc = 0;
    		var cena = 0;
    		var index = 0;
    		$.each(dataa['produkt_id'], function(key, prod_id){
	    		usluga = 0;
	    		vrealizacja = 0;
	    		zgodnosc = 0;
	    		cena = 0;
	    		index = 0;
	    		console.log(prod_id);
	    		$.each(prod_id, function(key2, val){
	    			index++;
	    			usluga += val['usluga']*1;
	    			realizacja += val['realizacja']*1;
	    			zgodnosc += val['zgodnosc']*1;
	    			cena += val['cena']*1;
	    		});
	    		usluga /= index;
	    		vrealizacja /= index;
	    		zgodnosc /= index;
	    		cena /= index;
				console.log(key+" - "+index);
				dane.push([key, usluga, realizacja, zgodnosc, cena]);
	    		//,['"#001"', 1000, 400, 200, 50]
    		});//each
			console.log(dane);
			
	    	var data = google.visualization.arrayToDataTable(dane);

	        var options = {
	          chart: {
	            title: 'Company Performance',
	            subtitle: 'Sales, Expenses, and Profit: 2014-2017',
	          }
	        };

	        var chart = new google.charts.Bar(document.getElementById('chart'));

	        chart.draw(data, google.charts.Bar.convertOptions(options));
    	});//getJSON
      }
});//jq