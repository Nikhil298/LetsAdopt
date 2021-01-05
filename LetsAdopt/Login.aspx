<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LetsAdopt.WebForm1" %>
<%@ MasterType VirtualPath="~/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="limiter">
		<div class="container-login100" style="background-color:white">
			<h2>Dont' shop Lets' Adopt</h2>
            <asp:Image ID="Image1" runat="server" Height="450px" Width="600px"/>
			<div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-50">
				<div class="login100-form validate-form">
					<span class="login100-form-title p-b-33" style="color:#6C63FF">
						Account Login
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						
                        <asp:TextBox ID="email" class="input100" type="text" name="email" placeholder="Email" runat="server"></asp:TextBox>
						<span class="focus-input100-1"></span>
						<span class="focus-input100-2"></span>
					</div>

					<div class="wrap-input100 rs1 validate-input" data-validate="Password is required">
						<asp:TextBox ID="password" class="input100" type="password" name="psd" placeholder="Password" runat="server"></asp:TextBox>

						<span class="focus-input100-1"></span>
						<span class="focus-input100-2"></span>
					</div>

					<div class="container-login100-form-btn m-t-20">
                        <asp:Button ID="submit" class="login100-form-btn" runat="server" Text="Submit" OnClick="submit_Click" style="background-color:#6C63FF"/>
					</div>

					

					<div class="text-center">
						<span class="txt1" style="color:#6C63FF">
							Create an account?
						</span>

						<a href="Registeration.aspx" class="txt2 hov1" style="color:#6C63FF">
							Sign up
						</a>
					</div>
				</div>
			</div>
		</div>
	</div>

</asp:Content>
 
