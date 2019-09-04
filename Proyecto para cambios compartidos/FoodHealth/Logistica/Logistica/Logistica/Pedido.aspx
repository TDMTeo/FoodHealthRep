<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="Logistica.Pruebas3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agregar Pedido</title>
    
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
                        <h5 class="card-title text-center">Registrar Pedido</h5>
                        <form class="form-signin" runat="server">
                            <div class="form-label-group">
                                <asp:TextBox ID="txtCliente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                <asp:Label ID="Label1" runat="server" Text="Cliente"></asp:Label>
                            </div>

                            <div class="form-label-group">
                                <asp:TextBox ID="txtDomi" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                <asp:Label ID="Label2" runat="server" Text="Domiciliario"></asp:Label>
                            </div>

                            <div class="form-label-group">
                                <asp:TextBox ID="txtDireccion" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
                            </div>

                            <div class="form-label-group">
                                <asp:TextBox ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                                <asp:Label ID="Label4" runat="server" Text="Descripcion"></asp:Label>
                            </div>
                            <div class="custom-control custom-checkbox mb-3">
                                <asp:CheckBox ID="customCheck1" CssClass="custom-control-input" runat="server" Text="Recordar Contraseña" />
                            </div>
                            <asp:Button ID="Button1" CssClass="btn btn-lg btn btn-light btn-block text-uppercase" runat="server" Text="Guardar" />
                            <hr class="my-4" />
                            <asp:Button ID="Button2" CssClass="btn btn-lg btn-google btn-block text-uppercase" runat="server" Text="Volver" OnClick="Button2_Click" />
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
