<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Viewer.aspx.cs" Inherits="Reporting_ObjectDS_WebForms.Viewer" %>
<%@ Register Assembly="DevExpress.XtraReports.v22.2.Web.WebForms, Version=22.2.1.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server">
    </dx:ASPxWebDocumentViewer>
</asp:Content>