<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="Master_page_2.add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <br />
        <br />
        <h1>Add User</h1>
        <br />
        <br />
        <div class="row">
            <div class="col-md-6 mx-auto" style="border: 2px solid #808080; border-radius: 15px; padding: 20px; background-color: azure">
                <div runat="server">
                    <div class="mb-3">
                        <label for="name" class="form-label">Name</label>
                        <asp:TextBox ID="name" runat="server" class="form-control" placeholder="Enter your name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="name" Text="* Required" SetFocusOnError="true" ForeColor="Orange" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label for="address" class="form-label">Address</label>
                        <asp:TextBox ID="address" runat="server" class="form-control" placeholder="Enter your address"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="address" Text="* Required" SetFocusOnError="true" ForeColor="Orange" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label for="branch" class="form-label">Branch</label>
                        <asp:TextBox ID="branch" runat="server" class="form-control" placeholder="Enter your name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="branch" Text="* Required" SetFocusOnError="true" ForeColor="Orange" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Email address</label>
                        <asp:TextBox ID="email" runat="server" class="form-control" TextMode="Email" placeholder="Enter your email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="email" Text="* Required" SetFocusOnError="true" ForeColor="Orange" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label for="password" class="form-label">Password</label>
                        <asp:TextBox ID="password" runat="server" class="form-control" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="password" Text="* Required" SetFocusOnError="true" ForeColor="Orange" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    </div>
                    <asp:Button ID="signup_btn" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="signup_btn_Click" />
                </div>
            </div>
        </div>
        <br />
        <br />
    </div>
</asp:Content>
