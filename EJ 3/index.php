<?php
include 'conexion.php';

$pdo = new Conexion();

//Listar registros y consultar registro

//GET
//http://localhost/examen%20324/3er%20p/EJ%203/micro/


if ($_SERVER['REQUEST_METHOD'] == 'GET') {
	if (isset($_GET["id"])) {
		$sqlp = "SELECT * FROM alumno WHERE id=:id";
		$sql = $pdo->prepare($sqlp);
		$sql->bindValue(':id', $_GET["id"]);
		$sql->execute();
		$sql->setFetchMode(PDO::FETCH_ASSOC);
		echo json_encode($sql->fetchAll());
		header("HTTP/1.1 200 HAY DATOS");
		exit;
	} else {
		$sqlp = "SELECT * FROM alumno";
		$sql = $pdo->prepare($sqlp);
		$sql->execute();
		$sql->setFetchMode(PDO::FETCH_ASSOC);
		echo json_encode($sql->fetchAll());
		header("HTTP/1.1 200 HAY DATOS");
		exit;
	}
}

//Insertar registro
//POST
//http://localhost/examen%20324/3er%20p/EJ%203/micro/?nombre=marco&paterno=mamani&materno=guitierrez&matricula=3564&email=marcoo@gmail.com


if ($_SERVER['REQUEST_METHOD'] == 'POST') {
	$sqlp = "INSERT INTO alumno (nombre, paterno, materno, matricula, email) VALUES(:nombre,:paterno,:materno,:matricula,:email)";
	$sql = $pdo->prepare($sqlp);
	$sql->bindValue(':nombre', $_GET["nombre"]);
	$sql->bindValue(':paterno', $_GET["paterno"]);
	$sql->bindValue(':materno', $_GET["materno"]);
	$sql->bindValue(':matricula', $_GET["matricula"]);
	$sql->bindValue(':email', $_GET["email"]);
	$sql->execute();
	$idPost = $pdo->lastInsertId();

	if($idPost){
		header("HTTP/1.1 200 ejecucion correcta");
		echo json_encode('REGISTRO AGREGADO EXITOSAMENTE');
		echo json_encode($idPost);
		exit;
	}else{
		header("HTTP/1.1 400 PETICION ERRONEA");
		exit;
	}
}

//Actualizar registro
//PUT
//http://localhost/examen%20324/3er%20p/EJ%203/micro/?id=24&nombre=jorge&paterno=patt&materno=martt&matricula=54678&email=uno@gmail.com


if ($_SERVER['REQUEST_METHOD'] == 'PUT') {
	$sqlp = "UPDATE alumno SET nombre=:nombre, paterno=:paterno, materno=:materno, matricula=:matricula, email=:email WHERE id=:id";
	$sql = $pdo->prepare($sqlp);
	$sql->bindValue(':id', $_GET["id"]);
	$sql->bindValue(':nombre', $_GET["nombre"]);
	$sql->bindValue(':paterno', $_GET["paterno"]);
	$sql->bindValue(':materno', $_GET["materno"]);
	$sql->bindValue(':matricula', $_GET["matricula"]);
	$sql->bindValue(':email', $_GET["email"]);
	$sql->execute();
	echo json_encode('REGISTRO ACTUALIZADO CON EXITO');
	header("HTTP/1.1 200 EJECUCION CORRECTA");
	exit;
}


//Eliminar registro
//DELETE
//http://localhost/examen%20324/3er%20p/EJ%203/micro/?id=24


if ($_SERVER['REQUEST_METHOD'] == 'DELETE') {
	$sqlp = "DELETE FROM alumno WHERE id=:id";
	$sql = $pdo->prepare($sqlp);
	$sql->bindValue(':id', $_GET["id"]);
	$sql->execute();
	echo json_encode('REGISTRO ELIMINADO CON EXITO');
	header("HTTP/1.1 200 EJECUCION CORRECTA");
	exit;
}

header("HTTP/1.1 400 PETICION ERRONEA");
