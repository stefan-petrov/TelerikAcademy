<?php
require './includes/globals.php';
$pageTitle = 'Списък на книги';
include './includes/header.php';

?>
<div class="index-btn"><a href="index.php">Книги</a></div>
<div class="table-wrapper">
<div class="empty-div">A</div>
<table>
<tr><th>Книга</th><th>Автори</th></tr>
<?php
        if ($connection) {
            if (isset($_GET['authorID']) && is_numeric($_GET['authorID'])) {
                $getAllBooksByAuthorQuery = mysqli_query($connection, 'SELECT * FROM authors INNER JOIN books_authors ON authors.author_id=books_authors.author_id INNER JOIN books ON books_authors.book_id=books.book_id WHERE authors.author_id="'.$_GET['authorID'].'"');
                if ($getAllBooksByAuthorQuery->num_rows > 0) { 
                     while ($row=$getAllBooksByAuthorQuery->fetch_assoc()) {
                        echo '<tr><td><div class="book-title"><a href="book.php?book_id='.$row['book_id'].'">'.$row['book_title'].'</a></div></td><td>';
                        $getAllAuthorsForGivenBookQuery = mysqli_query($connection, 'SELECT * FROM authors INNER JOIN books_authors ON authors.author_id=books_authors.author_id INNER JOIN books ON books_authors.book_id=books.book_id WHERE book_title="'.$row['book_title'].'"');
                        while ($row2=$getAllAuthorsForGivenBookQuery->fetch_assoc()) {
                            echo '<div class="author-name"><a href="booksList.php?authorID='.$row2['author_id'].'">'.$row2['author_name'].' </a></div>';
                        }
                     echo '</td><tr>';
                     } 
                }
                else {
                    echo '<div class="error-msg">No such author or no books added with this author</div>';               
                }
            }
            else {
                echo '<div class="error-msg">No such author</div>';
            }
        }
        else    {
            echo 'No connection to database - '.mysqli_connect_error();
        }
?>
</table>
</div>
<?php
include './includes/footer.php';
?>