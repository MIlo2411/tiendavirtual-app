<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFReloj.aspx.cs" Inherits="Presentation.WFReloj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Listado de Reloj</title>

    <style>
        .product-card img {
            width: 100%;
            height: 200px;
            object-fit: cover;
        }

        .product-card {
            border: 1px solid #ddd;
            border-radius: 5px;
            box-shadow: 0px 2px 5px rgba(0, 0, 0, 0.1);
        }

        .product-price {
            font-size: 1.2rem;
            font-weight: bold;
            color: #ff9900;
        }

        .stock-info {
            color: red;
        }
    </style>
</head>
<body>
    <div class="container mt-4">
        <h1 class="text-center mb-4">Computadoras Disponibles</h1>
        <div class="row row-cols-1 row-cols-md-3 row-cols-lg-4 g-4">

            <!-- Producto 1 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel1.jpg" alt="Computadora 1">
                    <h5 class="mt-3">Reloj inteligente para hombres y mujeres</h5>
                    <p>Reloj inteligente para hombres y mujeres (llamada recibir/dial), Alexa integrado, pantalla táctil de 1.7 pulgadas, rastreador de fitness con seguimiento de frecuencia cardíaca del sueño.</p>
                    <p class="product-price">$69.000</p>
                    <p class="stock-info">Solo quedan 11 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 2 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel2.jpg" alt="Computadora 2">
                    <h5 class="mt-3">Reloj Inteligente Original Smartwatch D20</h5>
                    <p>Reloj Inteligente Original Smartwatch D20 - Y68 PRO - Reloj Inteligente Original Smartwatch D20 - Y68 PRO Negro</p>
                    <p class="product-price">$99.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>

            <!-- producto 3 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel3.jpg" alt="Computadora 3">
                    <h5 class="mt-3">Reloj inteligente Samsung Galaxy Watch5 40mm Plata LTE</h5>
                    <p>Reloj inteligente Samsung Galaxy Watch5 40mm Plata LTE</p>
                    <p class="product-price">$89.000</p>
                    <p class="stock-info">Stock limitado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>

            <!-- Producto 4-->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel4.jpg" alt="Computadora 1">
                    <h5 class="mt-3">Reloj inteligente Redondo ZL02</h5>
                    <p> Tecnología, calidad y sofisticación definen al smartwatch.</p>
                    <p class="product-price">$190.000</p>
                    <p class="stock-info">Solo quedan 8 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 5 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel5.jpg" alt="Computadora 2">
                    <h5 class="mt-3">Apple Watch Series 5 GPS</h5>
                    <p> Apple Watch Series 5 GPS 44mm Aluminio Plata con Correa Deportiva Blanca</p>
                    <p class="product-price">$199.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- producto 6 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel6.jpg" alt="Computadora 3">
                    <h5 class="mt-3">Reloj Inteligente Conecta Y Entrena</h5>
                    <p>Descubre la combinación perfecta de tecnología y estilo con nuestro Smartwatch de última generación.</p>
                    <p class="product-price">$159.000</p>
                    <p class="stock-info">Stock limitado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 7 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel7.jpg" alt="Computadora 1">
                    <h5 class="mt-3">reloj inteligente Tft1.32</h5>
                    <p>reloj inteligente Tft1.32 correa de reloj de silicona negra para hombres y mujeres</p>
                    <p class="product-price">$69.000</p>
                    <p class="stock-info">Solo quedan 11 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 8 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/rel8.jpg" alt="Computadora 2">
                    <h5 class="mt-3">reloj inteligente Tft1.35</h5>
                    <p>reloj inteligente Tft1.35 correa de reloj de silicona negra para hombres y mujeres</p>
                    <p class="product-price">$120.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            
        </div>
    </div>


</body>
</html>

</asp:Content>
