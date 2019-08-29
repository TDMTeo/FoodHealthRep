<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar_Admi.aspx.cs" Inherits="Logistica.Agregar_Admi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="bootstrap4/css/bootstrap.css" rel="stylesheet" />
    <link href="bootstrap4/css/bootstrap-grid.css" rel="stylesheet" />

    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />
    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />

    <link href="plugins/animate.css/animate.css" rel="stylesheet" />
</head>
<body>


    <div class="container align-content-center ">
                <div class="card">
                    <div class="card-header">
                        FoodHealth
                    </div>
                    <div class="card-body text-center">
                        <h5 class="card-title">Registrarse</h5>
                        <div class="container ">
                            <div class="row">
                                <div class="col-12 col-sm-12 col-md-2 col-xl-2"></div>
                                <div class="col-12 col-sm-12 col-md-8 col-xl-8">
                                    <form id="form1" runat="server">
                                        <div class="form-group">
                                            <asp:Label ID="Label1" runat="server" Text="Identificacion"></asp:Label>
                                            <asp:TextBox ID="txtNombre" CssClass="form-control" TextMode="Number" runat="server"></asp:TextBox>
                                        </div>
                                       <div class="form-group">
                                            <asp:Label ID="Label5" runat="server" Text="Rol"></asp:Label>
                                           <br />
                                           <asp:RadioButton ID="RadioCliente" runat="server" GroupName="Rol" Text="Cliente"/>
                                           <asp:RadioButton ID="RadioAdmin" runat="server" GroupName="Rol" Text="Domiciliario   " />
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                                            <asp:TextBox ID="txtDocumento" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label3" runat="server" Text="Correo"></asp:Label>
                                            <asp:TextBox ID="txtCorreo" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
                                            <asp:TextBox ID="txtDireccion" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label>
                                            <asp:TextBox ID="txtContraseña" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                        </div>
                                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Registrarse" OnClick="Button1_Click" />
                                          <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="Volver" OnClick="Button2_Click" />
                                    </form>
                                </div>
                                <div class="col-12 col-sm-12 col-md-2 col-xl-2"></div>
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
