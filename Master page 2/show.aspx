<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="Master_page_2.show" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Data Table</h1>

        <table class="table table-bordered table-responsive table-dark table-hover">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Department</th>
                    <th>Email</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="col_repeater" runat="server" OnItemCommand="col_repeater_ItemCommand" >
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("Id") %></td>
                            <td><%#Eval("Name") %></td>
                            <td><%#Eval("Address") %></td>
                            <td><%#Eval("Branch") %></td>
                            <td><%#Eval("Email") %></td>
                            <td>
                                <asp:Button ID="edit" runat="server" Text="Edit" CssClass="btn btn-primary"  CommandArgument='<%#Eval("Id") %>' CommandName="edit" />
                                &nbsp
                                <asp:Button ID="delete" runat="server" Text="Delete" CssClass="btn btn-danger" CommandArgument='<%#Eval("Id") %>' CommandName="delete" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
