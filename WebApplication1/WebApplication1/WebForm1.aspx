<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="validation.js"></script>
  <link rel="stylesheet" href="validation.css">
<body>

   <div class="container">
  <h2 class="title">Registration</h2>
  <form action="#" name="registration">

    <label for="firstname">First Name</label>
    <input type="text" name="firstname" id="firstname" placeholder="John">

    <label for="lastname">Last Name</label>
    <input type="text" name="lastname" id="lastname" placeholder="Doe">

    <label for="email">Email</label>
    <input type="email" name="email" id="email" placeholder="john@doe.com">

    <label for="password">Password</label>
    <input type="password" name="password" id="password" placeholder="&#9679;&#9679;&#9679;&#9679;&#9679;">

    <button type="submit">Register</button>
  </form>

  <div class="article-reference">
    This example is part of the article
    <a href="https://www.sitepoint.com/basic-jquery-form-validation-tutorial/" target="_blank">Basic jQuery Form Validation Example</a> on <a href="http://sitepoint.com/" target="_blank">SitePoint</a> by
    <a href="https://github.com/julmot" target="_blank">Julian Motz</a>.
  </div>
</div>
</body>
</html>
