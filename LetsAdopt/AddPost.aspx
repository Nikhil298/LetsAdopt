<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddPost.aspx.cs" Inherits="LetsAdopt.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container">
      <h2 style="margin-top:15px">Add a Post</h2>
      <div class="row">
        
                <asp:Image ID="Image1" runat="server" Height="350px" Width="450px"/>
       
                <asp:FileUpload ID="FileUpload1" runat="server"/>
                <br />
                <h3><asp:Label ID="Label2" runat="server" Text="Description" style="font-size:large"></asp:Label></h3>
                <br/>
                <asp:TextBox ID="des" runat="server" style="color:black;width:100%;border:2px solid black" TextMode="MultiLine"></asp:TextBox>
                <asp:TextBox ID="uid" runat="server" Visible="False"></asp:TextBox>
                <asp:Button ID="Post" runat="server" class="login100-form-btn" Text="Add" OnClick="Post_Click" style="background-color:#6C63FF"/>
        
        
    </div>
  </div>
    <div style="height:70px;">

        </div>
</asp:Content>
