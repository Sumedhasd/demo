<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EventManagement.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
        </div>
    </form>
</body>
</html>
