<?php
    
    $d=mysql_connect('localhost','root','sumarabo')or die('接続失敗しました');
 
    
    $login_num = 0;
    $name ="suma";
    $pass = "0110";
    
    
    mysql_select_db('Suma',$d);
    mysql_set_charset('utf8');
    

        
        $sql = "INSERT INTO test VALUES ('$login_num','$name','$pass')";
        
        $result2 = mysql_query($sql);
   
    if(result2)echo "ok";
    
    $close_flag = mysql_close($d);
    
    
    
    ?>