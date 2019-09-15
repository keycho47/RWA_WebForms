<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Options.aspx.cs" Inherits="RWA_Labos.Options" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Test Options</h3>
    <div>

       
        <table class="w-100">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Teme:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTeme" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Language:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLang" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Repo:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlRepo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlRepo_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>

       
    </div>
</asp:Content>
