<?php
session_set_cookie_params(5184000, '/Homework2', 'localhost' , false, true);
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'Enter';
include './includes/header.php';
require './includes/globals.php';
$noSuchUserErr = "hidden";
$emptyFieldErr = "hidden";

if (isset($_SESSION['isLogged']) && $_SESSION['isLogged'] == true) {
    header('Location: messages.php?selectedCat=9&dateSort=desc');
    exit;
}
else {
        if ($_POST) {  
        $username = mysqli_real_escape_string($connection, trim($_POST['username']));
        $username = htmlentities($username);
        $pass = mysqli_real_escape_string($connection, trim($_POST['password']));
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
            $checkForUserQuery = mysqli_query($connection, 'SELECT user_name, password FROM users WHERE user_name="'.$username.'" AND password="'.$pass.'"');
         
            if (!$checkForUserQuery->num_rows>0) {           
                $noSuchUserErr = 'visible';
            } 
            else {
                $_SESSION['isLogged']=true;
                $_SESSION['username']=$username;
                header('Location: messages.php');
                exit;
            }
        }
    else {
        $errorLogVisibility = 'visible';
    }
    }
}
?>
<div class="login-container">
    <form method="POST" name="login-form">
        <input type="text" name="username" placeholder="Username"/>
        <input type="password" name="password" placeholder="Password"/>
        <div id="submit-btn-div">
        <input type="submit" value="" name="form-submit" id="submit-btn"/>
        </div>
        <div id="register"><a href='register.php'>Регистрация</a></div>
    </form>    
</div>
<div class="login-error" style="visibility:<?php echo $emptyFieldErr; ?>" >
    Please fill all the fields
</div>
<div class="login-error" style="visibility:<?php echo $noSuchUserErr; ?>" >
    Wrong username or password!
</div>
<?php
include './includes/footer.php';
?>