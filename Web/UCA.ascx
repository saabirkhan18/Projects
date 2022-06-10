<%@ Control Language="VB" AutoEventWireup="false" CodeFile="UCA.ascx.vb" Inherits="UCA" %>
<%@ Register Src="UCB.ascx" TagName="UCB" TagPrefix="ucb" %>
<br />
Name:<br />
<asp:TextBox ID="txtname" runat="server" Text="Saabir"></asp:TextBox>
<ucb:UCB ID="UCB1" runat="server" />
