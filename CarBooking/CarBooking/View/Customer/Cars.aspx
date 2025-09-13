<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="CarBooking.View.Customer.Cars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10"></div>
                
            
        </div>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4 ml-5"><img src="../../Asserts/img/Pagani.png" height="70px" width:"auto";/></div>
            <div class="col-md-4"></div>
        </div>
       
        <div class="row" >
            <div class="col-md-3"></div>
            <div class="col">
                <form runat="server">
                    <div class="row">
                        <div class="col-2"></div> 
                        <div class="col-8"><h2  style="color:black; ">Available Cars</h2></div>
                    </div>
                     <div class="col-md-8">
                         <center>
               <asp:GridView runat="server" ID="CarList" Class="table table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged" >
                   

               </asp:GridView>
                             </center>
            </div>
                    <div class="row">
                        <div class="col-4">
                            <div class="form-group">                    
                                <input type="date" class="form-control" id="Bdate" placeholder="Select Date" runat="server" required="required" />                     
                            </div>
                        </div>
                        <div class="col-4">
                             <div class="form-group d-grid">
                    <label id="InfoMsg" runat="server" class="text-danger"></label>
                      <asp:Button type="submit" id="BookingTb" class="btn btn-Black btn-block" Text="BOOK" AutoGenerateSelectButton="True" runat="server" OnClick="BookingTb_Click1" /> 
                </div>
                
                        </div>
                    </div>
                </form>
               
            </div>
        </div>
        
    </div>
</asp:Content>
