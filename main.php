<?php
    $conn = mysqli_connect("localhost","root","","budzet");
    if (!$conn) {
        echo "<em class='errorMessage'>Nie można połączyć z serwerem i/lub bazą danych</em>";
    }

    if (isset($_POST["earningSent"])) {
        $sql = ("INSERT INTO earnings(amount, comm, data_trans) VALUES ('" . $_POST["earningAmount"] . "', '" . $_POST["earningComm"] . "', '" . $_POST["earningDate"] . "')");
        $query = @mysqli_query($conn, $sql);
        if (!$query) {
            echo "<em class='errorMessage'>Nie udało się dodać przychodów</em>";
        }
    } else if (isset($_POST["outgoSent"])) {
        $categoryId = 7;
        $sql = "";
        if (isset($_POST["outgoCategory"]) && $_POST["outgoCategory"] != NULL) {
            $sql = ("SELECT id FROM categories WHERE name='" . $_POST["outgoCategory"] . "'");
            $query = mysqli_query($conn, $sql);
            if (!$query) {
                echo "<em class='errorMessage'>Nie udało się znaleźć kategorii</em>";
            } else {
                while ($row=mysqli_fetch_row($query)) {
                    $categoryId = $row[0];
                }
            }
        }
        
        $sql = "INSERT INTO outgo(amount, comm, data_trans, category_id) VALUES (" . $_POST["outgoAmount"] . ', "' . $_POST["outgoComm"] . '", "' . $_POST["outgoDate"] . '", ' . $categoryId . ")";
        $query = mysqli_query($conn, $sql);
        if (!$query) {
            echo "<em class='errorMessage'>Nie udało się dodać wydatków</em>";
        }
    } else if (isset($_POST["categorySend"]) && isset($_POST["addCategory"])) {
        $sql = "INSERT INTO categories(name) VALUES ('" . $_POST["addCategory"] . "')";
        $query = mysqli_query( $conn, $sql);
        if (!$query) {
            echo "<em class='errorMessage'>Istnieje już taka kategoria</em>";
        }
    }
?>

<!DOCTYPE html>
<html lang="pl">
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
                <label for="earningDate">Data:</label>
                <input type="date" id="earningDate" name="earningDate">
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
                <label for="outgoDate">Data:</label>
                <input type="date" id="outgoDate" name="outgoDate">
                <label for="outgoCategory">Kategoria:</label>
                <select name="outgoCategory" id="outgoCategory" value="NULL">
                    <option value="">-- wybierz kategorię -- </option>
                    <?php
                        $query = mysqli_query($conn, "SELECT * FROM categories WHERE id != 7;");
                        if (!$query) {
                            echo "<em class='errorMessage'>Nie udało się wykonać zapytania</em>";
                        } else {
                            while ($row = mysqli_fetch_array($query)) {
                                echo '<option name="' . $row[0] . '">' . $row[1] . "</option>";
                            }
                        }
                    ?>
                </select>
                <button type="submit" name="outgoSent">Dodać</button>
            </form>
            <form id="categoryAdding" action="budzet.php" method="POST">
                    <div>
                        <label for="addCategory">Dodaj kategorię:</label>
                        <input type="text" name="addCategory" id="addCategory">
                    </div>
                    <button type="submit" name="categorySend">Dodaj</button>
            </form>
        </div>
    </div>

    <footer>
        <button id="raportButton" onclick="showmoney()">Raport</button>

        <div id="result_bg" onclick="hidemoney()">
            <div id="result_block" onclick="prevent(event)">
                <div id="res_left_right">
                    <div class="left_right" id="res_l">
                        <h2>przychody</h2>
                        <div class="scrollable_table">
                            <table>
                                <tr>
                                    <th>Ilość</th>
                                    <th>Data</th>
                                    <th>Komentarz</th>
                                </tr>
                                <?php
                                    $sql="select amount,comm, data_trans from earnings";
                                    $result = mysqli_query($conn, $sql);
                                    while ($row = mysqli_fetch_array($result)){
                                        echo"<tr><td>".$row["amount"]."</td><td>".$row["data_trans"]."</td><td>".$row["comm"]."</td></tr>";
                                    }

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
                                    $sql="select amount,category_id,comm, data_trans from outgo";
                                    $result = mysqli_query($conn, $sql);
                                    while ($row = mysqli_fetch_array($result)){
                                        echo"<tr><td>".$row["amount"]."</td><td>".$row["data_trans"]."</td><td>".$row["category_id"]."</td><td>".$row["comm"]."</td></tr>";
                                    }

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

<?php
    mysqli_close($conn);
?>