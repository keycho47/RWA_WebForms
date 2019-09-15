<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="RWA_Labos.Home1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Test Add User</h2>
    <div>

        <table style="margin: auto"class="table">
            <tr>
                <td class="auto-style2">
    <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label>
                    <br />
    <asp:TextBox ID="tbAddName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Phone :"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbAddPhone" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
    <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
                    <br />
    <asp:TextBox ID="tbAddPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Lastname :"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbAddLastName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="City : "></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True">
                        <asp:ListItem>Zagreb</asp:ListItem>
                        <asp:ListItem>Karlovac</asp:ListItem>
                        <asp:ListItem>Rijeka</asp:ListItem>
                        <asp:ListItem>Split</asp:ListItem>
                        <asp:ListItem>Osijek</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Comfirm Password :"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbConfirmPass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Email : "></asp:Label>
                    <br />
                    <asp:TextBox ID="tbAddEmail" runat="server"></asp:TextBox>
                    <br />
                    <a href="AddUser.aspx">Add email...</a>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Role :"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlRole" runat="server" AutoPostBack="True">
                        
                        <asp:ListItem>USER</asp:ListItem>
                        <asp:ListItem>ADMIN</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
                </td>
            </tr>
        </table>

    </div>
    </asp:Content>
