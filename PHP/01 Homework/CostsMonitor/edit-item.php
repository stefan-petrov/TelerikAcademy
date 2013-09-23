<?php
include './includes/head.php';
require './includes/globals.php';

$costErrorMsg = 'hidden';
$nameErrorMsg = 'hidden';
$recordSuccesfulMsg = 'hidden';
if(file_exists('data.txt')){
        $result =  file('data.txt');          
        $currentRow = explode('@', $result[(int)$_GET['edit']]);
        $namePlaceHolder = '"'.$currentRow[0].'"';
        $pricePlaceHolder = '"'.$currentRow[1].'"';
        $currentType = (int)$currentRow[2];        
}
        
if ($_POST) {
    $date = getdate();
    $name = trim($_POST['name']);
    $name = str_replace('@', '', $name);
    setlocale(LC_MONETARY, 'bg_BG');
    $cost = trim($_POST['cost']);
    $cost = str_replace(',', '.', $cost);
    $cost = str_replace('@', '', $cost);
    $cost = (float)$cost;    
    $selectedType = (int)$_POST['type'];
    $error = false;
    
    if (mb_strlen($name) < 3) {
        $nameErrorMsg  = 'visible';
        $error = true;
    }   
    if (!(float)$cost && (float)$cost <= 0) {
        $costErrorMsg = 'visible';
        $error = true;
    }     
    if (!array_key_exists($selectedType, $types)) {
        echo '<p>Invalid Group</p>';
        $error = true;
    }
    if (!$error) {
        $result[(int)$_GET['edit']] = $name.'@'.$cost.'@'.$selectedType.'@'.$date['mday'].'.'.$date['mon'].'.'.$date['year']."\n";
        file_put_contents('data.txt', $result);
        $recordSuccesfulMsg = 'visible';
    }          
}

?>
    <div id="form-wrapper">
            <a href="index.php" class="links"><div id="back-to-list" align="center">Към списъка</div></a>
            <div id="record-succes-log"><p id='record-successful' style="visibility:<?php echo $recordSuccesfulMsg; ?>">Записът е успешен !</p></div>
        <form method='POST'>     
            <div>
                <div class="words-container">Име:</div><input type='text' name='name' placeholder= <?php echo $namePlaceHolder;?> /><p id='name-paragraph' style="visibility: <?php echo $nameErrorMsg; ?>">* Invalid Name</p>
            </div>
            <div>
                <div class="words-container">Сума:</div><input type='text' name='cost' placeholder= <?php echo $pricePlaceHolder;?> /><p id='cost-paragraph' style="visibility: <?php echo $costErrorMsg; ?>">* Invalid Cost</p>
            </div>
            <div><div class="words-container">Вид:</div>            
                <select name='type' >
                <?php        
                foreach ($types as $key=>$value) {
                        
                        if ($key == $currentType) {
                            echo '<option selected="selected" value="'.$key.'">'.$value.'</option>';
                        }
                        else {
                            echo '<option value="'.$key.'">'.$value.'</option>';
                        }
                }
                ?>
                </select>               
            </div>
            <input type='submit' id='add_button' value='Редактирай !'/>
        </form>
        </div>  
<?php
include './includes/footer.php';
?>
