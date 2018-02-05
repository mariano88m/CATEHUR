<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="GUI.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
      <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
          <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
          <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
          <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
          <!-- Slide One - Set the background image for this slide in the line below -->
          <div class="carousel-item active" style="background-image: url('./Content/img/01.png')">
            <div class="carousel-caption d-none d-md-block">
              <h3>First Slide</h3>
              <p>This is a description for the first slide.</p>
            </div>
          </div>
          <!-- Slide Two - Set the background image for this slide in the line below -->
          <div class="carousel-item" style="background-image: url('./Content/img/02.png')">
            <div class="carousel-caption d-none d-md-block">
              <h3>Second Slide</h3>
              <p>This is a description for the second slide.</p>
            </div>
          </div>
          <!-- Slide Three - Set the background image for this slide in the line below -->
          <div class="carousel-item" style="background-image: url('./Content/img/03.png')">
            <div class="carousel-caption d-none d-md-block">
              <h3>Third Slide</h3>
              <p>This is a description for the third slide.</p>
            </div>
          </div>
          <div class="carousel-item" style="background-image: url('./Content/img/04.png')">
            <div class="carousel-caption d-none d-md-block">
              <h3>Third Slide</h3>
              <p>This is a description for the third slide.</p>
            </div>
          </div>
          <div class="carousel-item" style="background-image: url('./Content/img/05.png')">
            <div class="carousel-caption d-none d-md-block">
              <h3>Third Slide</h3>
              <p>This is a description for the third slide.</p>
            </div>
          </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </header>
    <section class="py-5">
      <div class="container">
        <h1><asp:Label ID="lbl_titulo" runat="server" Text="CateHUR Servicios de Catering"></asp:Label></h1>
        <p>
            <asp:Label ID="lbl_1Parrafo" runat="server" Text="CateHUR es una empresa que tiene como actividad principal proporcionar un servicio de Catering en un lugar designado por el cliente. CateHUR SRL ofrece a nuestros clientes una gestión integral en cualquier reunión, celebración o evento público, persiguiendo siempre la mejor solución en base a las necesidades específicas de cada proyecto.El principal factor de diferenciación en el que la empresa se enfoca es en el armado del menú y en la originalidad de los platos que se ofrece hacia el cliente. A tales efectos, contamos con los siguientes servicios:"></asp:Label> </p>
 <p>
     <asp:Label ID="lbl_2Parrafo" runat="server" Text="Servicio de Cocineros y Camareros"></asp:Label></p>
 <p>
     <asp:Label ID="lbl_3Parrafo" runat="server" Text="Servicio integral de Catering"></asp:Label></p>
 <p>
     <asp:Label ID="lbl_4Parrafo" runat="server" Text="Servicio integral de Limpieza"></asp:Label></p>
 <p>
     <asp:Label ID="lbl_5Parrafo" runat="server" Text="Provisión/Alquiler de vajilla y Mantelería"></asp:Label></p>
           
      </div>
    </section>

      <footer>
        <p>© CATEHUR</p>
      </footer>



</asp:Content>