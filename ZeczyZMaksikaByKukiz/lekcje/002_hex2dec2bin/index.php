<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	<style type="text/css">
	body,
	input{
		font-size: 48px;
	}
	label{
		display: inline-block;
		width: 150px;
	}
	</style>
	<script src="../../../scripts/jq.js"></script>
	<script type="text/javascript">
		$(function(){
			$('#hex2dec2bin input').keyup(function(){
				var thisNumberType = $(this).attr('id');
				var thisNumberValue = $(this).val();
				var num;
				switch(thisNumberType){
					case 'hex':
						num = parseInt(thisNumberValue, 16);
						if(num){
							$('#hex2dec2bin input#dec').val(num.toString(10));
							$('#hex2dec2bin input#bin').val(num.toString(2));
						}else{
							$('#hex2dec2bin input#dec').val('');
							$('#hex2dec2bin input#bin').val('');
						}
						break;
					case 'dec':
						num = parseInt(thisNumberValue, 10);
						if(num){
							$('#hex2dec2bin input#hex').val(num.toString(16).toUpperCase());
							$('#hex2dec2bin input#bin').val(num.toString(2));
						}else{
							$('#hex2dec2bin input#hex').val('');
							$('#hex2dec2bin input#bin').val('');
						}
						break;
					case 'bin':
						num = parseInt(thisNumberValue, 2);
						if(num){
							$('#hex2dec2bin input#hex').val(num.toString(16).toUpperCase());
							$('#hex2dec2bin input#dec').val(num.toString(10));
						}else{
							$('#hex2dec2bin input#hex').val('');
							$('#hex2dec2bin input#dec').val('');
						}
						break;
				}
			});
		});//jq
	</script>
</head>
<body>
	<form id="hex2dec2bin">
		<div>
			<label for="hex">Hex</label>
			<input id="hex" type="text" placeholder="0" pattern="[0-9a-fA-F]{1,}">
		</div>
		<div>
			<label for="dec">Dec</label>
			<input id="dec" type="text" placeholder="0" pattern="[0-9]{1,}">
		</div>
		<div>
			<label for="bin">Bin</label>
			<input id="bin" type="text" placeholder="0" pattern="[0-1]{1,}">
		</div>
	</form>
</body>
</html>