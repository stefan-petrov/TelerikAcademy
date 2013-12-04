<?php
$pageTitle = 'Нов автор';
include './includes/header.php';
require './includes/globals.php';
$authorAddedNotification = false;
$authorNameTooShortErr = false;
$authorNameExistErr = false;
$error = false;
if (!isset($_GET['sort'])) {
    header('Location: new_author.php?sort=desc');
    exit;
}
if ($connection) {
    if (isset($_POST['author-name'])) {
        $authorName = mysqli_real_escape_string($connection, trim($_POST['author-name']));
        $authorName = htmlentities($authorName);
        if (mb_strlen($authorName) <= 2) {
           $error = true;
           $authorNameTooShortErr = true;
        }
        $checkForSameNameQuery = mysqli_query($connection, 'SELECT COUNT(*) as count FROM authors WHERE author_name="'.$authorName.'"');
        $count=$checkForSameNameQuery->fetch_assoc();
        if ($count['count']!='0') {     
            $authorNameExistErr = true;
            $error = true;
            
        }                   
        if (!$error) {
            $addAuthorQuery = mysqli_query($connection, 'INSERT INTO authors (author_name) VALUES ("'.$authorName.'")');
            if ($addAuthorQuery) {               
                $authorAddedNotification = true;              
            }
        }               
    }
}
else    {
    echo 'No connection to database - '.mysqli_connect_error();
}
?>
<div class="table-wrapper">
<div class="index-btn"><a href="index.php">Книги</a></div>
<div id="add-author-form-container">
    <form method="POST">
        <span>Автор</span>
        <input type="text" name="author-name"/>
        <input type="submit" name="submit" value=""/>
        
    </form>
    <?php
            if ($authorAddedNotification) {
               echo '<div class="error-msg">Author successfuly added</div>';
            }
            else if ($authorNameTooShortErr) {
               echo '<div class="error-msg">Author name is too short</div>';
            }
            else if ($authorNameExistErr) {
               echo '<div class="error-msg">This author already exists</div>';
            }
            else {
                echo '<div class="empty-div">A</div>';
            }
            
    ?>
</div>
<div id="sort-div">
<?php
     if ($_GET['sort']=='asc') {
         echo 'Сортирай:<a href="new_author.php?sort=desc">Низходящ ред</а>';
     }
      else {
          echo 'Сортирай:<a href="new_author.php?sort=asc">Възходящ ред</а>';
      }          
?>
</div>
    <table>
        <thead><tr><th>Автори</th></tr></thead>
        <tbody>
            <?php 
            if ($_GET['sort'] == 'asc') {
                $getAllAuthorsQuery = mysqli_query($connection, 'SELECT author_id, author_name FROM authors ORDER BY author_name ASC');
            }
            else {
                $getAllAuthorsQuery = mysqli_query($connection, 'SELECT author_id, author_name FROM authors ORDER BY author_name DESC');
            }                
                while ($row=$getAllAuthorsQuery->fetch_assoc()) {
                    echo '<tr><td><div class="author-name"><a href="booksList.php?authorID='.$row['author_id'].'">'.$row['author_name'].'</a></div></td></tr>';
                }
            ?>
        </tbody>
    </table>
</div>
<?php
include './includes/footer.php';
?>
