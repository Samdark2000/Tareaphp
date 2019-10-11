<?php
if( $_POST["submit"] ){
    foreach($_POST as $campo => $valor) {
        $_SESSION['formulariototal'][$campo] = $valor;
    }
}



if( $_POST["submit"] ){
    foreach($_POST as $campo => $valor) {
        $_SESSION['formulariototal'][$campo] = $valor;
    }
}



/* var_dump($_SESSION['formulariototal']);*/
echo $_SESSION['formulariototal']['nombres'];
echo $_SESSION['formulariototal']['email'];
echo $_SESSION['formulariototal']['password'];
?>



<html>
<head></head>
<body>
    


<form method="post" action="">
    <input type="text" name="nombres" placeholder="Nombre" />
    <input type="text" name="email" placeholder="Email" />
    <input type="password" name="password" placeholder="Password" />
    <input name="submit" type="submit" value="Enviar Formulario" />
</form>




</body>

</html>