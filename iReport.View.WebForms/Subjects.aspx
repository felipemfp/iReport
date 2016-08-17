<%@ Page Title="Subjects" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subjects.aspx.cs" Inherits="iReport.View.WebForms.Subjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Subjects</h2>
    <div class="row">
        <div class="one-half column">            
            <h3>New</h3>
            <label>Description</label>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Description"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />            
        </div>
        <div class="one-half column">
            <h3>Update or Delete</h3>
            <label>Course</label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Description" DataValueField="Id"></asp:DropDownList>
            <label>New Description</label>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Description"></asp:TextBox><br />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />            
        </div>
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetList" TypeName="iReport.Business.Subject"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" CssClass="u-full-width" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="#" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
