<%@ Page Title="" Language="C#" MasterPageFile="~/webpage.Master" AutoEventWireup="true" CodeBehind="Foodorderpage.aspx.cs" Inherits="EventManagement.Foodorderpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>book venue</h1>
    <table>
        <tr>
            <td class="autostyle1">event type</td>
        </tr>
        <tr>
            <td>
                <asp:dropdownlist id="eventtype" runat="server">
                    <asp:listitem>select</asp:listitem>
                    <asp:listitem>birthday party</asp:listitem>
                    <asp:listitem>anniversary</asp:listitem>
                </asp:dropdownlist>
            </td>
        </tr>
             <tr>
            <td class="autostyle1">venue type</td>
        </tr>
           <tr>
            <td>
                <asp:dropdownlist id="venuetype" runat="server">
                    <asp:listitem>select</asp:listitem>
                    <asp:listitem>beach venue</asp:listitem>
                    <asp:listitem value="palace venue">palace venue</asp:listitem>
                </asp:dropdownlist>
            </td>
        </tr>
             <tr>
            <td class="autostyle1">no of guest</td>
        </tr>
        <tr>
            <td>
                <asp:textbox id="txtnoofguest" runat="server"></asp:textbox>
            </td>
        </tr>
        <tr>
            <td class="autostyle1">Booking Date(yyyy-mm-dd)</td>
        </tr>
        <tr>
            <td>
                <asp:textbox id="txtbookingdate" runat="server"></asp:textbox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:button id="btnbookevent" runat="server" text="book event" onclick="btnbookevent_click" />
                 <asp:button id="btncancel" runat="server" text="cancel" OnClick="btncancel_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblapproval" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        
    </table>
    <h1> Food item </h1>
    <table>
        <tr>
            <td class="autostyle1">Foodtype</td>
           <td> <asp:RadioButton ID="veg" runat="server" Text="Veg" /></td>
             <td> <asp:RadioButton ID="nonveg" runat="server" Text="NonVeg" /></td>
        </tr>
          <tr>
            <td class="autostyle1">Meal type</td>
           <td> <asp:RadioButton ID="Lunch" runat="server" Text="Lunch" /></td>
            <td> <asp:RadioButton ID="Dinner" runat="server" Text="Dinner" /></td>
        </tr>
        <tr>
            <td class="autostyle1">Dish type</td>
            <td><asp:DropDownList ID="Dishtype" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Deluxe</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
   
    <tr>
        <td>
            <asp:CheckBox ID="thaliSI" runat="server" Text="South Indian Thali" />
        </td>
    </tr>
     <tr>
        <td>
            <asp:CheckBox ID="thaliNI" runat="server" Text="North Indian Thali" />
        </td>
    </tr>
     <tr>
        <td>
            <asp:CheckBox ID="thaliPI" runat="server" Text="Punjab Thali" />
        </td>
    </tr>
     <tr>
        <td>
            <asp:CheckBox ID="thaliMI" runat="server" Text="Maharashtrian Thali" />
        </td>
    </tr>
         <tr>
            <td>
                <asp:button id="btnsavedish" runat="server" text="book Food" OnClick="btnsavedish_Click" />
                 <asp:button id="tncanceldish" runat="server" text="cancel" OnClick="tncanceldish_Click"  />
            </td>
        </tr>
         </table>
</asp:Content>
