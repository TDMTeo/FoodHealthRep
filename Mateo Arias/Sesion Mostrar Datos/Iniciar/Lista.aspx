<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Iniciar.Lista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap-grid.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="table-responsive">
	        <table class="table table-active">
		        <tr> 
			        <td> 
				        <asp:GridView ID="GvUsuarios" runat="server"></asp:GridView>
			        </td>
		        </tr>
	        </table>
        </div> 
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.bundle.js"></script>
</body>
</html>
