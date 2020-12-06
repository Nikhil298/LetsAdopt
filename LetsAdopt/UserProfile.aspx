<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="LetsAdopt.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style="margin-left:42%;margin-bottom:25px;margin-top:25px;font-weight:bold;text-decoration: underline;">My Address</h3>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped" ShowHeaderWhenEmpty="true">
        <EmptyDataTemplate>
        <div>No records found.</div>
    </EmptyDataTemplate>
    </asp:GridView>
    <h3 style="margin-left:40%;font-weight:bold;text-decoration: underline;margin-top:5%">Update Address</h3>
    <div class="container py-5" style="margin-top:25px;">
     <div class="row">
      <div class="col-md-10 mx-auto">
          <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputFirstname">Phone</label>
                         <asp:TextBox ID="pno" runat="server" BorderStyle="Solid" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-6">
                        <label for="inputLastname">Street</label>
                        <asp:TextBox ID="street" runat="server" BorderStyle="Solid" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputAddressLine1">City</label>
                         <asp:TextBox ID="city" runat="server" BorderStyle="Solid" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-6">
                        <label for="inputAddressLine2">State</label>
                        <asp:TextBox ID="state" runat="server" BorderStyle="Solid" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputCity">Zip</label>
                         <asp:TextBox ID="zip" runat="server" BorderStyle="Solid" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-6">
                        <label for="inputState">Country</label>
                        <asp:TextBox ID="country" runat="server" BorderStyle="Solid" class="form-control"></asp:TextBox>
                    </div>
                   
                       <div class="form-group row">
                            
                                <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click"  class="btn btn-primary px-4 float-right"  style="margin-top:8px"/>
                           
                        </div>

                </div>
               
            </div>
   </div>
  </div>
        
       
        
       
        
       
        
       


  

</asp:Content>
