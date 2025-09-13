<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="CarBooking.View.Admin.Customer" enableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <link href="../../Asserts/CSS/Customer.css" rel="stylesheet" />
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                        <h3 class="fo1r">Manage Customers</h3>
                        <img src="../../Asserts/img/Customer.jpeg" height="250px"/></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form id="Form1" runat="server">
                            <div class="form-group">
                                <label for="exampleInputEmail">Customer Name</label>
                                <input type="text" class="form-control" id="CustNameTb" placeholder="Enter Customer Name" runat="server" />
                            </div>
                             <div class="form-group">
                                <label for="exampleInputEmail">Customer Address</label>
                                <input type="text" class="form-control" id="AddTb"  placeholder="Enter Customer Address " runat="server" />
                            </div>
                             <div class="form-group">
                                <label for="exampleInputEmail">Customer Phone</label>
                                <input type="text" class="form-control" id="PhoneTb"  placeholder="Enter Phone Number " runat="server" />
                            </div> 
                             <div class="form-group">
                                <label for="exampleInputEmail">Customer Password</label>
                                <input type="text" class="form-control" id="PassTb"  placeholder="Enter Customer Password " runat="server" />
                            </div> 

                            <br />
                            <label id="ErrorMsg" runat="server" class="fo1r"></label><br />
                              <asp:Button type="submit" id="addbtn" class="btn btn-danger" Text="ADD" runat="server" OnClick="addbtn_Click" />                            
                              <asp:Button type="submit" id="editbtn" class="btn btn-danger" Text="UPDATE" runat="server" OnClick="editbtn_Click" />
                              <asp:Button type="submit" id="deletebtn" class="btn btn-danger" Text="DELETE" runat="server" OnClick="deletebtn_Click"/>


                           </form>
                    </div>
                </div>
            </div>
            <div class="col-md-8" style="margin-top:9px">
                  <h1 style="margin-bottom:100px">Customer List</h1>
               <asp:GridView runat="server" ID="CustList" Class="table table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CustList_SelectedIndexChanged">

               </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
