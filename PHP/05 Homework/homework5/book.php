<?php
require './includes/globals.php';
$pageTitle = 'Книга';
include './includes/header.php';

if (!(isset($_SESSION['logged']) && $_SESSION['logged'] == TRUE)) {
   $displayNewCommentSection = false;
   $displayLoginBtn = true;
   $displayLogoutBtn = false;
   checkForPostLogin($connection);
}
else {
    $displayNewCommentSection = true;
    $displayLoginBtn = false;
    $displayLogoutBtn = true;
}

if (isset($_GET['book_id'])) {
    $book_id = intval(mysqli_real_escape_string($connection, trim($_GET['book_id'])));   

if (isset($_POST['comment-data'])) {
    $comment_data = mysqli_real_escape_string($connection, trim($_POST['comment-data']));
    $addNewCommentQuery = mysqli_query($connection, 'INSERT INTO comments (comment_content, user_name, comment_date) 
        VALUES ("'.$comment_data.'", "'.$_SESSION['username'].'", NOW())');
    
    $id = mysqli_insert_id($connection);
    $addNewCommentQUery2 = mysqli_query($connection, 'INSERT INTO books_comments (book_id, comment_id) VALUES ('.$book_id.', '.$id.')');     
}
}
else {
    header('Location: index.php');
    exit;
}
?>
<div id="go-back"><a href="index.php">Назад</a></div>
<div id="login-btn" style="display: <?php if ($displayLoginBtn) {
    echo 'inline-block';
}
else {
    echo 'none';
}
?>"><a href="login.php">Вход</a></div>
<div id="logout-btn" style="display: <?php if ($displayLogoutBtn) {
    echo 'inline-block';
}
else {
    echo 'none';
}
?>"><a href="destroy.php?url=book&book_id=<?php echo $_GET['book_id'];?>">Изход</a></div>
<div id="book-info-wrapper">
    <div class="book-title preview">
        <?php
            if ($connection) {
                if (isset($_GET['book_id']) && $book_id!='') {
                    
                    $getBookNameQuery = mysqli_query($connection, 'SELECT book_id, book_title FROM books WHERE book_id='.$book_id.'');
                    $bookName = $getBookNameQuery->fetch_assoc();
                    echo $bookName['book_title'];
                }                           
                else {
                    echo 'Invalid Book id';
                }
            }
else    {
    echo 'No connection to database - '.mysqli_connect_error();
}
        ?>
    </div>
    <div id="book-cover"><img src="./imgs/book.png"/></div>
    <div id="authors-list"><p>Автори:</p>
        <?php
        if ($connection) {
            $getAllAuthorsForGivenBookIDQuery = mysqli_query($connection, 'SELECT * FROM authors INNER JOIN books_authors ON authors.author_id=books_authors.author_id INNER JOIN books ON books_authors.book_id=books.book_id WHERE books_authors.book_id="'.$book_id.'"');
            while ($row=  mysqli_fetch_assoc($getAllAuthorsForGivenBookIDQuery)) {
                echo '<p><a href="booksList.php?authorID='.$row['author_id'].'">'.$row['author_name'].'</a></p>';
            }
        }
        else {
            echo 'No connection to database - '.mysqli_connect_error();
        }
        ?>
    </div>
    <div id="new-comment" style="display:<?php if ($displayNewCommentSection) {
            echo 'block';
        }
        else {
            echo 'none';
        }
?>"><p>Добави коментар</p>
        <form method="POST">
        <textarea maxlength="250" name="comment-data"></textarea>
        <input type="submit" value="" name="submit-comment"/>
        </form>
    </div>
    <div id="comments-wrapper"><p>Коментари:</p>             
            <?php 
                    if ($connection) {
                        $getCommentQuery = mysqli_query($connection, 'SELECT * FROM comments INNER JOIN books_comments ON books_comments.comment_id=comments.comment_id WHERE book_id='.$book_id.' ');
                        while ($row=  mysqli_fetch_assoc($getCommentQuery)) {                          
                            echo '<div id="comment-author">'.$row['user_name'].'</div><div id="comment-date">'.$row['comment_date'].'</div><div id="comment-content">'.$row['comment_content'].'</div>';
                        }
                    }
            ?>
         
    </div>
</div>
<?php
include './includes/footer.php';
?>
