<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="UCA.ascx" TagName="UCA" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <uc1:UCA ID="UCA1" runat="server" />
            <br />
            Hello my name is
            <asp:Literal ID="LitName" runat="server"></asp:Literal>
            and my age is 
            <asp:Literal ID="LitAge" runat="server"></asp:Literal>
            <asp:Button runat="server" ID="BtnSubmit" Text="Submit"  />

        </div>
    </form>
</body>
</html>
