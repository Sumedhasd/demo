<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Mymovieapp.WebForm1" %>

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
                        <td></td>
                    <td><asp:Label ID="lblMovieID" runat="server" Text=" "></asp:Label></td>
                </tr>
                 <tr>
                        <td class="auto-style1">Name</td>
                   
                    <td>
                        <asp:TextBox ID="txtname" runat="server"> </asp:TextBox>
                    </td>
                </tr>
                     <tr>
                        <td class="auto-style1">Movie Type</td>
                   
                    <td>
                        <asp:TextBox ID="txtmovietype" runat="server"> </asp:TextBox>
                    </td>
                </tr>
                     <tr>
                        <td class="auto-style1">Movie Desc</td>
                   
                    <td>
                        <asp:TextBox ID="txtmoviedes" runat="server"> </asp:TextBox>
                    </td>
                </tr>
                <tr>
                 
                         <td class="auto-style2">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Width="98px" />
                           
                    </td>
                </tr>
                <tr>
                        
                    <td><asp:Label ID="lbltext" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" />
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="MovieType" HeaderText="Movie Type" />
                            <asp:BoundField DataField="MovieDesc" HeaderText="Movie Desc" />
                        </Columns>
                    </asp:GridView>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
