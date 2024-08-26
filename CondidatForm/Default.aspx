<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CondidatForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
    <section class="row">
        <h2 id="Contitle" class="d-flex justify-content-center"  style="margin-bottom : 70px ; font-size : 2.7em">Add Condidat</h2>
        
    </section>

        <div class="row">
            <div class="col">
                <Label> Condidat_Id : </Label>
                <asp:TextBox ID="cond_id" runat="server" class="form-control was-validated"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvid" runat="server" ControlToValidate="cond_id" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>

            <div class="col">
                <Label> Nom : </Label>
                <asp:TextBox ID="nom" runat="server" class="form-control was-validated"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNom" runat="server" ControlToValidate="nom" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>

            <div class="col">
                <Label> Prenom : </Label>
                <asp:TextBox ID="prenom" runat="server" class="form-control was-validated"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvprenom" runat="server" ControlToValidate="prenom" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col">
                <label for="date_naissance">Date de naissance :</label>
                <asp:TextBox ID="date_naissance" runat="server" CssClass="form-control was-validated" TextMode="Date" />
                <asp:RequiredFieldValidator ID="rfvdate" runat="server" ControlToValidate="date_naissance" Text="*" ForeColor="Red" Display="Dynamic" />
            </div>
        
            <div class="col">
                <Label> Email : </Label>
                <asp:TextBox ID="email" runat="server" class="form-control was-validated"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rvfemail" runat="server" ControlToValidate="email" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="rvfemailstructure" runat="server" ControlToValidate="email" ForeColor="Red" Text="Valid email adress is required" ValidationExpression="\w+([-+.'']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>

            <div class="col">
                <Label> Phone : </Label>
                <asp:TextBox ID="phone" runat="server" class="form-control was-validated"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvphone" runat="server" Text="*" ControlToValidate="phone" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>



        <div class="row">
            <div class="col">
                <Label> Adresse : </Label>
                <asp:TextBox ID="adresse" runat="server" class="form-control was-validated"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvadresse" runat="server" Text="*" ControlToValidate="adresse" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>

            <div class="col">
                <Label> Sexe : </Label>
                <asp:DropDownList ID="sexe" runat="server" class="form-control was-validated">
                    <asp:ListItem Text="--Select Sexe--" Value="" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvsexe" runat="server" InitialValue="" Text="*" ControlToValidate="sexe" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>
        
            <div class="col">
                <Label> Situation : </Label>
                <asp:DropDownList ID="Situation" runat="server" class="form-control was-validated">
                    <asp:ListItem Text="--Select Situation--" Value="" />
                    <asp:ListItem Text="Veuf(ve)" Value="Veuf" />
                    <asp:ListItem Text="Marié(e)" Value="Marié" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rvfsituation" runat="server" InitialValue="" ControlToValidate="Situation" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

            <ContentTemplate>
                <asp:UpdatePanel>

        <div class="row">
            <div class="col">
                <Label> Region : </Label>
                <asp:DropDownList ID="Region" runat="server" OnSelectedIndexChanged="Ville_Liste" AutoPostBack="true" CssClass="form-control was-validated">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rvfregion" runat="server" InitialValue="" ControlToValidate="Region" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>
        

         
            <div class="col">
                <Label> Ville : </Label>
                <asp:DropDownList ID="Ville" runat="server" OnSelectedIndexChanged="Commune_Liste"  AutoPostBack="true"  CssClass="form-control was-validated">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rvfville" runat="server" InitialValue="" ControlToValidate="Ville" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>


            <div class="col">
                <Label> Commune : </Label>
                <asp:DropDownList ID="Commune" runat="server" CssClass="form-control was-validated">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rvfcommune" runat="server" InitialValue="" ControlToValidate="Commune" Text="*" ForeColor="Red" Dispaly="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>
        </asp:UpdatePanel>
    </ContentTemplate>
     


        <div>
            <Label> Sources : </Label>
        </div>
        <div>
            <asp:CheckBox ID="source1" Text="Internet" runat="server" />
            <asp:CheckBox ID="source2" Text="Jounal" runat="server" />
            <asp:CheckBox ID="source3" Text="Ami(e)" runat="server" />
        </div>

        <div class="d-flex justify-content-center" style="margin-top : 50px ; margin-bottom : 40px">

            <asp:Button ID="Button1" runat="server" Text="Valider" OnClick="submit" class="btn btn-primary ml-3" style="margin-right : 10px" />
            <a href="/afficheCond" class="btn btn-outline-success ml-3">Back to list</a>
        </div>



    </main>
</asp:Content>

