<?php
$serverName="localhost";
$userName="root";
$password="";
$dbname="neymar";
$conn= mysqli_connect($serverName,$userName,$password,$dbname);
if(!$conn)
    die("connection failed: ".mysqli_connect_error());
$query="SELECT * FROM  folder where parentFolderId = 0";
$result=mysqli_query($conn,$query);
$result = mysqli_fetch_all($result);
echo json_encode($result);
?>