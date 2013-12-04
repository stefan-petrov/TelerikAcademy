<?php
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'Messages';
include './includes/header.php';
require './includes/globals.php';
?>
<div id="new-msg-btn"><a href="new_message.php">Ново съобщение</a></div>
<div id="category-menu-div"><a href="messages.php?selectedCat=9&dateSort=<?php if(isset($_GET['dateSort'])) { echo $_GET['dateSort'];}else { echo 'desc';}?>">Всички</a>
     <ul id="category-menu">
         <?php
         foreach ($categories as $key=>$value) {
             if ($key == 9) {
                 continue;
             }
             if (isset($_GET['dateSort'])  && $_GET['dateSort']=='asc') {
                 echo '<li><a href="messages.php?selectedCat='.$key.'&dateSort=asc">'.$categories[$key].'</a></li>';
             }
             else {
                echo '<li><a href="messages.php?selectedCat='.$key.'&dateSort=desc">'.$categories[$key].'</a></li>';
             }
         }
         ?>
    </ul>
</div>
<div id="date-sort-div">
<?php
        if(isset($_GET['selectedCat'])) { 
            if (isset($_GET['dateSort']) && $_GET['dateSort']=='asc') {
                 echo '<a href="messages.php?selectedCat='.$_GET['selectedCat'].'&dateSort=desc">По-нови отгоре</а>';
            }
            else {
                echo '<a href="messages.php?selectedCat='.$_GET['selectedCat'].'&dateSort=asc">По-стари отгоре</а>';
            }          
        }
        else { 
            if (isset($_GET['dateSort']) && $_GET['dateSort']=='asc') {
                 echo '<a href="messages.php?selectedCat=9&dateSort=desc">По-нови отгоре</а>';
            }
            else {
                echo '<a href="messages.php?selectedCat=9&dateSort=asc">По-стари отгоре</а>';
            }
        }
?>
</div>
<div>
<div id="logout-btn"><a href="destroy.php">Изход</a></div>
</div>
<?php
if (!(isset($_SESSION['isLogged']) && $_SESSION['isLogged'] == true)) {
    header('Location: index.php');
    exit;
}
else {
    if (isset($_GET['selectedCat']) && $_GET['selectedCat']>=1 && $_GET['selectedCat']<=8) {
        $sql = 'SELECT msg_id, user_name, msg_title, msg_data, category_id, date FROM messages WHERE category_id='.$_GET['selectedCat'].' ORDER BY date ';
        if (isset($_GET['dateSort']) && $_GET['dateSort'] == 'asc') {
             $sql .= 'ASC';
        }
        else {
            $sql .= 'DESC';
        }
    }
    else {
        $sql = 'SELECT msg_id, user_name, msg_title, msg_data, category_id, date FROM messages ORDER BY date ';
        if (isset($_GET['dateSort']) && $_GET['dateSort'] == 'asc') {
             $sql .= 'ASC';
        }
        else {
            $sql .= 'DESC';
        }
    }
    $getMsgsQuery = mysqli_query($connection, $sql);
    if ($getMsgsQuery->num_rows>0) {
        echo '<ul id="msg-list">';
        while ($row=$getMsgsQuery->fetch_assoc()) {
            echo '<li><div class="username">'.$row['user_name'].':'.' </div><div class="msg-title"><h3>'.$row['msg_title'].'</h3></div><div class="msg-data">'.$row['msg_data'].'</div><div class="msg-category">'.$categories[$row['category_id']].'</div><div class="date">'.$row['date'].'</div>';
            if  (isset($_SESSION['username']) && $_SESSION['username'] == 'admin') {
                echo '<div class="del-msg-btn"><a href="delete-msg.php?msgID='.$row['msg_id'].'">Изтрий</a></div></li>';
            }
            else {
                echo '</li>';
            }
        }  
        echo '</ul>';
    }
    else {
        echo 'No messages';
    }
}
?>
<?php
include './includes/footer.php';
?>
