<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rDetalleVendedor.aspx.cs" Inherits="GestionVentas.Registros.rDetalleVendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="panel panel-primary">
        <div class="panel-heading">Registro de Gastos</div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">

     <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                       
                        
                        <asp:Button ID="BuscarButton" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
                        <%-- Input VendedorID--%>
                    </div>
                </div>
                <%--<asp:DropDownList ID="VendedorDropDownList" runat="server">
                        </asp:DropDownList>--%>
                 <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Vendedor Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <%-- <asp:TextBox ID="VendedorIdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode="Number"></asp:TextBox>--%>
                        <asp:DropDownList ID="VendedorDropDownList1" runat="server">
                        </asp:DropDownList>
                        <%-- Input CategoriaID--%>
                        
                    </div>


                </div>

                <%--<asp:DropDownList ID="VendedorDropDownList" runat="server">
                        </asp:DropDownList>--%>
                 <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Categoria Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <%-- <asp:TextBox ID="VendedorIdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode="Number"></asp:TextBox>--%>
                        <asp:DropDownList ID="CategoriaDropDownList1" runat="server">
                        </asp:DropDownList>
                        <%--  Input Concepto--%>
                        
                    </div>
                </div>


                  <%--  Input Concepto--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">MaximoVenta: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="MaximoventaTextBox" class="form-control input-sm" TextMode="Number" runat="server"></asp:TextBox>
                        <%--<asp:TextBox  runat="server"   OnTextChanged="MaximoventaTextBox_TextChanged"></asp:TextBox>--%>
                  
                  
                        
                    
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        
                   
                        <asp:Button ID="AgregalButton" class="btn btn-info" runat="server" Text="Agregar" OnClick="AgregalButton_Click" />
                       
                     
                    </div>

                     
                </div>
                 <asp:GridView ID="GridView" CssClass="auto-style3" runat="server" ForeColor="#333333" Width="758px" ShowFooter="True" Height="115px" HorizontalAlign="Center">
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

               
                 <div class="form-group">
                     
                </div>
                   <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">
               
                    
                    <asp:Button ID="LimpiarButton" class="btn btn-info" runat="server" Text="Limpiar" OnClick="LimpiarButton_Click" />
                    <asp:Button ID="GuardarButton" class="btn btn-success" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                     <asp:Button ID="EliminarButton"  class="btn btn-danger" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
                    
                
                
 </div>
            </div>
        </div>

                </div></div></div>



</asp:Content>
