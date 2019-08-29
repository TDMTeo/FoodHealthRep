<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Iniciar.aspx.cs" Inherits="Logistica.Iniciar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sesion</title>
    <link href="bootstrap4/css/bootstrap.css" rel="stylesheet" />
    <link href="bootstrap4/css/bootstrap-grid.css" rel="stylesheet" />

    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />
    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />

    <link href="plugins/animate.css/animate.css" rel="stylesheet" />

</head>
<body>
    <div class="container align-content-center ">
        <div class="row">
            <div class="col-12 col-md">
                <div class="card">
                    <div class="card-header">
                        FoodHealth
                    </div>
                    <div class="card-body text-center">
                        <h5 class="card-title">Iniciar Sesion</h5>
                        <form id="form1" runat="server" class="align-content-center">
                            <div class="form-group align-content-center">
                                <asp:Label ID="Label1" runat="server" Text="Nombre  "></asp:Label>
                                <asp:TextBox CssClass="align-content-center" ID="txtNombre" runat="server"></asp:TextBox>
                            </div>
                            <br />
                            <div class="form-group align-content-center">
                                <asp:Label ID="Label2" runat="server"  Text="Contraseña  "></asp:Label>
                                <asp:TextBox CssClass="align-content-center" ID="txtContra" runat="server"></asp:TextBox>
                            </div>
                            <br />
                            <asp:Button ID="Button1" runat="server"  CssClass="btn btn-primary" Text="Entrar" OnClick="Button1_Click" />
                            <asp:Button ID="Button2" runat="server"  CssClass="btn btn-primary" Text="Registrarse " OnClick="Button2_Click" /> <br />
                         <asp:Button ID="Button3"   CssClass="btn btn-primary" runat="server" Text="Inicio" OnClick="Button3_Click" />
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="jquery/jquery-3.3.1.min.js"></script>
    <script src="popper/popper.min.js"></script>
    <script src="bootstrap4/js/bootstrap.min.js"></script>
</body>
</html>
