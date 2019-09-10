<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Clientes.aspx.cs" Inherits="Logistica.Listado_Clientes" %>

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
    <form id="form1" runat="server">
        <div class="table-responsive">
            <table class="table table-active">
                <tr>
                    <td>
                        <asp:GridView ID="GvUsuarios" runat="server" OnSelectedIndexChanged="GvUsuarios_SelectedIndexChanged">
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Datos" ShowHeader="True" Text="Editar" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Refrescar" OnClick="Button1_Click" style="height: 26px" />
        <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Volver" OnClick="Button2_Click" />
    </form>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="jquery/jquery-3.3.1.min.js"></script>
    <script src="popper/popper.min.js"></script>
    <script src="bootstrap4/js/bootstrap.min.js"></script>
</body>
</html>
