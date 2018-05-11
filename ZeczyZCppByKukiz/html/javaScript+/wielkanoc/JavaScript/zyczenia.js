$(function(){
	$('#logo_1').animate({opacity: 0},1000);
	setTimeout(function(){
		$('#logo_2').animate({opacity: 1},1000);
		setTimeout(function(){
			$('#logo_2').animate({height: 160, left: 10, top: 10},1000);
			setTimeout(function(){
				$('#zyczenia_1').animate({opacity: 1},1000);
			},1000);
			$('#zajacSkacz').animate({left:1000},7000);
		},1000);
	},1000);
})