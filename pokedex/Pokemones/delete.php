<?php
//incluimos los archivos php que estaremos utilizando
require_once '../helpers/utilities.php';
require_once 'personaje.php';
require_once '../services\IServiceBase.php';
require_once '../helpers/FileHandler/IFileHandler.php';
require_once '../helpers/FileHandler/SerializationFileHandler.php';
require_once '../helpers/FileHandler/JsonFileHandler.php';
require_once 'CharacterService.php';

$service = new CharacterService("data","personajes");


$containId = isset($_GET['id']); 
$characterId = 0;


if ($containId) {
    $characterId = $_GET['id'];    
    $service->Delete($characterId);

}

 header("Location: ../index.php"); 
 exit(); 
?>