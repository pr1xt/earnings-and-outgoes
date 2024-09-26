<?php
    $connection = mysqli_connect("localhost","root","","budzet");
    if (!$connection) {
        echo "Nie można połączyć z serwerem i/lub bazą danych";
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Zarządzanie budżetem</title>
</head>
<body>
    <header>
        <h1>ZARZĄDZANIE BUDŻETEM</h1>
    </header>
    <div id="main">
        <div id="left">
            <form action="budzet.php" method="POST">
                <h1>PRZYCHODY</h1>
                <label for="earningAmount">Ilość:</label>
                <input type="number" id="earningAmount" name="earningAmount" required>
                <label for="earningComm">Komentarz:</label>
                <input type="text" id="earningComm" name="earningComm">
                <label for="earningAmount">Data:</label>
                <input type="date" id="earningAmount" name="earningAmount">
                <button type="submit" name="earningSent">Dodać</button>
            </form>
        </div>

        <div id="right">
            <form action="budzet.php" method="POST">
                <h1>WYDATKI</h1>
                <label for="outgoAmount">Ilość:</label>
                <input type="number" id="outgoAmount" name="outgoAmount" required>
                <label for="outgoComm">Komentarz:</label>
                <input type="text" id="outgoComm" name="outgoComm">
                <label for="outgoAmount">Data:</label>
                <input type="date" id="outgoAmount" name="outgoAmount">
                <label for="outgoCategory">Kategoria:</label>
                <select name="outgoCategory" id="outgoCategory">
                    <?php
                        $query = mysqli_query($connection, "SELECT * FROM categories;");
                        if (!$query) {
                            echo "Nie udało się wykonać zapytania";
                        } else {
                            while ($row = mysqli_fetch_array($query)) {
                                echo '<option name="' . $row[0] . '">' . $row[1] . "</option>";
                            }
                        }
                    ?>
                </select>
                <label for="addCategory">Dodaj kategorię:</label>
                <input type="text" name="addCategory" id="addCategory">
                <button type="submit" name="outgoSent">Dodać</button>
            </form>
        </div>
    </div>

    <footer>
        <button id="raportButton">Raport</button>

        <div id="raport_bg" onclick="hidemoney()">
            <div id="raport_block" onclick="prevent(event)">
                <div id="res_left_right">
                    <div class="left_right" id="res_l">
                        <h2>PRZYCHODY</h2>
                    </div>
                    <div class="left_right" id="res_r">
                        <h2>WYDATKI</h2>
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