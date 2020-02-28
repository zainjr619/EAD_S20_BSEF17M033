<?php
$serverName="localhost";
$userName="root";
$password="";
$dbname="neymar";
$conn= mysqli_connect($serverName,$userName,$password,$dbname);
if(!$conn){
    die("connection failed: ". mysqli_connect_error());
}
else
{
    $name=$_REQUEST["name"];
    $user=$_REQUEST["username"];
    $pass=$_REQUEST["pass"];
    $query="select username from user where username='$user'";
    $result=mysqli_query($conn,$query);
    $rowCount=mysqli_num_rows($result);
    if($rowCount > 0){
        echo json_encode("found");
    }
    else {
        $queryInsert="insert into user(username, password, name) values ('$user', '$pass', '$name')";
        $resultInsert=mysqli_query($conn,$queryInsert);
        if ($resultInsert === TRUE) {
            echo json_encode("success");
        }
        else {
            echo json_encode("notInserted");
        }
    }
}

?>