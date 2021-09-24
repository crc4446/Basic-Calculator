<%@ Page Title="" Language="C#" MasterPageFile="~/MIS316/MasterPagecrc4446.master" AutoEventWireup="true" CodeFile="mp1Acrc4446.aspx.cs" Inherits="MIS316_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        Value A:
        <asp:TextBox ID="txtInputA" runat="server"></asp:TextBox>
    </p>
    <p>
        Value B:
        <asp:TextBox ID="txtInputB" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAddThem" runat="server" OnClick="btnAddThem_Click" Text="Add Them" Width="140px" />
&nbsp;<asp:Label ID="lblAddThem" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnSubThem" runat="server" OnClick="btnSubThem_Click" Text="Subtract Them" Width="140px" />
&nbsp;<asp:Label ID="lblSubThem" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnMultThem" runat="server" OnClick="btnMultThem_Click" Text="Multiply Them" Width="140px" />
&nbsp;<asp:Label ID="lblMultThem" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnDivThem" runat="server" OnClick="btnDivThem_Click" Text="Divide Them" Width="140px" />
&nbsp;<asp:Label ID="lblDivThem" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnAllCalc" runat="server" OnClick="btnAllCalc_Click" Text="Complete All Calculations" Width="170px" />
&nbsp;<asp:Label ID="lblAllCalc" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnClearAll" runat="server" OnClick="btnClearAll_Click" Text="Clear All Values" Width="110px" />
&nbsp;<asp:Label ID="lblClearAll" runat="server"></asp:Label>
    </p>
</asp:Content>

