﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="CrudMVC.Views.Registrar.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <meta name="description" content=""/>
  <meta name="author" content=""/>
  <title>Proycto MVC</title>
  <!-- Bootstrap core CSS-->
  <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
  <!-- Custom fonts for this template-->
  <link href="../../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
  <!-- Custom styles for this template-->
  <link href="../../css/sb-admin.css" rel="stylesheet"/>

  <link href="../../css/sweetalert.css" rel="stylesheet" />

     <!-- Bootstrap core JavaScript-->
  <script src="../../vendor/jquery/jquery.min.js"></script>
  <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
  <!-- Core plugin JavaScript-->
  <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
  <script src="../../js/sweetalert.min.js" type="text/javascript"></script>

</head>
<body class="bg-dark">
    <div class="container">
    <div class="card card-register mx-auto mt-5">
      <div class="card-header">Register an Account</div>
      <div class="card-body">
        <form runat="server">
          <div class="form-group">
            <div class="form-row">
              <div class="col-md-6">
                  <asp:Label ID="lblNombre" Text="Nombre" runat="server" />
                  <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"/>
              </div>
              <div class="col-md-6">
                <asp:Label ID="lblApellido" Text="text" runat="server" />
                  <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"/>
              </div>
            </div>
          </div>
          <div class="form-group">
              <asp:Label ID="lblEmai" Text="Email" runat="server" />
              <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"/>
          </div>
          <div class="form-group">
            <div class="form-row">
              <div class="col-md-6">
                  <asp:Label ID="lblPassword" Text="password" runat="server" />
                  <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"/>    
              </div>
              <div class="col-md-6">
                  <asp:Label ID="lblConfirmarPassword" Text="Confirmar Password" runat="server" />
                  <asp:TextBox ID="txtConfirmarPassword" runat="server" CssClass="form-control" TextMode="Password"/>
              </div>
            </div>
          </div>
            <asp:Button ID="btnRegistrar" Text="Registrar" runat="server"  CssClass="btn btn-primary btn-block"/>
        </form>
        <div class="text-center">
          <a class="d-block small mt-3" href="#">Login Page</a>
          <a class="d-block small" href="#">Forgot Password?</a>
        </div>
      </div>
    </div>
  </div>
</body>
</html>
