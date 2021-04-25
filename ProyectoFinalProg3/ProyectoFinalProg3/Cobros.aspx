<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cobros.aspx.cs" Inherits="ProyectoFinalProg3.Cobros" %>

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

               <h1>Cobros <small>Reservas</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>
            <hr />

             <div class="form-group row">
                 <div class="form-row col">

                <div class="col">                  
                <asp:Label ID="Label1" runat="server" Text="No. Reserva"></asp:Label>
                 <asp:TextBox ID="TextBox1" class="form-control" placeholder="Ingrese su numero de reserva" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Monto"></asp:Label>
                <asp:TextBox ID="TextBox2" class="form-control" placeholder="Ingrese el monto a pagar" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>

              <asp:Button ID="Button1" class="btn btn-primary btn-block mt-4 mb-4" runat="server" Text="Registrar pago" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
