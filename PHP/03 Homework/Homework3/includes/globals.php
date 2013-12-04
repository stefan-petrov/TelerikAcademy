<?php
$connection = mysqli_connect('localhost', 'test_user', 'test56', 'homework3');
mysqli_query($connection, 'SET NAMES utf8');
$categories = array(1=>'C#', 2=>'PHP', 3=>'JAVA', 4=>'JavaScript', 5=>'HTML', 6=>'CSS', 7=>'OOP', 8=>'Друго', 9=>'Всички');
?>