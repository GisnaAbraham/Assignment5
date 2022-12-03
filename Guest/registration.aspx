<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="assignment5.Guest.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>REGISTRATION FORM</center></h1>
      <table bgcolor="white" align="center">
               

                <tr>
                    <td>Name: </td>
                    <td>
                      <asp:TextBox ID="name" runat="server" required></asp:TextBox><br /><br />
                    </td>
                </tr>

                   <tr>
                    <td>Age: </td>
                    <td>
                       <asp:TextBox ID="age" runat="server" required></asp:TextBox><br /><br />
                    </td>
                </tr>
                
                <tr>
                    <td>Email: </td>
                    <td>
                       <asp:TextBox ID="mail" runat="server" required></asp:TextBox><br /><br />
                    </td>
                </tr>

                 <tr>
                    <td>Phone: </td>
                    <td>
                       <asp:TextBox ID="phone" runat="server" required></asp:TextBox><br /><br />
                    </td>
                </tr>
              
                <tr>
                    <td>Username: </td>
                    <td>
                        <asp:TextBox ID="uname" runat="server" required></asp:TextBox><br /><br />
                    </td>
                </tr>
                <tr>
                    <td> Password: </td>
                    <td>
                        <asp:TextBox ID="pswd" runat="server" TextMode="Password" required></asp:TextBox><br /><br />
                    </td>
                </tr>
                
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            </td>
        </tr>
                         
            </table>
</asp:Content>
