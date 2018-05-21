<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rCategorias.aspx.cs" Inherits="GestionVentas.Registros.rCategorias" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">Registro de Categorias</div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">

                <%--CategoriaId--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server"  placeholder="0" class="form-control input-sm"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:LinkButton ID="BusquedaButton" CssClass="btn btn-info btn-block btn-md" data-toggle="modal" data-target="#myModal" CausesValidation="False" runat="server" Text="<span class='glyphicon glyphicon-search'></span>" OnClick="BusquedaButton_Click" />

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>

                <%--Nombre--%>
                <div class="form-group">
                    <label for="NombreTextBox" class="col-md-3 control-label input-sm">(*) Nombre</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="NombreTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RFVNombre" runat="server" MaxLength="50" ControlToValidate="NombreTextBox" ErrorMessage="Campo Nombre obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Nombre obligatorio">Por favor llenar el campo Nombre</asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>

                <%--MaximoVentaDefault--%>
                <div class="form-group">
                    <label for="MaximoVentaDefaultTextBox" class="col-md-3 control-label input-sm">(*) MaximoVentaDefault</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="MaximoVentaDefaultTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RFVMaximoVentaDefault" runat="server" ControlToValidate="MaximoVentaDefaultTextBox" ErrorMessage="Campo MaximoVentaDefault obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo MaximoVentaDefault obligatorio">Por favor llenar el campo MaximoVentaDefault</asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-1">
                    </div>
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

        </div>

        <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">
                    <asp:Button class="btn btn-info" ID="LimpiarCampos" runat="server" CausesValidation="False" Text="Limpiar"  TabIndex="1" OnClick="LimpiarCampos_Click" />
                    <asp:Button class="btn btn-success" ID="GuardarButton" runat="server" CausesValidation="True" Text="Guardar"  TabIndex="2" OnClick="GuardarButton_Click" />
                    <asp:Button class="btn btn-danger" ID="AnularButton" runat="server" CausesValidation="False" Text="Anular" TabIndex="4" OnClick="AnularButton_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
