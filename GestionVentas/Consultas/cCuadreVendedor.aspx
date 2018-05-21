<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cCuadreVendedor.aspx.cs" Inherits="GestionVentas.Consultas.cCuadreVendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="panel panel-primary">
        <div class="panel-heading">Registro de Gastos</div>

        <div class="panel-body">
            <div class="auto-style1" role="form">


                
                <div class="text-center">
                <div class="form-group">
                 
                <asp:Label ID="Label1" runat="server" Text="Filtrar Por:"></asp:Label>                
                <asp:DropDownList ID="FiltrarDropDownList" runat="server" Height="22px" Width="112px">
                    <asp:ListItem>Todos</asp:ListItem>
                    <asp:ListItem>GastosID</asp:ListItem>
                    <asp:ListItem>Vendedor Id</asp:ListItem>
                </asp:DropDownList>             
                <asp:TextBox ID="BuscarTextBox" runat="server" Width="151px"></asp:TextBox>
                <asp:Button ID="BuscarButton" runat="server"  Text="Buscar" OnClick="BuscarButton_Click" Width="69px" />
                &nbsp;</div>
                 <div class="form-group">
                  <asp:Label ID="Label2" runat="server" Text="Desde:"></asp:Label> 
                  <asp:TextBox ID="DesdeTextBox" runat="server"></asp:TextBox>
                  <asp:Label ID="Label3" runat="server" Text="Hasta:"></asp:Label> 
                  <asp:TextBox ID="HastaTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class="form-group">
                <asp:GridView ID="ConsultaClienteGridView" CssClass="auto-style3" runat="server" ForeColor="#333333" Width="758px" ShowFooter="True" Height="115px" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" Font-Bold="False" />
                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" VerticalAlign="Middle" />
                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                <FooterStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderColor="white" BorderWidth="2px" HorizontalAlign="Justify" VerticalAlign="Top" />
                <HeaderStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderStyle="Outset" Font-Italic="True" Font-Size="12pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#F8F8FF" ForeColor="White" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2px" />
                <RowStyle BackColor="#EFF3FB" BorderColor="Black" BorderStyle="None" BorderWidth="2px" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" BorderStyle="Solid" BorderWidth="3px" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" BorderStyle="Solid" BorderWidth="3px" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
                </div>

                
                </div>


                



                </div></div></div>
</asp:Content>
