<?php
for( $i = 0; $i < 10; $i++ )
{
   $liczby[$i] = rand( 1, 50 );
}
 
$elementow = count( $liczby );
 
for( $i = 0; $i < $elementow; $i++ )
{
   for( $j = 0; $j < $elementow; $j++ )
   {
	   if( $liczby[$j] < $liczby[$j+1] )
	   {
		   $tmp = $liczby[$j];
		   $liczby[$j] = $liczby[$j+1];
		   $liczby[$j+1] = $tmp;
	   }
	}
}
?>