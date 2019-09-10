<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Logistica.Administrador1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administrador</title>
<link href="bootstrap4/css/bootstrap.css" rel="stylesheet" />
    <link href="bootstrap4/css/bootstrap-grid.css" rel="stylesheet" />

    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />
    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />

    <link href="plugins/animate.css/animate.css" rel="stylesheet" />

    <link href="css/resume.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top">
        <div class="container">
            <a class="navbar-brand" >Food Health</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto flex-row w-100">
                    <li class="nav-item px-2 mr-auto active ">
                        <a class="nav-link" href="Administrador.aspx">Inicio
                    <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Agregar_Admi.aspx">Agregar</a>
                    </li>
                    <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                      Listados
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                      <a class="dropdown-item" href="Listado_Clientes.aspx">Clientes</a>
                        <div class="dropdown-divider"></div>
                      <a class="dropdown-item" href="Listado_Domiciliario.aspx">Domicilarios</a>
                    </div>
                  </li>
                    <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                      Perfil
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                      <a class="dropdown-item" href="#">Perfil</a>
                      <a class="dropdown-item" href="#">Notificaciones</a>
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
    <section>
<div class="container">
  <h1 class="my-4">FoodHealth
    <small>Admin</small>
  </h1>
  <div class="row">
    <div class="col-md-8">
      <img class="img-fluid" src="http://elespectadordigital.com/wp-content/uploads/2014/11/Ingresos.png" alt="">
    </div>

    <div class="col-md-4">
      <h3 class="my-3">Actualidad</h3>
      <ul>
        <li>Satisfaccion del cliente 98%</li>
        <li>satisfaccion del servicio de logistica 90%</li>
        <li>Satisfaccion del servicio de comida 90%</li>
        <li>Calidad del servicio apox. 95%</li>
      </ul>
      <h3 class="my-3">Mes Anterior</h3>
      <ul>
        <li>Satisfaccion del cliente 60%</li>
        <li>satisfaccion del servicio de logistica 70%</li>
        <li>Satisfaccion del servicio de comida 70%</li>
        <li>Calidad del servicio apox. 65%</li>
      </ul>
    </div>

  </div>


</div>
  </section>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="jquery/jquery-3.3.1.min.js"></script>
    <script src="popper/popper.min.js"></script>
    <script src="bootstrap4/js/bootstrap.min.js"></script>
</body>
</html>
