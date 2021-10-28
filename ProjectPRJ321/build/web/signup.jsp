<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<html>
    <head><title>ADD</title>
        <link href="styleSignup.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
    <nav class="navbar navbar-light bg-light">
        <a href="login.jsp" style="color: greenyellow; font-weight: bold; border-radius: 5px" class="navbar-brand">HOME</a>
            <form class="form-inline">
                <table>
                    <tr>
                        <!--<td><input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search"></td>
                        <td><button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button></td>-->
                    </tr>
                </table>
            </form>
    </nav>
        <div>
            <c:if test="${notMatch!=null}">
                <div class="alert alert-danger" id="danger" role="alert">
                    Re-enter password must be match with Password!
                </div>
            </c:if>
        </div>
        <div>
            <c:if test="${somethingIsNull!=null}">
                <div class="alert alert-danger" id="danger" role="alert">
                    You must enter all of your information
                </div>
            </c:if>
        </div>
        <div>
            <c:if test="${success!=null}">
                <div class="alert alert-danger" id="danger" role="alert">
                    Sign-up Successful! Welcome to The Pet Shop
                    Click HOME to Sign-in
                </div>
            </c:if>
        </div>
        <div class="page-container">
            <form action="register" method="POST">
                <h1>Sign Up</h1>
                <input type="text" name="name" class="Name" placeholder="Name">
                <input type="email" name="email" class="Email" placeholder="Email">
                <input type="password" name="password" class="Address" placeholder="Password">
                <input type="password" name="repassword" class="Address" placeholder="Ee-enter password">
                <button type="submit" value="Add" name="submit">Submit</button>
            </form>
        </div>
    </body>
</html>