<?php

require_once '../helpers/utilities.php';
require_once 'race.php';
require_once '../services\IServiceBase.php';
require_once 'RaceService.php';

$service = new RaceService();


$containId = isset($_GET['id']);
$raceId = 0;


if ($containId) {
    $raceId = $_GET['id'];  
    $service->Delete($raceId);

}

 header("Location: list.php"); 
 exit(); 

?>