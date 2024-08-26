<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AfficheCond.aspx.cs" Inherits="CondidatForm.AfficheCond" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row">
    <h2 id="Afftitle" class="d-flex justify-content-center"  style="margin-bottom : 70px ; font-size : 2.7em">Affichage</h2>
    
</section>

        
        <div class="container-fluid">

            <asp:GridView ID="Cond" runat="server" AutoGenerateColumns="False" class="table table-bordered table table-hover">
                <Columns>
                    
                    
                    <asp:BoundField DataField="Nom" HeaderText="Nom" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="Prenom" HeaderText="Prenom" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="DateNaissance" HeaderText="Date de naissance" DataFormatString="{0:dd/MM/yyyy}" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="Email" HeaderText="Email" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="Adresse" HeaderText="Adresse" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="Sexe" HeaderText="Sexe" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="Situation" HeaderText="Situation" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="Sources" HeaderText="Sources" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="RegionName" HeaderText="Region" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="VilleName" HeaderText="Ville" HeaderStyle-BackColor="LightGray" />
                    <asp:BoundField DataField="CommuneName" HeaderText="Commune" HeaderStyle-BackColor="LightGray" />

                </Columns>
            </asp:GridView>

        </div>

        <div class="d-flex justify-content-center">
            <a href="/" class="btn btn-primary">Add new Condidat</a>
        </div>

    



    </main>
</asp:Content>

