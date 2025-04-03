<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="ShopingWebSiteFirstProject.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 186px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 186px;
            height: 38px;
        }
        .auto-style4 {
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Image ID="Image1" runat="server" CssClass="auto-style2" Height="432px" Width="644px" />
            </td>
            <td>&nbsp;</td>
           
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Text="Label    "></asp:Label>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="#CCCC00" Text="RS"></asp:Label>
            </td>
            <td>&nbsp;</td>
           
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Size="Small" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Italic="True" Font-Size="Small" Font-Underline="True" ForeColor="#CCFFFF" Text="Stock:  "></asp:Label>
                <asp:Label ID="Label4" runat="server" Font-Italic="True" Font-Size="Small" Font-Underline="True" ForeColor="#CCFFFF" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
          
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Quantity:  "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Number" Width="66px"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="Label    " Visible="False"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter a Quantity"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Quantity must be greater than 0" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </td>
            <td>&nbsp;</td>
            
        </tr>
       
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style4"></td>
            
        </tr>
       
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Add To Cart" Width="157px" />
                <asp:Label ID="Label9" runat="server" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
            
        </tr>
       
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Continue" Width="158px" />
            </td>
            <td>&nbsp;</td>
            
        </tr>
       
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="View Cart" Width="158px" />
            </td>
            <td>&nbsp;</td>
            
        </tr>
       
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            
        </tr>
       
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            
        </tr>
       
    </table>
</asp:Content>
