<%@ Page Title="" Language="C#" MasterPageFile="~/webpage.Master" AutoEventWireup="true" CodeBehind="Booking details.aspx.cs" Inherits="EventManagement.Booking_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Booking details
    </h1>
    <hr />
   <table>
       <tr>
           <asp:TextBox ID="txtbookingdet" runat="server"></asp:TextBox>
       </tr>
   </table>
</asp:Content>
