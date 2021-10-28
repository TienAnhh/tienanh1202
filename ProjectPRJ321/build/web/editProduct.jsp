<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<%-- 
    Document   : editProduct
    Created on : Nov 19, 2020, 1:52:42 AM
    Author     : TISD
--%>

<script type="text/javascript">
 
         function ConfirmDialog()  {
 
              var result = confirm("Do you want to continue?");
 
              if(result)  {
                  alert("Delete Successful!");
              } else {
                  alert("Delete Canceled!");
              }
         }
 
</script>
    <c:if test="${updateERROR!=null}">
        <div class="alert alert-danger" id="danger" role="alert">
            You need to input correct price!
        </div>
    </c:if>
    <% String id = request.getParameter("id");%>
    <form action="edit" method="GET">
        <table border="2">
            <tr>
                <td>ID</td><td><input name="id" type="" value="<%=id%>"></td>
            </tr>
            <tr>
                <td>Name</td><td><input type="text" name="name"></td>
            </tr>
            <tr>
                <td>Origin</td><td><input type="text" name="origin"></td>
            </tr>
            <tr>
                <td>Price</td><td><input type="text" name="price"></td>
            </tr>
            <tr>
                <td>Description</td><td><input type="text" name="description"></td>
            </tr>
            <tr>
                <td><a href="deleteProduct?id=<%=id%>" onclick="ConfirmDialog()">Delete</a></td><td><input type="submit" name="Change" value="CHANGE"></td>
            </tr>
        </table>
    </form>
