<?php
require './includes/globals.php';
$pageTitle = 'Нова книга';
include './includes/header.php';
$bookNameExistErr = false;
$authorNotSelectedErr = false;
$bookAddedNotification = false;
$bookNameTooShortErr = false;
$error = false;
if ($connection) {
    if (isset($_POST['book-name'])) {
        if (isset($_POST['authorNames'])) {
            $bookName = mysqli_real_escape_string($connection, trim($_POST['book-name']));
            $bookName = htmlentities($bookName);
            $authorsSelected = $_POST['authorNames']; 
            $checkForSameBookNameQuery = mysqli_query($connection, 'SELECT book_title FROM books WHERE book_title="'.$bookName.'"');
            
            if (mb_strlen($bookName)<=2) {
                $error = true;
                $bookNameTooShortErr = true;
            }  
            
            if ($checkForSameBookNameQuery->num_rows>0) {
                $bookNameExistErr = true;
                $error = true;
            }
                                                     
            if (!$error) {
                $addNewBookQuery = mysqli_query($connection, 'INSERT INTO books(book_title) VALUES ("'.$bookName.'")');
                if ($addNewBookQuery) {
                    $bookAddedNotification = 'visible';
                    $getTheBookIdQuery = mysqli_query($connection, 'SELECT book_id FROM books WHERE book_title="'.$bookName.'"');
                    $bookId = $getTheBookIdQuery->fetch_assoc();                  
                    for ($i = 0; $i < count($authorsSelected); $i++) {
                        $getAuthorIdQuery = mysqli_query($connection, 'SELECT author_id FROM authors WHERE author_name="'.$authorsSelected[$i].'"');
                        $authorId = $getAuthorIdQuery->fetch_assoc();
                        $insertIntoHelpTableQuery = mysqli_query($connection, 'INSERT INTO books_authors(book_id, author_id) VALUES ("'.$bookId['book_id'].'", "'.$authorId['author_id'].'")');
                    }                                        
                }
            }
        }
        else {
            $authorNotSelectedErr = true;
        }
    }   
}
else    {
    echo 'No connection to database - '.mysqli_connect_error();
}
?>
<div id="logout-btn"><a href="destroy.php">Изход</a></div>
<div class="table-wrapper">
<div class="index-btn"><a href="index.php">Книги</a></div>
<div id="add-book-form-container">
    <form method="POST">
        <span>Име на книгата:</span>
        <input type="text" name="book-name"/>
        <select multiple name="authorNames[]" size="7">
            <?php
                $getAllAuthorsQuery = mysqli_query($connection, 'SELECT author_id, author_name FROM authors');
                while ($row=$getAllAuthorsQuery->fetch_assoc()) {
                    echo '<option>'.$row['author_name'].'</option>';            
                }
            ?>
        </select>
        <input type="submit" name="submit" value=""/>
    </form>
    <?php
            if ($authorNotSelectedErr) {
               echo '<div class="error-msg">Please select an author</div>';
            }
            else if ($bookNameExistErr) {
               echo '<div class="error-msg">This book name already exist</div>';
            }
            else if ($bookAddedNotification) {
               echo '<div class="error-msg">Book Added</div>';
            }
            else if ($bookNameTooShortErr) {
               echo '<div class="error-msg">Book name too short</div>';
            }
    ?>
</div>
<?php
include './includes/footer.php';
?>