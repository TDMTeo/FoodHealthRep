<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Usuarios.aspx.cs" Inherits="Logistica.Listado_Clientes" %>

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
     <div runat="server" id="Modificar" class="container" >
        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card card-signin my-5">
                    <div class="card-body">
                        <h5 class="card-title text-center">Registrarse</h5>
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

                            <div class="custom-control custom-checkbox mb-3">
                                <asp:CheckBox ID="customCheck1" CssClass="custom-control-input" runat="server" Text="Recordar Contraseña" />
                            </div>
                            <hr class="my-4" />
                            <asp:Button ID="btnModificar" CssClass="btn btn-lg btn-google btn-block text-uppercase" runat="server" Text="Inicio" OnClick="btnModificar_Click" />
                            <asp:Button ID="btnCancelar" CssClass="btn btn-lg btn-facebook btn-block text-uppercase" runat="server" Text="Iniciar Sesion" OnClick="btnCancelar_Click"/>
                        
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
