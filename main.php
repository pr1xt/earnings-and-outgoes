<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <footer>
        <a class="buttonClass" onclick="showmoney()">Button text</a>
        <div id="result_bg" onclick="hidemoney()">
            <div id="result_block" onclick="prevent(event)">
                <div id="res_left_right">
                    <div class="left_right" id="res_l">
                        <h2>przychody</h2>
                        <div class="scrollable_table">
                            <table>
                                <tr><th>Ilość</th><th>Data</th><th>Komentarz</th></tr>
                                <?php
                                    $conn = mysqli_connect("localhost","root","","budzet");

                                    $sql="select amount,comm, data_trans from earnings";
                                    $result = mysqli_query($conn, $sql);
                                    while ($row = mysqli_fetch_array($result)){
                                        echo"<tr><td>".$row["amount"]."</td><td>".$row["data_trans"]."</td><td>".$row["comm"]."</td></tr>";
                                    }
                                    mysqli_close($conn);

                                ?>
                            </table>
                        </div>
                    </div>
                    <div class="left_right" id="res_r">
                        <h2>wydatki</h2>
                        <div class="scrollable_table">
                            <table>
                                <tr><th>Ilość</th><th>Data</th><th>Kategoria</th><th>Komentarz</th></tr>
                                <?php
                                    $conn = mysqli_connect("localhost","root","","budzet");

                                    $sql="select amount,category_id,comm, data_trans from outgo";
                                    $result = mysqli_query($conn, $sql);
                                    while ($row = mysqli_fetch_array($result)){
                                        echo"<tr><td>".$row["amount"]."</td><td>".$row["data_trans"]."</td><td>".$row["category_id"]."</td><td>".$row["comm"]."</td></tr>";
                                    }
                                    mysqli_close($conn);

                                ?>
                            </table>
                        </div>
                    </div>
                </div>
                <?php
                
                ?>
            </div>
        </div>
    </footer>
    
    <script src="script.js"></script>
</body>
</html>