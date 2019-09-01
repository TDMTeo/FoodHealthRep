<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pruebas.aspx.cs" Inherits="Logistica.Pruebas" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="bootstrap4/css/bootstrap.css" rel="stylesheet" />
    <link href="bootstrap4/css/bootstrap-grid.css" rel="stylesheet" />

    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />
    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />

    <link href="css/Iniciar.css" rel="stylesheet" />    
    <link href="plugins/animate.css/animate.css" rel="stylesheet" />
</head>
<body>
  <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
            <h5 class="card-title text-center">Sign In</h5>
            <form class="form-signin" runat="server">
              <div class="form-label-group">
                  <asp:TextBox ID="inputEmail" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                  <asp:Label ID="Label1" runat="server" Text="Correo"></asp:Label>
              </div>

              <div class="form-label-group">
                  <asp:TextBox ID="inputPassword" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                  <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
              </div>

              <div class="custom-control custom-checkbox mb-3">
                  <asp:CheckBox ID="customCheck1" CssClass="custom-control-input" runat="server" Text="Recordar Contraseña" />
              </div>
                <asp:Button ID="Button1" CssClass="btn btn-lg btn-primary btn-block text-uppercase" runat="server" Text="Entrar" />
              <hr class="my-4">
                <asp:Button ID="Button2" CssClass="btn btn-lg btn-google btn-block text-uppercase" runat="server" Text="Registrarse" />
                <asp:Button ID="Button3" CssClass="btn btn-lg btn-facebook btn-block text-uppercase" runat="server" Text="Button" />
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>


    <%--<div class="container">
        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card card-signin my-5">
                    <div class="card-body">
                        <div class="card-title text-center">FoodHealth</div>
                        <form class="form-signin" runat="server">
                            <div class="form-label-group">
                                <asp:Label ID="Label1" placeholder="Correo" runat="server" Text="Label" ></asp:Label>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    --%>
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="jquery/jquery-3.3.1.min.js"></script>
    <script src="popper/popper.min.js"></script>
    <script src="bootstrap4/js/bootstrap.min.js"></script>
</body>
</html>
