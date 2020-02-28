 <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <script
  src="https://code.jquery.com/jquery-3.4.1.js"
  integrity="sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU="
  crossorigin="anonymous"></script>
    <title>signup</title>
</head>
<style>
input[type=text], input[type=password] {
  width:25%;
  padding: 5px;
  margin: 2px 0 2px 0;
  border: solid;
  background: #f1f1f1;
}
#btnlogin{
  background-color: #4CAF50;
  color: white;
  padding: 16px 20px;
  margin: 8px 0;
  border: none;
}


div {
  border-radius: 5px;
  background-color: #f2f2f2;
  padding: 20px;
}
</style>
<body>
<div>
<h1><b>SIGNUP</b></h1>
<b>Name:<b><input type="text"  name="txtName" id="name" required/><br><br>
<b>User Name:<b><input type="text"  name="txtUserName" id="uname" required/><br><br>
<b>password:<b><input type="password" name="txtPassword" id="pass" required/><br><br>
<b>ConfirmPassword:<b><input type="password" name="txtConPassword" id="cpass" required/><br><br>
<input type="button" name="btnSubmit" value="SIGNUP" id="btnlogin">
</div>
<script>
var n,u,p,cp;
$(document).ready(function(){
  $("#btnlogin").click(function(){
    n=$("#name").val();
    u=$("#uname").val();
    p=$("#pass").val();
    cp=$("#cpass").val();
    if(cp!=p)
    {
      alert("Password is incorrect");
    }
    else{
    let obj1={name:n,username:u,pass:p};
    console.log(obj1);
    var ajaxcall={
      type:"POST",
      dataType:"json",
      url:"signupApi.php",
      data:obj1,
      success:successFun,
      error:OnError
    }
    $.ajax(ajaxcall);
      }
    });
    function successFun(res){
       if(res == 'success'){
         window.location.href="login.php";
        console.log(res);
       }
       else if(res=="error"){
         alert("invalid username");
       }
       console.log(res);
    }
    function OnError(res){
       if(res=="success"){
         window.location.href="login.php";
       }
       else if(res=="error"){
         alert("invalid")
       }
      console.log(res);
    }
});
</script>
</body>
</html>