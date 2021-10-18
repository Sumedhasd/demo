<%@ Page Title="" Language="C#" MasterPageFile="~/webpage.Master" AutoEventWireup="true" CodeBehind="User registration page.aspx.cs" Inherits="EventManagement.User_registration_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style1">First Name</td>
             </tr>
         <tr>
            <td >
                <asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
            </td>
              
        </tr>

        <tr>
            <td class="auto-style1">Last Name</td>
             </tr>
         <tr>
            <td >
                <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
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
            <td class="auto-style1">Email id</td>
             </tr>
         <tr>
            <td>
                <asp:TextBox ID="txtemailid" runat="server"></asp:TextBox>
            </td>
              
        </tr>
                
        
          <tr>
            <td class="auto-style1">Phone</td>
             </tr>
         <tr>
            <td>
                <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="auto-style1">Address</td>
             </tr>
         <tr>
            <td>
                <asp:TextBox ID="txtaddress" runat="server" Height="30px"></asp:TextBox>
            </td>
         </tr>
         <tr>
             <td>

                 <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" />

             </td>
            
         </tr>
         <tr>
             <td>

                 <asp:Label ID="lbltext" runat="server" Text=""></asp:Label>

             </td>
            
         </tr>
         </table>
</asp:Content>
