<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewPost.aspx.cs" Inherits="LetsAdopt.WebForm4"%>
<%@ MasterType VirtualPath="~/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand1">
        
        <ItemTemplate>
           <!-- <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br />-->

            <div class="card" style="width: 18rem; margin-left:10px;border:1px;margin-top:20px">
                <img class="card-img-top" src="..." alt="Card image cap">
               <!-- <asp:Label ID="Label2" runat="server" class="card-img-top" Text='<%# Eval("image") %>'></asp:Label> -->
                    <div class="card-body">
                       <!-- <asp:Label ID="Label4" runat="server" class="card-title" Text='<%# Eval("pid") %>'></asp:Label>-->
                        <h2 class="card-title"><%# Eval("pid") %></h2> 
                        <!--<asp:Label ID="Label3" runat="server" class="card-text" Text='<%# "des" %>'></asp:Label>-->
                        <h4 class="card-text"><%# Eval("des") %></h4>
                        <asp:Button ID="Button1" runat="server" Text="Intrested" class="btn btn-primary" CommandName="viewdetail" CommandArgument='<%# Eval ("pid") %>'/>
                    </div>
            </div>
          
        </ItemTemplate>
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
   
   
   


</asp:Content>
