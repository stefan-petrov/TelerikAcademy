<a href="../public_html/index.php">Списък</a>
<form method="post" action="add_book.php">
    Име: <input type="text" name="book_name" />
    <div>Автори:<select name="authors[]" multiple style="width: 200px">
            <?php
                
                foreach ($data['authors'] as $row) {
                    echo '<option value="'. $row['author_id'].'">
                    '.$row['author_name'].'</option>';
                }
                echo var_dump($data['authors']);
            ?>
                </select>
    </div>
    <input type="submit" value="Добави" />
    
</form>