var timeAnime2 = 400;

$(function(){
	reklama();
	social();
	pepeToTopRight();
});

function reklama(){
	$('#showaj').click(function(){
		//$(this).parent().animate({right: -innerWidth}, 400);
		$(this).parent().animate({'right':-innerWidth}, 400);
	});
}


function social(){
	$('#wysun').mouseenter(function(){
		$(this).parent().stop().animate({left: 0},400);
	});
	$('#social').mouseleave(function(){
		$(this).stop().animate({left: -50},400);
	});
}


var width2 = innerWidth - 275;
var height2 = innerHeight - 275;
function pepeToTopRight(){
	$('#pepe').click(function(){
		$(this).stop().animate({
			top: 25,
			left: width2
		},timeAnime2);
		pepeToBottomRight();
	});
}
function pepeToBottomRight(){
	$('#pepe').click(function(){
		$(this).stop().animate({
			top: height2,
			left: width2
		},timeAnime2);
		pepeToBottomLeft();
	});
}
function pepeToBottomLeft(){
	$('#pepe').click(function(){
		$(this).stop().animate({
			top: height2,
			left: 25
		},timeAnime2);
		pepeToTopLeft();
	});
	
}
function pepeToTopLeft(){
	$('#pepe').click(function(){
		$(this).stop().animate({
			top: 25,
			left: 25
		},timeAnime2);
		pepeToTopRight();
	});
}