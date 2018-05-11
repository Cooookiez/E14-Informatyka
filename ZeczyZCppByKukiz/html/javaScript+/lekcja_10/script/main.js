
$(function(){
    //animacja ptak 1
    $('#ptak1').stop().animate({
    	top: 50,
    	left: 1300,
    	height: 300
    }, 3500);

    //ainmcja motorówka
    $('#motorowka').stop().animate({
    	left: 350
    },1000, function(){
    	$(this).stop().animate({
    	top: 150
	    },1000, function(){
	    	$(this).stop().animate({
	    		left: 800
			},1000,function(){
				$(this).stop().animate({
					top: 300
				}, 1000, function(){
					$(this).stop().animate({
						left: 1300
					},1000);
				});
			});
		});
	});
	//end animacja motoowka
});