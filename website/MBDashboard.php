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

<img src=topfixeddashboard.png alt=menu style="position: fixed; top: 0px; right: 0px;" >
<img src=imageleftfixed.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<a href="MBprofile.php">
<img src=pagebuttonprofile.png class=profilebutton style="position: fixed; top: 0px; left: 0px;">
<a href="MBDashboard.php">
<img src=pagebuttondashboardhover.png class=profilebutton style="position: fixed; top: 237px; left: 0px;">
<a href="MBinventory.php">
<img src=pagebuttoninventory.png class=profilebutton style="position: fixed; top: 340px; left: 0px;">
<a href="MBannouncements.php">
<img src=pagebuttonannouncements.png class=profilebutton style="position: fixed; top: 443px; left: 0px;"> </a>
<form method="post">
<input  class="input-group input-group-sm mb-3" type="submit" name="buttonlogout" style="width: 200; position: fixed; bottom: 10px; left: 85px;" value="Log out" /> 
</form>
<header>
<b>Working Calendar.</b><br>
<a href="MBevents.php">
<img src=buttonevents.png class=eventsbutton> </a>
</header>
<body>
Here you can view all your scheduled work shifts.<br><br> <b>Your ID:</b> <?php echo $_COOKIE["myid"]; ?> <br>
Morning Shifts:
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
	
	$id = $_COOKIE["myid"];
	$query1 = "SELECT * FROM ScheduleData WHERE Morning = '$id' ORDER BY Day;";
	
	$data = $conn->query($query1);
	echo '<table class="table table-striped" width="30%" border="1" cellpadding="1" cellspacing="1">
	<tr><th>Day</th><th>Morning</th><th>Afternoon</th><th>Evening</th></tr>';	
	foreach($data as $row){
		echo '<tr>
		<td>'.$row["Day"].'</td>
		<td>'.$row["Morning"].'</td>
		<td>'.$row["Afternoon"].'</td>
		<td>'.$row["Evening"].'</td>
		</tr>';
	}	
	echo '</table>';
}	
catch(Exception $e){echo "no rows found";}	    
			
$conn = null;	
?>
<br> Afternoon Shifts: 
<?php
try{	
	$username = 'admin';
	$password = 'admin';
    $conn = new PDO("sqlsrv:Server=89.157.247.62;Database=Media Bazaar", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	$id = $_COOKIE["myid"];
	$query1 = "SELECT * FROM ScheduleData WHERE Afternoon = '$id' ORDER BY Day;";
	
	$data = $conn->query($query1);
	echo '<table  class="table table-striped" width="30%" border="1" cellpadding="1" cellspacing="1">
	<tr><th>Day</th><th>Morning</th><th>Afternoon</th><th>Evening</th></tr>';	
	foreach($data as $row){
		echo '<tr>
		<td>'.$row["Day"].'</td>
		<td>'.$row["Morning"].'</td>
		<td>'.$row["Afternoon"].'</td>
		<td>'.$row["Evening"].'</td>
		</tr>';
	}	
	echo '</table>';
}	
catch(Exception $e){echo "no rows found";}	    
			
$conn = null;
?>
<br> Evening Shifts: 
<?php
try{	
	$username = 'admin';
	$password = 'admin';
    $conn = new PDO("sqlsrv:Server=89.157.247.62;Database=Media Bazaar", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	$id = $_COOKIE["myid"];
	$query1 = "SELECT * FROM ScheduleData WHERE Evening = '$id' ORDER BY Day;";
	
	$data = $conn->query($query1);
	echo '<table class="table table-striped" width="30%" border="1" cellpadding="1" cellspacing="1">
	<tr><th>Day</th><th>Morning</th><th>Afternoon</th><th>Evening</th></tr>";

	</rt>';	
	foreach($data as $row){
		echo '<tr>
		<td>'.$row["Day"].'</td>
		<td>'.$row["Morning"].'</td>
		<td>'.$row["Afternoon"].'</td>
		<td>'.$row["Evening"].'</td>
		</tr>';
	}	
	echo '</table>';
}	
catch(Exception $e){echo $e;}	    
			
$conn = null;
?>
</body>
</html>