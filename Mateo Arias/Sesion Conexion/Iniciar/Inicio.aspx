<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Iniciar.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap-grid.css" rel="stylesheet" />
</head>
<body>
   

    <div class="container align-content-center " >
        <div class="row" >
            <div class="col-12 col-md">
<div class="card">
  <div class="card-header"> 
      FoodHealth
  </div>
  <div class="card-body">
    <h5 class="card-title">Iniciar Sesion</h5>
        
        <form id="form1" runat="server" class="align-content-center">
                    <div class="form-group">
                       <asp:Label ID="Label1" CssClass=" align-content-center" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox  CssClass="align-content-center" ID="txtNombre" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                       <asp:Label ID="Label2" CssClass=" align-content-center" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox CssClass="align-content-center" ID="txtContra" runat="server"></asp:TextBox>
                    </div>
                        <asp:Button ID="Button1" CssClass="btn btn-outline-primary" runat="server" Text="Enviar" OnClick="Button1_Click" />
                    <div class="form-group">
                       
                    </div>
        </form>

    
  </div>
</div>
            </div>
        </div>
    </div>


    
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.bundle.js"></script>
</body>
</html>