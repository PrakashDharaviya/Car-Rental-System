<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CarBooking.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Asserts/Libraries/css/bootstrap.min.css"/>
    <link href="../Asserts/CSS/login.css" rel="stylesheet" />
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-5">
                <div class="row mt-5">
                    <div class="col"></div>
                    
                    <div class="col"></div>
                </div>
              <form runat="server">
                  <h2 class="text-warning">Login Page</h2>
                <div class="form-group" runat="server">
                 
                    <label for="exampleInputEmail1">Username :</label>
                    <input type="text" class="form-control" id="Uname" aria-describedby="emailHelp" placeholder="Enter Username HERE" runat="server" required="required">
                    <small id="emailHelp" class="form-text text-muted">We'll never share your Username with anyone else.</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Password :</label>
                    <input type="password" class="form-control" id="Upass" placeholder="Enter Password HERE" runat="server" required="required">
                     <small id="Small1" class="form-text text-muted">We'll never share your Password with anyone else.</small>
                </div>
                <div class="form-group ">
                    <input type="radio" class="form-check-input" id="CustRDB" name="role" runat="server" />
                    <label class="form-check-label" for="exampleCheck1">Customer</label>
                    <br />
                    <input type="radio" class="form-check-input" id="AdminRDB" name="role" runat="server" />
                    <label class="form-check-label" for="exampleCheck1">Admin</label>
                </div>
                  <br />
                 <div class="form-group d-grid">
                   <label id="InfoMsg" runat="server" class="text-danger"></label>
                      <asp:Button type="submit" id="LoginTb" class="btn btn-warning btn-block" Text="Login" runat="server" OnClick="LoginTb_Click" /> 
                </div>
                
            </form>
            </div>
            <div class="col-md-3"></div>
        </div>
    </div>
   
</body>
</html>
