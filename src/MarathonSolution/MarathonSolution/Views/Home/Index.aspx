<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<MarathonSolution.RaceModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <% foreach (var m in ViewData.Model)
      {%>
    <h4><%=m.Title%></h4>
    <p>
        <%=m.Summary %>
    </p>
    <%} %>
</asp:Content>
