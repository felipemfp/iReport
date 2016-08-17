<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="iReport.View.WebForms.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Dashboard</h2>
    <div class="cards">
        <div class="card">
            <figure class="image">
                <img src="Image/Layout/course-icon.png" />
            </figure>
            <div class="legend">
                Courses
            </div>
            <div class="action">
                <a href="Courses.aspx">Abrir</a>
            </div>
        </div>
        <div class="card">
            <figure class="image">
                <img src="Image/Layout/subject-icon.png" />
            </figure>
            <div class="legend">
                Subjects
            </div>
            <div class="action">
                <a href="Subjects.aspx">Abrir</a>
            </div>
        </div>
        <div class="card">
            <figure class="image">
                <img src="Image/Layout/student-icon.png" />
            </figure>
            <div class="legend">
                Students
            </div>
            <div class="action">
                <a href="Students.aspx">Abrir</a>
            </div>
        </div>
        <div class="card">
            <figure class="image">
                <img src="Image/Layout/report-card-icon.png" />
            </figure>
            <div class="legend">
                Report Cards
            </div>
            <div class="action">
                <a href="ReportCards.aspx">Abrir</a>
            </div>
        </div>
    </div>
</asp:Content>
