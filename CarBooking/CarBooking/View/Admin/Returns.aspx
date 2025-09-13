<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Returns.aspx.cs" Inherits="CarBooking.View.Admin.Returns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5"></div>
            <center>

            <div class="col-md-5" style=" margin-left:21vw; "><img src="../../Asserts/img/dogglogin-removebg-preview.png" height="170px"/>
                <br /><h2>Return Car</h2>
                </center>

            </div> 
            <div class="col-md-3"></div>
        </div> 
            <div class="container">
                <form id="Form1" runat="server"> 
                     
                             <asp:GridView runat="server" CssClass="grd_padding" ID="RentList" Class="table table-hover" AutoGenerateSelectButton="false"  >

                             </asp:GridView>                                            
                        </form>
            </div>
        
    

</asp:Content>
