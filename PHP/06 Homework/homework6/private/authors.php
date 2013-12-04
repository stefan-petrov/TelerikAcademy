<?php
include './functions/functions.php';


if ($_POST) {
    $author_name = trim($_POST['author_name']);
    if (mb_strlen($author_name) < 2) {
        echo '<p>Невалидно име</p>';
    } else {
        $author_esc = mysqli_real_escape_string($db, $author_name);
        $q = mysqli_query($db, 'SELECT * FROM authors WHERE
        author_name="' . $author_esc . '"');
        if (mysqli_error($db)) {
            echo 'Грешка';
        }

        if (mysqli_num_rows($q) > 0) {
            echo 'Има такъв автор';
        } else {
            mysqli_query($db, 'INSERT INTO authors (author_name)
            VALUES("' . $author_esc . '")');
            if (mysqli_error($db)) {
                echo 'Грешка';
            } else {
                echo 'Успешен запис';
            }
        }
    }
}


$data = [];
$authors = getAuthors($db);
foreach ($authors as $row) {
    $data['authors'][]=$row['author_name'];
}
$data['title'] = 'Автори';
$data['content'] = '../public_html/authors_public.php';
render($data, 'templates/layouts/normal_layout.php');
?>
 
