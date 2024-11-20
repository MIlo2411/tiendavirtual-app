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
                        <img src="resources/images/comp1.jpg" alt="Computadora 1">
                        <h5 class="mt-3">HP EliteDesk 800 G8</h5>
                        <p>Intel Octa-Core i7-11700T, 64GB DDR4 RAM, 2TB PCIe SSD.</p>
                        <p class="product-price">$1.869.00.</p>
                        <p class="stock-info">Solo quedan 11 en stock</p>
                        <button class="btn btn-warning w-100">Agregar al carrito</button>
                    </div>
                </div>
                <!-- Producto 2 -->
                <div class="col">
                    <div class="product-card p-3">
                        <img src="resources/images/comp2.jpg" alt="Computadora 2">
                        <h5 class="mt-3">Dell Vostro 3910</h5>
                        <p>Intel Core i3-12100, 16GB DDR4 RAM, 512GB PCIe SSD.</p>
                        <p class="product-price">$1.499.000</p>
                        <p>50+ vendidos el mes pasado</p>
                        <button class="btn btn-warning w-100">Agregar al carrito</button>
                    </div>
                </div>

                <!-- producto 3 -->
                <div class="col">
                    <div class="product-card p-3">
                        <img src="resources/images/comp3.jpg" alt="Computadora 3">
                        <h5 class="mt-3">Lenovo ThinkCentre M90q</h5>
                        <p>Intel Core i5-10400T, 8GB DDR4 RAM, 256GB SSD.</p>
                        <p class="product-price">$3.699.000</p>
                        <p class="stock-info">Stock limitado</p>
                        <button class="btn btn-warning w-100">Agregar al carrito</button>
                    </div>
                </div>

                <!-- Producto 4-->
                <div class="col">
                    <div class="product-card p-3">
                        <img src="resources/images/comp4.jpg" alt="Computadora 1">
                        <h5 class="mt-3">Lenovo Yoga 9i</h5>
                        <p> 14 inch 2.8K Oled Intel Evo Core Ultra 7 155H 16Gb RAM 1TB SSD Windows 11 Home Notebook</p>
                        <p class="product-price">$2.000.000</p>
                        <p class="stock-info">Solo quedan 8 en stock</p>
                        <button class="btn btn-warning w-100">Agregar al carrito</button>
                    </div>
                </div>
                <!-- Producto 5 -->
                <div class="col">
                    <div class="product-card p-3">
                        <img src="resources/images/comp5.jpg" alt="Computadora 2">
                        <h5 class="mt-3">Lenovo Legion 7i 15</h5>
                        <p> gaming Laptop - 15.6" - Intel Core i7 Processor (2.60 GHz) - NVIDIA RTX 2070 - 1 TB SSD - 512 GB SSD - 16GB RAM - Windows 10</p>
                        <p class="product-price">$3.499.000</p>
                        <p>50+ vendidos el mes pasado</p>
                        <button class="btn btn-warning w-100">Agregar al carrito</button>
                    </div>
                </div>
                <!-- producto 6 -->
                <div class="col">
                    <div class="product-card p-3">
                        <img src="resources/images/comp6.jpg" alt="Computadora 3">
                        <h5 class="mt-3">Macbook Air M2 Mockup</h5>
                        <p>Intel Core i5-10400T, 8GB DDR4 RAM, 256GB SSD.</p>
                        <p class="product-price">$3.699.000</p>
                        <p class="stock-info">Stock limitado</p>
                        <button class="btn btn-warning w-100">Agregar al carrito</button>
                    </div>
                </div>
                <!-- Producto 7 -->
                <div class="col">
                    <div class="product-card p-3">
                        <img src="resources/images/comp7.jpg" alt="Computadora 1">
                        <h5 class="mt-3">Thermaltake LCGS View 390 AIO</h5>
                        <p>AMD Ryzen 7 5800X 8-core, ToughRam DDR4 3600Mhz 16GB RGB Memory, NVIDIA GeForce RTX 3090, 1TB NVMe Gen4 M.2, Win 10 Home</p>
                        <p class="product-price">$1.869.000</p>
                        <p class="stock-info">Solo quedan 11 en stock</p>
                        <button class="btn btn-warning w-100">Agregar al carrito</button>
                    </div>
                </div>
                <!-- Producto 8 -->
                <div class="col">
                    <div class="product-card p-3">
                        <img src="resources/images/comp8.jpg" alt="Computadora 2">
                        <h5 class="mt-3">Dell Vostro 3910</h5>
                        <p>Intel Core i3-12100, 16GB DDR4 RAM, 512GB PCIe SSD.</p>
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
