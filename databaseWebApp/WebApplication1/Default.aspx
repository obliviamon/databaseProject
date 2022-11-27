<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display Current Selection" />
        <asp:Label ID="Label2" runat="server" Text="Insert Criteria for Value to Search &quot;games&quot; By, or leave blank to view all table indexes + names of the selected table below"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="16px" Width="173px"></asp:TextBox>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Character</asp:ListItem>
            <asp:ListItem>Company</asp:ListItem>
            <asp:ListItem>Franchise</asp:ListItem>
            <asp:ListItem>Games</asp:ListItem>
            <asp:ListItem>Platform</asp:ListItem>
            <asp:ListItem>Release Date</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label1" runat="server" Text="Value to Search By"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="16px">
            <asp:ListItem Selected="True">Character</asp:ListItem>
            <asp:ListItem>Company</asp:ListItem>
            <asp:ListItem>Franchise</asp:ListItem>
            <asp:ListItem>Games</asp:ListItem>
            <asp:ListItem>Platform</asp:ListItem>
            <asp:ListItem>Release Date</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label3" runat="server" Text="Display matching rows from &quot;games&quot; and the Value to search by"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <div>
        </div>
            <asp:TextBox ID="TextBox2" runat="server" Height="51px" ReadOnly="True" TextMode="MultiLine" Width="876px"></asp:TextBox>
    </div>

    </asp:Content>
