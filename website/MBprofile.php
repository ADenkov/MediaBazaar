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
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

<link rel="stylesheet" href="MBstyle.css">
<img src=topfixedprofile.png alt=menu style="position: fixed; top: 0px; right: 0px;" >
<img src=imageleftfixed.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<a href="MBprofile.php">
<img src=pagebuttonprofilehover.png class=profilebutton style="position: fixed; top: 0px; left: 0px;">
<a href="MBDashboard.php">
<img src=pagebuttondashboard.png class=profilebutton style="position: fixed; top: 237px; left: 0px;">
<a href="MBinventory.php">
<img src=pagebuttoninventory.png class=profilebutton style="position: fixed; top: 340px; left: 0px;">
<a href="MBannouncements.php">
<img src=pagebuttonannouncements.png class=profilebutton style="position: fixed; top: 443px; left: 0px;">
</a>
<form method="post">
<input type="submit" name="buttonlogout" style="width: 200; position: fixed; bottom: 10px; left: 85px;" value="Log out" /> 
</form>

<?php if(array_key_exists('buttonlogout', $_POST)) { 
    buttonlogout(); 
}
else{}	
	function buttonlogout(){
	setcookie("loggedin","false");
	header('Location: index.php');	
	}
?>
<header>
<link rel="stylesheet" href="css/MBstyle.css">
<img src=companyinformation.png> <br>
Your general information. To change your info, contact Media Bazaar HR. <br><br>

<b>Current adress: </b><?php echo $_COOKIE["myadd"]; ?> <br><br>
<b>Store address: </b><?php echo $_COOKIE["mysto"]; ?> <br><br>
<b>Working since: </b><?php echo $_COOKIE["myjoi"]; ?> <br><br>
<b>Hours worked: </b><?php echo $_COOKIE["myhou"]; ?> <br><br>
<b>Empoyee ID: </b><?php echo $_COOKIE["myid"]; ?> <br><br><br>

<img src=accountsettings.png> <br>
Your Personal contact information.<br><br>

<b>Your e-mail: </b><?php echo $_COOKIE["myema"]; ?> <br><br>
<b>Your BSN: </b><?php echo $_COOKIE["mybsn"]; ?> <br><br>
<b>Your Phone Number: </b><?php echo $_COOKIE["mypho"]; ?> <br><br>

</header>
<body>
<link rel="stylesheet" href="css/MBstyle.css">

</body>

</html>