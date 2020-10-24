<?php
    require_once('../config/connection.php');
    if(isset($_POST['username']) && isset($_POST['password'])){
        $username = $_POST['username'];
        $password = $_POST['password'];

        //
    }else{
        http_response_code(404);
    }
?>