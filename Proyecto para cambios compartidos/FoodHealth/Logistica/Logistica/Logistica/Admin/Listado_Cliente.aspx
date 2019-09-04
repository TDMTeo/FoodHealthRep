<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Cliente.aspx.cs" Inherits="Logistica.Listado_Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Clientes</title>
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
    <br />
    <br />
    <form id="form1" runat="server">
    <div class="container" style="width: 750px;">
        <div class="table-responsive">
            <table class="table table-active">
                <tr>
                    <td>
                        <asp:GridView ID="GvUsuarios" runat="server" OnSelectedIndexChanged="GvUsuarios_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button"  CommandName="Select" HeaderText="Modificar" ShowHeader="True" Text="Seleccionar" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </div>
     <div runat="server" id="Modificar" class="container" style="width: 760px;">
         <button type="button" class="btn btn-outline-primary" data-toggle="modal" data-target="#exampleModal">
            Modificar
        </button>
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
                        <div class="form-label-group">
                            <asp:TextBox ID="txtDocumento" CssClass="form-control" TextMode="Number" runat="server"></asp:TextBox>
                            <asp:Label ID="Label3" runat="server" Text="Identificacion"></asp:Label>
                            <asp:HiddenField ID="hdClientesID" runat="server" />
                            <asp:HiddenField ID="hdDocumento" runat="server" />
                        </div>
                        <div class="form-label-group">
                            <asp:TextBox ID="txtEmail" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                            <asp:Label ID="Label1" runat="server" Text="Correo"></asp:Label>
                        </div>

                        <div class="form-label-group">
                            <asp:TextBox ID="txtContra" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                        </div>
                        <div class="form-label-group">
                            <asp:TextBox ID="txtNombre" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                            <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
                        </div>

                        <div class="form-label-group">
                            <asp:TextBox ID="txtDireccion" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                            <asp:Label ID="Label5" runat="server" Text="Direccion"></asp:Label>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                         <asp:Button ID="btnModificar" CssClass="btn btn-primary" runat="server" Text="Inicio" OnClick="btnModificar_Click" />
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
