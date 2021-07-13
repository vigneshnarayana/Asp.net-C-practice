<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: 100; font-style: inherit; font-variant: small-caps; text-transform: capitalize">Complete Curd Operations</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Medium" ForeColor="#993300" Text="ProductId"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" ForeColor="#6600FF" OnClick="Button4_Click" Text="Search.." />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Medium" ForeColor="#993300" Text="ItemName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Medium" ForeColor="#993300" Text="Specification"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Medium" ForeColor="#993300" Text="Unit"></asp:Label>
            </td>
            <td style="height: 26px">
                <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Medium" Width="200px">
                    <asp:ListItem>PC</asp:ListItem>
                    <asp:ListItem>KGC</asp:ListItem>
                    <asp:ListItem>DE</asp:ListItem>
                    <asp:ListItem>LO</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Medium" ForeColor="#993300" Text="Status"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Running</asp:ListItem>
                    <asp:ListItem>Unused</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Medium" ForeColor="#993300" Text="Creation Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" ForeColor="#6600FF" OnClick="Button1_Click" Text="Insert" />
                <asp:Button ID="Button3" runat="server" ForeColor="#6600FF" OnClick="Button2_Click" Text="Update" />
                <asp:Button ID="Button4" runat="server" ForeColor="#6600FF" OnClick="Button3_Click" OnClientClick="return confirm('Are you Sure To Delete?');" Text="Delete" />
                <asp:Button ID="Button6" runat="server" ForeColor="#6600FF" OnClick="Button5_Click" OnClientClick="return confirm('Are you Sure To Delete?');" Text="Load" />
                <br />
                <br />
            </td>
        </tr>
    </table>
    <p>
    </p>
    <table class="nav-justified">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="1116px">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
