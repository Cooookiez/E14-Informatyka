<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	<style type="text/css">
	    * {
	            box-sizing: border-box;
	    }
	    #dane{
	            width: 60%;
	            margin: 0 auto;
	    }
	    fieldset {
	            padding: 20px;
	            width: 800px;
	            margin: 0 auto;
	            text-align: center;
	    }
	    textarea {
	            width: 100%;
	    }

	    .column input {
	            width: 100%;
	    }
	    .main {
	            width: 80%;
	            margin: 0 auto;
	    }
	    .column {
	            width: 20%;
	            float: left;
	    }
	    .preview {
	            width: 50%;
	            float: left;
	            margin: 0 5%;
	    }

	    #text-podglad{
	            width: 100%;
	            padding: 20px;
	            border: 1px solid #CCC;
	            min-height: 150px;
	            background-color: black;
	            color: white;
	    }

	    .clear {
	            clear: both;
	    }
	</style>
	<script src="../../../scripts/jq.js"></script>
	<script type="text/javascript">
		$(function(){
			$('input').keyup(function(){
				var bg_r = $('#text-bg-r').val();
					bg_r = bg_r ? bg_r:0;
				var bg_g = $('#text-bg-g').val();
					bg_g = bg_g ? bg_g:0;
				var bg_b = $('#text-bg-b').val();
					bg_b = bg_b ? bg_b:0;

				var co_r = $('#text-color-r').val();
					co_r = co_r ? co_r:0;
				var co_g = $('#text-color-g').val();
					co_g = co_g ? co_g:0;
				var co_b = $('#text-color-b').val();
					co_b = co_b ? co_b:0;

				var text = $('#text-val').val();

				$('#text-podglad')
				.text(text)
				.css({
					"background-color": "rgb("+bg_r+","+bg_g+","+bg_b+")",
					"color": "rgb("+co_r+","+co_g+","+co_b+")"
				});
			});
		});//jq
	</script>
</head>
<body>

    <fieldset>
            <legend>Konwerter kolorków</legend>
            <label for="text-val">Tekst</label>
            <input id="text-val" name="tekst" type="text" placeholder="Wpisz text">
            <div class="main">
                    <div class="column column-left">
                            <p>Tlo</p>
                            <p>
                                <label for="text-bg-r">R</label>
                                <input id="text-bg-r" type="number" min="0" max="255" placeholder="0-255" value="0">
                            </p>    
                            <p>
                                <label for="text-bg-g">G</label>
                                <input id="text-bg-g" type="number" min="0" max="255" placeholder="0-255" value="0">
                            </p>
                            <p>
                                <label for="text-bg-b">B</label>
                                <input id="text-bg-b" type="number" min="0" max="255" placeholder="0-255" value="0">
                            </p>
                    </div>
                    <div class="preview">
                            <p>Podglad</p>
                            <div id="text-podglad"></div>
                    </div>
                    <div class="column column-right">
                            <p>Tekst</p>
                            <p>
                                <label for="text-color-r">R</label>
                                <input id="text-color-r" type="number" min="0" max="255" placeholder="0-255" value="255">
                            </p>    
                            <p>
                                <label for="text-color-g">G</label>
                                <input id="text-color-g" type="number" min="0" max="255" placeholder="0-255" value="255">
                            </p>
                            <p>
                                <label for="text-color-b">B</label>
                                <input id="text-color-b" type="number" min="0" max="255" placeholder="0-255" value="255">
                            </p>
                    </div>                          
            </div>
    </fieldset>

</body>
</html>