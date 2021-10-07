<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="webapp.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>
                <tr>
                    
                    <td><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></td>
                     
                </tr>
                <tr>
                    <td class="auto-style1">Purchase Amount</td>
                    <td>
                        <asp:TextBox ID="txtpurch_amt" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td class="auto-style1">Order date</td>
                    <td>
                        <asp:TextBox ID="txtord_date" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">Salesman_id and name</td>

                     <td>
                         <asp:DropDownList ID="ddlSalesmanid" runat="server"></asp:DropDownList>
                     </td>
                </tr>
                 <tr>
                     <td class="auto-style1">Customer id and name</td>

                     <td>
                         <asp:DropDownList ID="ddlcusid" runat="server"></asp:DropDownList>
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
                                
                                <asp:BoundField DataField="ord_no" HeaderText="order no" />
                                <asp:BoundField DataField="purch_amt" HeaderText="purchase amt" />
                                <asp:BoundField DataField="ord_date" HeaderText="order date" />
                                <asp:BoundField DataField="salesman_id" HeaderText="Salesman id" />
                                <asp:BoundField DataField="customer_id" HeaderText="Customer id" />
                                <asp:TemplateField HeaderText="edit">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="eidbtnid" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ord_no") %>'>Edit</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="delete">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Editbtndelete" runat="server"  CommandName="Delete" CommandArgument='<%# Eval("ord_no") %>'>Delete</asp:LinkButton>
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
