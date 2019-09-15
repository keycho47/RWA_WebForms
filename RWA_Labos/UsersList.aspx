<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="RWA_Labos.UsersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Test Users List</h3>
    <div >

        <asp:GridView CssClass="table" Style="margin: auto;" ID="gvUsers" runat="server" AutoGenerateColumns="False" ShowFooter="True" DataKeyNames="IDUser,Password,City" OnRowDeleting="gvUsers_RowDeleting" OnRowEditing="gvUsers_RowEditing" OnRowUpdating="gvUsers_RowUpdating" OnRowCancelingEdit="gvUsers_RowCancelingEdit" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Name" HeaderStyle-CssClass="thead-dark">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Firstname") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="tbFirstName" runat="server" Text='<%# Eval("Firstname") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tbFirstNameFooter" runat="server" />
                    </FooterTemplate>             

<HeaderStyle CssClass="thead-dark"></HeaderStyle>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Lastname">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Lastname") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="tbLastName" runat="server" Text='<%# Eval("Lastname") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tbLastNameFooter" runat="server" />
                    </FooterTemplate>             
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Email") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="tbEmail" runat="server" Text='<%# Eval("Email") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tbEmailFooter" runat="server" />
                    </FooterTemplate>             
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Phone">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Phone") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="tbPhone" runat="server" Text='<%# Eval("Phone") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tbPhoneFooter" runat="server" />
                    </FooterTemplate>             
                </asp:TemplateField>


                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlRole" runat="server" Enabled="False" CssClass="form-check-label" AutoPostBack="True">
                            <asp:ListItem>ADMIN</asp:ListItem>
                            <asp:ListItem>USER</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlRoleEdit" runat="server" Enabled="true">
                            <asp:ListItem>Test1</asp:ListItem>
                            <asp:ListItem>Test2</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="tbRole" runat="server" Text='<%# Eval("Role")%>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tbRoleFooter" runat="server" />
                    </FooterTemplate>             
                </asp:TemplateField>          
            
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button Text="Edit" runat="server" CommandName="Edit" ToolTip="Edit" />
                        <asp:Button Text="Delete" runat="server" CommandName="Delete" ToolTip="Delete" />

                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Button Text="Update" runat="server" CommandName="Update" ToolTip="Update"/>
                        <asp:Button Text="Cancel" runat="server" CommandName="Cancel" ToolTip="Cancel" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Button Text="Add" runat="server" CommandName="AddNew" ToolTip="Add New" />
                    </FooterTemplate>
                </asp:TemplateField>



            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>

        <br />

        <asp:Repeater ID="RepeaterUsersList" runat="server">
        </asp:Repeater>

    </div>
</asp:Content>
