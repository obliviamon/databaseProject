<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display Current Selection" />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Character</asp:ListItem>
            <asp:ListItem>Company</asp:ListItem>
            <asp:ListItem>Franchise</asp:ListItem>
            <asp:ListItem>Games</asp:ListItem>
            <asp:ListItem>Platform</asp:ListItem>
            <asp:ListItem>Release Date</asp:ListItem>
        </asp:RadioButtonList>
        <div>
        </div>
            <asp:TextBox ID="TextBox2" runat="server" Height="51px" ReadOnly="True" TextMode="MultiLine" Width="876px"></asp:TextBox>
    </div>

    </asp:Content>
