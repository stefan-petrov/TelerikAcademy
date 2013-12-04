<?php
session_set_cookie_params(5184000, '/Homework2', 'localhost' , false, true);
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'Enter';
include './includes/header.php';
$noSuchUserErr = "hidden";
$emptyFieldErr = "hidden";

if (isset($_SESSION['isLogged']) && $_SESSION['isLogged'] == true) {
    header('Location: files.php');
    exit;
}
else {
        if ($_POST) {
        $username = trim($_POST['username']);
        filter_var($username, FILTER_SANITIZE_SPECIAL_CHARS);
        $pass = trim($_POST['password']);
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
            if (file_exists('users.txt')) {
                $result =  file('users.txt');

                foreach ($result as $value) {
                    $userData = explode('@', $value);                            
                    
                    if (trim($userData[0])==$username && trim($userData[1]) == $pass) {             
                        $_SESSION['isLogged'] = true;
                        $_SESSION['username'] = $username;
                        header('Location: files.php');
                        exit;
                    }
                }
                $noSuchUserErr = 'visible';
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
    <p>Please fill all the fields</p>
</div>
<div class="login-error" style="visibility:<?php echo $noSuchUserErr; ?>" >
    No such user
</div>
<?php
include './includes/footer.php';
?>