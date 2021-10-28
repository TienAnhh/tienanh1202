package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class view_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("<link href=\"//netdna.bootstrapcdn.com/bootstrap/3.0.1/css/bootstrap.min.css\" rel=\"stylesheet\" id=\"bootstrap-css\">\n");
      out.write("<script src=\"//netdna.bootstrapcdn.com/bootstrap/3.0.1/js/bootstrap.min.js\"></script>\n");
      out.write("<script src=\"//code.jquery.com/jquery-1.11.1.min.js\"></script>\n");
      out.write("<link href=\"styleView.css\" rel=\"stylesheet\" type=\"text/css\"/>\n");
      out.write("<!------ Include the above in your HEAD tag ---------->\n");
      out.write("\n");
      out.write("<nav class=\"navbar navbar-dark bg-primary\" style=\"color: red ; background-color: #00a8e8; margin-bottom: 80px; height: 80px\">\n");
      out.write("  <!-- Navbar content -->\n");
      out.write("  <a class=\"navbar-brand\" href=\"home.jsp\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Home</a>\n");
      out.write("  <a class=\"navbar-brand\" href=\"home.jsp\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Contact</a>\n");
      out.write("  <a class=\"navbar-brand\" href=\"cart.jsp\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Watch your cart</a>\n");
      out.write("</nav>\n");
      out.write("<div class=\"container-fluid\">\n");
      out.write("    <div class=\"content-wrapper\">\t\n");
      out.write("\t\t<div class=\"item-container\">\t\n");
      out.write("\t\t\t<div class=\"container\">\t\n");
      out.write("\t\t\t\t<div class=\"col-md-12\">\n");
      out.write("                                    <div style=\"border: none;\" class=\"product col-md-3 service-image-left\">\n");
      out.write("\t\t\t\t\t\t<center>\n");
      out.write("                                                        <img style=\"width: 350px; height: 200px; max-height: 250px;\" src=\"image/");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.image}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\" alt=\"\"></img>\n");
      out.write("\t\t\t\t\t\t</center>\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\n");
      out.write("\t\t\t\t\t<div style=\"border: none\" class=\"container service1-items col-sm-2 col-md-2 pull-left\">\n");
      out.write("\t\t\t\t\t\t<center>\n");
      out.write("\t\t\t\t\t\t\t<a style=\"border: none\" id=\"item-1\" class=\"service1-item\">\n");
      out.write("\t\t\t\t\t\t\t\t<img src=\"http://www.corsair.com/Media/catalog/product/g/s/gs600_psu_sideview_blue_2.png\" alt=\"\"></img>\n");
      out.write("\t\t\t\t\t\t\t</a>\n");
      out.write("\t\t\t\t\t\t\t<a style=\"border: none\" id=\"item-2\" class=\"service1-item\">\n");
      out.write("\t\t\t\t\t\t\t\t<img src=\"http://www.corsair.com/Media/catalog/product/g/s/gs600_psu_sideview_blue_2.png\" alt=\"\"></img>\n");
      out.write("\t\t\t\t\t\t\t</a>\n");
      out.write("\t\t\t\t\t\t\t<a style=\"border: none\" id=\"item-3\" class=\"service1-item\">\n");
      out.write("\t\t\t\t\t\t\t\t<img src=\"http://www.corsair.com/Media/catalog/product/g/s/gs600_psu_sideview_blue_2.png\" alt=\"\"></img>\n");
      out.write("\t\t\t\t\t\t\t</a>\n");
      out.write("\t\t\t\t\t\t</center>\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\n");
      out.write("\t\t\t\t<div class=\"col-md-7\">\n");
      out.write("\t\t\t\t\t<div class=\"product-title\">");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.name}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("</div>\n");
      out.write("\t\t\t\t\t<div class=\"product-desc\">");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.origin}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("</div>\n");
      out.write("\t\t\t\t\t<div class=\"product-rating\"><i class=\"fa fa-star gold\"></i> <i class=\"fa fa-star gold\"></i> <i class=\"fa fa-star gold\"></i> <i class=\"fa fa-star gold\"></i> <i class=\"fa fa-star-o\"></i> </div>\n");
      out.write("\t\t\t\t\t<hr>\n");
      out.write("\t\t\t\t\t<div class=\"product-price\">");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.price}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("$</div>\n");
      out.write("\t\t\t\t\t<div class=\"product-stock\">In Stock</div>\n");
      out.write("\t\t\t\t\t<hr>\n");
      out.write("\t\t\t\t\t<div class=\"btn-group cart\">\n");
      out.write("                                            <a href=\"bill?item_id=");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.id}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("&item_name=");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.name}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\">\n");
      out.write("\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-success\">\n");
      out.write("\t\t\t\t\t\t\tAdd to cart \n");
      out.write("\t\t\t\t\t\t</button>\n");
      out.write("                                            </a>\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t<div class=\"btn-group wishlist\">\n");
      out.write("                                            <a href=\"bill?item_id=");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.id}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("&item_name=");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.name}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\">\n");
      out.write("\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-danger\">\n");
      out.write("\t\t\t\t\t\t\tAdd to wishlist \n");
      out.write("\t\t\t\t\t\t</button>\n");
      out.write("                                            </a>\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t</div> \n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div class=\"container-fluid\">\t\t\n");
      out.write("\t\t\t<div class=\"col-md-12 product-info\">\n");
      out.write("\t\t\t\t\t<ul id=\"myTab\" class=\"nav nav-tabs nav_tabs\">\n");
      out.write("\t\t\t\t\t\t\n");
      out.write("\t\t\t\t\t\t<li class=\"active\"><a href=\"#service-one\" data-toggle=\"tab\">DESCRIPTION</a></li>\n");
      out.write("\t\t\t\t\t\t<li><a href=\"#service-two\" data-toggle=\"tab\">PRODUCT INFO</a></li>\n");
      out.write("\t\t\t\t\t\t<li><a href=\"#service-three\" data-toggle=\"tab\">REVIEWS</a></li>\n");
      out.write("\t\t\t\t\t\t\n");
      out.write("\t\t\t\t\t</ul>\n");
      out.write("\t\t\t\t<div id=\"myTabContent\" class=\"tab-content\">\n");
      out.write("\t\t\t\t\t\t<div class=\"tab-pane fade in active\" id=\"service-one\">\n");
      out.write("\t\t\t\t\t\t \n");
      out.write("\t\t\t\t\t\t\t<section class=\"container product-info\">\n");
      out.write("\t\t\t\t\t\t\t\t");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.description}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\n");
      out.write("\n");
      out.write("\t\t\t\t\t\t\t\t<h3>");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${att.name}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("</h3>\n");
      out.write("\t\t\t\t\t\t\t\t<li>Nice fish, healthy eating, parents from abroad.</li>\n");
      out.write("\t\t\t\t\t\t\t\t<li>Full certificate of origin.</li>\n");
      out.write("\t\t\t\t\t\t\t\t<li>Warranty for 3 months, great deals when transferring.</li>\n");
      out.write("\t\t\t\t\t\t\t\t<li>Huge offer when the buyer is female</li>\n");
      out.write("\t\t\t\t\t\t\t\t<li>Fish do not eat much, the seller does not take money</li>\n");
      out.write("\t\t\t\t\t\t\t</section>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t  \n");
      out.write("\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t<div class=\"tab-pane fade\" id=\"service-two\">\n");
      out.write("\t\t\t\t\t\t\n");
      out.write("\t\t\t\t\t\t<section class=\"container\">\n");
      out.write("\t\t\t\t\t\t\t\t\n");
      out.write("\t\t\t\t\t\t</section>\n");
      out.write("\t\t\t\t\t\t\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t<div class=\"tab-pane fade\" id=\"service-three\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t\t<hr>\n");
      out.write("\t\t\t</div>\n");
      out.write("\t\t</div>\n");
      out.write("\t</div>\n");
      out.write("</div>");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
