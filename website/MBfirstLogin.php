<?php
session_start();
if(isset($_COOKIE["loggedin"])){
	$checker = $_COOKIE["loggedin"];
	if($checker == 'false'){
		buttonlogout();
	}
}
else{
	buttonlogout();
}
?>
<!doctype html>
<html>
<link rel="stylesheet" href="MBstyle.css">

<img src=topfixedprofile.png alt=menu style="position: fixed; top: 0px; right: 0px;" >
<img src=imageleftfixed.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<img src=pagebuttonprofilehover.png alt=menu style="position: fixed; top: 0px; left: 0px;" >

<form method="post" style="width: 200; position: fixed; bottom: 330px; left: 575px;">
Welcome to Media Bazaar, for your first log-in, please change your password.<br>
Old Password:<input  class="input-group input-group-sm mb-3" type="password" id="oldPassword" name="oldPassword" value=""style="width: 200; position: fixed; bottom: 365px; left: 700px;">
<br>New Passord:<input  class="input-group input-group-sm mb-3" type="password" id="newPassword" name="newPassword" value=""style="width: 200; position: fixed; bottom: 344px; left: 700px;">
<br>Confirm Password:<input type="password" id="confirmPassword" name="confirmPassword" value=""style="width: 200; position: fixed; bottom: 323px; left: 700px;">
<input   type="submit" name="buttonchange" style="width: 200; position: fixed; bottom: 298px; left: 700px;" value="Confirm" /> 
<input   type="submit" name="buttonskip" style="width: 200; position: fixed; bottom: 298px; left: 770px;" value="skip" /> 
</form>
<p>

<?php	
if(array_key_exists('buttonchange', $_POST)) { 
    buttonchange(); 
}
if(array_key_exists('buttonskip', $_POST)) { 
    buttonskip(); 
}

function buttonlogout(){
	setcookie("loggedin","false");
	header('Location: index.php');	
	}

function buttonskip (){
header('Location: MBprofile.php');	
}	

function buttonchange (){
	$myId = $_COOKIE["myid"];
	$realOld = $_COOKIE["mypas"];
	$givenOld = $_POST["oldPassword"];
	$givenNew = $_POST["newPassword"];
	$givenConfirm = $_POST["confirmPassword"];
	if ($givenOld == $realOld) {
	if ($givenNew == $givenConfirm){
	try{
	
$username = "admin";
$password = "admin";
$conn = new PDO("sqlsrv:Server=89.157.247.62;Database=Media Bazaar", $username, $password);
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
$sql = "UPDATE EmployeeData SET Password='$givenNew' WHERE Employee_ID='$myId'";
if ($conn->query($sql) == TRUE) {
  $returner =  "Record updated successfully";
  setcookie("myChangedPass","true");
	header('Location: MBprofile.php');	
} else {
  $returner = "Error updating record: " ;//. $conn->error;
}
$conn->close();

	
	//setcookie("myChangedPass","true");
	//header('Location: MBprofile.php');	
	}
	catch(Exception $e){echo $e;}
	$returner = "error";
	}	
	else{$returner = "Please enter the same password twice";}
	}
	else {$returner = "Incorrect old password.";}
	echo $returner;
}	

?>
</p>

</html>