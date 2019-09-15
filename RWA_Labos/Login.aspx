<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RWA_Labos.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
    <div class="text-center" data-gr-c-s-loaded="true" >

                    <asp:TextBox Style="margin: auto" ID="tbUsename" runat="server" Width="200px" class="form-control" placeholder="Name" required="" autofocus=""></asp:TextBox>
         
                    <asp:TextBox Style="margin: auto" ID="tbPassword" runat="server" Width="200px" TextMode="Password" class="form-control" placeholder="Password" required=""></asp:TextBox>
            
                    <asp:Button ID="btnLogin" runat="server" Width="200px" OnClick="btnLogin_Click" Text="Login" class="btn btn-lg btn-primary" />

        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="#CC0000"></asp:Label>

    </div>

</asp:Content>
