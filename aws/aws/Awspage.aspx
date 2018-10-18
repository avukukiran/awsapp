<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Awspage.aspx.cs" Inherits="aws.Awspage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <table>  
    <tr>  
        <td colspan="2">  
            <h1>Empployee Details</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee ID</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpID" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee Name</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
       <tr>  
        <td>Gender</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpGender" runat="server"></asp:TextBox>  
        </td>  
    </tr>
   <tr>  
        <td>Mobile</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpMobile" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee Email-ID</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpEmail" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td colspan="2">  
            <asp:Button ID="btnInsertion" runat="server" Text="Insert" OnClick="btnInsertion_Click" Style="width: 48px" />  
            <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>  
</table>  
</asp:Content>
