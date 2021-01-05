<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewPost.aspx.cs" Inherits="LetsAdopt.WebForm4" %>

<%@ MasterType VirtualPath="~/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="justify-content: center; margin-left: 30%">
        <asp:Image ID="Image2" runat="server" Width="550" Height="500" />
        <h2>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h2>
    </div>

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="7" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand1">

        <ItemTemplate>

            <div class="card" style="width: 18rem; border: 1px; margin-top: 20px; margin-left: 10px">
                <!--<img class="card-img-top" src="..." alt="Card image cap">-->

                <asp:Image ID="Image1" runat="server" class="card-img-top" ImageUrl='<%# Eval("image") %>' Style="height: 180px; width: 180px;" />

                <div class="card-body">
                    <!-- <asp:Label ID="Label4" runat="server" class="card-title" Text='<%# Eval("pid") %>'></asp:Label>-->
                    <!-- <h4 class="card-title"><%# Eval("pid") %></h4>-->
                    <!--<asp:Label ID="Label3" runat="server" class="card-text" Text='<%# "des" %>'></asp:Label>-->
                    <div style="margin-top: 5px; margin-bottom: 6px;">
                        <h4 class="card-text"><%# Eval("des") %></h4>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Intrested" class="btn btn-primary" CommandName="viewdetail" CommandArgument='<%# Eval ("pid") %>' />
                </div>
            </div>

        </ItemTemplate>
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    </asp:DataList>



    <div style="height: 100px;">
    </div>

</asp:Content>
