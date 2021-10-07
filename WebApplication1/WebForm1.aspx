<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My web page
    </title>
    <style>
        th {
  text-align: left;
}
        .auto-style1 {
            width: 345px;
        }
    </style>
    
</head>
<body>
        <div>
            <form id ="form1" runat ="server">
            <table>
                <tr>
                    <td></td>
                    <td><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></td>
                     
                </tr>
                <tr>
                    <td class="auto-style1">Salesman name</td>
                    <td>
                        <asp:TextBox ID="txtSalesmanname" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td class="auto-style1">Salesman city</td>
                    <td>
                        <asp:TextBox ID="txtSalesmancity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">Salesman commission</td>
                    <td>
                        <asp:TextBox ID="txtSalesmancommission" runat="server"></asp:TextBox></td>
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
                                <asp:BoundField DataField="salesman_id" HeaderText="Salesman id" />
                                <asp:BoundField DataField="name" HeaderText="Salesman name" />
                                <asp:BoundField DataField="city" HeaderText="city" />
                                <asp:BoundField DataField="commission" HeaderText="commission" />
                                <asp:TemplateField HeaderText="edit">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="eidbtnid" runat="server" CommandName="Edit" CommandArgument='<%# Eval("salesman_id") %>'>Edit</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="delete">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Editbtndelete" runat="server"  CommandName="Delete" CommandArgument='<%# Eval("salesman_id") %>'>Delete</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                </table>
                    </form>
            
                </div>

            <%--<table border="1">
                <thead>
                    <tr>
                        <th>salesman_id</th>
                        <th>name</th>
                        <th>city</th>
                        <th>commission</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>5001</td>
                        <td>James Hoog</td>
                        <td>New York</td>
                        <td>0.15</td>
                    </tr>
                    <tr>
                        <td>5001</td>
                        <td>James Hoog</td>
                        <td>New York</td>
                        <td>0.15</td>
                    </tr>
                    <tr>
                        <td>5002</td>
                        <td>Nail Knite</td>
                        <td>Paris</td>
                        <td>0.13</td>
                    </tr>
                    <tr>
                        <td>5003</td>
                        <td>Lauson Hen</td>
                        <td>San Jose</td>
                        <td>0.12</td>
                    </tr>
                    <tr>
                        <td>5004</td>
                        <td>Pit Alex</td>
                        <td>London</td>
                        <td>0.11</td>
                    </tr>
                    <tr>
                        <td>5005</td>
                        <td>Mc Lyon</td>
                        <td>Paris</td>
                        <td>0.14</td>
                    </tr>
                    <tr>
                        <td>5006</td>
                        <td>Paul Adam</td>
                        <td>Rome</td>
                        <td>0.13</td>
                    </tr>
                </tbody>
            </table>--%>
        
    
 
    
 
</body>
</html>
