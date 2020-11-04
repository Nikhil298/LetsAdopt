<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddPost.aspx.cs" Inherits="LetsAdopt.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-inline">
  <div class="form-group">
    <label for="exampleInputEmail1">image</label>
      <asp:FileUpload ID="FileUpload1" runat="server" />
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Description</label>
    <asp:TextBox ID="des" runat="server" class="form-control"></asp:TextBox>
  </div>
  <div class="form-check">
    <asp:TextBox ID="uid" runat="server" class="form-control"></asp:TextBox>
  </div>
     <asp:Button ID="Post" runat="server" Text="Button" OnClick="Post_Click" />
</div>







</asp:Content>
