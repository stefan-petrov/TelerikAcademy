<?php
$path = realpath('uploads');
$filePath = $path.DIRECTORY_SEPARATOR.$_GET['filename'];
if ($filePath) {
    header('Content-Disposition: attachment; filename='.$_GET['filename'].'');
    readfile($filePath);
}
else {
    Echo 'File Not Found ';
}
?>
