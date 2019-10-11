<?php

function getLastElement($list)
{
    $countList = count($list);
    $lastElement = $list[$countList - 1];

    return $lastElement;
}

function searchProperty($list, $property, $value)
{
    $filter = [];

    foreach ($list as $item) {

        if ($item[$property] == $value) {
            array_push($filter, $item);
        }
    }

    return $filter;
}

function getTarea3Element($list, $property, $value)
{
    $tarea3 = 0;
    $i = 0;
    foreach ($list as $item) {

        if ($item[$property] == $value) {
            $tarea3 = $i;
            break;
        }
        $i++;
    }
    return $tarea3;
}