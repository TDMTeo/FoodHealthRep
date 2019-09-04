<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Rol.aspx.cs" Inherits="Logistica.Listado_Rol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Roles</title>
    <link href="../bootstrap4/css/bootstrap.css" rel="stylesheet" />
    <link href="../bootstrap4/css/bootstrap-grid.css" rel="stylesheet" />

    <link href="../plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />
    <link href="../plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />

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
                    <li class="nav-item px-2 mr-auto active ">
                        <a class="nav-link" href="../Administrador.aspx">Inicio
                    <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLinks" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Agregar
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                            <a class="dropdown-item" href="Agregar_Admi.aspx">Usuario</a>
                            <a class="dropdown-item" href="../Pedido.aspx">Pedido</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLinke" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Listados
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                            <a class="dropdown-item" href="Listado_Cliente.aspx">Clientes</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="Listado_Domiciliario.aspx">Domicilarios</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="Listado_Rol.aspx">Roles</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Perfil
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                            <a class="dropdown-item" href="#">Perfil</a>
                            <a class="dropdown-item" href="#">Notificaciones</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="../Cliente.aspx">Cerrar Sesion</a>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container" style="width: 730px;">
        <div class="table-responsive">
            <table class="table table-active">
                <tr>
                    <td>
                        <asp:GridView ID="GvUsuarios" runat="server" OnSelectedIndexChanged="GvUsuarios_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Rol" ShowHeader="True" Text="Editar" />
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
    </form>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="../jquery/jquery-3.3.1.min.js"></script>
    <script src="../popper/popper.min.js"></script>
    <script src="../bootstrap4/js/bootstrap.min.js"></script>
</body>
</html>
