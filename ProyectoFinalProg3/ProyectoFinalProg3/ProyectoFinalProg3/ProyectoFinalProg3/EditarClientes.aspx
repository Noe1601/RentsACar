<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarClientes.aspx.cs" Inherits="ProyectoFinalProg3.EditarClientes" %>

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
            <h1>Editar <small>Clientes</small></h1>
            <a href="Principal.aspx" class="m-2">Ir a dashboard</a>
            <div class="form-group row">
                <div class="form-row col">

                  <div class="col">          
                <asp:TextBox ID="TextBox9" class="form-control" placeholder="Ingrese su ID" runat="server"></asp:TextBox>
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
                <asp:Label ID="Label1" runat="server" Text="Cedula"></asp:Label>
                <asp:TextBox ID="TextBox1" class="form-control" placeholder="Ingrese su cedula" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="TextBox2" class="form-control" placeholder="Ingrese su nombre" runat="server"></asp:TextBox>
                </div>
                </div>

                 <div class="col">
                <asp:Label ID="Label8" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="TextBox3" class="form-control" placeholder="Ingrese su correo" runat="server"></asp:TextBox>
                </div>
                </div>
            

            
             <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                <asp:Label ID="Label3" runat="server" Text="Licencia"></asp:Label>
                <asp:TextBox ID="TextBox4" class="form-control" placeholder="Ingrese su licencia" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label4" runat="server" Text="Nacionalidad"></asp:Label>
                <asp:TextBox ID="TextBox5" class="form-control" placeholder="Ingrese su nacionalidad" runat="server"></asp:TextBox>
                </div>
                </div>
            </div>


            
             <div class="form-group row">
                 <div class="form-row col">

                <div class="col">
                <asp:Label ID="Label5" runat="server" Text="Sangre"></asp:Label>
                <asp:TextBox ID="TextBox6" class="form-control" placeholder="Ingrese su tipo de sangre" runat="server"></asp:TextBox>
                </div>

                <div class="col">
                <asp:Label ID="Label6" runat="server" Text="Foto personal"></asp:Label>
                <asp:TextBox ID="TextBox7" class="form-control" placeholder="Ingrese su foto personal" runat="server"></asp:TextBox>
                </div>

                     
                <div class="col">
                <asp:Label ID="Label7" runat="server" Text="Foto licencia"></asp:Label>
                <asp:TextBox ID="TextBox8" class="form-control" placeholder="Ingrese su foto licencia" runat="server"></asp:TextBox>
                </div>
                </div>

                   <asp:Button ID="Button1" class="btn btn-primary btn-block mt-4 mb-4" runat="server" Text="Editar cliente" OnClick="Button1_Click" />
            </div>
            
            </div>
           
        

    </form>
</body>
</html>
