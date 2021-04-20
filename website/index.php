<?php
session_start();
$string = 'hello world';
?>
<!doctype html>
<html>
<link rel="stylesheet" href="MBstyle.css">

<img src=topfixedprofile.png alt=menu style="position: fixed; top: 0px; right: 0px;" >
<img src=imageleftfixed.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<img src=pagebuttonprofilehover.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<img src=MBloginlogo.png alt=menu style="position: fixed; top: 180px; left: 600px;" >
<form method="post">
<input  class="input-group input-group-sm mb-3" type="text" id="username" name="username" value="Username"style="width: 200; position: fixed; bottom: 65px; left: 20px;">
<input  class="input-group input-group-sm mb-3"type="password" id="password" name="password" value="password"style="width: 200; position: fixed; bottom: 40px; left: 20px;">
<input type="submit" class="btn btn-primary" name="buttonlogin" style="width: 200; position: fixed; bottom: 10px; left: 20px;" value="Log in" /> 
</form>
<p>
<?php	
if(array_key_exists('buttonlogin', $_POST)) { 
    buttonlogin(); 
}
function buttonlogin() {	
	$givenuser = $_POST["username"];
	$givenpass = $_POST["password"];
	
	$username = 'admin';
	$password = 'admin';
    $conn = new PDO("sqlsrv:Server=89.157.247.62;Database=Media Bazaar", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	$query1 = "SELECT Employee_ID, First_Name, Last_Name, Gender, Email, BSN, Phone, Address, Password, Store_address, Date_Joined, Hours_Worked, Salary FROM EmployeeData WHERE Employee_ID = '$givenuser';";
	try{
	$data = $conn->query($query1);

	foreach($data as $row){
$readid = $row["Employee_ID"];
$readfir = $row["First_Name"];
$readlas = $row["Last_Name"];
$readgen = $row["Gender"];
$readema = $row["Email"];
$readbsn = $row["BSN"];
$readpho = $row["Phone"];
$readadd = $row["Address"];
$readpas = $row["Password"];
$readsto = $row["Store_address"];
$readjoi = $row["Date_Joined"];
$readhou = $row["Hours_Worked"];
$readsal = $row["Salary"];
	}
if(isset($readpas)){	
if($givenpass == $readpas)	{
setcookie("loggedin","true");
setcookie("myid","$readid");
setcookie("myfir","$readfir");
setcookie("mylas","$readlas");
setcookie("mygen","$readgen");
setcookie("myema","$readema");
setcookie("mybsn","$readbsn");
setcookie("mypho","$readpho");
setcookie("myadd","$readadd");
setcookie("mypas","$readpas");
setcookie("mysto","$readsto");
setcookie("myjoi","$readjoi");
setcookie("myhou","$readhou");
setcookie("mysal","$readsal");
if(isset($_COOKIE["myChangedPass"])){
header('Location: MBprofile.php');
}
else{header('Location: MBfirstLogin.php');}
}
else{
$returner = "incorrect password";	
}	
}
else{$returner = "no such user found";}
	}
catch(Exception $e){echo $e;}	    
	
echo $returner;
}
?>
</p>

</html>