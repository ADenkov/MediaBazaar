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
function buttonlogout(){
	setcookie("loggedin","false");
	header('Location: index.php');	
	}
?>
<!doctype html>
<html>
<head>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <meta charset="utf-8"/>
    <title>Calendar</title>
    <link rel="stylesheet" type='text/css' href='./themes/standard.css'/>
    <link rel="stylesheet" href="MBstyle.css">
  </head>


<img src=topfixeddashboard.png alt=menu style="position: fixed; top: 0px; right: 0px;" >
<img src=imageleftfixed.png alt=menu style="position: fixed; top: 0px; left: 0px;" >
<a href="MBprofile.php">
<img src=pagebuttonprofile.png class=profilebutton style="position: fixed; top: 0px; left: 0px;">
<a href="MBDashboard.php">
<img src=pagebuttondashboardhover.png class=profilebutton style="position: fixed; top: 237px; left: 0px;">
<a href="MBinventory.php">
<img src=pagebuttoninventory.png class=profilebutton style="position: fixed; top: 340px; left: 0px;">
<a href="MBannouncements.php">
<img src=pagebuttonannouncements.png class=profilebutton style="position: fixed; top: 443px; left: 0px;">
</a>



<body>
<div id="content" style="top:60px; bottom:24px;">
      <div style="position: absolute; width: 800px; height: 600px";>
        <div id="calendar" style="height: 100%; width:100%"></div>
      </div>
    </div>

    <script data-main="JS/main.js" src="JS/require.js"></script>


<?php echo $string; ?>

</body>
</html>