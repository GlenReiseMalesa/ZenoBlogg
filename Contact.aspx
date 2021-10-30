<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ZenoBlogg.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- main content-->

<section class="jumbotron text-center">
    <div class="container">
        <h1 class="jumbotron-heading">CONTACT US</h1>
        <p class="lead text-muted mb-0">We'll Never Share Your Email With Anyone Else !</p>
    </div>
</section>

<div class="container" style="width:70%;">
    <div class="row">
        <div class="col" >
            <div class="card">
                <div class="card-header bg-dark text-white"><i class="fa fa-envelope"></i> Contact us.
                </div>
                <div class="card-body">
                    <form runat="server">
                        <div class="form-group">
                            <label for="name mb-5">Subject</label>
                            <input type="text" class="form-control" runat="server" id="name" aria-describedby="emailHelp" placeholder="Enter subject" required/>
                        </div>
>
                        <div class="form-group"  style="margin-top: 10px;">
                            <label for="message">Message</label>
                            <textarea class="form-control" id="message" runat="server" rows="6" required></textarea>
                        </div>
                        <div class="mx-auto" style="margin-top: 10px;">
                        <asp:Button ID="submit" runat="server" OnClick="send" class="btn btn-dark text-right" Text="Send"/>

                        </div>
                    </form>
                </div>
            </div>
        </div>
   
    </div>
</div>
</asp:Content>
