<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Pedidos_Domiciliario.aspx.cs" Inherits="Logistica.Listado_Pedidos_Domiciliario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Pedidos</title>
    <link href="../bootstrap4/css/bootstrap.css" rel="stylesheet" />
    <link href="../bootstrap4/css/bootstrap-grid.css" rel="stylesheet" />

    <link href="../plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />
    <link href="../plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />

    <link href="../css/Iniciar.css" rel="stylesheet" />
    <link href="../plugins/animate.css/animate.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top">
        <div class="container">
            <a class="navbar-brand">Food Health</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto flex-row w-100">
                    <li class="nav-item px-2 mr-auto active">
                        <a class="nav-link" href="Domiciliario.aspx">Inicio
                    <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Listado_Pedidos_Domiciliario.aspx">Pedidos</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Listado_Pedidos_Domiciliario.aspx">Rutas</a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Perfil
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                            <a class="dropdown-item" href="Iniciar.aspx">Perfil</a>
                            <a class="dropdown-item" href="Registrarse.aspx">Notificaciones</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="Cliente.aspx">Cerrar Sesion</a>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container" style="width: 600px;">
            <div class="table-responsive">
                <table class="table table-active">
                    <tr>
                        <td>
                            <asp:GridView ID="GvUsuarios" runat="server" OnSelectedIndexChanged="GvUsuarios_SelectedIndexChanged" CellPadding="10" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Modificar" ShowHeader="True" Text="Seleccionar" />
                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div runat="server" id="Modificar" class="container" style="width: 760px;">
            <button type="button" class="btn btn-outline-primary" data-toggle="modal" data-target="#exampleModal">
                Modificar</button>
            <!-- Modal -->
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">

                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Modificar</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="card-body">
                            <h5 class="card-title text-center">Registrar Pedido</h5>
                            <div class="form-label-group">
                                <asp:TextBox ID="txtCliente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                <asp:Label ID="Label1" runat="server" Text="Cliente"></asp:Label>
                                <asp:HiddenField ID="hdPedidoID" runat="server" />
                                <asp:HiddenField ID="hdClientes" runat="server" />
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
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-outline-secondary" data-dismiss="modal">Close</button>
                            <asp:Button ID="btnModificar" CssClass="btn btn-outline-primary" runat="server" Text="Aceptar" OnClick="btnModificar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="../jquery/jquery-3.3.1.min.js"></script>
    <script src="../popper/popper.min.js"></script>
    <script src="../bootstrap4/js/bootstrap.min.js"></script>
</body>
</html>
