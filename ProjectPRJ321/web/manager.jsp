<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="styleManager.css" rel="stylesheet" type="text/css"/>
<script src="javascriptManager.js" type="text/javascript"></script>
<!------ Include the above in your HEAD tag ---------->
<jsp:useBean id="info" class="dal.AccountDAO" scope="request"></jsp:useBean>

<nav class="navbar navbar-inverse">
      <div class="container">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar-collapse-3">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">RedHawk</a>
        </div>
    
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="navbar-collapse-3">
          <ul class="nav navbar-nav navbar-right">
            <li><a href="home.jsp">Home</a></li>
          </ul>
        </div><!-- /.navbar-collapse -->
      </div><!-- /.container -->
    </nav><!-- /.navbar -->
<div class="container">
    <div class="row">
		<div class="col-lg-offset-0 col-lg-20">
    	 <div class="well profile">
            <div class="col-lg-8">
                <div class="col-lg-offset-0 row-lg-offset-10 col-lg-3">
                    <figure>
                        <img src="http://science-all.com/images/wallpapers/iron-man-images/iron-man-images-1.jpg" alt="" class="img-circle img-responsive">
                    </figure>
                </div>
                <div class="col-lg-20 col-lg-8">
                    <h3>Iron Man</h3>
                    <p><strong>Login: </strong> ${loginname} </p>
                    <p><strong>Manager: </strong> ${manageracc} </p>
                    <p><strong>Job Title: </strong> ${jobtitle} </p>
                </div>             
            </div>            
    	 </div>                 
		</div>
	</div>
</div>
<div class="container">
    <div class="row">
        <div class="col-lg-15">
            <form action="#" method="get">
                <div class="input-group">
                    <!-- USE TWITTER TYPEAHEAD JSON WITH API TO SEARCH -->
                    <input class="form-control" id="system-search" name="q" placeholder="Search for" required>
                    <span class="input-group-btn">
                        <button type="submit" class="btn btn-default"><i class="glyphicon glyphicon-search"></i></button>
                    </span>
                </div>
            </form>
        </div>
    </div>
</div>
<div class="container">
    <div class="row">
    	 <table class="table table-list-search table table-hover">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Origin</th>
                            <th>Price</th>
                            <th>Description</th>
                        </tr>
                    </thead>
         <c:forEach items="${info.listAnimalsInfo()}" var="in4">
                    <tbody>
                        <tr>
                            <td>${in4.id}</td>
                            <td>${in4.name}</td>
                            <td>${in4.origin}</td>
                            <td>${in4.price}</td>
                            <td>${in4.description}</td>
                            <td><a href="editProduct.jsp?id=${in4.id}">Edit</a></td>
                             <td><a href="deleteProduct?id=${in4.id}" onclick="ConfirmDialog()">Delete</a></td><td></td>
                            
                        </tr>
                    </tbody>
                    </c:forEach>
                </table>   
	</div>
</div>