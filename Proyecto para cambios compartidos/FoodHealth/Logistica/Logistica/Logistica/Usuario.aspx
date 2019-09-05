<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Logistica.Usuario" %>

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
                        <a class="nav-link" href="Usuario.aspx">Inicio
                    <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Listado_Pedido_Cliente.aspx">Pedidos</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Menu</a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Perfil
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
    <br />
    <br />
    <br />
    <section>
        <div class="container">
            <div class="row">
                <div class="col-xl-3 col-md-6 mb-4">
                    <div class="card border-0 shadow">
                        <img src="https://dea154aeb528bee620f5-799733fd03b9298a9f65fee6178f3d08.ssl.cf1.rackcdn.com/pix_5_0_0_5b4372eab090f.jpg" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title mb-0">Lunes</h5>
                            <div class="card-text text-black-50">Carne con...</div>
                            <a href="#">mas...</a>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-md-6 mb-4">
                    <div class="card border-0 shadow">
                        <img src="https://www.clara.es/medio/2018/12/18/recetas-de-comida-saludable_8ca711d6_1200x630.jpg" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title mb-0">Martes</h5>
                            <div class="card-text text-black-50">Arroz Con..</div>
                            <a href="#">mas...</a>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-md-6 mb-4">
                    <div class="card border-0 shadow">
                        <img src="https://rec-end.elnuevodia.com/images/tn/0/71/942/539/900/447/2017/04/26/opcionesdecomidasaludable.jpg" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title mb-0">Miercoles</h5>
                            <div class="card-text text-black-50">Ensalada acompañada de...</div>
                            <a href="#">mas...</a>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-md-6 mb-4">
                    <div class="card border-0 shadow">
                        <img src="https://statics-cuidateplus.marca.com/sites/default/files/images/alimentos-saludables.jpg" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title mb-0">Jueves</h5>
                            <div class="card-text text-black-50">Pez Con...</div>
                            <a href="#">mas...</a>
                        </div>
                    </div>
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
