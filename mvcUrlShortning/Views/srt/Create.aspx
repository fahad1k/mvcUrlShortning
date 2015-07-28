<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<mvcUrlShortning.Models.urlDetails>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="~/Scripts/jquery.validate.min.js" type="text/javascript"></script>
    <title>Create Short Url</title>
</head>
<body style="font-family:Arial">
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Create new Short URL</legend>
            Fill the textbox with a long Url


            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.longUrl) %>
                <%: Html.ValidationMessageFor(model => model.longUrl) %>
            </div>
            
 
       
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</body>
</html>

