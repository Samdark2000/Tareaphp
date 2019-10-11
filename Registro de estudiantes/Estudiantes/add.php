<?php

include '../Diseño\header.php';
include '../Diseño\footer.php';
include '../necessary\utilities.php';

session_start();

if(isset($_POST['name'] ) && isset($_POST['companyId'])){
    

    $estudiante = $_SESSION['estudiantes'];

    $estudianteId = 1;

    if(!empty($estudiante)){
        $lastElement = getLastElement($estudiante); 
        $estudianteId =  $lastElement["id"] + 1;
    }


    array_push($estudiante, ["id" => $estudianteId,"name" =>$_POST['name'],"companyId" => $_POST['companyId'] ]);
  

    $_SESSION['estudiantes'] = $estudiante;

    header("Location: ../tarea3.php");
    exit();
}

if(isset($_POST['lastname'] ) && isset($_POST['companyId'])){
    

    $estudiante = $_SESSION['estudiantes'];

    $estudianteId = 1;

    if(!empty($estudiante)){
        $lastElement = getLastElement($estudiante); 
        $estudianteId =  $lastElement["id"] + 1;
    }


    array_push($estudiante, ["id" => $estudianteId,"lastname" =>$_POST['lastname'],"companyId" => $_POST['companyId'] ]);
  

    $_SESSION['estudiantes'] = $estudiante;

    header("Location: ../tarea3.php");
    exit();
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

        <div class="card">
            <div class="card-header">
               <a href="../tarea3.php" class="btn btn-info"><i class="fa fa-arrow-left"></i> Volver atras </a> Registrando a un Estudiante
            </div>
            <div class="card-body">

                <form method="POST" action="add.php">

                    <div class="col-md-4">
                        <div class="form-group">

                            <label for="InputName">Nombre</label>
                            <input type="text" name="name" class="form-control" id="InputName" placeholder="Introduzca su nombre ">
                            <label for="InputLastName">Apellido</label>
                            <input type="text" name="name" class="form-control" id="InputLastName" placeholder="Introduzca su apellido ">
                            <label for="InputCarrera"> Carrera </label>
                            <select name="carrera" class="form-control" id="InputCarrera">
                                <option value="1">Redes</option>
                                <option value="2">Software</option>
                                <option value="3">Multimedia</option>
                                <option value="4">Mecatronica</option>
                                <option value="5"> Seguridad informática</option>

                         
                                
                            </select>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="form-group">
                            <label for="company"> Status </label>
                            <select name="companyId" class="form-control" id="company">
                                <option value="1">Activos</option>
                                <option value="2">Inactivos</option>


                                <div class="form-group row">
                              <div class="col-sm-2">Status</div>
                             <div class="col-sm-10">
                              <div class="form-check">
                            <input class="form-check-input" type="checkbox" id="company">
                              <label class="form-check-label" for="company">
                                Activos
                              </label>
                              <br/>
                              <input class="form-check-input" type="checkbox" id="company">
                              <label class="form-check-label" for="company">
                                Inactivos
                              </label>
                        
                               </div>
                              </div>
                             </div>
                                
                            </select>
                        </div>
                    </div>

                    <button type="submit" class="btn btn-primary"><i class="fa fa-plus-square"></i> Creando estudiantes</button>
                </form>

            </div>
        </div>

    </main>

    <?php printFooter(); ?>

</body>

</html>