<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="style.css" rel="stylesheet" type="text/css"/>
<!------ Include the above in your HEAD tag ---------->
<div>
    <c:if test="${error!=null}">
        <div class="alert alert-danger" id="danger" role="alert">
            <form action="signup.jsp" method="GET">
                Login Failed
                <input type="submit" value="Register" class="button">
            </form>
        </div>
    </c:if>
</div>
<div>
    <c:if test="${invalid!=null}">
        <div class="alert alert-danger" id="danger" role="alert">
            Your email is invalid
        </div>
    </c:if>
</div>
<div>
    <c:if test="${canNotFind!=null}">
        <div class="alert alert-danger" id="danger" role="alert">
            Your account is not availabel!
        </div>
    </c:if>
</div>
<div>
    <c:if test="${findSuccess!=null}">
        <div class="alert alert-danger" id="danger" role="alert">
            Your password is ${findSuccess}
        </div>
    </c:if>
</div>
<div>
    <c:if test="${logedout!=null}">
        <div class="alert alert-danger" id="danger" role="alert">
            You must re-login
        </div>
    </c:if>
</div>
<div class="login-wrap">
    <div class="login-html">
        <input id="tab-1" type="radio" name="tab" class="sign-in" checked><label for="tab-1" class="tab">Sign In</label>
        <input id="tab-2" type="radio" name="tab" class="for-pwd"><label for="tab-2" class="tab">Forgot Password</label>
        <div class="login-form">
            <form action="login" method="GET">
                <div class="sign-in-htm">
                    <div class="group">
                        <label for="user" class="label">Username or Email</label>
                        <input name="userName" id="user" type="text" class="input">
                    </div>
                    <div class="group">
                        <label for="pass" class="label">Password</label>
                        <input name="password" id="pass" type="password" class="input" data-type="password">
                    </div>
                    <div class="group">
                        <input type="submit" class="button" value="Sign In">
                    </div>
                    <div>
                        <a href="adminController.jsp" style="color: cyan; text-align: center;">----Login with administrator----</a>
                    </div>
                    <div class="hr"></div>
                </div>
            </form>
            <form action="forgot" method="GET">
                <div class="for-pwd-htm">
                    <div class="group">
                        <label for="user" class="label">Email</label>
                        <input name="email" id="email" type="text" class="input">
                    </div>
                    <div class="group">
                        <input type="submit" class="button" value="Reset Password">
                    </div>
                    <div class="hr"></div>
                </div>
            </form>
        </div>
    </div>
</div>