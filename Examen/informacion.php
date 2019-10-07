<?php
$QuienSoy = $_POST["QuienSoy"];
$ExperienciaLaboral = $_POST["ExperienciaLaboral"];
$Estudios = $_POST["Estudios"];
$Habilidades = $_POST["Habilidades"];
$Idiomas = $_POST["Idiomas"];
$ReferenciasPersonales = $_POST["ReferenciasPersonales"];


?>

<!DOCTYPE htmal>
<html>

<head>  
       <title>Generador de curriculum </title>
</head>


<body background="l.jpg">

<br>
<br>
   <center><h1>Generador de curriculum</h1></center> 


         
         
         <center><h2> Datos Personal </h2></center> 

          <br>
          <br>
<center>
    <table>

           <tr>
           <td><strong>Quien Soy</strong></td>
            <td><strong>:</strong></td>
            <td> <strong> <?php echo $QuienSoy ?> </strong>   </td>
           
           </tr>

    </table>

    <br/>
    <br/>


    <table>
    
            <tr>
            <td> <strong>Experiencia laboral</strong>  </td>
            <td><strong>:</strong></td>
            <td>  <strong><?php echo $ExperienciaLaboral ?></strong>  </td>
           
           </tr>

    </table>

    <br/>
    <br/>


    <table>
    
    
    <tr>
    <td>  <strong>Estudios</strong> </td>
            <td><strong>:</strong></td>
            <td> <strong><?php echo $Estudios ?></strong>   </td>
           
           </tr>
    
    
         </table> 
         <br/>
         <br/>

           <table>
           
            <tr>
            <td>  <strong>Habilidades</strong>   </td>
            <td><strong>:</strong></td>
            <td>  <strong><?php echo $Habilidades ?></strong>  </td>
           
           </tr>

           </table>

           <br/>
           <br/>


           <table>
           
           <tr>
           <td>  <strong>Idiomas</strong> </td>
            <td><strong>:</strong></td>
            <td>  <strong><?php echo $Idiomas ?></strong>   </td>
            
           
           </tr>
           
           </table>

           <br/>
            <br/>

          
           <table > 

           </tr>
           <tr>
           <td><strong>Referencias Personales</strong></td>
            <td><strong>:</strong></td>
            <td >  <strong><?php echo $ReferenciasPersonales ?></strong>  </td>
           
           </tr>


           </table>

           
        </center>

</body>

</html>