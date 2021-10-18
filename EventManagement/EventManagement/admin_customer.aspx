<%@ Page Title="" Language="C#" MasterPageFile="~/webpage.Master" AutoEventWireup="true" CodeBehind="admin_customer.aspx.cs" Inherits="EventManagement.admin_customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4> Login page </h4>
    <table>
        <tr>
            <td class="auto-style1">Admin/Customer</td>
             </tr>
         <tr>
            <td >
                <asp:TextBox ID="txtadmincus" runat="server"></asp:TextBox>
            </td>
              
        </tr>
        <tr>
            <td class="auto-style1">Username</td>
             </tr>
         <tr>
            <td >
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            </td>
              
        </tr>
        <tr>
            <td class="auto-style1">Password</td>
             </tr>
         <tr>
            <td>
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            </td>
              
        </tr>
         <tr>
             <td class="auto-style2">
                 <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
         </tr>
        <tr>
            <td class ="auto- style3">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/User registration page.aspx">Register for new customer</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblresult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
         
       
         
    </table>
</asp:Content>
