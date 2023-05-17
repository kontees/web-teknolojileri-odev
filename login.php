<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login PHP</title>
</head>
<body>
<?php
// Kullanıcı adı ve şifreyi alın
$email = $_POST['email'];
$password = $_POST['password'];

// Kullanıcı adı ve şifreyi kontrol et
if ($email === 'g221210082' && $password === 'g221210082') {
  // Doğru ise kullanıcı bilgilerini sakla
  session_start();
  $_SESSION['email'] = $email;

  // Yönlendirme yapmadan önce birkaç saniye bekleyebilirsiniz
   echo "Hoşgeldin, " . $email . "! Yönlendiriliyorsunuz...";
   header("refresh:3;url=duygu.html");

  // Yönlendirme yap
  header("Location: duygu.html");
  exit();
} else {
  echo "Kullanıcı adı veya şifre hatalı.";
}
?>



</body>
</html>


