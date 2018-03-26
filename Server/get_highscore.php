<?php   
  // kalau di web hosting
  $con=mysqli_connect("localhost","id5119757_unity","unity","id5119757_unity");

  // kalau di lokal
  // $con=mysqli_connect("localhost","root","","fitness");
   if (mysqli_connect_errno($con)) {
      echo "Failed to connect to MySQL: " . mysqli_connect_error();
   }
	
   $result = mysqli_query($con, "SELECT nama, score FROM highscore ORDER BY score DESC LIMIT 10");

   while ($row = mysqli_fetch_assoc($result)) {
     $array[] = $row;
   }

   header('Content-Type:Application/json');
   
   echo json_encode($array);
 
   mysqli_free_result($result);
 
   mysqli_close($con);