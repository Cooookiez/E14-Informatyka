<?php
if(
    isset($_GET['p']) &&
    isset($_GET['w']) &&
    $_GET['p'] != "" &&
    $_GET['w'] != ""
){
    $p = (int)$_GET['p'];
    $w = (int)$_GET['w'];
    if($w>0){
        if($p == 0) $wynik = "Wynik działania wynosi: 1";
        else $wynik = "Wynik działania wynosi: ".pow($p,$w);
    }else $wynik = "wykładnik musi być dodatni.";
}else $wynik = "Wpisz podstawę i wykładnik potęgi.";

?>
<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>index.html</title>
    <style>
    #box{
        width: 600px;
        margin: 50px auto;
    }
    #banner{
        height: 75px;
        margin-bottom: 20px;
    }
    #banner img{
        max-height: 100%;
        max-width: 100%;
    }
    #panel{
        float: left;
        margin-right: 10px;
        width: 110px;
    }
    #tresc{
        float: left;
        width: calc(100% - 110px - 10px);
    }
    </style>
    <script>
        
    </script>
</head>
<body>
    <div id="box">
        <div id="banner"><a href="."><img src="baner.jpg" alt="baner"></a></div>
        <div id="panel">
            Menu<br>
            <a href="strona1.html">Proste działania</a><br>
            <a href="strona2.php">Potęgowanie</a>
        </div>
        <form id="tresc" action="" method="get">
            <h1>POTĘGOWANIE</h1>
            <label for="liczba1">Podaj podstawę potęgi: <input type="number" id="podstawa" name="p" value="<?php echo @ $p; ?>"></label><br>
            <label for="liczba2">Podaj dodani, całkowity wykłdnik potęgi: <input type="number" id="wykladnik" name="w" value="<?php echo @ $w; ?>"></label><br>
            <input type="submit" value="POTĘGOWANIE">
            <br>
            <p id="wynik"><?php echo $wynik; ?></p>
        </form>
    </div>
</body>
</html>