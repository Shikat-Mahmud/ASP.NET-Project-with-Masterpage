<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Master_page_2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <br />
        <br />
        <h1 style="text-align: center">Login</h1>
        <br />
        <br />
        <div class="row">
            <div class="col-md-4 mx-auto" style="border: 2px solid #808080; border-radius: 15px; padding: 20px; background-color: azure">
                <form runat="server">
                    <div class="mb-3">
                        <label for="email" class="form-label">Email address</label>
                        <asp:TextBox ID="email" runat="server" class="form-control" TextMode="Email" placeholder="Enter your email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="email" Text="* Required" SetFocusOnError="true" ForeColor="Orange" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label for="password" class="form-label">Password</label>
                        <asp:TextBox ID="password" runat="server" class="form-control" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="password" Text="* Required" SetFocusOnError="true" ForeColor="Orange" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    </div>
                    <asp:Button ID="login_btn" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="login_btn_Click" />
                </form>
                <br />
                <span>Don't have an account?</span>
                <a href="signup.aspx" style="text-decoration: none">Signup</a>
            </div>
        </div>
        <br />
        <br />
    </div>
</body>
</html>
