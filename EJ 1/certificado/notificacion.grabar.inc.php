<?php
    session_start();
    include "conexion.inc.php";
    $usu = $_SESSION['usuario'];

    $sql = "UPDATE certificado SET estado ='Finalizado' WHERE usuario = '".$usu."'";
    mysqli_query($con, $sql);
?>