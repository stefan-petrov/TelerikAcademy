<?php 
session_start();
session_destroy();
if (isset($_GET['url'])) {
    if (isset($_GET['book_id'])) {
        header('location: '.$_GET['url'].'.php?book_id='.$_GET['book_id'].'');
    }
    header('location: '.$_GET['url'].'.php');
}
else {
     header('location: index.php');
}

?>
