<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFCelulares.aspx.cs" Inherits="Presentation.WFCelulares" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Listado de Celulares</title>

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
                    <img src="resources/images/cel1.jpg" alt="Computadora 1">
                    <h5 class="mt-3">SAMSUN GALAXY S22 ULTRA</h5>
                    <p>Samsung Galaxy S22 Ultra Smartphone, teléfono celular Android desbloqueado de fábrica, 256 GB, cámara y video de 8 K.</p>
                    <p class="product-price">$5.869.00.</p>
                    <p class="stock-info">Solo quedan 11 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 2 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/cel2.jpg" alt="Computadora 2">
                    <h5 class="mt-3">iPhone 14 Pro</h5>
                    <p>pantalla 6.1 pulgadas  Chip A15 Bionic principal de 12 MP y ultra gran angular de 12 MP.</p>
                    <p class="product-price">$6.499.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>

            <!-- producto 3 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/cel3.jpg" alt="Computadora 3">
                    <h5 class="mt-3">Samsung Galaxy A15</h5>
                    <p>samsung Galaxy A15 (SM-155M/DSN), 128GB 6GB RAM, Dual SIM, Factory Unlocked GSM.</p>
                    <p class="product-price">$699.000</p>
                    <p class="stock-info">Stock limitado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>

            <!-- Producto 4-->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/cel4.jpg" alt="Computadora 1">
                    <h5 class="mt-3">Sony Xperia 1 Unlocked</h5>
                    <p> Sony Xperia 1 Unlocked Smartphone 6.5" 4K HDR OLED CinemaWide Display, 128GB - Purple</p>
                    <p class="product-price">$1.000.000</p>
                    <p class="stock-info">Solo quedan 8 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 5 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/cel5.jpg" alt="Computadora 2">
                    <h5 class="mt-3">Samsung Galaxy A51</h5>
                    <p> amsung Galaxy A51 (SM-155M/DSN), 128GB 6GB RAM, Dual SIM, Factory Unlocked GSM.</p>
                    <p class="product-price">$1.499.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- producto 6 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/cel6.jpg" alt="Computadora 3">
                    <h5 class="mt-3"> Poco X6 PRO</h5>
                    <p>Celular Xiaomi PocoPhone Poco X6 PRO 5G 256GB ROM/ 8GB RAM Versão Global | Smartphone 5G , ROM Global , Câmera 64MP , Carregador 67W</p>
                    <p class="product-price">$899.000</p>
                    <p class="stock-info">Stock limitado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 7 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/cel7.jpg" alt="Computadora 1">
                    <h5 class="mt-3">Xiaomi Redmi 10</h5>
                    <p>Xiaomi Redmi 10 5G-Smartphone de 6.58" FHD+ Display,5000mAh High Capacity,MediaTek Dimensity 700,4GB RAM 64GB ROM</p>
                    <p class="product-price">$1.869.000</p>
                    <p class="stock-info">Solo quedan 11 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 8 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/cel8.jpg" alt="Computadora 2">
                    <h5 class="mt-3">Xiaomi 14 Ultra</h5>
                    <p>XIAOMI - Xiaomi 14 Ultra 16GB + 512GB móvil libre</p>
                    <p class="product-price">$3.000.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            
        </div>
    </div>


</body>
</html>


</asp:Content>
