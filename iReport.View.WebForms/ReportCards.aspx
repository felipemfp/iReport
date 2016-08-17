<%@ Page Title="Report Cards" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportCards.aspx.cs" Inherits="iReport.View.WebForms.ReportCards" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Report Cards
        <small><small><small>Course
            &nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource3" DataTextField="Description" DataValueField="Id" AutoPostBack="True"></asp:DropDownList>
            Student
            &nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnDataBound="DropDownList1_DataBound" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        </small></small></small>
    </h2>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetList" TypeName="iReport.Business.Course"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetList" TypeName="iReport.Business.Student">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList2" PropertyName="SelectedValue" Name="idCourse" Type="Int32"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>

    <div class="row">
        <div class="one-half column">
            <h3>New</h3>
            <label>Subject</label>
            <asp:DropDownList ID="DropDownListSubject" runat="server" DataSourceID="ObjectDataSource4" DataTextField="Description" DataValueField="Id"></asp:DropDownList>
            <label>Year</label>
            <asp:TextBox ID="TextBoxYear" runat="server" TextMode="Number" Text="2015" placeholder="Year"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
        </div>
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetList" TypeName="iReport.Business.Subject"></asp:ObjectDataSource>
        <div class="one-half column">
            <h3>Update or Delete</h3>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <label>Subject</label>
                    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="ObjectDataSource4" DataTextField="Description" DataValueField="Id" AutoPostBack="True"></asp:DropDownList>
                    <label>Yeah</label>
                    <asp:TextBox ID="TextBoxUpYear" runat="server" placeholder="Number" Text="2015"></asp:TextBox>
                    <label>Quarter</label>
                    <asp:DropDownList ID="DropDownList4" runat="server" OnDataBound="DropDownList4_DataBound" OnSelectedIndexChanged="DropDownList4_DataBound" AutoPostBack="True">
                        <asp:ListItem Value="1">Quarter 1</asp:ListItem>
                        <asp:ListItem Value="2">Quarter 2</asp:ListItem>
                        <asp:ListItem Value="3">Quarter 3</asp:ListItem>
                        <asp:ListItem Value="4">Quarter 4</asp:ListItem>
                        <asp:ListItem Value="5">Final</asp:ListItem>
                    </asp:DropDownList>
                    <label>Value</label>
                    <asp:TextBox ID="TextBoxUpValue" runat="server" TextMode="Number" Number="100" placeholder="Value"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="Delete Report" OnClick="Button3_Click" />
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="Button2" />
                    <asp:PostBackTrigger ControlID="Button3" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </div>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetList" TypeName="iReport.Business.ReportCard">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" PropertyName="SelectedValue" Name="idStudent" Type="Int32"></asp:ControlParameter>
            <asp:Parameter Name="idSubject" Type="Int32"></asp:Parameter>
            <asp:Parameter Name="year" Type="Int32"></asp:Parameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" CssClass="u-full-width" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year"></asp:BoundField>
            <asp:BoundField DataField="IdStudent" HeaderText="IdStudent" SortExpression="IdStudent"></asp:BoundField>
            <asp:BoundField DataField="IdSubject" HeaderText="IdSubject" SortExpression="IdSubject"></asp:BoundField>
            <asp:BoundField DataField="Quarter1" HeaderText="Quarter1" SortExpression="Quarter1"></asp:BoundField>
            <asp:BoundField DataField="Quarter2" HeaderText="Quarter2" SortExpression="Quarter2"></asp:BoundField>
            <asp:BoundField DataField="Quarter3" HeaderText="Quarter3" SortExpression="Quarter3"></asp:BoundField>
            <asp:BoundField DataField="Quarter4" HeaderText="Quarter4" SortExpression="Quarter4"></asp:BoundField>
            <asp:BoundField DataField="PartialAverage" HeaderText="PartialAverage" SortExpression="PartialAverage"></asp:BoundField>
            <asp:BoundField DataField="Final" HeaderText="Final" SortExpression="Final"></asp:BoundField>
            <asp:BoundField DataField="Average" HeaderText="Average" SortExpression="Average"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
