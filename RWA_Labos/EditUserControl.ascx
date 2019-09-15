<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditUserControl.ascx.cs" Inherits="RWA_Labos.EditUserControl" %>
<style type="text/css">
    .auto-style1 {
        width: 43%;
    }
</style>

<table class="table">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Name:" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbFirstname" runat="server" Text='<%# Eval("Firstname") %>'></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Lastname:" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbLastname" runat="server" Text='<%# Eval("Lastname") %>'></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Email:" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbEmail" runat="server" Text='<%# Eval("Email") %>'></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Phone:" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbPhone" runat="server" Text='<%# Eval("Phone") %>'></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Password:" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbPassword" runat="server" Text='<%# Eval("Password") %>'></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Text="Role:" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlRole" runat="server">
                <asp:ListItem>ADMIN</asp:ListItem>
                <asp:ListItem>USER</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="City:" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCity" runat="server">
                <asp:ListItem>Zagreb</asp:ListItem>
                <asp:ListItem>Karlovac</asp:ListItem>
                <asp:ListItem>Rijeka</asp:ListItem>
                <asp:ListItem>Split</asp:ListItem>
                <asp:ListItem>Osijek</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnEdit" class="btn btn-sl btn-info" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" class="btn btn-sl btn-warning" runat="server" OnClick="btnDelete_Click" Text="Delete" ForeColor="White" />
        </td>
    </tr>
</table>


