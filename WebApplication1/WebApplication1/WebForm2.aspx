<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation with Jquery</title>
      <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

   <input type="checkbox" id="vehicle1" name="vehicle1" value="Bike"/>
<label for="vehicle1"> I have a bike</label><br/>
<input type="checkbox" id="vehicle2" name="vehicle2" value="Car"/>
<label for="vehicle2"> I have a car</label><br/>
<input type="checkbox" id="vehicle3" name="vehicle3" value="Boat"/>
<label for="vehicle3"> I have a boat</label><br/>
</body>
</html>
