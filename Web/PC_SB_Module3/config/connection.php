<?php
    
    try {
        define('HOST','localhost');
        define('USER','root');
        define('PASS','');
        define('DB','pc_sb');
        $conn = new mysqli(HOST, USER, PASS, DB) or die('Connection ERROR');
    } catch (Exception $ex) {
        echo "<script>alert('Connection ERROR')</script>";
    }
?>