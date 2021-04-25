<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RptBeneficios.aspx.cs" Inherits="ProyectoFinalProg3.RptBeneficios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <h1>Listado de<small> beneficios</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>
            <hr />

             <asp:GridView class="table table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="false">
                   <Columns>             
                    <asp:BoundField DataField="MARCA" HeaderText="Marca" />
                    <asp:BoundField DataField="MODELO" HeaderText="Modelo" />
                    <asp:BoundField DataField="COLOR" HeaderText="Color" />
                    <asp:BoundField DataField="CANTIDAD" HeaderText="Cantidad de veces alquiladas" />
                    <asp:BoundField DataField="MONTO" HeaderText="Beneficios" />
                    </Columns>
             </asp:GridView>

        </div>
    </form>
</body>
</html>
