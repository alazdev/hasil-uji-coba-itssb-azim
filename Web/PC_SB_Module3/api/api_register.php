<?php
    require_once('../config/connection.php');
    if(isset($_POST['firstname']) && isset($_POST['lastname']) && isset($_POST['username']) && isset($_POST['password'])){
        $username = $_POST['firstname'];
        $password = $_POST['lastname'];
        $password = $_POST['username'];
        $password = $_POST['password'];
    }else{
        http_response_code(404);
    }
?>