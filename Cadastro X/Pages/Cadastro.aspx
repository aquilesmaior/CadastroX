 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Cadastro_X.Pages.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-lg-12">
            <div class="form-panel">
              <h4 class="mb"><i class="fa fa-angle-right"></i> Cadastro de Funcionário</h4>
                
                <asp:Label ID="txtResp" runat="server" Font-Size="Large" Text=""></asp:Label>

                <form class="form-horizontal style-form" method="get" runat="server">
                  <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Nome Completo</label>
                  <div class="col-sm-10">
                  <asp:TextBox ID="txtName" class="form-control" runat="server"></asp:TextBox>
                  </div>
                  </div>
             
                 <div class="form-group">
                 <label class="col-sm-2 col-sm-2 control-label">Email</label>
                 <div class="col-sm-10">
                 <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
                 </div>
                 </div>
                 
                 <div class="form-group">
                 <label class="col-sm-2 col-sm-2 control-label">CPF</label>
                 <div class="col-sm-10">
                 <asp:TextBox ID="txtCPF" class="form-control" runat="server"></asp:TextBox>
                 </div>
                 </div>
  
                  <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Nascimento</label>
                  <div class="col-sm-10">
                  <asp:TextBox ID="txtBirth" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
                  </div>
                  </div>

                  <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">CEP</label>
                  <div class="col-sm-10">
                  <asp:TextBox ID="txtCEP" class="form-control" runat="server"></asp:TextBox>
                  </div>
                  </div>
                
                  <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Endereço</label>
                  <div class="col-sm-10">
                  <asp:TextBox ID="txtAddress" class="form-control" runat="server"></asp:TextBox>
                  </div>
                  </div>

                  <div class="form-group">
                  <label class="col-lg-2 col-sm-2 control-label">Bairro</label>
                  <div class="col-lg-10">
                  <asp:TextBox ID="txtDistrict" class="form-control" runat="server"></asp:TextBox>
                  </div>
                  </div>

                  <div class="form-group">
                  <label class="col-lg-2 col-sm-2 control-label">Estado</label>
                  <div class="col-lg-10">
                  <asp:TextBox ID="txtUF" class="form-control" runat="server"></asp:TextBox>
                  </div>
                  </div>

                  <div class="form-group">
                  <label class="col-lg-2 col-sm-2 control-label">Cidade</label>
                  <div class="col-lg-10">
                  <asp:TextBox ID="txtCity" class="form-control" runat="server"></asp:TextBox>
                  </div>
                  </div>

                  <div class="form-group">
                  <label class="col-lg-2 col-sm-2 control-label">Departamento</label>
                  <div class="col-lg-10">
                  <asp:TextBox ID="txtDepartment" class="form-control" runat="server"></asp:TextBox>
                  </div>          
                  </div>
                  
                  <div class="form-group">
                  <div class="col-lg-10">
                  <asp:Button ID="btPersist" class="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btPersist_Click" />
                  </div>          
                  </div>


                </div>
              </form>
            </div>
          </div>
</asp:Content>

