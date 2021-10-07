<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebForm2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My web page for customers</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>
                <tr>
                    
                    <td><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></td>
                     
                </tr>
                <tr>
                    <td class="auto-style1">Customer name</td>
                    <td>
                        <asp:TextBox ID="txtcusname" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td class="auto-style1">Customer city</td>
                    <td>
                        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">grade</td>
                    <td>
                        <asp:TextBox ID="txtgrade" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                     <td class="auto-style1">Salesman_id and name</td>

                     <td>
                         <asp:DropDownList ID="ddlSalesmanid" runat="server"></asp:DropDownList>
                     </td>
                 </tr>

                <tr>
                   
                    <td class="auto-style1">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Width="98px" />
                        <asp:Button ID="btnUpdate" runat="server" OnClick="Button1_Click" Text="Update" />
                        <br />
                    </td>
                </tr>
                <tr> 
                    
                    <td class="auto-style1">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting">
                            <Columns>
                                <asp:BoundField DataField="customer_id" HeaderText="Customer id" />
                                <asp:BoundField DataField="cus_name" HeaderText="name" />
                                <asp:BoundField DataField="city" HeaderText="city" />
                                <asp:BoundField DataField="grade" HeaderText="grade" />
                                <asp:BoundField DataField="salesman_id" HeaderText="Salesman_id" />
                                <asp:TemplateField HeaderText="edit">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="eidbtnid" runat="server" CommandName="Edit" CommandArgument='<%# Eval("customer_id") %>'>Edit</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="delete">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Editbtndelete" runat="server"  CommandName="Delete" CommandArgument='<%# Eval("customer_id") %>'>Delete</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                </table>

        </div>
    </form>
</body>
</html>
