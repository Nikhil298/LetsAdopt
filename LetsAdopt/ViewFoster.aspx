<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewFoster.aspx.cs" Inherits="LetsAdopt.ViewFoster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="7" RepeatDirection="Horizontal">

        <ItemTemplate>

            <div class="card" style="width: 18rem;">
                <div class="card-body" style="margin-top:25px;margin-left:25px">
                    <h4 class="card-text"><%# Eval("name") %></h4>
                    <h5 class="card-text"><%# Eval("email") %></h5>
                    <h4 class="card-text"><%# Eval("phone") %></h4>
                    <h4 class="card-text"><%# Eval("lane") %></h4>
                    <h4 class="card-text"><%# Eval("city") %></h4>
                    <h4 class="card-text"><%# Eval("state") %></h4>
                    <h4 class="card-text"><%# Eval("zip") %></h4>
                    <h4 class="card-text"><%# Eval("country") %></h4>
                </div>
            </div>

        </ItemTemplate>

    </asp:DataList>

</asp:Content>
