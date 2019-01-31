<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarUsuario.aspx.cs" Inherits="Registro.Consultar.ConsultarUsuario" %>



<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="server">

    <div class="container form-group ">
        <div class="row">

            <label for="TipodeFiltro" style="width: 50px">Filtro:</label>
            <div style="width: 220px">
                <asp:DropDownList class="form-control" ID="TipodeFiltro" runat="server" for="TipodeFiltro" Width="200px">
                    <asp:ListItem>ID</asp:ListItem>
                    <asp:ListItem>Nombre</asp:ListItem>
                    <asp:ListItem>Usuario</asp:ListItem>
                     <asp:ListItem>Fecha</asp:ListItem>
                    <asp:ListItem>Telefono</asp:ListItem>
                    <asp:ListItem>Celular</asp:ListItem>

                </asp:DropDownList>
            </div>
            <asp:Label ID="LabelCriterio" runat="server" Text="Criterio:" Style="width: 60px"></asp:Label>
            <div style="width: 370px">
                <asp:TextBox class="form-control" ID="TextCriterio" runat="server" Style="width: 350px"></asp:TextBox>

            </div>
            <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" class="btn btn-info btn-md" OnClick="ButtonBuscar_Click1" />

        </div>
    </div>

    <div>
        <table>
            <tr>
                <td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        </td>
                <td>
                    <asp:TextBox ID="FechaunoTextBox" TextMode="Date" runat="server" class="form-control" Height="25" Width="175"></asp:TextBox>
                </td>
                <td>&nbsp<strong><asp:Label ID="Label1" runat="server" Text="-">  </asp:Label></strong>&nbsp
                        </td>
                <td>
                    <asp:TextBox ID="FechadosTextBox" TextMode="Date" runat="server" class="form-control" Height="25" Width="175"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>

    <div class="container form-group ">
        <div class="row">
            <div class="form-row justify-content-center">
                <asp:GridView ID="UsuarioGridView" runat="server" class="table table-condensed table-bordered table-responsive" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="LightSkyBlue" />
                    <Columns>
                        <asp:BoundField DataField="UsuarioId" HeaderText="UsuarioId" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" />
                        <asp:BoundField DataField="Clave" HeaderText="Clave" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="Celular" HeaderText="Celular" />


                    </Columns>
                    <HeaderStyle BackColor="LightCyan" Font-Bold="True" />
                </asp:GridView>
            </div>
        </div>
    </div>
    
</asp:content>
