<?php
$pageTitle = 'Начало';
include './includes/header.php';
require './includes/globals.php';
if (!isset($_GET['sort'])) {
    header('Location: index.php?sort=desc');
    exit;
}
?>
<div id="new-author-btn"><a href="new_author.php">Нов автор</a></div>
<div id="new-book-btn"><a href="new_book.php">Нова книга</a></div>

<div class="table-wrapper">
<?php
echo '<div id="sort-div">Сортирай:<a href="index.php?';          
if ($_GET['sort']=='asc') {
    echo 'sort=desc">Низходящ ред';
}
else {
    echo 'sort=asc">Възходящ ред';
}  
     echo '</a></div>';
?>
<table>
    <thead><tr><th>Книга</th><th>Автори</th></tr></thead>
    <tbody>
        <?php 
        if ($connection) {
            if ($_GET['sort'] == 'asc') {
                 $getAllBooksQuery = mysqli_query($connection, 'SELECT * FROM books INNER JOIN books_authors ON 
                 books.book_id=books_authors.book_id LEFT JOIN authors ON books_authors.author_id=authors.author_id ORDER BY book_title ASC');
            }
            else {
                 $getAllBooksQuery = mysqli_query($connection, 'SELECT * FROM books INNER JOIN books_authors ON 
                 books.book_id=books_authors.book_id LEFT JOIN authors ON books_authors.author_id=authors.author_id ORDER BY book_title DESC');
            }
            $result = array();
            while ($row=  mysqli_fetch_assoc($getAllBooksQuery)) {
                $result[$row['book_id']]['book_title'] = $row['book_title'];
                $result[$row['book_id']]['authors'][''.$row['author_id'].'']=$row['author_name'];               
            }    
            foreach ($result as $val1) {
                echo '<tr><td><div class="book-title">'.$val1['book_title'].'</div></td><td>';
                
                foreach ($val1['authors'] as $key => $val2) {
                    echo '<div class="author-name"><a href="booksList.php?authorID='.$key.'">'.$val2.'</a></div> ';
                }
                echo '</td></tr>';
            }
        }
        else {
            echo 'No connection to database - '.mysqli_connect_error();
        }
        ?>
    </tbody>
</table>
</div>
<?php
include './includes/footer.php';
?>
