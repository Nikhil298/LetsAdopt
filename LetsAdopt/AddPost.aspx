<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddPost.aspx.cs" Inherits="LetsAdopt.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
   
  <div style="width:40%;margin-left:30%;margin-top:5%">
    <asp:Label ID="Label1" runat="server" Text="Image" style="font-size:large"></asp:Label>
    <asp:FileUpload ID="FileUpload1" runat="server"/>
      <br />
    <asp:Label ID="Label2" runat="server" Text="Description" style="font-size:large"></asp:Label>
      <br/>
    <asp:TextBox ID="des" runat="server" style="color:black;width:100%;border:2px solid black" TextMode="MultiLine"></asp:TextBox>
    <asp:TextBox ID="uid" runat="server" Visible="False"></asp:TextBox>
     <asp:Button ID="Post" runat="server" class="login100-form-btn" Text="Add" OnClick="Post_Click" />
  </div>
        
    

</asp:Content>
