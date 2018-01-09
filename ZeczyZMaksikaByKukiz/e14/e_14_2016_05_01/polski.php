<?php
if($connect = @ mysqli_connect('localhost', 'root', '', 'szkola')){

        //scriptL
        $sql = "SELECT imie, nazwisko FROM `uczen`;";
        $scriptL = '';
        if($result = mysqli_query($connect, $sql)){
            while($t = mysqli_fetch_assoc($result)){
                $imie = $t['imie'];
                $nazwisko = $t['nazwisko'];
                $scriptL.= "<li>$imie $nazwisko</li>";
            }
        }else echo 'Błąd L';

        //scriptR1
        $sql = "SELECT imie, nazwisko FROM `uczen` WHERE id = 2";
        if($result = mysqli_query($connect, $sql)){
            while($t = mysqli_fetch_assoc($result)){
                $scriptR1 = $t['imie']." ".$t['nazwisko'];
            }
        }else echo 'Błąd R1';

        //scriptR2
        $sql = "SELECT avg(ocena) ocena_avg FROM `ocena` where uczen_id = 2 AND przedmiot_id = 1";
        if($result = mysqli_query($connect, $sql)){
            while($t = mysqli_fetch_assoc($result)){
                $scriptR2 = $t['ocena_avg'];
            }
        }else echo 'Błąd R2';

    mysqli_close($connect);
}else echo 'Błąd 1';
?>
<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Szkoła Ponadgimnazjalna</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <div id="baner"><h1>Oceny uczniów: język polski</h1></div>
    <div id="panelL">
        <h2>Lista uczniów: </h2>
        <ol>
            <?php echo $scriptL;?>
        </ol>
    </div>
    <div id="panelR">
        <h2>Uczeń: <?php echo $scriptR1;?></h2>
        <p>Średnia ocen z języka polskiego: <?php echo $scriptR2;?></p>
    </div>
    <div id="stopka">
        <h3>Zespół Szkół Ponadgimnazjalnych</h3>
        <p>Strone opracował: 00000000000</p>
    </div>
</body>
</html>