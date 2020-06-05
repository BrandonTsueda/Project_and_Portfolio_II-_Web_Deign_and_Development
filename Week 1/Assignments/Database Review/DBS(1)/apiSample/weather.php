<?php
/*
Description: 	Returns the weather for a city.
Inputs:	city
URL:	

http://localhost:8888/apiSample/weather.php

http://localhost:8888/apiSample/weather.php?city=Chicago

http://localhost:8888/apiSample/weather.php?city=Orlando
*/

// Connect to MySQL
$mysql_dsn = "mysql:host=127.0.0.1;port=8889;dbname=sampleAPIData;";
$mysql_user = "root";
$mysql_pass = "root";
$db = new \PDO($mysql_dsn, $mysql_user, $mysql_pass);
$output = array();

if ( !isset($_GET['city']) ){
	$output['success'] = 0;
	$output['msg'] = 'You must pass city as a valid url variable.';
} else {
	$SQL = "select createdDate, description, temp, pressure, humidity, temp_min, temp_max, windSpeed from weather where city = :city order by createdDate desc limit 1";
	
	$statement = $db->prepare($SQL);
	$statement->bindParam(':city', $_GET['city'], PDO::PARAM_STR);
	$statement->execute();
	$rows = $statement->fetchAll(\PDO::FETCH_ASSOC);

	if ( count($rows) == 1 ){
		$p = array();
		$p['description'] = $rows[0]['description'];
		$p['temp'] = $rows[0]['temp'];
		$p['pressure'] = $rows[0]['pressure'];
		$p['humidity'] = $rows[0]['humidity'];
		$p['temp_min'] = $rows[0]['temp_min'];
		$p['temp_max'] = $rows[0]['temp_max'];
		$p['windSpeed'] = $rows[0]['windSpeed'];
		
		$output['success'] = 1;
		$output['msg'] = '';
		$output['data'] = $p;

	} else {
		$output['success'] = 0;
		$output['msg'] = 'No data available';
	}	
}
// json_encode converts an array to JSon format
header('Cache-Control: no-cache, must-revalidate');
header('Content-type: application/json');
echo json_encode($output);
?>