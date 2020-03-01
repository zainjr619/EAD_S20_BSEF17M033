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
        $queryInsert="insert into folder (foldername,parentfolderId) values ('$name','0')";
        $resultInsert=mysqli_query($conn,$queryInsert);
        if ($resultInsert === TRUE) {
            echo json_encode("success");
        }
        else {
            echo json_encode("notInserted");
        }
    
}

?>