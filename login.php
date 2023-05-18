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
if ($email === 'g221210082@sakarya.edu.tr' && $password === 'g221210082') {
  // Doğru ise kullanıcı bilgilerini sakla
  session_start();
  $_SESSION['email'] = $email;

  // JavaScript kodunu yazdır
  echo '<script>
    alert("Hoşgeldin, ' . $email . '!");
    setTimeout(function() {
      window.location.href = "index.html";
    }, 3000); // 3 saniye bekleyip yönlendirme yap
  </script>';

  exit();
} else {
  echo "Kullanıcı adı veya şifre hatalı.";
}
?>



</body>
</html>


