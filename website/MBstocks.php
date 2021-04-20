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
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">


<img src=topfixedinventory.png alt=menu style="position: fixed; top: 0px; right: 0px;" >
<img src=imageleftfixed.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<a href="MBprofile.php">
<img src=pagebuttonprofile.png class=profilebutton style="position: fixed; top: 0px; left: 0px;">
<a href="MBDashboard.php">
<img src=pagebuttondashboard.png class=profilebutton style="position: fixed; top: 237px; left: 0px;">
<a href="MBinventory.php">
<img src=pagebuttoninventoryhover.png class=profilebutton style="position: fixed; top: 340px; left: 0px;">
<a href="MBannouncements.php">



<img src=pagebuttonannouncements.png class=profilebutton style="position: fixed; top: 443px; left: 0px;">
</a>
<head>
<form method="post">
<input type="submit" name="buttonlogout" style="width: 200; position: fixed; bottom: 10px; left: 85px;" value="Log out" /> 
</form>
<img src=orderstocks.png>
<br>
 
</head>

<body>

<?php if(array_key_exists('buttonlogout', $_POST)) { 
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
	$query1 = "SELECT * FROM OrderData;";
	
	$data = $conn->query($query1);
	echo '<table class="table table-striped w-auto" width="20%" border="1" cellpadding="1" cellspacing="1"  style="margin-left: 230px;">
	<tr><th>Order_ID</th><th>Product_ID</th><th>Product_Name</th><th>Quantity</th><th>Unit_Price</th></tr>';	
	foreach($data as $row){
		echo '<tr>
		<td>'.$row["Order_ID"].'</td>
		<td>'.$row["Product_ID"].'</td>
		<td>'.$row["Product_Name"].'</td>
		<td>'.$row["Quantity"].'</td>
		<td>'.$row["Unit_Price"].'</td>
		</tr>';
	}	
	echo '</table>';
}	
catch(Exception $e){echo "no rows found";}	    
	
 	
$conn = null;	
?>

</body>



</html>