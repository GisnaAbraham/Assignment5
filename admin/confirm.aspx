<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="assignment5.admin.confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Admin Home Page</h1>
  
    <table>
       
        <tr>
           
            <h2>Confirm</h2>
       
            <td>
                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="emp_id" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="UserName" />
            <asp:BoundField DataField="mail" HeaderText="Email" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="age" HeaderText="Age" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="Confirm" HeaderText="Confirm" ShowDeleteButton="True" />
           
        </Columns>
    </asp:GridView>
            </td>
        </tr>

       </table>
    <table>
        <tr>
             <h2>Block</h2>
            <td>
                 <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="emp_id" OnRowDeleting="GridView2_RowDeleting">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="UserName" />
            <asp:BoundField DataField="mail" HeaderText="Email" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="age" HeaderText="Age" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="Block" HeaderText="Block" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
