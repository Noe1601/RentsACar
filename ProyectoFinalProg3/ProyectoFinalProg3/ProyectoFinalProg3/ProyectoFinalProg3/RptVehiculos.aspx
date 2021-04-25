<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RptVehiculos.aspx.cs" Inherits="ProyectoFinalProg3.RptVehiculos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
        <link rel="stylesheet" href="Estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <h1>Listado de<small> vehiculos</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>
            <hr />

             <div class="form-group row">
                 <div class="form-row col">

                <div class="col">                  
                <asp:Label ID="Label1" runat="server" Text="Fecha inicial"></asp:Label>
                 <asp:TextBox ID="TextBox1" class="form-control" placeholder="Ingrese la fecha principal" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Fecha final"></asp:Label>
                <asp:TextBox ID="TextBox2" class="form-control" placeholder="Ingrese la fecha final" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>

            <asp:Button ID="Button1" class="btn btn-primary btn-block mt-4 mb-4" runat="server" Text="Buscar vehiculos" />
            
                <asp:GridView class="table table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="ID" HeaderText="No. Vehiculo" />
                    <asp:BoundField DataField="MARCA" HeaderText="Marca" />
                    <asp:BoundField DataField="MODELO" HeaderText="Modelo" />
                    <asp:BoundField DataField="ANIO" HeaderText="Año" />
                    <asp:BoundField DataField="COLOR" HeaderText="Color" />
                    <asp:BoundField DataField="PRECIO_DIA" HeaderText="Precio por dia" />
                    <asp:BoundField DataField="PASAJEROS" HeaderText="Capacidad pasajeros" />
                    <asp:BoundField DataField="CAPACIDAD_CARGA" HeaderText="Capacidad de carga (KG)" />
                    <asp:BoundField DataField="MATRICULA" HeaderText="No.Matricula" />
                    <asp:BoundField DataField="NO_SEGURO" HeaderText="No.Seguro" />
                    <asp:BoundField DataField="FOTO" HeaderText="Imagen" />
                    </Columns>
                </asp:GridView>
            
        </div>
    </form>
</body>
</html>
