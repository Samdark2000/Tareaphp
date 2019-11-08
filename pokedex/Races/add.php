<?php


require_once '../layout/layout.php';
require_once '../helpers/utilities.php';
require_once 'race.php';
require_once '../services\IServiceBase.php';
require_once 'RaceService.php';

$layout = new Layout(true);
$utilities = new Utilities();
$service = new RaceService();


if (isset($_POST['name'])) {

  
    $newRace = new Race();

    $newRace->InitializeData(0, $_POST['name']);

    $service->Add($newRace);

    header("Location: list.php"); 
    exit(); 
}

?>

<?php $layout->printHeader(); ?>

<main role="main">

    <div style="margin-top: 10%;margin-bottom: 5%;" class="card">
        <div class="card-header text-white bg-secondary">
        <img src="https://media.moddb.com/cache/images/games/1/59/58753/thumb_620x2000/MapPromotional.png"  width="100" height="60"><strong>Registra una nueva Region</strong>
        </div>
        <div class="card-body">


            <form method="POST" action="add.php" enctype="multipart/form-data">

                <div class="col-md-4">
                    <div class="form-group">

                        <label for="InputName">Nombre</label>
                        <input type="text" name="name" class="form-control" id="InputName" placeholder="Introduzca el nombre ">

                    </div>
                </div>    

                <button type="submit" class="btn btn-secondary"><i class="fa fa-plus-square"></i> Crear</button>
            </form>

        </div>
    </div>

</main>

<?php $layout->printFooter(); ?>