<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FoodHealth._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    
        <div class="bd-example">
          <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
              <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
              <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
              <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
              <div class="carousel-item active">
                <img src="http://lorempixel.com/1230/700/" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block">
                  <h5>Restaurante</h5>
                  <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                </div>
              </div>
              <div class="carousel-item">
                <img src="http://lorempixel.com/1230/700/" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block">
                  <h5>Acerca</h5>
                  <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                </div>
              </div>
              <div class="carousel-item">
                <img src="http://lorempixel.com/1230/700/" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block">
                  <h5>Menu</h5>
                  <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                </div>
              </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
              <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
              <span class="carousel-control-next-icon" aria-hidden="true"></span>
              <span class="sr-only">Next</span>
            </a>
          </div>
        </div>

    <section class="py-5">
  <div class="container">
    <h1 class="font-weight-light">FoodHealth</h1>
    <p class="lead">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum corporis minima facilis accusamus! 
        Repellendus debitis aliquam quod distinctio itaque omnis error facilis, quis eaque tenetur. Quas provident tempore sapiente recusandae.<a href="https://unsplash.com">Mas...</a>!</p>
  </div>
</section>

</asp:Content>
