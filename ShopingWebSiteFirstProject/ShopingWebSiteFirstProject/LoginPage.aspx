    <%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ShopingWebSiteFirstProject.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    <table class="w-100">
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Login" Font-Underline="True"></asp:Label>
            </td>
            <td></td>
        </tr>
    <tr>

        <td class="auto-style1">
            </td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
        </td>
        <td class="auto-style1">
            </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter UserName"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Invalid Username Or Password" Visible="False"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UserRegistration.aspx">Don&#39;t have an account? </asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="Large" NavigateUrl="~/AdminReg.aspx">Admin   </asp:HyperLink>
            <asp:Label ID="Label4" runat="server" Text="Or   "></asp:Label>
            <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Size="Large" NavigateUrl="~/UserRegistration.aspx">User</asp:HyperLink>
        </td>
        <td>&nbsp;</td>
    </tr>
    </table>
    
    
    
</asp:Content>
