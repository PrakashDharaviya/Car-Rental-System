<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="CarBooking.View.Admin.Cars" enableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody"
     runat="server">
    
    <div class="container" >
        <link href="../../Asserts/CSS/caradmin.css" rel="stylesheet" />
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                        <h1 class="text-light">Manage Cars</h1>
                    </div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col container">
                        <form runat="server">
                            <div class="form-group">
                                <label for="exampleInputEmail">Licence Number</label>
                                <input type="text" class="form-control" id="LnumTb" placeholder="Enter Plate Number" runat="server" />
                            </div>
                             <div class="form-group">
                                <label for="exampleInputEmail">Brand</label>
                                <input type="text" class="form-control" id="BrandTb"  placeholder="Enter Car's Brand" runat="server" />
                            </div> <div class="form-group">
                                <label for="exampleInputEmail">Model</label>
                                <input type="text" class="form-control" id="ModelTb"  placeholder="Enter Model " runat="server" />
                            </div> <div class="form-group">
                                <label for="exampleInputEmail">Price</label>
                                <input type="text" class="form-control" id="PriceTb"  placeholder="Enter Car Price" runat="server" />
                            </div> <div class="form-group">
                                <label for="exampleInputEmail">Color</label>
                                <input type="text" class="form-control" id="ColorTb"  placeholder="Enter Car Color" runat="server"  />
                            </div> <div class="form-group">
                                <label for="exampleInputEmail">Availabel</label>
                                <asp:dropdownlist ID="AvaiCb" runat="server" class="form-control" >
                                    <asp:ListItem>Availabel</asp:ListItem>
                                    <asp:ListItem>Booked</asp:ListItem>
                                </asp:dropdownlist>
                               
                            </div>
                            <br />
                            <label id="ErrorMsg" runat="server" class="text-danger"></label><br />
                            <asp:Button type="submit" id="addbtn" class="btn btn-danger" Text="ADD" runat="server" OnClick="addbtn_Click"/>
                            <asp:Button type="submit" id="editbtn" class="btn btn-danger" Text="UPDATE" runat="server" OnClick="editbtn_Click"/>
                            <asp:Button type="submit" id="deletebtn" class="btn btn-danger" Text="DELETE" runat="server" OnClick="deletebtn_Click"/>
                           
                        </form>
                    </div>
                </div>
            </div>
            <div class="col-md-8 " style="margin-top:40px">

                <h1 style="margin-bottom:75px">Car List</h1>
               <asp:GridView runat="server" ID="CarList" Class="table table-hover gredbg" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged">
                   

               </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
