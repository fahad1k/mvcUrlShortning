<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<mvcUrlShortning.Models.urlDetails>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Shortened Urls list</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="~/Scripts/jquery.validate.min.js" type="text/javascript"></script>

</head>
<body style="font-family:Arial">
<h1>Shortened Urls list</h1>
    <table border="1" cellspacing="1">
        <tr>
            
            <th>
                Sr.
            </th>
            <th>
                Short Url
            </th>
            <th>
                Long Url
            </th>
            <th>
                Date
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
         
            <td>
                <%: item.Srno %>
            </td>
            <td>
                
                 <%: Html.ActionLink(item.shortUrl, "url", new { id = item.uniqueID })%>
            </td>
            <td>
                <%: item.longUrl %>
            </td>
            <td>
                <%: String.Format("{0:d}", item.date) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</body>
</html>

