<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="LetsAdopt.UserProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h2 style="margin-top: 5%; margin-right: 10%">Update Address</h2>
        <div class="row">

            <asp:Image ID="Image1" runat="server" Height="300px" Width="400px" />
            <div class="container py-5" style="margin-top: 25px;">
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
                            
                            <div class="form-group row" style="margin-top:80px">
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                </div>

                            <div class="form-group row">
                                <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" class="btn btn-primary px-4 float-right" Style="margin-top: 8px; background-color: #6C63FF" />
                            </div>

                            

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

    <h2 style="margin-left: 42%; margin-bottom: 25px; margin-top: 25px;">My Address</h2>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-condensed table-hover" ShowHeaderWhenEmpty="true" OnRowDataBound="GridView1_RowDataBound">
        <EmptyDataTemplate>
            <div>No records found.</div>
        </EmptyDataTemplate>
    </asp:GridView>




    <div style="height: 100px;">
    </div>


</asp:Content>
