<?php
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'New Message';
include './includes/header.php';
require './includes/globals.php';
$messageSentLog = 'hidden';
$messageNotSentLog = 'hidden';
$fieldsDataLengthErr = 'hidden';
$error = false;
if (!(isset($_SESSION['isLogged']) && $_SESSION['isLogged'] == true)) {
    header('Location: index.php');
    exit;
}
else {
    if ($_POST) {
       $msgTitle = mysqli_real_escape_string($connection, trim($_POST['msg-title']));
       $msgTitle = htmlentities($msgTitle);      
       $msgData = mysqli_real_escape_string($connection, trim($_POST['msg-data']));
       $msgData = htmlentities($msgData);
       $categoryId = (int)$_POST['category'];
       
       if (mb_strlen($msgTitle) > 50 || mb_strlen($msgTitle) < 1) {
           $error = true;
       }
       if (mb_strlen($msgData) > 250 || mb_strlen($msgData) < 1) {
           $error = true;         
       }
          
       if (!$error) {
           $sendMsgQuery = mysqli_query($connection, 'INSERT INTO messages (user_name, msg_title, msg_data, category_id, date) VALUES ("'.$_SESSION['username'].'", "'.$msgTitle.'", "'.$msgData.mb_strlen($msgData).'", '.$categoryId.', NOW())');
           if ($sendMsgQuery) {
               header('Location: messages.php?selectedCat=9&dateSort=desc');
               exit;
           }   
       }
       else {
           $messageNotSentLog = 'visible';
           if ($error) {
               $fieldsDataLengthErr = 'visible';
           }
       }
    }
}
?>
<div id="logout-btn"><a href="destroy.php">Изход</a></div>
<form method="POST" id="new-msg-form">
    <div>Заглавие:</div><input type="text" name="msg-title">
    <div>Текст:</div><textarea maxlength="251" name="msg-data"></textarea>
    <div class="category-div">
        <select name="category">
        <?php
            foreach ($categories as $key=>$value) {
                if ($key==9) {
                    continue;
                }
                echo '<option value="'.$key.'">'.$value.'</option>';
            }
        ?>
        </select>
    </div>
    <input type="submit" name="submit-msg-btn" value="Изпрати">
    <div id="msg-sent" style="visibility: <?php echo $messageSentLog;?>">Message successfuly sent</div>
<div id="msg-not-sent" style="visibility: <?php echo $messageNotSentLog;?>">Message not sent</div>
<div id="fields-data-length" style="visibility: <?php echo $fieldsDataLengthErr;?>">Check fields' content length</div>
</form>

<?php
include './includes/footer.php';
?>
