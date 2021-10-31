<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="zUpdateMe.aspx.cs" Inherits="ZenoBlogg.zUpdateMe" %>
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
                <div class="card-header bg-dark text-white">UPDATE YOUR ARTICLE</div>
                <div class="card-body">
                    <form>
                        <div class="form-group">
                            <label for="name mb-5">Author</label>
                            <input type="text" class="form-control" id="author" aria-describedby="emailHelp" placeholder="Enter Author Name" required>
                        </div>
                        <div class="form-group"  style="margin-top: 10px;">
                            <label for="email">Date</label>
                            <input type="text" class="form-control" id="date" aria-describedby="emailHelp" placeholder="Enter Date" required>
                        </div>
                       <div class="form-group"  style="margin-top: 10px;">
                            <label for="email">Title</label>
                            <input type="text" class="form-control" id="title" aria-describedby="emailHelp" placeholder="Enter Title" required>
                        </div>
                        <div class="form-group"  style="margin-top: 10px;">
                            <label for="message">Body</label>
                            <textarea class="form-control" id="body" placeholder="Enter Body Content" rows="6" required></textarea>
                        </div>
                        <div class="mx-auto" style="margin-top: 10px;">
                        <button type="submit" class="btn btn-dark text-right">Update</button></div>
                    </form>
                </div>
            </div>
        </div>
   
    </div>
</div>

</asp:Content>
