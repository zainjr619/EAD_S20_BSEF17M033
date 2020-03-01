<?php
    session_start();
    if(isset($_SESSION["username"])==FALSE)
        header('Location:login.php');
        //echo($_SESSION["username"]);
    ?>
<!DOCTYPE html>
<html lang="en">
<head>
     <meta charset="UTF-8">
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <meta http-equiv="X-UA-Compatible" content="ie=edge">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
     <title>home</title>
</head>
<style>
.folder{
  background-color: whitesmoke;
  border:solid;
  width: 200px; 
  margin-bottom: 3px;
} 
</style>
<body>
<div id="fol">
</div>
<div class="container">
  <!-- Trigger the modal with a button -->
  <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal" >create folder</button>
  <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Please Enter Folder Name</h4>
         </div>
         <div class="modal-body">
          Name:<b><input type="text"  name="txtName" id="name" required/><br><br>
         </div>
         <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal" id="btn1">Enter</button>
        </div>
      </div>
    </div>
  </div>
</div>

<script>
var n;
$(document).ready(function(){
    console.log("loaded");
     $("#btn1").click(function(){
         console.log("fn");
         let n=$("#name").val();
         let obj1={name:n};
         console.log("obj1");
         var ajaxcall={
         type:"POST",
         dataType:"json",
         url:"homeApi.php",
         data:obj1,
         success:successFun,
         error:OnError
         }
      $.ajax(ajaxcall);
      });
     function successFun(res){
       console.log(res)
     }
     function OnError(res){
        console.log(res)
     } 
      
     var ajaxcal={
          type:"POST",
          dataType:"json",
          url:"displayhome.php",
          success:loadfolder,
          error: function(res){console.log(res.responseText);}
         }
        
         function loadfolder(res)
         {
             for(let i=0; i<res.length;i++)
             {
                 $("#fol").append("<div class='folder' id='"+res[i][0]+"' onclick='changecolor()'>"+res[i][1]+"</div>");
                    
             }
             

        }
        
        $.ajax(ajaxcal);



});
function changecolor()
{
    event.target.style.backgroundColor="blue";
}
</script>
</body>
</html>