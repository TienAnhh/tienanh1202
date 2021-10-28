<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<link href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.1/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="styleView.css" rel="stylesheet" type="text/css"/>
<!------ Include the above in your HEAD tag ---------->
<%--<jsp:useBean id="info" class="dal.AccountDAO" scope="request"></jsp:useBean>--%>
<nav class="navbar navbar-dark bg-primary" style="color: red ; background-color: #00a8e8; margin-bottom: 80px; height: 80px">
  <!-- Navbar content -->
  <a class="navbar-brand" href="home.jsp" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Home</a>
  <a class="navbar-brand" href="home.jsp" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Contact</a>
  <a class="navbar-brand" href="cart.jsp" style="font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson">Watch your cart</a>
</nav>
<div class="container-fluid">
    <div class="content-wrapper">	
		<div class="item-container">	
			<div class="container">	
				<div class="col-md-12">
                                    <div style="border: none;" class="product col-md-3 service-image-left">
						<center>
                                                        <img style="width: 350px; height: 200px; max-height: 250px;" src="image/${att.image}" alt=""></img>
						</center>
					</div>
					
					<div style="border: none" class="container service1-items col-sm-2 col-md-2 pull-left">
						<center>
							<a style="border: none" id="item-1" class="service1-item">
								<img src="http://www.corsair.com/Media/catalog/product/g/s/gs600_psu_sideview_blue_2.png" alt=""></img>
							</a>
							<a style="border: none" id="item-2" class="service1-item">
								<img src="http://www.corsair.com/Media/catalog/product/g/s/gs600_psu_sideview_blue_2.png" alt=""></img>
							</a>
							<a style="border: none" id="item-3" class="service1-item">
								<img src="http://www.corsair.com/Media/catalog/product/g/s/gs600_psu_sideview_blue_2.png" alt=""></img>
							</a>
						</center>
					</div>
				</div>
					
				<div class="col-md-7">
					<div class="product-title">${att.name}</div>
					<div class="product-desc">${att.origin}</div>
					<div class="product-rating"><i class="fa fa-star gold"></i> <i class="fa fa-star gold"></i> <i class="fa fa-star gold"></i> <i class="fa fa-star gold"></i> <i class="fa fa-star-o"></i> </div>
					<hr>
					<div class="product-price">${att.price}$</div>
					<div class="product-stock">In Stock</div>
					<hr>
					<div class="btn-group cart">
                                            <a href="bill?item_id=${att.id}&item_name=${att.name}">
						<button type="submit" class="btn btn-success">
							Add to cart 
						</button>
                                            </a>
					</div>
					<div class="btn-group wishlist">
                                            <a href="bill?item_id=${att.id}&item_name=${att.name}">
						<button type="submit" class="btn btn-danger">
							Add to wishlist 
						</button>
                                            </a>
					</div>
				</div>
			</div> 
		</div>
		<div class="container-fluid">		
			<div class="col-md-12 product-info">
					<ul id="myTab" class="nav nav-tabs nav_tabs">
						
						<li class="active"><a href="#service-one" data-toggle="tab">DESCRIPTION</a></li>
						<li><a href="#service-two" data-toggle="tab">PRODUCT INFO</a></li>
						<li><a href="#service-three" data-toggle="tab">REVIEWS</a></li>
						
					</ul>
				<div id="myTabContent" class="tab-content">
						<div class="tab-pane fade in active" id="service-one">
						 
							<section class="container product-info">
								${att.description}

								<h3>${att.name}</h3>
								<li>Nice fish, healthy eating, parents from abroad.</li>
								<li>Full certificate of origin.</li>
								<li>Warranty for 3 months, great deals when transferring.</li>
								<li>Huge offer when the buyer is female</li>
								<li>Fish do not eat much, the seller does not take money</li>
							</section>
										  
						</div>
					<div class="tab-pane fade" id="service-two">
						
						<section class="container">
								
						</section>
						
					</div>
					<div class="tab-pane fade" id="service-three">
												
					</div>
				</div>
				<hr>
			</div>
		</div>
	</div>
</div>