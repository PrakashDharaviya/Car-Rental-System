<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CarBooking.View.Admin.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container mt-5 ml-5">
        <div class="row">

            <div class="jumbotron bg-black" style="width:100vw;">
                <div class="container-fluid">
                    <link href="../../Asserts/CSS/Home.css" rel="stylesheet" />
                <h2 class="display-4">Admin Panel</h2>
             </div>
                <center><p style="margin-top:2vh;" class="lead">The Admin Can Manage Cars , Customers , Rentals and Returns.</p></center>
        </div>
     </div>
        <div class="row">
            <div class="col-lg-3 col-md-8 car"><div><img src="../../Asserts/img/Mclaren.png" height="210px"/></div><div><h6 class="fo1r">Mclaren</h6></div></div>
            <div class="col-lg-3 col-md-8 car "><div> <img src="../../Asserts/img/Audi.jpg" height="170px"/></div><div><h6 class="fo1r">Audi</h6></div></div>
            <div class="col-lg-3 col-md-8 car"><div><img src="../../Asserts/img/_Ferrari_-removebg-preview.png" height="180px"/></div><div><h6 class="fo1r">Ferrari</h6></div></div>
            <div class="col-lg-3 col-md-8 car"><div><img src="../../Asserts/img/Urus.jpg" height="210px"/></div><div><h6 class="fo1r">Urus</h6></div></div>
        </div>
        <div class="row">
            <div class="col-lg-3 col-md-6 car"><div><img src="../../Asserts/img/(SVJ63).png" height="200px" /></div><div><h6 class="fo1r">SVJ 63</h6></div></div>
            <div class="col-lg-3 col-md-6 car"><div><img src="../../Asserts/img/(Koenigsegg).png" height="210px" /></div><div><h6 class="fo1r">Koenigsegg</h6></div></div>
            <div class="col-lg-3 col-md-6  car" ><div><img src="../../Asserts/img/Pagani-removebg-preview.png" height="210px"/></div><div><h6 class="fo1r">Pagani </h6></div></div>
            <div class="col-lg-3 col-md-6 car"><div><img src="../../Asserts/img/Bugatti.png" height="210px"/></div><div><h6 class="fo1r">Bugatti</h6></div></div>
        </div>
    </div>
</asp:Content>
