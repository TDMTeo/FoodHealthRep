<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Iniciar.Administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pagina</title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="table-responsive">
	        <table class="table table-active">
		        <tr> 
			        <td> 
                        <asp:GridView ID="gvUsuarios" runat="server" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged">
                        </asp:GridView>
			        </td>
		        </tr>
	        </table>
        </div> 
    </form>
</body>
</html>
