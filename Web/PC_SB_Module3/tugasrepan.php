<?php
    $number = "9,3,5,5,7,8";
    // $sum = array_sum(array($number));
    $sum = array_sum(explode(',', $number));
    echo $sum;
?>