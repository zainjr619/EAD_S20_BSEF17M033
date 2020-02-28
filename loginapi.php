<?php
session_start();
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
    $user=$_REQUEST["username"];
    $pass=$_REQUEST["pass"];
    $query="SELECT * FROM  user where username='$user' and password ='$pass'";
    $result=mysqli_query($conn,$query);
    $rowFound=mysqli_num_rows($result);
    if($rowFound > 0){
        $_SESSION["username"]=$user;
        echo ("success");
    }
    else
        { 
          echo ("invalid");
        }
}

?>