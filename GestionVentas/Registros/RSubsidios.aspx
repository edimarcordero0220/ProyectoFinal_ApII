<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RSubsidios.aspx.cs" Inherits="GestionVentas.Registros.RSubsidios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

    <asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <div class="panel panel-primary">
        <div class="panel-heading">Registro de Gastos</div>

        <div class="panel-body">
            <dv class="form-horizontal col-md-12" role="form">

                <%--SubsidiosId--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">SubsidiosId: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="SubsidiosIdTextBox" runat="server" ReadOnly="True" placeholder="0" class="form-control input-sm"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:LinkButton ID="BusquedaButton" CssClass="btn btn-info btn-block btn-md" data-toggle="modal" data-target="#myModal" CausesValidation="False" runat="server" Text="<span class='glyphicon glyphicon-search'></span>" OnClick="BusquedaButton_Click" />

                    </div>
                    
                </div>

                <%--VendedorId--%>
                <div class="form-group">
                    <label for="VendedorIdTextBox" class="col-md-3 control-label input-sm">VendedorId</label>

                    <div class="col-md-8">
                        <asp:DropDownList ID="VendedorDropDownList1" runat="server">
                        </asp:DropDownList>
                        

                    </div>
                   
                    </div>
                

                <%--Fecha--%>
                <div class="form-group">
                    <label for="FechaTextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="FechaTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RFVFecha" runat="server" ControlToValidate="FechaTextBox" ErrorMessage="Campo Fecha obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Fecha obligatorio">Por favor llenar el campo Fecha</asp:RequiredFieldValidator>

                    </div>
                    
                    </div>
                

             <%--Concepto--%>
                <div class="form-group">
                    <label for="ConceptoTextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (*) Concepto</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="ConceptoTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RFVConcepto" runat="server" ControlToValidate="ConceptoTextBox" ErrorMessage="Campo Concepto obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Concepto obligatorio">Por favor llenar el campo Concepto</asp:RequiredFieldValidator>

                    </div>
                    
                </div>

            

              <%--Monto--%>
                <div class="form-group">
                    <label for="MontoTextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(*) Monto</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="MontoTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        

                    </div>
                    
                    </div>
              



            <div class="col-md-12">
                <asp:ValidationSummary runat="server" ID="SumaryValidation"
                    ForeColor="red"
                    DisplayMode="BulletList"
                    ShowSummary="true"
                    EnableClientScript="True"
                    Font-Bold="False"
                    CssClass=" alert alert-danger" />
            </div>

            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>

        

        <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">
                    <asp:Button class="btn btn-info" ID="LimpiarCampos" runat="server" CausesValidation="False" Text="Limpiar"  TabIndex="1" OnClick="LimpiarCampos_Click" />
                    <asp:Button class="btn btn-success" ID="GuardarButton" runat="server" CausesValidation="True" Text="Guardar"  TabIndex="2" OnClick="GuardarButton_Click" />
                    <asp:Button class="btn btn-primary" ID="ImprimirButton" runat="server" CausesValidation="True" Text="Imprimir"  TabIndex="3" />
                    <asp:Button class="btn btn-danger" ID="AnularButton" runat="server" CausesValidation="False" Text="Anular" TabIndex="4" OnClick="AnularButton_Click" />
                </div>
            </div>
        </div>
    </div></div>

</asp:Content>


