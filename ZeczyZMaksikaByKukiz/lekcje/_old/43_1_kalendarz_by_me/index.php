<?php

?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>d</title>
	<link rel="stylesheet" type="text/css" href="screen.css">
	<link rel="stylesheet" href="css/fontello.css">
	<link rel="stylesheet" href="jquery-ui.min.css">
	<link rel="stylesheet" href="jquery-ui.theme.min.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
	<script src="jquery-ui.min.js"></script>
	<script>
		var year 	= <?php echo date('Y') ?>;
		var month 	= <?php echo date('m') ?>;
		var day 	= <?php echo date('d') ?>;

		$(function(){
			get_calender();
			get_notes();

			$('body')
			.delegate('#prev_month', 'click', function(){
				month--;
				if(month <= 0){
					year--;
					month = 12;
				}
				get_calender();
			})
			.delegate('#next_month', 'click', function(){
				month++;
				if(month >= 13){
					year++;
					month = 1;
				}
				get_calender();
			})
			.delegate('#kalendarz > table > tbody > tr > td > span', 'click', function(){
				$('span.check').removeClass('check');
				$(this).addClass('check');
				day = parseInt($(this).text());
				get_notes();
			});

    var dialog, form,
 
      // From http://www.whatwg.org/specs/web-apps/current-work/multipage/states-of-the-type-attribute.html#e-mail-state-%28type=email%29
      name = $( "#name" ),
      email = $( "#email" ),
      password = $( "#password" ),
      allFields = $( [] ).add( name ).add( email ).add( password ),
      tips = $( ".validateTips" );
 
    function updateTips( t ) {
      tips
        .text( t )
        .addClass( "ui-state-highlight" );
      setTimeout(function() {
        tips.removeClass( "ui-state-highlight", 1500 );
      }, 500 );
    }
 
    function checkLength( o, n, min, max ) {
      if ( o.val().length > max || o.val().length < min ) {
        o.addClass( "ui-state-error" );
        updateTips( "Length of " + n + " must be between " +
          min + " and " + max + "." );
        return false;
      } else {
        return true;
      }
    }
 
    function checkRegexp( o, regexp, n ) {
      if ( !( regexp.test( o.val() ) ) ) {
        o.addClass( "ui-state-error" );
        updateTips( n );
        return false;
      } else {
        return true;
      }
    }
 
    function addUser() {
      var valid = true;
      allFields.removeClass( "ui-state-error" );
 
      valid = valid && checkLength( name, "username", 3, 16 );
      valid = valid && checkLength( email, "email", 6, 80 );
      valid = valid && checkLength( password, "password", 5, 16 );
 
      valid = valid && checkRegexp( name, /^[a-z]([0-9a-z_\s])+$/i, "Username may consist of a-z, 0-9, underscores, spaces and must begin with a letter." );
      valid = valid && checkRegexp( email, emailRegex, "eg. ui@jquery.com" );
      valid = valid && checkRegexp( password, /^([0-9a-zA-Z])+$/, "Password field only allow : a-z 0-9" );
 
      if ( valid ) {
        $( "#users tbody" ).append( "<tr>" +
          "<td>" + name.val() + "</td>" +
          "<td>" + email.val() + "</td>" +
          "<td>" + password.val() + "</td>" +
        "</tr>" );
        dialog.dialog( "close" );
      }
      return valid;
    }
 
    dialog = $( "#dialog-form" ).dialog({
      autoOpen: false,
      height: 400,
      width: 350,
      modal: true,
      buttons: {
        "Create an account": addUser,
        Cancel: function() {
          dialog.dialog( "close" );
        }
      },
      close: function() {
        form[ 0 ].reset();
        allFields.removeClass( "ui-state-error" );
      }
    });
 
    form = dialog.find( "form" ).on( "submit", function( event ) {
      event.preventDefault();
      addUser();
    });
 
    $( "#addNote" ).button().on( "click", function() {
      dialog.dialog( "open" );
    });

		});//jQ END

		function get_calender(){
			$.post('get_calender',{
				year: 	year,
				month: 	month
			}).done(function(calendar){
				$('#kalendarz').html(calendar);
			});
		}
		function get_notes(){
			$.post('get_note',{
				year: 	year,
				month: 	month,
				day: 	day
			}).done(function(notes){
				$('#notes').html(notes);
			});
		}
	</script>
</head>
<body>
<main class="">
	<div id="kalendarz"></div>
	<div id="notes">
		<div class="note">
			<header>Tytul</header>
			<article>tresc</article>
		</div>
		<div class="note">
			<header>Tytul 2</header>
			<article>tresc 2</article>
		</div>
	</div>
	<div id="addNote">Dodaj Notatke</div>
</main>
<!-- <div id="popup">
	<header>
		<h1>PopUp</h1>
		<div id="exit">X</div>
	</header>
	<article>
		<form>
			<label><span>Tytuł</span><input type="text" name="head"></label>
			<label><span>Treść</span><textarea name="tresc"></textarea></label>
			<input type="submit" value="Zapisz">
		</form>
	</article>
</div> -->

<div id="dialog-form" title="Create new user">
  <p class="validateTips">All form fields are required.</p>
 
  <form>
    <fieldset>
      <label for="newDate_h">Header</label>
      <input type="text" name="newDate_h" id="newDate_h" value="" class="text ui-widget-content ui-corner-all">
      <label for="newDate_t">Treść</label>
	  <textarea name="newDate_t" id="newDate_t" class="text ui-widget-content ui-corner-all" style="width: 100%;"></textarea>
 
      <!-- Allow form submission with keyboard without duplicating the dialog button -->
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
    </fieldset>
  </form>
</div>


</body>
</html>