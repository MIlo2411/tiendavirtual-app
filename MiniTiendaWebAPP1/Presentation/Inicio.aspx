<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Presentation.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mi Tienda</title>
  
    <style>
        /* Estilo para el carrusel */
        .carousel-inner {
            max-height: 300px; /* Altura máxima del carrusel */
        }
        .carousel-inner img {
            width: 100%;
            height: 300px; /* Altura uniforme para todas las imágenes del carrusel */
            object-fit: cover; /* Mantiene proporciones y recorta si es necesario */
        }

        /* Estilo para las imágenes de productos */
        .card img {
            width: 100%;
            height: 200px; /* Altura uniforme para imágenes de productos */
            object-fit: cover; /* Mantiene proporciones y recorta si es necesario */
        }
    </style>
</head>
<body>

    <h1></h1>

    <!-- Carousel de Bootstrap -->
    <div id="carouselExampleInterval" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active" data-bs-interval="10000">
                <img src="resources/images/carrusel5.jpg" class="d-block w-100" alt="Descripción de la imagen 1">
            </div>
            <div class="carousel-item" data-bs-interval="2000">
                <img src="resources/images/carrusel4.jpg" class="d-block w-100" alt="Descripción de la imagen 2">
            </div>
            <div class="carousel-item">
                <img src="resources/images/carrusel6.jpg" class="d-block w-100" alt="Descripción de la imagen 3">
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Anterior</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Siguiente</span>
        </button>
    </div>

    <div class="container mt-4">
        <h2 class="mb-4">Ofertas del día</h2>
        <div class="row">
            <!-- Computadoras -->
            <div class="col-md-3">
                <div class="card">
                    <img src="resources/images/Carrusel1.jpg" class="card-img-top" alt="Computadoras">
                    <div class="card-body">
                        <h5 class="card-title">Potencia y rendimiento en tus manos</h5>
                        <p class="card-text">Descubre la computadora perfecta para ti. Equipadas con procesadores de última generación, amplia capacidad de almacenamiento y pantallas de alta definición.</p>
                        <a href="WFComputers.aspx" class="btn btn-primary">Comprar</a>
                    </div>
                </div>
            </div>

            <!-- Audífonos -->
            <div class="col-md-3">
                <div class="card">
                    <img src="resources/images/producto3.jpg" class="card-img-top" alt="Audífonos">
                    <div class="card-body">
                        <h5 class="card-title">Calidad de sonido que te envuelve</h5>
                        <p class="card-text">Sumérgete en tu música con nuestros audífonos de última generación. Diseñados para ofrecer un sonido nítido y bajos profundos.</p>
                        <a href="WFAudifonos.aspx" class="btn btn-primary">Ver más</a>
                    </div>
                </div>
            </div>

            <!-- Celulares -->
            <div class="col-md-3">
                <div class="card">
                    <img src="resources/images/producto2.jpg" class="card-img-top" alt="Celulares">
                    <div class="card-body">
                        <h5 class="card-title">Tecnología que te conecta al mundo</h5>
                        <p class="card-text">Nuestros celulares cuentan con cámaras de alta resolución, pantallas impresionantes y un rendimiento fluido.</p>
                        <a href="WFCelulares.aspx" class="btn btn-primary">Ver más</a>
                    </div>
                </div>
            </div>

            <!-- Reloj inteligente -->
            <div class="col-md-3">
                <div class="card">
                    <img src="resources/images/carrusel3.jpg" class="card-img-top" alt="Reloj inteligente">
                    <div class="card-body">
                        <h5 class="card-title">Estilo y funcionalidad en tu muñeca</h5>
                        <p class="card-text">Mantente conectado y saludable con nuestros relojes inteligentes. Monitorea tu actividad física, recibe notificaciones en tiempo real y personaliza tu estilo con diseños modernos.</p>
                        <a href="WFReloj.aspx" class="btn btn-primary">Ver más</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    
</body>
</html>
</asp:Content>

