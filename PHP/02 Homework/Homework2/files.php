<?php
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'Files';
include './includes/header.php';
require './includes/functions.php';

if (!(isset($_SESSION['isLogged']) && $_SESSION['isLogged'] == true)) {
    header('Location: index.php');
}
?>

<div id="logout-btn"><a href="destroy.php">Изход</a></div>
<div id="list-btn-wrapper">
<div id="upload-link"><a href="upload.php">Upload a file</a></div>
<div id="list-wrapper"> 
    <table> 
    <?php
        $dir = scandir('uploads');
        for ($i = 0; $i < count($dir);$i++) {
            if ($dir[$i] == '.' || $dir[$i] == '..') {
                continue;
            }
            $path = realpath('uploads');      
            $filesize = filesize($path.DIRECTORY_SEPARATOR.$dir[$i]);
            echo '<tr><td><div class="pic-link"><a href="download.php?filename='.$dir[$i].'">'.$dir[$i].'</a></div></td><td><div class="pic-size">'.  formatSizeUnits($filesize).'</div></td></tr>';
        }
        
    ?>
    </table>
</div>
<div>
<?php
include './includes/footer.php';
?>
