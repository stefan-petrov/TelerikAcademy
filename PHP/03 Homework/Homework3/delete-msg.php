<?php
session_start();
require './includes/globals.php';
if (isset($_GET['msgID'])) {
    if (isset($_SESSION['username']) && $_SESSION['username']=='admin') {
        $delMsgQuery = mysqli_query($connection, 'DELETE FROM messages WHERE msg_id='.$_GET['msgID'].';');
        if ($delMsgQuery) {
            header('Location: messages.php?selectedCat=9&dateSort=desc');
            exit;
        }
    }   
}

?>
