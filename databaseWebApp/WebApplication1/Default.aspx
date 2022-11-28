<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Display Selected Table" Width="177px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Display &quot;games&quot; and selected" Width="198px" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search by Text:" />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="16px" Width="173px"></asp:TextBox>
        <div style="width: 164px" class="text-center">
        </div>
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="124px" style="margin-left: 5px; margin-top: 0px; margin-bottom: 57px" Width="809px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="124px">
                    <asp:ListItem>Character</asp:ListItem>
                    <asp:ListItem>Company</asp:ListItem>
                    <asp:ListItem>Franchise</asp:ListItem>
                    <asp:ListItem>Games</asp:ListItem>
                    <asp:ListItem>Platform</asp:ListItem>
                    <asp:ListItem>Release Date</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" style="margin-left: 271px">
                <asp:TextBox ID="TextBox2" runat="server" Height="400px" ReadOnly="True" TextMode="MultiLine" Width="1534px"></asp:TextBox>
            </asp:Panel>
        </div>
    </div>

    </asp:Content>
