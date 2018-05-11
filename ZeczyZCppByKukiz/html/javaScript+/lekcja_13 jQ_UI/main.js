$(function(){

    $(function() {
        $( ".draggable" ).draggable();
    });

    $( "#sortable" ).sortable({
      revert: true
    });
    $( "#dialog-confirm" ).dialog({
          autoOpen: false,
          resizable: false,
          height: 223,
          modal: true,
          buttons: {
            "Przenieś mnie!": function() {
              $( this ).dialog( "open" );
            },
            "Nope": function() {
              $( this ).dialog( "close" );
            }
          }
        });



    $('a').click(function() {

        $( "#dialog-confirm" ).dialog({
          autoOpen: true,
          resizable: false,
          height: 323,
          modal: true,
          buttons: {
            "Przenieś mnie!": function() {
                window.open("http://www.wp.pl/");
              $( this ).dialog( "close" );
            },
            "Nope": function() {
              $( this ).dialog( "close" );
            }
          }
        });

    });




});





    