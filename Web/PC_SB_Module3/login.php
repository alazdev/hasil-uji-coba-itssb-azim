<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <style>
        body{
            width: 100%;
            margin-top: 20px;
            background-color: rgb(245,245,245);
        }
        header{
            width: 98%;

            background-color: rgb(100, 100, 100);
            margin: 1%;
            border-radius: 10px;

            text-align: center;
            color: white;
        }
        content{
            width: 98%;
            background-color: white;

            margin: 1%;
            border-radius: 10px;
            position: fixed;
        }
        footer{
            width: 98%;

            background-color: rgb(100, 100, 100);
            margin: 1%;
            border-radius: 10px;

            text-align: center;
            color: white;
        }
    </style>
</head>
<body>
    <header>
        <br/>
        <h1>Login</h1>
        <br/>
    </header>
    <content align="center">
        </br>
        </br>
        </br>
        </br>
        <form action=""></form>
            <table border="0" align="center">
                <tr>
                    <td>Username</td>
                    <td>:</td>
                    <td><input type="text" name="username"/></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>:</td>
                    <td><input type="password" name="password"/></td>
                </tr>
                <tr>
                    <td colspan="3" align="right"><button type="submit">Login</button></td>
                </tr>
            </table>
            <a href="register.php" align="center">want to register? click here!</a>
        </form>
        </br>
        </br>
        </br>
    </content>
</body>
</html>