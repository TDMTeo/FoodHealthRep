<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Logistica.Cliente1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>FoodHealth</title>
    <link href="bootstrap4/css/bootstrap.css" rel="stylesheet" />
    <link href="bootstrap4/css/bootstrap-grid.css" rel="stylesheet" />

    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />
    <link href="plugins/sweetAlert2/sweetalert2.min.css" rel="stylesheet" />

    <link href="plugins/animate.css/animate.css" rel="stylesheet" />

    <link href="css/resume.css" rel="stylesheet" />

</head>
<body class="d-flex flex-column">
    <nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top">
        <div class="container">
            <a class="navbar-brand">Food Health</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto flex-row w-100">
                    <li class="nav-item px-2 mr-auto active">
                        <a class="nav-link" href="Cliente.aspx">Inicio
                    <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#Acerca">Acerca</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Menu</a>
                    </li>
                    `
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Perfil
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                            <a class="dropdown-item" href="Iniciar.aspx">Iniciar Sesion</a>
                            <a class="dropdown-item" href="Registrarse.aspx">Registrarse</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="#">Recuperar Cuenta</a>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <header>
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner" role="listbox">

                <div class="carousel-item active" style="background-image: url('https://restauranteloscaballeros.com/wp-content/uploads/revslider/slider-inicio-2019/restaurante-0001.jpg')">
                    <div class="carousel-caption d-none d-md-block">
                        <h3 class="display-4">Food Health</h3>
                        <p class="lead">Actualmente hubicado en Cr 81ª #37d-25 - Medellín</p>
                    </div>
                </div>

                <div class="carousel-item" style="background-image: url('https://www.aldelis.com/wp-content/uploads/2018/08/28-ag-18.jpg')">
                    <div class="carousel-caption d-none d-md-block">
                        <h3 class="display-4">Menu Especial</h3>
                        <p class="lead"></p>
                    </div>
                </div>

                <div class="carousel-item" style="background-image: url('https://cdn2.ticbeat.com/src/uploads/2018/08/alimentos-comer-todos-los-dias-810x518.jpg?x32709')">
                    <div class="carousel-caption d-none d-md-block">
                        <h3 class="display-4">Menu Mas Pedido</h3>
                        <p class="lead"></p>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </header>

    <section id="Acerca">
        <div class="container">
            <h1 class="my-4">FoodHealth
    <small>More Than One Family </small>
            </h1>
            <div class="row">
                <div class="col-md-8">
                    <img class="img-fluid" src="https://e00-elmundo.uecdn.es/assets/multimedia/imagenes/2018/06/08/15284709731053.jpg" alt="">
                </div>
                <div class="col-md-4">
                    <h3 class="my-3">Mision</h3>
                    <p>
                        Satisfacer las necesidades gastronómicas de nuestros clientes, ofreciendo alimentos y servicios con la más alta calidad, donde se sobrepasen las expectativas de nuestros clientes y ser un espacio de trabajo que permita la realización personal y el Desarrollo de sus colaboradores en el grupo.
Tomando como estrategia principal el mejoramiento continúo de los estrictos estándares de higiene y buen servicio en un ambiente seguro, agradable y familiar a un precio justo.
                    </p>
                    <h3 class="my-3">Vision</h3>
                    <p>“Ser el Mejor Restaurante a nivel Regional y nacional" Ser reconocido y preferido a nivel Regional y Nacional, como un grupo de trabajo original, sólido y profesional</p>
                </div>
            </div>
        </div>
    </section>

    <footer>
        <div class="mt-5 pt-5 pb-5 footer">
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-xs-12 about-company">
                        <h2>FoodHealth</h2>
                        <p class="pr-5 text-white-50">Mas que una familia, con los cocineros mas preparados y reconocidos de Colombia </p>
                        <p><a href="#"><i class="fa fa-facebook-square mr-1"></i></a><a href="#"><i class="fa fa-linkedin-square"></i></a></p>
                    </div>

                    <div class="col-lg-4 col-xs-12 location align-content-end">
                        <h4 class="mt-lg-0 mt-sm-4">Localizacion</h4>
                        <p>Actualmente hubicado en Cr 81ª #37d-25 - Medellín</p>
                        <p class="mb-0"><i class="fa fa-phone mr-3"></i>+57 3103857765</p>
                        <p><i class="fa fa-envelope-o mr-3"></i>FoodHealth@gmail.com</p>
                    </div>
                </div>
                <div class="row mt-5">
                    <div class="col copyright">
                        <p class=""><small class="text-white-50">© 2019. Derechos Reservados a los TDM</small></p>
                    </div>
                </div>
            </div>
        </div>
    </footer>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="jquery/jquery-3.3.1.min.js"></script>
    <script src="popper/popper.min.js"></script>
    <script src="bootstrap4/js/bootstrap.min.js"></script>
</body>
</html>
