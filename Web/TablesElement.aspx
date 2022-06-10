<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TablesElement.aspx.cs" Inherits="TablesElement" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>


<body>
    <form id="form1" runat="server">
        <div id="here_table">
            <table border="1" style="width: 100%" id="mytable">
                <tr>
                    <td>S/N</td>
                    <td>name</td>
                    <td>Age</td>
                    <td>salary</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>saabir</td>
                    <td>30</td>
                    <td>100000</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Rohit</td>
                    <td>32</td>
                    <td>300000</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>Ravi</td>
                    <td>35</td>
                    <td>32000</td>
                </tr>
            </table>
        </div>
        <button type="button" value="check" onclick="checkdata()">value</button>
    </form>
</body>
</html>
<script type="text/javascript">
    var max_salary = 0;
    function checkdata() {
        var td = null;
        $('#mytable tr').each(function () {
            var value = Number($(this).find("td").eq(3).html());
            if (value > max_salary) {
                td = $(this).find("td").eq(3);
                max_salary = value;
            }
        });
        td.css('background-color', 'red');
    }
</script>