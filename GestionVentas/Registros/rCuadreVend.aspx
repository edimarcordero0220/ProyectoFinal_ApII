<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rCuadreVend.aspx.cs" Inherits="GestionVentas.Registros.rCuadreVend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
            <div class="panel panel-primary">
        <div class="panel-heading">Registro de Cuadres de Vendedor</div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">
                 <%-- <asp:LinkButton ID="BusquedaButton" CssClass="btn btn-info btn-block btn-md" data-toggle="modal" data-target="#myModal" CausesValidation="False" runat="server" Text="<span class='glyphicon glyphicon-search'></span>" />--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Cuadre Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                       
                        <%--<asp:Button ID="BuscarButton" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />--%>
                      
                        <%--<asp:Button ID="BuscarButton" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />--%>
                      
                        <asp:Button ID="BuscarButton" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
                      
                    </div>
                </div>

               <%--  Fecha--%>
                 <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Vendedor Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                      
                        <asp:DropDownList ID="VendedorDropDownList1" runat="server">
                        </asp:DropDownList>
                       
                         
                    </div>
                     
                </div>

              <%--  Input Concepto--%>
                <div class="form-group">
                    
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Fecha: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="FechaTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

              <%--  Input Monto--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Concepto: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="ConceptoTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

              <%-- <asp:Button class="btn btn-primary" ID="ImprimirButton" runat="server" CausesValidation="True" Text="Imprimir"  TabIndex="3" />--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Monto: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="MontoTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>

                </div>



                      <div class="panel-footer">
            <div class="text-center">
                <asp:Button ID="NuevoButton" class="btn btn-info" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />
                <asp:Button ID="GuardarButton" class="btn btn-success" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                <asp:Button ID="EliminarButton" class="btn btn-danger" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
                <div class="form-group" style="display: inline-block">
                   
                    
                    

                </div>
            </div>
                   
        </div>

        </div></div>
</asp:Content>
