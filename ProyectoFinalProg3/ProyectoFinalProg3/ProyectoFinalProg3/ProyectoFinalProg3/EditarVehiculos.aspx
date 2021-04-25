﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarVehiculos.aspx.cs" Inherits="ProyectoFinalProg3.EditarVehiculos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Editar <small>Vehiculos</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>
             <div class="form-group row">
                <div class="form-row col">

                  <div class="col">          
                <asp:TextBox ID="TextBox13" class="form-control" placeholder="Ingrese ID del vehiculo" runat="server"></asp:TextBox>
                </div>

                      <div class="col">          
                         <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Buscar" OnClick="Button2_Click"/>
                </div>
                </div>
            </div>
            <hr />

            <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                <asp:Label ID="Label1" runat="server" Text="Marca del vehiculo"></asp:Label>
                <asp:TextBox ID="TextBox1" class="form-control" placeholder="Marca" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Modelo del vehiculo"></asp:Label>
                <asp:TextBox ID="TextBox2" class="form-control" placeholder="Modelo" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>

             <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                  <asp:Label ID="Label14" runat="server" Text="Año del vehiculo"></asp:Label>
                <asp:TextBox ID="TextBox3" class="form-control" placeholder="Año" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label15" runat="server" Text="Color del vehiculo"></asp:Label>
                <asp:TextBox ID="TextBox4" class="form-control" placeholder="Color" runat="server"></asp:TextBox>                </div>
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Tipo de vehiculo"></asp:Label>
                <asp:DropDownList class="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>

            
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Precio por dia"></asp:Label>
                <asp:TextBox ID="TextBox5" class="form-control" placeholder="Precio" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            </div>

             <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                <asp:Label ID="Label3" runat="server" Text="Capacidad del vehiculo (KG)"></asp:Label>
                <asp:TextBox ID="TextBox6" class="form-control" placeholder="Capacidad" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                     <asp:Label ID="Label4" runat="server" Text="Capacidad de pasajeros"></asp:Label>
                <asp:TextBox ID="TextBox7" class="form-control" placeholder="Pasajeros" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>

            
             <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                <asp:Label ID="Label7" runat="server" Text="Matricula del vehiculo"></asp:Label>
                <asp:TextBox ID="TextBox8" class="form-control" placeholder="Matricula" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                     <asp:Label ID="Label8" runat="server" Text="No. Seguro del vehiculo"></asp:Label>
                <asp:TextBox ID="TextBox9" class="form-control" placeholder="Numero de seguro" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="Foto del vehiculo"></asp:Label>
                <asp:TextBox ID="TextBox10" class="form-control" placeholder="Foto" runat="server"></asp:TextBox>
            </div>


            <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                <asp:Label ID="Label9" runat="server" Text="Latitud"></asp:Label>
                <asp:TextBox ID="TextBox11" class="form-control" placeholder="latitud" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                     <asp:Label ID="Label10" runat="server" Text="Longitud"></asp:Label>
                <asp:TextBox ID="TextBox12" class="form-control" placeholder="longitud" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>
    
            <asp:Button ID="Button1" class="btn btn-primary btn-block mt-4 mb-4" runat="server" Text="Editar vehiculo" OnClick="Button1_Click1"  />

        </div>
    </form>
</body>
</html>
