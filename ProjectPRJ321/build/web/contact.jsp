<%-- 
    Document   : contact
    Created on : Mar 24, 2021, 8:16:04 PM
    Author     : Tien Anh
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<link href="stylecontact.css" rel="stylesheet" type="text/css"/>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <a class="navbar-brand" href="home.jsp" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Home</a>
        <section id="mainContainer">
            <div class="about" >
                <h2 style="font-size:45px;font-family:Time New Roman">CONTACT US</h2>
                <div style="margin-top:-20px;font-size:30px;color:#556B2F;">+84 98 427 0668    |    anhbthe141027@fpt.edu.vn  </div>
                <div style="margin-top:20px;font-family:Candara;padding-left:210px;width:800px;font-size:20px;color:#556B2F;line-height:2em;">

                </div>


                <div class="container">
                    <form action="contact" method="post">
                        <label>Your Name</label>
                        <input type="text"name="name" required placeholder="Your name..">

                        <label>Email</label>
                        <input type="text" name="email" required placeholder="Your email..">

                        <label>Phone</label>
                        <input type="text" name="phone" required placeholder="Your phone..">

                        <label>Content</label>
                        <textarea  name="contents" required placeholder="Write something.." style="height:70px"></textarea>

                        <input type="submit" value="Send">
                    </form>

                    <%
                        if (request.getAttribute("msg") != null) {
                    %>
                    <h2 style="color: red"><%= request.getAttribute("msg")%></h2>
                    <%
                        }
                    %>
                </div>

        </section>
    </body>
</html>
