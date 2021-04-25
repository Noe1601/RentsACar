<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RptDeudas.aspx.cs" Inherits="ProyectoFinalProg3.RptDeudas" %>

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

            <h1>Listado de<small> deudas</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>
            <hr />

             <asp:GridView class="table table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="false">
                  <Columns>             
                    <asp:BoundField DataField="CEDULA" HeaderText="Cedula cliente" />
                    <asp:BoundField DataField="NOMBRE" HeaderText="Nombre cliente" />
                    <asp:BoundField DataField="MONTO" HeaderText="Monto pendiente" />
                    </Columns>
             </asp:GridView>

        </div>
    </form>
</body>
</html>
