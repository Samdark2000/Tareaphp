<?php

include 'Diseño\header.php';
include 'Diseño\footer.php';
include 'necessary\utilities.php';

session_start();
$_SESSION['estudiantes'] = isset($_SESSION['estudiantes']) ? $_SESSION['estudiantes'] : array(); 

$listadoEstudiantes = $_SESSION['estudiantes'];
if (!empty($listadoEstudiantes)) {
    if (isset($_GET['companyId'])) { 
        $listadoEstudiantes = searchProperty($listadoEstudiantes, 'companyId', $_GET['companyId']); 
    }
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Estudiante</title>
</head>

<body>

    <?php printHeader(); ?>

    <main role="main">

        <section class="jumbotron text-center">
            <div class="container">
                <h1 class="jumbotron-heading">Estudiantes</h1>
                <p class="lead text-muted">Listado de Estudiantes</p>
                <p>
                    <a href="Estudiantes/add.php?page=true" class="btn btn-success my-2"><i class="fa fa-plus-square"></i> Agregar un Estudiante Nuevo</a>
                </p>
            </div>
        </section>

        <div class="album py-5 bg-light">
            <div class="container">

                <div class="row">
                    <div class="col-md-9"></div>

                    <div class="col-md-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <a href="tarea3.php?companyId=1" class="btn btn-success">Activos</a>

                            <a href="tarea3.php?companyId=2" class="btn btn-danger">Inactivos</a>
                            

                        </div>
                    </div>
                </div>

                <div class="row">

                    <?php if (empty($listadoEstudiantes)) : ?>

                        <h2>Estudiante no estan registrado, <a href="Estudiantes/add.php?page=true" class="btn btn-success my-2"><i class="fa fa-plus-square"></i> Agregar Estudiante Nuevo</a> </h2>

                    <?php else : ?>

                        <?php foreach ($listadoEstudiantes as $estudiante) : ?>

                            <div class="col-md-4">
                                <div class="card mb-4 shadow-sm">
                                    <svg class="bd-placeholder-img card-img-top" width="100%" height="50" xmlns="http://www.w3.org/2000/svg" preserveAspectRatio="xMidYMid slice" focusable="false" role="img" aria-label="Placeholder: Estudiantes">
                                        <title>Inform</title>
                                        <rect width="100%" height="100%" fill="blue"></rect><text x="50%" y="50%" fill="#eceeef" dy=".3em">Estudiante</text>
                                    </svg>
                                    <div class="card-body">
                                        <p class="card-text"><strong> <?php echo $estudiante['name'];  ?> </strong></p>
                                   
                                        

                                        <div class="d-flex justify-content-between align-items-center">
                                            <div class="btn-group">
                                                <a href="Estudiantes/edit.php?page=true&id=<?php echo $estudiante['id'] ?>" class="btn btn-sm btn-outline-Success">Edit</a>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>

                        <?php endforeach; ?>
                    <?php endif; ?>
                </div>
            </div>
    </main>

    <?php printFooter(); ?>

</body>

</html>