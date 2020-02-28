<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h1>HOME<h1>
    <?php
    
    if(isset($_SESSION["user"])==FALSE){
        header('Location:login.php')
    }
    
    
    
    
    ?>
</body>
</html>