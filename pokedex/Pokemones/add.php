<?php


require_once '../layout/layout.php';
require_once '../helpers/utilities.php';
require_once '../helpers/FileHandler/IFileHandler.php';
require_once '../helpers/FileHandler/SerializationFileHandler.php';
require_once '../helpers/FileHandler/JsonFileHandler.php';
require_once 'personaje.php';
require_once '../services\IServiceBase.php';
require_once 'CharacterService.php';
require_once '../Races/RaceService.php';

$layout = new Layout(true);
$utilities = new Utilities();
$service = new CharacterService("data","personajes");
$raceService = new RaceService();

if (isset($_POST['name']) && isset($_POST['characterType']) && isset($_POST['raceId']) && isset($_POST['techniques'])) {

    $techniques = explode(",", $_POST['techniques']);
    $newCharacter = new Character();

    $newCharacter->InitializeData($characterId, $_POST['name'], $_POST['characterType'], $_POST['raceId'], $techniques);

    $service->Add($newCharacter);

    header("Location: ../index.php"); 
    exit(); 
}

?>

<?php $layout->printHeader(); ?>

<main role="main">

    <div style="margin-top: 10%;margin-bottom: 5%;" class="card">
        <div class="card-header text-white bg-secondary">
        <img src="https://cdn.icon-icons.com/icons2/851/PNG/512/Pokedex_tool_icon-icons.com_67529.png" width="70" height="60"><strong>Registra un nuevo Pokemon</strong>
        </div>
        <div class="card-body">


            <form method="POST" action="add.php" enctype="multipart/form-data">

                <div class="col-md-4">
                    <div class="form-group">

                        <label for="InputName">Nombre</label>
                        <input type="text" name="name" class="form-control" id="InputName" placeholder="Introduzca el nombre ">

                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label for="characterTypeInput"> Tipo de Pokemon </label>
                        <select name="characterType" class="form-control" id="characterTypeInput">

                            <?php foreach ($utilities->characterTypeList as $id => $text) : ?>
                                <option value="<?php echo $id ?>"><?php echo $text ?></option>
                            <?php endforeach; ?>

                        </select>
                    </div>
                </div>


                <div class="col-md-4">
                    <div class="form-group">
                        <label for="raceInput"> Region </label>

                        <select name="raceId" class="form-control" id="raceInput">

                            <?php foreach ($raceService->GetList() as $race) : ?>
                                <option value="<?php echo $race->id ?>"><?php echo $race->name ?></option>
                            <?php endforeach; ?>

                        </select>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">

                        <label for="InputTechniques">Tecnicas</label>
                        <textarea name="techniques" class="form-control" id="InputTechniques" aria-describedby="TechniquesHelp" placeholder="Introduzca los Poderes "> </textarea>
                        <small id="TechniquesHelp" class="form-text text-muted">Colocar poderes separados por comas</small>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label for="characterPhoto">Foto del Pokemon</label>
                        <input type="file" name="profilePhoto" class="form-control-file" id="characterPhoto">
                    </div>
                </div>

                <button type="submit" class="btn btn-secondary"><i class="fa fa-plus-square"></i> Crear</button>
            </form>

        </div>
    </div>

</main>

<?php $layout->printFooter(); ?>