<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewResponse.aspx.cs" Inherits="LetsAdopt.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:GridView ID="GridView1" runat="server" CssClass="table table-condensed table-hover" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand" ShowHeaderWhenEmpty="True">
        <Columns>
            <asp:ButtonField ButtonType="Button" Text="Contact" CommandName="contact" />

        </Columns>
        <EmptyDataTemplate>
            <div>No Responses.</div>
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:Image ID="Image1" runat="server" Height="250px" Width="250px" />


    <h2 style="margin-left: 42%;">Contact Info</h2>
    <div class="container py-5" style="margin-top: 5%;">
        <div class="row">
            <div class="col-md-10 mx-auto">
                <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputFirstname">Name: </label>
                        <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
                    </div>

                    <div class="col-sm-6">
                        <label for="inputFirstname">Email: </label>
                        <asp:Label ID="email" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputFirstname">Phone: </label>
                        <asp:Label ID="phone" runat="server" Text="Label"></asp:Label>
                    </div>

                    <div class="col-sm-6">
                        <label for="inputFirstname">Street: </label>
                        <asp:Label ID="street" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputFirstname">City: </label>
                        <asp:Label ID="city" runat="server" Text="Label"></asp:Label>
                    </div>

                    <div class="col-sm-6">
                        <label for="inputFirstname">State: </label>
                        <asp:Label ID="state" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputFirstname">Pin: </label>
                        <asp:Label ID="pin" runat="server" Text="Label"></asp:Label>
                    </div>

                    <div class="col-sm-6">
                        <label for="inputFirstname">Country: </label>
                        <asp:Label ID="country" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div style="height: 100px;">
                </div>
            </div>
        </div>
    </div>

</asp:Content>
