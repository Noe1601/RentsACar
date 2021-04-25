<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="ProyectoFinalProg3.Reservas" %>

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

             <h1>Registro <small>Reservas</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>
            <hr />

              <div class="form-group row">
                 <div class="form-row col">

                <div class="col">                  
                <asp:Label ID="Label1" runat="server" Text="Vehiculo"></asp:Label>
                <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
                </div>

                <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Cliente"></asp:Label>
                <asp:DropDownList ID="DropDownList2" class="form-control" runat="server"></asp:DropDownList>
                </div>
                </div>
            </div>

              <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                <asp:Label ID="Label3" runat="server" Text="Fecha inicio"></asp:Label>
                    <asp:TextBox ID="TextBox1" placeholder="Ingrese la ficha de comienzo" class="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label4" runat="server" Text="Fecha fin"></asp:Label>
                <asp:TextBox ID="TextBox2" placeholder="Ingrese la ficha de fin" class="form-control" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>

          <%--  <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Monto"></asp:Label>
                <asp:TextBox ID="TextBox2" class="form-control" placeholder="Ingrese su nombre" runat="server"></
            </div>--%>

            <asp:Button ID="Button1" class="btn btn-primary btn-block mt-4 mb-4" runat="server" Text="Registrar reserva" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
