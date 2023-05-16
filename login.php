<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $users = array(
        array("email" => "g221210082@sakarya.edu.tr", "password" => "g221210082"),
    );
    $email = $_POST["email"];
    $password = $_POST["password"];

    $loggedIn = false;
    foreach ($users as $user) {
        if ($email === $user["email"] && $password === $user["password"]) {
            $loggedIn = true;
            break;
        }
    }

    if ($loggedIn) {
        header("Location: http://localhost/odev/duygu.html");
        echo "Hoşgeldiniz " . $email . "! Giriş Başarılı.";
    } else {
        header("Location: http://localhost/odev/log%c4%b1n.html");
        exit();
    }
}
?>
