<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EditUsers.aspx.cs" Inherits="RWA_Labos.EditUsers" %>
<%@ Register src="EditUserControl.ascx" tagname="EditUserControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Test Edit Users</h3>

        
        <asp:ListView ID="lvEditUsers" runat="server">

            <itemtemplate>
                <div style="display:inline-block; margin:auto; padding:25px" >
                    <uc1:EditUserControl block="<%# Container.DataItem %>" runat="server" user="<%# Container.DataItem %>" />
                </div>
            </itemtemplate>

        </asp:ListView>      

    
</asp:Content>
