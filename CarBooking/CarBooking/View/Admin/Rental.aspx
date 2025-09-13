<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rental.aspx.cs" Inherits="CarBooking.View.Admin.Rental" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-6">
                        <img src="../../Asserts/img/amglogin-removebg-preview.png" height="200px"/>
                        <h3 class="fo1r">Rented Cars</h3>
                    </div>
                        
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col-lg-1"></div>
                    <div class="col-lg-9">
                        <form runat="server">
                             <asp:GridView runat="server" ID="RentList" Class="table table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="RentList_SelectedIndexChanged" >
                                <AlternatingRowStyle BackColor="#FFCC00" ForeColor="White" />

                             </asp:GridView>
                            <div class="form-group ">

                                <label class="form-check-label" for="exampleCheck1">Delay :</label>
                                <input type="text" class="form-control" id="DelayTb" runat="server" />
                                
                                <label class="form-check-label" for="exampleCheck1">Fine :</label>
                                <input type="text" class="form-control" id="FineTb" runat="server" />
                                
                            </div>
                
                            <br />
                            <div class="form-group d-grid">
                                <label id="InfoMsg" runat="server" class="fo1r"></label>
                                <asp:Button type="submit" id="ReturnTb" class="btn btn-danger btn-block" Text="RETURN" runat="server" OnClick="ReturnTb_Click" /> 
                            </div>
                                            
                        </form>
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
