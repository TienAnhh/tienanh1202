<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="styleHome.css" rel="stylesheet" type="text/css"/>
<link href="styleView.css" rel="stylesheet" type="text/css"/>
<!------ Include the above in your HEAD tag ---------->
<jsp:useBean id="info" class="dal.AccountDAO" scope="request"></jsp:useBean>
<c:if test="${paymentsuccess!=null}">
    <div class="alert alert-danger" id="danger" role="alert">
        Your payment successful!
    </div>
</c:if>
<c:if test="${addsuccess!=null}">
    <div class="alert alert-danger" id="danger" role="alert">
        Add to cart successful!
    </div>
</c:if>
<c:if test="${paymentfailed!=null}">
    <div class="alert alert-danger" id="danger" role="alert">
        Add to cart failed! Nothing in your cart!
    </div>
</c:if>
<c:if test="${notAdmin!=null}">
    <div class="alert alert-danger" id="danger" role="alert">
        You can not use Manager function
    </div>
</c:if>
<c:if test="${updateSuccess!=null}">
    <div class="alert alert-danger" id="danger" role="alert">
        Update successful
    </div>
</c:if>
<nav class="navbar navbar-dark bg-primary" style="color: red ; background-color: #00a8e8; margin-bottom: 80px; height: 80px">
    <!-- Navbar content -->
    <a class="navbar-brand" href="home.jsp" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Home</a>
    <a class="navbar-brand" href="contact.jsp" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Contact</a>
    <a class="navbar-brand" href="cart.jsp" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Watch your cart</a>
    <a class="navbar-brand" href="manager?isAdmin=${isAdmin}" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Product Management</a>
    <a class="navbar-brand" href="logout" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Logout</a>
    <h3 style="text-align: right; margin-top: 25px; margin-right: 5px; color: red"><%String hello = (String) session.getAttribute("userName");%> Welcome : <%out.print(hello);%></h3>
</nav>

<div class="container">
    <div class="container_inner default_template_holder clearfix page_container_inner">
        <div class="vc_row wpb_row section vc_row-fluid" style=" padding-top:0px; text-align:left;"><div class=" full_section_inner clearfix">
                <div class="vc_col-sm-12 wpb_column vc_column_container">
                    <div class="wpb_wrapper">


                       


                        <div class="projects_holder_outer v3 portfolio_with_space portfolio_standard "><div class="filter_outer"><div class="filter_holder">
                                    <ul>
                                        <li class="filter active current" data-filter="all"><span></span></li><li class="filter" data-filter="portfolio_category_17"><span></span></li><li class="filter" data-filter="portfolio_category_2"><span></span></li><li class="filter" data-filter="portfolio_category_5"><span></span></li></ul></div></div><div class="projects_holder clearfix v3 standard">
                                                <c:forEach items="${info.listAnimalsInfo()}" var="in4">
                                    <article class="mix portfolio_category_17 portfolio_category_5  mix_all" style="display: inline-block; opacity: 1;"><div class="image_holder"><a class="portfolio_link_for_touch" href="viewServlet?ProductID=${in4.id}" target="_self"><span class="image"><img width="1100" height="825" src="image/${in4.image}" class="attachment-full wp-post-image" alt="qode interactive strata"></span></a><span class="text_holder"><span class="text_outer"><span class="text_inner"><span class="feature_holder"><span class="feature_holder_icons"><a class="lightbox qbutton small white" title="Golden" href="image/${in4.image}" data-rel="prettyPhoto[pretty_photo_gallery]" rel="prettyPhoto[pretty_photo_gallery]">zoom</a><a class="preview qbutton small white" href="viewServlet?ProductID=${in4.id}" target="_self">view</a></span></span></span></span></span></div><div class="portfolio_description "><h5 class="portfolio_title"><a href="viewServlet?ProductID=${in4.id}" target="_self">${in4.name}</a></h5><span class="project_category">Price: ${in4.price}$</span></div></article>
                                                </c:forEach>
                                <div class="filler"></div>
                                <div class="filler"></div>
                                <div class="filler"></div>
                            </div><div class="portfolio_paging"><span rel="2" class="load_more"><a href="viewServlet?ProductID=${in4.id}">Show more</a></span></div><div class="portfolio_paging_loading"><a href="javascript: void(0)" class="qbutton">Loading...</a></div></div><div class="separator  transparent center  " style="margin-top: 20px;margin-bottom: 20px;"></div>

                    </div> 
                </div> 
            </div></div>
    </div>
</div>
             