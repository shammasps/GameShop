<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ShopingWebSiteFirstProject.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 485px;
        }
        .auto-style4 {
            width: 474px;
        }
        .auto-style5 {
            width: 637px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" Text="Add Your Own Games" ForeColor="#FFCC00" style="margin-left: 100px;"></asp:Label>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>
    <table class="w-100" style="margin-left: 100px;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="102px" ImageUrl="~/img/pngtree-blue-joystick-for-gaming-png-image_6603316.png" PostBackUrl="~/Add_Categories.aspx" Width="112px" />
            </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="102px" ImageUrl="~/img/pngtree-blue-joystick-for-gaming-png-image_6603316.png" PostBackUrl="~/Add_Categories.aspx" Width="112px" />
            </td>
            <td>
                <asp:ImageButton ID="ImageButton3" runat="server" Height="102px" ImageUrl="~/img/pngtree-blue-joystick-for-gaming-png-image_6603316.png" PostBackUrl="~/Add_Games.aspx" Width="112px" />
            </td>
            <td>
                <asp:ImageButton ID="ImageButton4" runat="server" Height="102px" ImageUrl="~/img/pngtree-blue-joystick-for-gaming-png-image_6603316.png" PostBackUrl="~/Add_Games.aspx" Width="112px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" PostBackUrl="~/Add_Categories.aspx" Font-Size="Large">Add Categorie</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" PostBackUrl="~/Add_Categories.aspx" Font-Size="X-Large">Edit Categorie</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" PostBackUrl="~/Add_Games.aspx" Font-Size="X-Large">Add Games</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" PostBackUrl="~/Add_Games.aspx" Font-Size="X-Large">Edit Games</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
