<?php
	// kalau di web hosting
	$con = mysqli_connect("localhost","id5119757_unity","unity","id5119757_unity");

	// kalau di lokal
	// $con=mysqli_connect("localhost","root","","fitness");

	if (mysqli_connect_errno($con)) {
		echo "Failed to connect to MySQL: ".mysqli_connect_error();
	}

    //hapus data-data dari tabel;
    $query = "DELETE FROM highscore";
    if(!mysqli_query($con, $query)) {
        $response = array(
            "message" => "error in deleting table",
        );

        echo json_encode($response);
    } else {
        //mulai lagi auto increment dari1
        $query = "ALTER TABLE highscore AUTO_INCREMENT = 1";
        if (!mysqli_query($con, $query)) {
            $response = array(
                "messages" => "error in setting auto increment",
            );

            echo json_encode($response);
        } else {
            $response = array(
                "message" => "success",
            );

            echo json_encode($response);
        }
        
    }
    mysqli_close($con);
