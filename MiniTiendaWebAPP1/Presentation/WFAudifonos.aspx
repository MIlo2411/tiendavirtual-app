<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFAudifonos.aspx.cs" Inherits="Presentation.WFAudifonos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Listado de Audifonos</title>

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
                    <img src="resources/images/aud1.jpg" alt="Computadora 1">
                    <h5 class="mt-3">Audifonos lenovo</h5>
                    <p>Audifonos gamer bluetooth inalambricos p36 5.2</p>
                    <p class="product-price">$69.000</p>
                    <p class="stock-info">Solo quedan 11 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 2 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/aud2.jpg" alt="Computadora 2">
                    <h5 class="mt-3">TBONEEY Audifonos Inalámbricos</h5>
                    <p>TBONEEY Audifonos Inalámbricos Bluetooth 5.0 In Ear Auriculares Inalámbricos Control Tactil Auriculares Bluetooth Deportivos Mini TWS Hi-Fi Estéreo.</p>
                    <p class="product-price">$99.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>

            <!-- producto 3 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/aud3.jpg" alt="Computadora 3">
                    <h5 class="mt-3">Beats Studio3</h5>
                    <p>Audífonos Beats Studio3 Wireless Negro Mate</p>
                    <p class="product-price">$89.000</p>
                    <p class="stock-info">Stock limitado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>

            <!-- Producto 4-->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/aud4.jpg" alt="Computadora 1">
                    <h5 class="mt-3">Cowin E7 Pro</h5>
                    <p> Headset sem fio - Cowin E7 Pro - Bluetooth </p>
                    <p class="product-price">$190.000</p>
                    <p class="stock-info">Solo quedan 8 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 5 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/aud5.jpg" alt="Computadora 2">
                    <h5 class="mt-3">Binaural sports 5.0</h5>
                    <p> Audífonos Bluetooth binaural sports 5.0</p>
                    <p class="product-price">$199.000</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- producto 6 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/aud6.jpg" alt="Computadora 3">
                    <h5 class="mt-3"> Reproductor MP3 resistente al agua SONY NW-WS623</h5>
                    <p>Reproductor MP3 deportivo portátil SONY NW-WS623 de 4 GB, resistente al agua, resistente al sudor: para usar en agua salada y dulce hasta 2 metros (6,56 pies) de profundidad</p>
                    <p class="product-price">$99.000</p>
                    <p class="stock-info">Stock limitado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 7 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/aud7.jpg" alt="Computadora 1">
                    <h5 class="mt-3">Auriculares inalámbricos con cancelación de ruido Sony - Negro</h5>
                    <p>Diseñados para ser los auriculares inalámbricos con cancelación de ruido más livianos de Sony hasta el momento. Con una diadema más delgada.</p>
                    <p class="product-price">$69.000</p>
                    <p class="stock-info">Solo quedan 11 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 8 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/aud8.jpg" alt="Computadora 2">
                    <h5 class="mt-3">Auriculares inalámbricos con cancelación de ruido Sony ULT WEAR</h5>
                    <p>Auriculares inalámbricos con cancelación de ruido Sony ULT WEAR en gris bosque WHULT900N/H - Best Buy</p>
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
