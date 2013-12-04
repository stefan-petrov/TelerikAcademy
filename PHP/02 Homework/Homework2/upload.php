<?php
session_set_cookie_params(5184000, '/Homework2', 'localhost' , false, true);
session_start();
ob_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'Upload';
include './includes/header.php';
$fileSuccessfulyUploadedStatus = 'hidden';
$fileUnSuccessfulyUploadedStatus = 'hidden';
$chooseDifferentFileMsg = 'hidden';
if (count($_FILES)>0) {
    $dir = scandir('uploads');
    $nameSeparated = explode('.', $_FILES['pic']['name']);
    $altName = $nameSeparated[0].'.'.$nameSeparated[count($nameSeparated) - 1];
    $picCounter = 1;
    
    for ($i = 0; $i < count($dir); $i++ ) {
        if ($dir[$i] === $altName) {  
            $altName = $nameSeparated[0].'('.$picCounter.').'.$nameSeparated[count($nameSeparated) - 1];
            $picCounter++;
            $i = 0;
        }
    }
    
    if ($nameSeparated[count($nameSeparated) - 1] != 'php' && move_uploaded_file($_FILES['pic']['tmp_name'], 'uploads'.DIRECTORY_SEPARATOR.$altName)) {
        $fileSuccessfulyUploadedStatus = 'visible';
    }
    else if ($nameSeparated[count($nameSeparated) - 1] == 'php') {
        $chooseDifferentFileMsg = 'visible';
    }
    else    {
        $fileUnSuccessfulyUploadedStatus = 'visible';
    }
}

?>
<div id="logout-btn"><a href="destroy.php">Изход</a></div>
<div id="upload-form-wrapper">
    <div id="go-back-link"><a href="files.php">Files</a></div>
    <div id="file-upload-status">
        <?php if ($fileSuccessfulyUploadedStatus == 'visible') {
      echo  '<div  style="visibility:visible">Файлът е качен</div>';
    }
    else if ($chooseDifferentFileMsg = 'visible') {
        echo  '<div  style="visibility:visible">Изберете друг файл</div>';
    }
    else {
        echo  '<div  style="visibility:visible">Моля изберете файл</div>';
    }
?>
    </div> 
    <form method="POST" enctype="multipart/form-data">
        <div id="upload-file-container"><input id="browse-file-btn" type="file" name="pic" /></div>
        <input type="submit" value="" />
    </form>  
</div>
<?php
include './includes/footer.php';
?>
