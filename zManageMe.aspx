<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="zManageMe.aspx.cs" Inherits="ZenoBlogg.zManageMe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container" style="width:70%;margin-top: 5%;margin-bottom: 5%;">

    <div class="btn-toolbar" role="toolbar" style="margin-bottom: 10%;" aria-label="Toolbar with button groups">
  <div class="btn-group me-2" role="group" aria-label="First group">
    <a href="zPostMe.aspx"><button type="button" class="btn btn-primary">Write Article</button></a>
  </div>
  <div class="btn-group me-2" role="group" aria-label="Second group">

  </div>
  <div class="btn-group" role="group" aria-label="Third group">
    <a href="zManageMe.aspx"><button type="button" class="btn btn-info">Manage Articles</button></a>
  </div>
</div>

    <div class="row">
        <div class="col" >
            <div class="card" style="background-color: rgba(100, 100, 100, 0.5);">



<table class="table">
  <thead>
    <tr>
     
      <th scope="col">Title</th>
      <th scope="col"></th>
      <th scope="col"></th>
    </tr>
  </thead>
  <tbody id="displayArticles" runat="server">


  </tbody>
</table>






            </div>
        </div>
   
    </div>
</div>


</asp:Content>
