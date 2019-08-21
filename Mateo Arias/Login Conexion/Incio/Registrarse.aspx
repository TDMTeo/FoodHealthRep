<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Incio.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <form id="form1" runat="server">     
                  <div class="form-row">
                    <div class="form-group col-md-6">
                      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <input type="email" class="form-control" id="inputEmail4" placeholder="Email" />
                    </div>
                    <div class="form-group col-md-6">
                      <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                  </div>
                  <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  </div>
                  <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  </div>
                  <div class="form-row">
                    <div class="form-group col-md-6">
                     <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                     <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-2">
                       <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                      <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </div>
                  </div>
                  <div class="form-group">
                    <div class="form-check">
                       <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                      <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </div>
                  </div>
                  <button type="submit" class="btn btn-primary">Sign in</button>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
