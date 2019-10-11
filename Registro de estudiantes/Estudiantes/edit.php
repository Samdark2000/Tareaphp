<?php


include '../Diseño\header.php';
include '../Diseño\footer.php';
include '../necessary\utilities.php';

session_start();


$estudiante = $_SESSION['estudiantes'];

$containId = isset($_GET['id']); 

$element = [];

if ($containId) {

    $element = searchProperty($estudiante, 'id', $_GET['id'])[0]; 
    $elementTarea3 = getTarea3Element($estudiante, 'id', $_GET['id']); 

    $selectedCompanyActivo = ($element['companyId'] == 1) ? "selected" : "";
    $selectedCompanyInactivo = ($element['companyId'] == 2) ? "selected" : ""; 
}

if (isset($_POST['name']) && isset($_POST['companyId'])) { 

    $updateEstudiantes = ['id' => $_GET['id'], 'name' => $_POST['name'], 'companyId' => $_POST['companyId']]; 

    $estudiante[$elementTarea3] =  $updateEstudiantes;

    $_SESSION['estudiantes'] = $estudiante; 

    header("Location: ../tarea3.php"); 
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Informacion</title>
</head>

<body>

    <?php printHeader(); ?>

    <main role="main">

        <?php if ($containId && !empty($element)) : ?>

            <div class="card">
                <div class="card-header">
                    <a href="../tarea3.php" class="btn btn-info"><i class="fa fa-arrow-left"></i> Volver atras </a> Editando a los estudiantes <?php echo $element['name'] ?>
                </div>
                <div class="card-body">

                    <form method="POST" action="edit.php?id=<?php echo $element["id"] ?>">

                        <div class="col-md-4">
                            <div class="form-group">

                                <label for="InputName">Nombre</label>
                                <input type="text" value="<?php echo $element['name'] ?>" name="name" class="form-control" id="InputName" placeholder="Introduzca su nombre ">
                                <label for="InputLastName">Apellido</label>
                                <input type="text" value="<?php echo $element['lastname'] ?>" name="lastname" class="form-control" id="InputLastName" placeholder="Introduzca su apellido ">
                                
                                <label for="InputCarrera"> Status </label>
                                <select  value="<?php echo $element['carrera'] ?>" name="carrera" class="form-control" id="InputCarrera">
                                <option value="1">Redes</option>
                                <option value="2">Software</option>
                                <option value="3">Multimedia</option>
                                <option value="4">Mecatronica</option>
                                <option value="5"> Seguridad informática</option>

                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="company"> Status </label>
                                <select name="companyId" class="form-control" id="company">
                                    <option <?php echo $selectedCompanyActivo; ?> value="1">Activos</option>
                                    <option <?php echo $selectedCompanyInactivo; ?> value="2">Inactivos</option>

                                    

                                </select>
                            </div>
                        </div>

                        <button type="submit" class="btn btn-primary"> Guardar</button>
                    </form>

                </div>
            </div>

        <?php else : ?>

            <h2>No existe</h2>

        <?php endif; ?>

    </main>

    <?php printFooter(); ?>

</body>

</html>