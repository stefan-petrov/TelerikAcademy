<?php
require './includes/globals.php';
$pageTitle = 'Register';
include './includes/header.php';
$recordSuccesfulMsg = 'hidden';
if ($_POST) { 
    $username = mysqli_real_escape_string($connection, trim($_POST['username']));
    $username = htmlentities($username);
    $pass = mysqli_real_escape_string($connection, trim($_POST['password']));
    $pass = htmlentities($pass);
    $error = false;
    $thereIsSameAccount = false;
    $errorsArr;
    if (mb_strlen($username) <= 2 ) {
        $error = true;
        $errorsArr['errorUsername'] = 'Username is too short';
    }
    else if (mb_strlen($username) >= 25) {
        $error = true;
        $errorsArr['errorUsername'] = 'Username is too long';
    }
    if (mb_strlen($pass) <=2 ) {
        $error = true;
        $errorsArr['errorPassword'] = 'Password is too short';
    }
    else if (mb_strlen($pass) > 15 ) {
        $error = true;
        $errorsArr['errorPassword'] = 'Password is too long';
    }
    if (!$error) {        
        $searchForSameUserQuery = mysqli_query($connection, 'SELECT user_name FROM users WHERE user_name="'.$username.'"');
        if ($searchForSameUserQuery->num_rows > 0) {  
            $errorsArr['errorSameUserExist'] = 'This Username exists.Please type another.';
        }
        else {     
            $insertQuery = mysqli_query($connection, 'INSERT INTO users (user_name, password) VALUES ("'.$username.'", "'.$pass.'")');
            
            if ($insertQuery) {
                $_SESSION['isLogged']=true;
                $_SESSION['username'] = $username;
                header('Location: index.php');
                exit;
            }
        }
    }
    else {
        $errorLogVisibility = 'visible';
        
    }
    }
?>
<div class="login-container">
    <form method="POST" name="register-form">
        <input type="text" name="username" placeholder="Username"/>
        <input type="password" name="password" placeholder="Password"/>
        <input id="register-btn" type="submit" name="form-submit" value="" />
    </form>    
</div>
<div id="error-log" visibility="'<?php echo $errorLogVisibility;?>'">
<?php
   if (isset($errorsArr)) {
       foreach ($errorsArr as $value) {
       echo '<div>'.$value.'</div>';
   }
}
?>
</div>
<?php
include './includes/footer.php';
?>
