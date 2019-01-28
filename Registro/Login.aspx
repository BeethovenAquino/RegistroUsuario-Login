<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Registro.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" />

    <!--Bootstrap-->
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="/Scripts/bootstrap.min.js"></script>
    <script src="/Content/bootstrap3.7.min.js"></script>
    <!--toastr-->
    <link href="/Content/toastr.min.css" rel="stylesheet" />
    <script src="/Scripts/toastr.min.js"></script>

    <!--jquery-->
    <script src="/Scripts/jquery-2.2.0.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>

    <script src="/Scripts/bootstrap.min.js"></script>
    <script src="/Scripts/jquery-2.2.0.min.js"></script>
    <link href="/Content/toastr.min.css" rel="stylesheet" />
    <script src="/Scripts/toastr.min.js"></script>
    <script src="/Scripts/jquery-3.2.1.slim.min.js"></script>

        <div class="text-center">
         
        </div>
        <div class="row">
            <div class="co-12 col-sm-2 col-md-3 col-lg-5"></div>
            <div class="col-12 col-sm-8 col-md-6 col-lg-4">
                <div class="form-group">
                   &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<strong>
                        <asp:Label ID="Label1" runat="server" Text="User:"></asp:Label></strong>
                    <asp:TextBox ID="UsuarioTexbox" runat="server" class="form-control" Height="30" Width="200"></asp:TextBox>
                </div>

                <div class="form-group">
                     &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<strong>
                        <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label></strong>
                    <asp:TextBox ID="ContraseñaTextBox" runat="server" TextMode="Password" class="form-control" Height="30" Width="200"></asp:TextBox>

                </div>
              &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="LoginButton" runat="server" class="btn btn-info" Text="Login" OnClick="LoginButton_Click" />
            </div>
        </div>

</asp:Content>
