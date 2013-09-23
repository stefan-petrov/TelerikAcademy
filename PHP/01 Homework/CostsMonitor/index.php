<?php

include './includes/head.php';
$pageTitle = 'Списък';
require './includes/globals.php';
$types[] = 'Всички';
$sum =0;
?>      
        <div id="filter-wrapper">
            <form method="GET">
                <div id="please-select-filter">*Моля изберете филтър:</div>
                <div id="filter"><a>Всички</a>           
                    <ul id="filter-list">
                        <?php
                            foreach ($types as $key=>$value) {
                            echo '<li><a href="index.php?filter='.$key.'">'.$value.'</a></li>';
                            }
                        ?>
                    </ul>
                </div>
                <a href='cost_add.php' class="links"><div id="add-record" align="center">Добави Запис</div></a>
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
               
                        foreach ($result as $key => $value) {                       
                        $columns=  explode('@', $value);                        
                            if (isset($_GET['filter'])) {
                                $selectedType = (int)$_GET['filter'];
                            }
                            else {
                            $_GET['filter'] = 7;
                            $selectedType = (int)$_GET['filter'];
                            }
                            
                        
                            if ($columns[2] == $selectedType) {
                            
                            $sum += $columns[1];
                            if ($sum < 0) {
                                $sum = 0;
                            }
                            echo '<tr>
                                <td>'.$columns[3].'</td>
                                <td>'.$columns[0].'</td>
                                <td>'.$columns[1].'</td>
                                <td>'.$types[trim($columns[2])].'</td>
                                <td class="delete-item"><a href="delete-item.php?delete='.$key.'">Изтрий</a></td>
                                <td class="edit-item"><a href="edit-item.php?edit='.$key.'">Редактирай</a></td>
                                </tr>';
                            }
                            else if ($selectedType == 7) {
                                $sum += $columns[1];
                            if ($sum < 0) {
                                $sum = 0;
                            }
                            echo '<tr>
                                <td>'.$columns[3].'</td>
                                <td>'.$columns[0].'</td>
                                <td>'.$columns[1].'</td>
                                <td>'.$types[trim($columns[2])].'</td>
                                <td class="delete-item"><a href="delete-item.php?delete='.$key.'">Изтрий</a></td>
                                <td class="edit-item"><a href="edit-item.php?edit='.$key.'">Редактирай</a></td>
                                </tr>';
                            }                          
                        }
                     }
                    ?>
                <td></td>
                <td></td>
                <td id='sum'><?php echo $sum; ?></td>
                </tbody>
            </table>
            </form>
        </div>
<?php
include './includes/footer.php';
?>