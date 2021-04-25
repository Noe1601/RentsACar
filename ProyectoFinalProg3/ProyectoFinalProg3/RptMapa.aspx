<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RptMapa.aspx.cs" Inherits="ProyectoFinalProg3.RptMapa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>

    <script
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAH2FSNzoruu0wlP2ktYQ5mMHh3HR-uhtY&callback=initMap">
</script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="conatiner">
            <div id="ModalMapPreview" style="width: 80%; height: 400px;"></div>
        </div>
    </form>

    <script>
        $("#ModalMapPreview").locationpicker({
            radius: 0,
            location: {
                latitude: 18.5640695,
                longitude: -69.9192887
            },
            enabledAutoComplete: true
        });
    </script>
</body>
</html>
