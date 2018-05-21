<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RVendedores.aspx.cs" Inherits="GestionVentas.Registros.RVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="panel panel-primary">
        <div class="panel-heading">Registro de Gastos</div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">

               <%-- Input ID--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Vendedor Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                       

                        <asp:Button ID="BuscarButton1" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" OnClick="BuscarButton1_Click" />
                       <%-- <asp:LinkButton ID="BusquedaButton" CssClass="btn btn-info btn-block btn-md" data-toggle="modal" data-target="#myModal" CausesValidation="False" runat="server" Text="<span class='glyphicon glyphicon-search'></span>" />--%>
                    </div>
                </div>

               <%-- Input Nombre--%>
                 <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Nombre: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        
                         <asp:TextBox ID="NombreTextBox1" runat="server"  class="form-control input-sm"></asp:TextBox>
                        
                    </div>
                </div>

              <%--  Descripcion--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Descripcion: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="DescripcionTextBox" runat="server"  class="form-control input-sm" TextMode="Date"></asp:TextBox>
                    </div>
                    
                </div>

              <%--  Input Mensaje Inicial--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Mensaje Inicial: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="MensajeInicialTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

              <%--  Input Mensaje Final--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Mensaje Final: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="MensajefinalTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

                   <%--  Input %Comision--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Porciento Comision 1: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="PorcientoComisionTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

                <%--  Input %Comision 2 --%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Porciento Comision 2: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Porcientocomision2TextBox1" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

                   <%--  Input %Comision3--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Porciento Comision 3: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Porcientocomision3TextBox1" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>
                   <%--  Input %Comision4--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Porciento Comision 4: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Porcientocomision4TextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

                   <%--  Input %Comision5--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Porciento Comision 5: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Porcientocomision5TextBox1" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

                   <%--  Input Limite de Ventas--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*) Limite de Ventas: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="LimiteVentasTextBox1" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

            </div>
            
                   
             <div class="row">
            <asp:GridView ID="DetalleGridView" CssClass="col-md-offset-4 col-sm-offset-4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="455px" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" />
                    <asp:BoundField DataField="CategoriaId" HeaderText="CategoriaId" ReadOnly="True" />
                    <asp:BoundField DataField="MaximoVenta" HeaderText="MaximoVenta" ReadOnly="True" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

        </div>
            <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">
                    <asp:Button class="btn btn-info" ID="LimpiarCampos" runat="server" CausesValidation="False" Text="Eliminar"  TabIndex="1" OnClick="LimpiarCampos_Click" />
                    <asp:Button class="btn btn-success" ID="GuardarButton" runat="server" CausesValidation="True" Text="Guardar"  TabIndex="2" OnClick="GuardarButton_Click" />
                   <%-- <asp:Button class="btn btn-primary" ID="ImprimirButton" runat="server" CausesValidation="True" Text="Imprimir"  TabIndex="3" />--%>
                    <%--<asp:Button class="btn btn-danger" ID="AnularButton" runat="server" CausesValidation="False" Text="Eliminar" TabIndex="4" OnClick="AnularButton_Click" />--%>
                </div>
            </div>
        </div>
        </div>

        </div>
    
</asp:Content>

