<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFComputers.aspx.cs" Inherits="Presentation.WFComputers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Listado de Computadoras</title>
    
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
                    <img src="resources/images/producto1.jpg" alt="Computadora 1">
                    <h5 class="mt-3">HP EliteDesk 800 G8</h5>
                    <p>Intel Octa-Core i7-11700T, 64GB DDR4 RAM, 2TB PCIe SSD.</p>
                    <p class="product-price">US$869.00</p>
                    <p class="stock-info">Solo quedan 11 en stock</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Producto 2 -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/producto2.jpg" alt="Computadora 2">
                    <h5 class="mt-3">Dell Vostro 3910</h5>
                    <p>Intel Core i3-12100, 16GB DDR4 RAM, 512GB PCIe SSD.</p>
                    <p class="product-price">US$499.00</p>
                    <p>50+ vendidos el mes pasado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Repite para 20 productos -->
            <!-- Ejemplo -->
            <div class="col">
                <div class="product-card p-3">
                    <img src="resources/images/producto3.jpg" alt="Computadora 3">
                    <h5 class="mt-3">Lenovo ThinkCentre M90q</h5>
                    <p>Intel Core i5-10400T, 8GB DDR4 RAM, 256GB SSD.</p>
                    <p class="product-price">US$699.00</p>
                    <p class="stock-info">Stock limitado</p>
                    <button class="btn btn-warning w-100">Agregar al carrito</button>
                </div>
            </div>
            <!-- Agrega los productos restantes -->
        </div>
    </div>

    
</body>
</html>



</asp:Content>
