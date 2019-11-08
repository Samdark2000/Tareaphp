<?php

class Layout{    

   private $isPage; 
   private $directory; 

function __construct($page)
   {
       $this->isPage = $page;
       $this->directory = ($this->isPage) ? "../" : "";
   }

function printFooter(){

 $footer = <<< EOF
<script type="text/javascript" src="{$this->directory}assets\js\plugin\jquery\jquery.js"></script>
<script type="text/javascript" src="{$this->directory}assets\js\bootstrap.bundle.js"></script>
<script type="text/javascript" src="{$this->directory}assets\js\bootstrap.js"></script>
<link rel="stylesheet" type="text/css" href="{$this->directory}assets\css\bootstrap-grid.css">
<link rel="stylesheet" type="text/css" href="{$this->directory}assets\css\bootstrap-reboot.css">
<link rel="stylesheet" type="text/css" href="{$this->directory}assets\css\bootstrap.css">
<link rel="stylesheet" type="text/css" href="{$this->directory}assets\css\sticky-footer.css">

<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

</body>

</html>
EOF;

    echo $footer;
}


function printHeader(){
    $header = <<< EOF
    <!DOCTYPE html>
    <html lang="en">
    
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Pokedex</title>
    </head>
    
    <body class="d-flex flex-column h-100">
    
    <header>
    <!-- Fixed navbar -->
    <nav class="navbar navbar-light" style="background-color: #e3f2fd;">
      <a class="navbar-brand" href="{$this->directory}index.php" > <img src="https://camo.githubusercontent.com/1a4b11888ddf9f2b7a9353d6b69503e634e8704c/68747470733a2f2f692e696d6775722e636f6d2f415975745a4f462e706e67" width="250" height="60"> </a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarCollapse">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item">
            <a class="nav-link" href="{$this->directory}Pokemones/add.php"><img src="https://cdn.icon-icons.com/icons2/851/PNG/512/Pokedex_tool_icon-icons.com_67529.png" width="70" height="60"><strong>Agregar</strong> <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="{$this->directory}Races/list.php"><img src="https://media.moddb.com/cache/images/games/1/59/58753/thumb_620x2000/MapPromotional.png"  width="100" height="60"><strong>Region</strong></a>
          </li>     
        </ul>   
      </div>
    </nav>
    </header>
EOF;

    echo $header;
}


}
