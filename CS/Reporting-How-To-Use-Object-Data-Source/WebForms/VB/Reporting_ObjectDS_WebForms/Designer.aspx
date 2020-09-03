<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.vb" Inherits="Reporting_ObjectDS_WebForms.Designer" %>
<%@ Register Assembly="DevExpress.XtraReports.v20.1.Web.WebForms, Version=20.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
	<dx:ASPxReportDesigner EnableRichTextEditor="False" ID="ASPxReportDesigner1" runat="server">
	</dx:ASPxReportDesigner>
</asp:Content>