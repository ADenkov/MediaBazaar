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
<img src=productlist.png>
<br>
<a href="MBstocks.php">
<img src=buttonstocks.png class=stocksbutton> </a>
<br>
  Store Location: 
  <?php echo $_COOKIE["mysto"]; ?> 
  
  <br><br> 
Search Products:

<form method="post">
<input type="text" id="searchbar" name="searchbar" value="search"style="width: 500;">
  <select class="custom-select" name="searchfield">
    <option value="0">Product_ID</option>
    <option value="1">Department</option>
    <option value="2">Serial</option>
    <option value="3">Brand</option>
    <option value="4">Name</option>
    <option value="5">Description</option>
    <option value="6">Price</option>
	<option value="7">Discount_Index</option>
	<option value="8">Condition</option>
	<option value="9">Date_Added</option>
  </select> 
		<input type="submit" name="buttonsearch" class="button" value="search" />  
		<input type="submit" name="buttoncancelsearch" class="button" value="cancel" /> 
        <input type="submit" name="buttonprevious" class="button" value="<<" />          
        <input type="submit" name="buttonnext" class="button" value=">>" /> 
</form>  
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
	

	    if(array_key_exists('buttonnext', $_POST)) { 
            buttonnext(); 
        } 
        else if(array_key_exists('buttonprevious', $_POST)) { 
            buttonprevious(); 
        } 
		else if(array_key_exists('buttonsearch', $_POST)) { 
            buttonsearch(); 
        } 
		else if(array_key_exists('buttoncancelsearch', $_POST)) { 
            buttoncancelsearch(); 
        }
		else {}		
		
function buttonsearch() {	
if(isset($_COOKIE["row"])){}
else{
setcookie("row","0");	
}
setcookie("searching","true");
$searchvalue = $_POST["searchbar"];
setcookie("searchvalue","$searchvalue");
$searchfield = $_POST["searchfield"];
setcookie("searchfield","$searchfield");
display();
}

function buttoncancelsearch() {
if(isset($_COOKIE["row"])){}
else{
setcookie("row","0");	
}
setcookie("searching","false");	
display();
}	
			
function buttonnext() {
if(isset($_COOKIE["row"])){
$row1 = $_COOKIE["row"] + 5;
setcookie("row","$row1");	
}
else{
setcookie("row","4");	
}
display();
}
        	
function buttonprevious() { 	
if(isset($_COOKIE["row"])){
$row1 = $_COOKIE["row"] - 5;
if($row1 < 0){$row1 = 0;}
setcookie("row","$row1");	
}
else{
setcookie("row","0");
}
display();
}

function display() {
	$username = 'admin';
	$password = 'admin';
    $conn = new PDO("sqlsrv:Server=89.157.247.62;Database=Media Bazaar", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	$row1 = $_COOKIE["row"];
	$row2 = $_COOKIE["row"] + 5;
	$store = $_COOKIE["mysto"];
	
if(isset($_COOKIE["searching"])){
	if($_COOKIE["searching"] == 'true'){
	if($_COOKIE["searchfield"] == 0){$field = "Product_ID";}	
	else if($_COOKIE["searchfield"] == 1){$field = "Department";}
	else if($_COOKIE["searchfield"] == 2){$field = "Serial";}
	else if($_COOKIE["searchfield"] == 3){$field = "Brand";}
	else if($_COOKIE["searchfield"] == 4){$field = "Name";}
	else if($_COOKIE["searchfield"] == 5){$field = "Description";}
	else if($_COOKIE["searchfield"] == 6){$field = "Price";}
	else if($_COOKIE["searchfield"] == 7){$field = "Discount_Index";}
	else if($_COOKIE["searchfield"] == 8){$field = "Condition";}
	else{$field = "Date_Added";}
	$searchvalue = $_COOKIE["searchvalue"];
	$query1 = "SELECT  Product_ID, Department, Serial, Brand, Name, Description, Price, Discount_Index, Condition, Date_Added FROM( SELECT  *, ROW_NUMBER() OVER (ORDER BY Product_ID) AS rn FROM InventoryData ) q WHERE rn > $row1 AND rn < $row2 AND Store_Address = '$store' AND $field = '$searchvalue' ORDER BY Product_ID;";
	}
	else{
		$query1 = "SELECT Product_ID, Department, Serial, Brand, Name, Description, Price, Discount_Index, Condition, Date_Added FROM( SELECT  *, ROW_NUMBER() OVER (ORDER BY Product_ID) AS rn FROM InventoryData ) q WHERE rn > $row1 AND rn < $row2 AND Store_Address = '$store' ORDER BY Product_ID;";  
	}
}
else{
	$query1 = "SELECT Product_ID, Department, Serial, Brand, Name, Description, Price, Discount_Index, Condition, Date_Added FROM( SELECT  *, ROW_NUMBER() OVER (ORDER BY Product_ID) AS rn FROM InventoryData ) q WHERE rn > $row1 AND rn < $row2 AND Store_Address = '$store' ORDER BY Product_ID;";  	
}


try{
	$data = $conn->query($query1);
	echo '<table class="table table-striped" width="100%" border="1" cellpadding="1" cellspacing="1">
	<tr><th>Product_ID</th><th>Department</th><th>Serial</th><th>Brand</th><th>Name</th><th>Description</th><th>Price</th><th>Discount_Index</th><th>Condition</th><th>Date_Added</th></tr>';	
	foreach($data as $row){
		echo '<tr>
		<td>'.$row["Product_ID"].'</td>
		<td>'.$row["Department"].'</td>
		<td>'.$row["Serial"].'</td>
		<td>'.$row["Brand"].'</td>
		<td>'.$row["Name"].'</td>
		<td>'.$row["Description"].'</td>
		<td>'.$row["Price"].'</td>
		<td>'.$row["Discount_Index"].'</td>
		<td>'.$row["Condition"].'</td>
		<td>'.$row["Date_Added"].'</td>
		</tr>';
	}	
	echo '</table>';
	}
catch(Exception $e){echo "no rows found";}	    
	}	
 	
$conn = null;	
?>

</body>



</html>