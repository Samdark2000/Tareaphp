<?php

$directory = (isset($_GET['page'])) ? "../" : "";

$footer = <<<S

<script type="text/javascript" src="{$directory}styles\js\plugin\jquery\jquery.js"></script>
<script type="text/javascript" src="{$directory}styles\js\bootstrap.bundle.js"></script>
<script type="text/javascript" src="{$directory}styles\js\bootstrap.js"></script>
<link rel="stylesheet" type="text/css" href="{$directory}styles\css\bootstrap-grid.css">
<link rel="stylesheet" type="text/css" href="{$directory}styles\css\bootstrap-reboot.css">
<link rel="stylesheet" type="text/css" href="{$directory}styles\css\bootstrap.css">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
S;

function printFooter(){
    echo $GLOBALS['footer'];
}