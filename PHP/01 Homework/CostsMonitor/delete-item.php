<?php
include './includes/head.php';
require './includes/globals.php';
$buttonsVisible = "visible";
$isDeletedMsg = 'hidden';
if (isset($_GET['deleted']) && $_GET['deleted'] == true) {
    $isDeletedMsg = 'visible';
    $buttonsVisible = 'hidden';
}
else {
    $_GET['deleted'] = false;
}
$indexDel = (int)$_GET['delete'];
?>
<div id="question-delete-wrapper">
    
    <div id="question-delete">
        <p>Сигурен ли сте,че искате да изтриете следния запис?:</p>
    </div>
    <table>
        <thead>
                <th id="th-date"><div>Дата</div></th>
                <th id="th-name"><div>Име</div></th>
                <th id="th-sum"><div>Сума</div></th>
                <th id="th-type"><div>Вид</div></th>
        </thead>
        <tbody>
            <?php
                if(file_exists('data.txt')){
                $result =  file('data.txt');
                
                    if (isset($_GET['delete']) && (int) $_GET['delete'] >= 0) {
                    $lineToShowRaw = $result[(int)$_GET['delete']];
                    $lineToShow = explode('@', $lineToShowRaw);
                    echo '<tr>
                                <td>'.$lineToShow[3].'</td>
                                <td>'.$lineToShow[0].'</td>
                                <td>'.$lineToShow[1].'</td>
                                <td>'.$types[trim($lineToShow[2])].'</td>                             
                         </tr>';
                    }
                }               
            ?>
        </tbody>
    </table>
        <div id='record-deleted'style="visibility: <?php echo $isDeletedMsg; ?>">
            <p>Записът е изтрит !</p>
        </div>
    
        <a href=<?php echo 'delete-item.php?deleted=true&delete='.$indexDel; ?> ><div id='yes-button' style="visibility: <?php echo $buttonsVisible; ?>"><p>Да</p></div></a>
        <a href='index.php'><div id="get-back"><p>Върни се обратно</p></div></a>
    
</div>
<?php

if(file_exists('data.txt')){
  $result =  file('data.txt');
  
  if ($_GET['deleted'] == true) { 
      $indexDel = (int)$_GET['delete'];
      unset($result[$indexDel]);        
  }
  file_put_contents('data.txt', $result);
}
?>
<?php
include './includes/footer.php';
?>