<?php
$serverName="localhost";
$userName="root";
$password="";
$dbname="neymar";
$conn= mysqli_connect($serverName,$userName,$password,$dbname);
if(!$conn){
    die("connection failed: ".mysqli_connect_error());
}
?>