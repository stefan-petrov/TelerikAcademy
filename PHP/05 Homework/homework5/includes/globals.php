<?php
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$connection = mysqli_connect('localhost', 'test_user', 'test56', 'homework5');
mysqli_query($connection, 'SET NAMES utf8');

function checkForPostLogin ($conn) {
    if ($_POST) {  
        $username = mysqli_real_escape_string($conn, trim($_POST['username']));
        $username = htmlentities($username);
        $pass = mysqli_real_escape_string($conn, trim($_POST['password']));
        $pass = htmlentities($pass);
        $error = false;
        
        if ($username == '') {
            $error = true;
            $emptyFieldErr = "visible";
        }
        if ($pass == '') {
            $error = true;
            $emptyFieldErr = "visible";
        }
        
        if (!$error) {           
            $checkForUserQuery = mysqli_query($conn, 'SELECT user_name, password FROM users WHERE user_name="'.$username.'" AND password="'.$pass.'"');
         
            if (!$checkForUserQuery->num_rows>0) {           
                $noSuchUserErr = 'visible';
            } 
            else {
                $_SESSION['logged']=true;
                $_SESSION['username']=$username;               
            }
        }
    }
    else {
        $errorLogVisibility = 'visible';
    } 
}
?>