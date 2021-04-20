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

<img src=topfixedannouncements.png alt=menu style="position: fixed; top: 0px; right: 0px;" >
<img src=imageleftfixed.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<a href="MBprofile.php">
<img src=pagebuttonprofile.png class=profilebutton style="position: fixed; top: 0px; left: 0px;">
<a href="MBDashboard.php">
<img src=pagebuttondashboard.png class=profilebutton style="position: fixed; top: 237px; left: 0px;">
<a href="MBinventory.php">
<img src=pagebuttoninventory.png class=profilebutton style="position: fixed; top: 340px; left: 0px;">
<a href="MBannouncements.php">
<img src=pagebuttonannouncementshover.png class=profilebutton style="position: fixed; top: 443px; left: 0px;"> </a>
<form method="post">
<input type="submit" name="buttonlogout" style="width: 200; position: fixed; bottom: 10px; left: 85px;" value="Log out" /> 
</form>

<header>
<img src=announcements.png><br>
  Here you can see all your announcements at your location. <br><br>
  <b>Store Location:</b>
  <?php echo $_COOKIE["mysto"]; ?> <br>
</header>


<?php 
if(array_key_exists('buttonlogout', $_POST)) { 
    buttonlogout(); 
}
else{}	
	function buttonlogout(){
	setcookie("loggedin","false");
	header('Location: index.php');	
	}
try{	
	$username = 'admin';
	$password = 'admin';
    $conn = new PDO("sqlsrv:Server=89.157.247.62;Database=Media Bazaar", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	$store = $_COOKIE["mysto"];
	$query1 = "SELECT * FROM AnnoucementData WHERE To_Store_Address = '$store' ORDER BY Message_Date;";
	
	$data = $conn->query($query1);
	echo '<table class="table table-striped" width="100%" border="1" cellpadding="1" cellspacing="1">
	<tr><th>From_Department</th><th>Message</th><th>Message_Date</th><th>Message_Date</th></tr>';	
	foreach($data as $row){
		echo '<tr>
		<td>'.$row["From_Department"].'</td>
		<td>'.$row["Message"].'</td>
		<td>'.$row["Message_Subject"].'</td>
		<td>'.$row["Message_Date"].'</td>
		</tr>';
	}	
	echo '</table>';
}	
catch(Exception $e){echo "no rows found";}	    
		
 	
$conn = null;
	
?>


</html>