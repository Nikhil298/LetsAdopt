<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewResponse.aspx.cs" Inherits="LetsAdopt.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped"  AutoGenerateColumns="true" OnRowDataBound="GridView1_RowDataBound" ></asp:GridView>

</asp:Content>
