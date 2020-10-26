<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="LetsAdopt.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-50">
				<div class="login100-form validate-form">
					<span class="login100-form-title p-b-33">
						Account Login
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						<asp:TextBox ID="Name" class="input100" type="text" name="name" placeholder="Name" runat="server"></asp:TextBox>
						<span class="focus-input100-1"></span>
						<span class="focus-input100-2"></span>
					</div>

					<div class="wrap-input100 rs1 validate-input" data-validate="Password is required">
						<asp:TextBox ID="Email" class="input100" type="text" name="email" placeholder="E-mail" runat="server"></asp:TextBox>
						<span class="focus-input100-1"></span>
						<span class="focus-input100-2"></span>
					</div>
					<div class="wrap-input100 rs1 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						<asp:TextBox ID="password" class="input100" type="password" name="psd" placeholder="Password" runat="server"></asp:TextBox>
						<span class="focus-input100-1"></span>
						<span class="focus-input100-2"></span>
					</div>
					<div class="wrap-input100 rs1 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						<asp:TextBox ID="cpassword" class="input100" type="password" name="cpsd" placeholder="Confirm Password" runat="server"></asp:TextBox>
						<span class="focus-input100-1"></span>
						<span class="focus-input100-2"></span>
					</div>
					

					<div class="container-login100-form-btn m-t-20">
                        <asp:Button ID="submit" class="login100-form-btn" runat="server" Text="Submit" />
						
					</div>

				
					<div class="text-center">
						<span class="txt1">
							Have an account?
						</span>

						<a href="Login.aspx" class="txt2 hov1">
							Login
						</a>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
