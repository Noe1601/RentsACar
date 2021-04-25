<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroVehiculos.aspx.cs" Inherits="ProyectoFinalProg3.RegistroVehiculos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/7.29.0/sweetalert2.css" rel="stylesheet"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/7.29.0/sweetalert2.all.js"></script>
    <title></title>
    <script>
        function showAlert() {
            Swal.fire(
                'Good job!',
                'You clicked the button!',
                'success'
            )
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Registro <small>Vehiculos</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>

               <asp:Label ID="Label12" runat="server" Text="Label">
                 <div class="alert alert-success m-3" id="alerta1" role="alert">
              Vehiculo registrado exitosamente!
            </div>
            </asp:Label>
           
            <asp:Label ID="Label13" runat="server" Text="Label">
                <div class="alert alert-danger m-3" id="alerta2"  role="alert">
              No se registo el vehiculo, intentelo de nuevo.
            </div>
            </asp:Label>

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
                <asp:TextBox ID="TextBox5" class="form-control" placeholder="Precio" runat="server"></asp:TextBox>
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
    
            <asp:Button ID="Button1" class="btn btn-primary btn-block mt-4 mb-4" runat="server" Text="Registrar vehiculo" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
