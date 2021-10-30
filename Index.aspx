<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ZenoBlogg.Index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="bg-light" style="background-image: url('img/img2.jpg');height: 80vh;background-repeat: no-repeat;background-size: 100% 100%;padding-top:10%;margin-top:5%;">
    <!-- home main -->
<section class="jumbotron text-center" >
    <div class="container">
        <h1 class="jumbotron-heading">ZENOBLOGG</h1>
        <p class="lead text-muted mb-0">We'll Never Share Your Email With Anyone Else !</p>
    </div>
</section>



<!-- newsletter -->
<section class="newsletter ">
<div class="container">
<div class="row">
<div class="col-sm-12">
	<div class="content">
		<h6>SUBSCRIBE TO OUR NEWSLETTER</h6>
	<form runat="server">	
	<div class="input-group">
         <input runat="server" id="email" type="email" class="form-control" placeholder="Enter your email"/>
         <span class="input-group-btn">
         <asp:Button class="btn" ID="submit" OnClick="sub" Text="Subscribe" runat="server"></asp:Button>
         </span>
      </div>
        </form>
	</div>
	
</div>
</div>
</div>
</section>

</div>

<!-- blog articles -->
<div class="container-fluid p-5" id="articles">
	<div class="row" id="displayArticles" runat="server">
	






 

	</div>
</div>

</asp:Content>
