<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="iReport.View.WebForms.Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Students
        <small><small><small>
            Curso&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Description" DataValueField="Id" AutoPostBack="True"></asp:DropDownList>
        </small></small></small>
    </h2>
    <div class="row">
        <div class="one-half column">
            <h3>New</h3>
            <label>Name</label>
            <asp:TextBox ID="TextBoxName" runat="server" placeholder="Name"></asp:TextBox>
            <label>Email</label>
            <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
            <label>Phone</label>
            <asp:TextBox ID="TextBoxPhone" runat="server" TextMode="Phone" placeholder="Phone"></asp:TextBox>
            <label>Birth</label>
            <asp:TextBox ID="TextBoxBirth" runat="server" TextMode="Date" placeholder="Birth" CssClass="input"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
        </div>
        <div class="one-half column">
            <h3>Update or Delete</h3>
            <label>Student</label>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" OnDataBound="DropDownList2_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <label>Name</label>
            <asp:TextBox ID="TextBoxNewName" runat="server" placeholder="Name"></asp:TextBox>
            <label>Email</label>
            <asp:TextBox ID="TextBoxNewEmail" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
            <label>Phone</label>
            <asp:TextBox ID="TextBoxNewPhone" runat="server" TextMode="Phone" placeholder="Phone"></asp:TextBox>
            <label>Birth</label>
            <asp:TextBox ID="TextBoxNewBirth" runat="server" TextMode="Date" placeholder="Birth" CssClass="input"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
        </div>
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetList" TypeName="iReport.Business.Course"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetList" TypeName="iReport.Business.Student">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" PropertyName="SelectedValue" Name="idCourse" Type="Int32"></asp:ControlParameter>

        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" CssClass="u-full-width" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"></asp:BoundField>
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"></asp:BoundField>
            <asp:BoundField DataField="Birth" HeaderText="Birth" SortExpression="Birth"></asp:BoundField>
            <asp:BoundField DataField="IdCourse" HeaderText="IdCourse" SortExpression="IdCourse"></asp:BoundField>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True"></asp:CommandField>
        </Columns>
    </asp:GridView>
</asp:Content>
