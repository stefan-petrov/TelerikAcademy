<?php
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'Files';
include './includes/header.php';
$recordSuccesfulMsg = 'hidden';
if ($_POST) {    
    $username = trim($_POST['username']);
    $username = str_replace('@', '', $username);
    filter_var($username, FILTER_SANITIZE_SPECIAL_CHARS);
    $pass = trim($_POST['password']);
    $pass = str_replace('@', '', $pass);
    $error = false;
    $errorsArr;
    if (mb_strlen($username) <= 3 ) {
        $error = true;
        $errorsArr['errorUsername'] = 'Username is too short';
    }
    else if (mb_strlen($username) >= 205) {
        $error = true;
        $errorsArr['errorUsername'] = 'Username is too long';
    }
    if (mb_strlen($pass) <=4 ) {
        $error = true;
        $errorsArr['errorPassword'] = 'Password is too short';
    }
    else if (mb_strlen($pass) > 15 ) {
        $error = true;
        $errorsArr['errorPassword'] = 'Password is too long';
    }
    if (!$error) {
        $result = $username.'@'.$pass."\n";
        if(file_put_contents('users.txt', $result, FILE_APPEND))
        {
           header('Location: index.php');
           exit;
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
