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
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Login"></asp:Label>
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
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
        </td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:LinkButton ID="LinkButton1" runat="server">Forgot password?</asp:LinkButton>
        </td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
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
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/UserRegistration.aspx">Don&#39;t have an account? </asp:LinkButton>
            <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="Large">Admin </asp:LinkButton>
            <asp:Label ID="Label4" runat="server" Text="Or   "></asp:Label>
            <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/UserRegistration.aspx" Font-Bold="True" Font-Size="Large">User</asp:LinkButton>
        </td>
        <td>&nbsp;</td>
    </tr>
    </table>
    
    
    
</asp:Content>
