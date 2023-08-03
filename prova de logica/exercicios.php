<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
        <!-- Questão 1 -->
    <form action="" method="Post">
        <div class="p-1">
            <input name="codigoP1" type="text" placeholder="Codigo peça 1">
            <input name="qtdP1" type="text" placeholder="numero de peças 1">
            <input name="vnP1" type="text" placeholder="valor unitario da peça 1">
        </div>

        <div class="p-2">
            <input name="codigoP2" type="text" placeholder="Codigo peça 2">
            <input name="qtdP2" type="text" placeholder="numero de peças 2">
            <input name="vnP2" type="text" placeholder="valor unitario da peça 2">
        </div>

        <input type="submit">

    </form>

    <?php
    
    $codigoP1 = $_POST['codigoP1'];
    $qtdP1 = $_POST['qtdP1'];
    $vnP1 = $_POST['vnP1'];

    $codigoP2 = $_POST['codigoP2'];
    $qtdP2 = $_POST['qtdP2'];
    $vnP2 = $_POST['vnP2'];

    echo "Valor a pagar: " . ($qtdP1 * $vnP1) + ($qtdP2 * $vnP2);

    ?>

    
        <!-- questão 2 -->

        <!-- <form action="" method="Post">
        
        <input name="raio" type="text" placeholder="Raio do circulo">

        <input type="submit">

    </form>

    <?php
    
    $raio = $_POST['raio'];

    $area = number_format(pi(), 5) * ($raio * $raio);

    echo number_format($area, 4);
    
    ?>

    
        questão3
    
    <form action="" method="Post">
        
    <input name="item" type="text" placeholder="Codigo do item">
    <input name="qtd" type="text" placeholder="Quantidade">

        <input type="submit">

    </form>

    <?php

    $item = $_POST['item'];
    $qtd = $_POST['qtd'];

    if($item == 1){
        echo 4 * $qtd;
    }else if($item == 2){
        echo 4.50 * $qtd;
    }else if($item == 3){
        echo 5 * $qtd;
    } else if($item == 4){
        echo 2 * $qtd;
    }else{
        echo 1.50 * $qtd;
    }

    ?>    
    
        questão 4
    
    <form action="" method="Post">
        
    <input name="a" type="text" placeholder="valor de a">
    <input name="b" type="text" placeholder="valor de b">
    <input name="c" type="text" placeholder="valor de c">

        <input type="submit">

    </form>

    <?php
    
    $a = $_POST['a'];
    $b = $_POST['b'];
    $c = $_POST['c'];

    if($a != 0){

        $delta = ($b * $b) - (4 * $a * $c);

        if($delta < 0 ){
            echo "Impossivel calcular";
        }else{            
            $x1 = (-$b + sqrt($delta)) / (2 * $a);
            $x2 = (-$b - sqrt($delta)) / (2 * $a);

            echo number_format($x1, 5) . '<br />' . number_format($x2, 5);
        }
    }else {
        echo "impossivel calcular";
    }
    
    ?>


    <?php
    // questão 5
    $senhatenta = rand(2000, 3000);
    $senhaResposta = 2100;
    while ($senhatenta != $senhaResposta){
    $senhatenta = rand(2000, 2100);
        if($senhatenta != $senhaResposta){echo $senhatenta . " Senha incorreta <br />";}
        else{echo $senhatenta . " Senha correta!!";}
    }

    ?>

    <?php
    $n = 10;
    $senhatenta = rand(0, 20);
    $in = 0;
    $out = 0;

    for($i = 0; $i != $n; $i++){
        if($senhatenta <= 10){
            $in+= 1;
            echo $senhatenta . "<br />";
        }else{
            $out+= 1;
            echo $senhatenta . "<br />";
        }
        $senhatenta = rand(0, 20);
    }

    echo 'in: ' . $in . '<br /> out: ' . $out;

    ?> -->




</body>
</html>