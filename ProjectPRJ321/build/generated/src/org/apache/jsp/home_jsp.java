package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class home_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.apache.jasper.runtime.TagHandlerPool _jspx_tagPool_c_forEach_var_items;
  private org.apache.jasper.runtime.TagHandlerPool _jspx_tagPool_c_if_test;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspInit() {
    _jspx_tagPool_c_forEach_var_items = org.apache.jasper.runtime.TagHandlerPool.getTagHandlerPool(getServletConfig());
    _jspx_tagPool_c_if_test = org.apache.jasper.runtime.TagHandlerPool.getTagHandlerPool(getServletConfig());
  }

  public void _jspDestroy() {
    _jspx_tagPool_c_forEach_var_items.release();
    _jspx_tagPool_c_if_test.release();
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
      out.write("<link href=\"//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css\" rel=\"stylesheet\" id=\"bootstrap-css\">\n");
      out.write("<script src=\"//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js\"></script>\n");
      out.write("<script src=\"//code.jquery.com/jquery-1.11.1.min.js\"></script>\n");
      out.write("<link href=\"styleHome.css\" rel=\"stylesheet\" type=\"text/css\"/>\n");
      out.write("<link href=\"styleView.css\" rel=\"stylesheet\" type=\"text/css\"/>\n");
      out.write("<!------ Include the above in your HEAD tag ---------->\n");
      dal.AccountDAO info = null;
      synchronized (request) {
        info = (dal.AccountDAO) _jspx_page_context.getAttribute("info", PageContext.REQUEST_SCOPE);
        if (info == null){
          info = new dal.AccountDAO();
          _jspx_page_context.setAttribute("info", info, PageContext.REQUEST_SCOPE);
        }
      }
      out.write('\n');
      if (_jspx_meth_c_if_0(_jspx_page_context))
        return;
      out.write('\n');
      if (_jspx_meth_c_if_1(_jspx_page_context))
        return;
      out.write('\n');
      if (_jspx_meth_c_if_2(_jspx_page_context))
        return;
      out.write('\n');
      if (_jspx_meth_c_if_3(_jspx_page_context))
        return;
      out.write('\n');
      if (_jspx_meth_c_if_4(_jspx_page_context))
        return;
      out.write("\n");
      out.write("<nav class=\"navbar navbar-dark bg-primary\" style=\"color: red ; background-color: #00a8e8; margin-bottom: 80px; height: 80px\">\n");
      out.write("    <!-- Navbar content -->\n");
      out.write("    <a class=\"navbar-brand\" href=\"home.jsp\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Home</a>\n");
      out.write("    <a class=\"navbar-brand\" href=\"contact.jsp\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Contact</a>\n");
      out.write("    <a class=\"navbar-brand\" href=\"cart.jsp\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Watch your cart</a>\n");
      out.write("    <a class=\"navbar-brand\" href=\"manager?isAdmin=");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${isAdmin}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Product Management</a>\n");
      out.write("    <a class=\"navbar-brand\" href=\"logout\" style=\"font-weight: bold; margin-top: 12px; margin-left: 10px; color: crimson\">Logout</a>\n");
      out.write("    <h3 style=\"text-align: right; margin-top: 25px; margin-right: 5px; color: red\">");
String hello = (String) session.getAttribute("userName");
      out.write(" Welcome : ");
out.print(hello);
      out.write("</h3>\n");
      out.write("</nav>\n");
      out.write("\n");
      out.write("<div class=\"container\">\n");
      out.write("    <div class=\"container_inner default_template_holder clearfix page_container_inner\">\n");
      out.write("        <div class=\"vc_row wpb_row section vc_row-fluid\" style=\" padding-top:0px; text-align:left;\"><div class=\" full_section_inner clearfix\">\n");
      out.write("                <div class=\"vc_col-sm-12 wpb_column vc_column_container\">\n");
      out.write("                    <div class=\"wpb_wrapper\">\n");
      out.write("\n");
      out.write("\n");
      out.write("                       \n");
      out.write("\n");
      out.write("\n");
      out.write("                        <div class=\"projects_holder_outer v3 portfolio_with_space portfolio_standard \"><div class=\"filter_outer\"><div class=\"filter_holder\">\n");
      out.write("                                    <ul>\n");
      out.write("                                        <li class=\"filter active current\" data-filter=\"all\"><span></span></li><li class=\"filter\" data-filter=\"portfolio_category_17\"><span></span></li><li class=\"filter\" data-filter=\"portfolio_category_2\"><span></span></li><li class=\"filter\" data-filter=\"portfolio_category_5\"><span></span></li></ul></div></div><div class=\"projects_holder clearfix v3 standard\">\n");
      out.write("                                                ");
      if (_jspx_meth_c_forEach_0(_jspx_page_context))
        return;
      out.write("\n");
      out.write("                                <div class=\"filler\"></div>\n");
      out.write("                                <div class=\"filler\"></div>\n");
      out.write("                                <div class=\"filler\"></div>\n");
      out.write("                            </div><div class=\"portfolio_paging\"><span rel=\"2\" class=\"load_more\"><a href=\"viewServlet?ProductID=");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.id}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\">Show more</a></span></div><div class=\"portfolio_paging_loading\"><a href=\"javascript: void(0)\" class=\"qbutton\">Loading...</a></div></div><div class=\"separator  transparent center  \" style=\"margin-top: 20px;margin-bottom: 20px;\"></div>\n");
      out.write("\n");
      out.write("                    </div> \n");
      out.write("                </div> \n");
      out.write("            </div></div>\n");
      out.write("    </div>\n");
      out.write("</div>\n");
      out.write("             ");
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

  private boolean _jspx_meth_c_if_0(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:if
    org.apache.taglibs.standard.tag.rt.core.IfTag _jspx_th_c_if_0 = (org.apache.taglibs.standard.tag.rt.core.IfTag) _jspx_tagPool_c_if_test.get(org.apache.taglibs.standard.tag.rt.core.IfTag.class);
    _jspx_th_c_if_0.setPageContext(_jspx_page_context);
    _jspx_th_c_if_0.setParent(null);
    _jspx_th_c_if_0.setTest(((java.lang.Boolean) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${paymentsuccess!=null}", java.lang.Boolean.class, (PageContext)_jspx_page_context, null)).booleanValue());
    int _jspx_eval_c_if_0 = _jspx_th_c_if_0.doStartTag();
    if (_jspx_eval_c_if_0 != javax.servlet.jsp.tagext.Tag.SKIP_BODY) {
      do {
        out.write("\n");
        out.write("    <div class=\"alert alert-danger\" id=\"danger\" role=\"alert\">\n");
        out.write("        Your payment successful!\n");
        out.write("    </div>\n");
        int evalDoAfterBody = _jspx_th_c_if_0.doAfterBody();
        if (evalDoAfterBody != javax.servlet.jsp.tagext.BodyTag.EVAL_BODY_AGAIN)
          break;
      } while (true);
    }
    if (_jspx_th_c_if_0.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
      _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_0);
      return true;
    }
    _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_0);
    return false;
  }

  private boolean _jspx_meth_c_if_1(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:if
    org.apache.taglibs.standard.tag.rt.core.IfTag _jspx_th_c_if_1 = (org.apache.taglibs.standard.tag.rt.core.IfTag) _jspx_tagPool_c_if_test.get(org.apache.taglibs.standard.tag.rt.core.IfTag.class);
    _jspx_th_c_if_1.setPageContext(_jspx_page_context);
    _jspx_th_c_if_1.setParent(null);
    _jspx_th_c_if_1.setTest(((java.lang.Boolean) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${addsuccess!=null}", java.lang.Boolean.class, (PageContext)_jspx_page_context, null)).booleanValue());
    int _jspx_eval_c_if_1 = _jspx_th_c_if_1.doStartTag();
    if (_jspx_eval_c_if_1 != javax.servlet.jsp.tagext.Tag.SKIP_BODY) {
      do {
        out.write("\n");
        out.write("    <div class=\"alert alert-danger\" id=\"danger\" role=\"alert\">\n");
        out.write("        Add to cart successful!\n");
        out.write("    </div>\n");
        int evalDoAfterBody = _jspx_th_c_if_1.doAfterBody();
        if (evalDoAfterBody != javax.servlet.jsp.tagext.BodyTag.EVAL_BODY_AGAIN)
          break;
      } while (true);
    }
    if (_jspx_th_c_if_1.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
      _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_1);
      return true;
    }
    _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_1);
    return false;
  }

  private boolean _jspx_meth_c_if_2(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:if
    org.apache.taglibs.standard.tag.rt.core.IfTag _jspx_th_c_if_2 = (org.apache.taglibs.standard.tag.rt.core.IfTag) _jspx_tagPool_c_if_test.get(org.apache.taglibs.standard.tag.rt.core.IfTag.class);
    _jspx_th_c_if_2.setPageContext(_jspx_page_context);
    _jspx_th_c_if_2.setParent(null);
    _jspx_th_c_if_2.setTest(((java.lang.Boolean) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${paymentfailed!=null}", java.lang.Boolean.class, (PageContext)_jspx_page_context, null)).booleanValue());
    int _jspx_eval_c_if_2 = _jspx_th_c_if_2.doStartTag();
    if (_jspx_eval_c_if_2 != javax.servlet.jsp.tagext.Tag.SKIP_BODY) {
      do {
        out.write("\n");
        out.write("    <div class=\"alert alert-danger\" id=\"danger\" role=\"alert\">\n");
        out.write("        Add to cart failed! Nothing in your cart!\n");
        out.write("    </div>\n");
        int evalDoAfterBody = _jspx_th_c_if_2.doAfterBody();
        if (evalDoAfterBody != javax.servlet.jsp.tagext.BodyTag.EVAL_BODY_AGAIN)
          break;
      } while (true);
    }
    if (_jspx_th_c_if_2.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
      _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_2);
      return true;
    }
    _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_2);
    return false;
  }

  private boolean _jspx_meth_c_if_3(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:if
    org.apache.taglibs.standard.tag.rt.core.IfTag _jspx_th_c_if_3 = (org.apache.taglibs.standard.tag.rt.core.IfTag) _jspx_tagPool_c_if_test.get(org.apache.taglibs.standard.tag.rt.core.IfTag.class);
    _jspx_th_c_if_3.setPageContext(_jspx_page_context);
    _jspx_th_c_if_3.setParent(null);
    _jspx_th_c_if_3.setTest(((java.lang.Boolean) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${notAdmin!=null}", java.lang.Boolean.class, (PageContext)_jspx_page_context, null)).booleanValue());
    int _jspx_eval_c_if_3 = _jspx_th_c_if_3.doStartTag();
    if (_jspx_eval_c_if_3 != javax.servlet.jsp.tagext.Tag.SKIP_BODY) {
      do {
        out.write("\n");
        out.write("    <div class=\"alert alert-danger\" id=\"danger\" role=\"alert\">\n");
        out.write("        You can not use Manager function\n");
        out.write("    </div>\n");
        int evalDoAfterBody = _jspx_th_c_if_3.doAfterBody();
        if (evalDoAfterBody != javax.servlet.jsp.tagext.BodyTag.EVAL_BODY_AGAIN)
          break;
      } while (true);
    }
    if (_jspx_th_c_if_3.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
      _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_3);
      return true;
    }
    _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_3);
    return false;
  }

  private boolean _jspx_meth_c_if_4(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:if
    org.apache.taglibs.standard.tag.rt.core.IfTag _jspx_th_c_if_4 = (org.apache.taglibs.standard.tag.rt.core.IfTag) _jspx_tagPool_c_if_test.get(org.apache.taglibs.standard.tag.rt.core.IfTag.class);
    _jspx_th_c_if_4.setPageContext(_jspx_page_context);
    _jspx_th_c_if_4.setParent(null);
    _jspx_th_c_if_4.setTest(((java.lang.Boolean) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${updateSuccess!=null}", java.lang.Boolean.class, (PageContext)_jspx_page_context, null)).booleanValue());
    int _jspx_eval_c_if_4 = _jspx_th_c_if_4.doStartTag();
    if (_jspx_eval_c_if_4 != javax.servlet.jsp.tagext.Tag.SKIP_BODY) {
      do {
        out.write("\n");
        out.write("    <div class=\"alert alert-danger\" id=\"danger\" role=\"alert\">\n");
        out.write("        Update successful\n");
        out.write("    </div>\n");
        int evalDoAfterBody = _jspx_th_c_if_4.doAfterBody();
        if (evalDoAfterBody != javax.servlet.jsp.tagext.BodyTag.EVAL_BODY_AGAIN)
          break;
      } while (true);
    }
    if (_jspx_th_c_if_4.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
      _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_4);
      return true;
    }
    _jspx_tagPool_c_if_test.reuse(_jspx_th_c_if_4);
    return false;
  }

  private boolean _jspx_meth_c_forEach_0(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:forEach
    org.apache.taglibs.standard.tag.rt.core.ForEachTag _jspx_th_c_forEach_0 = (org.apache.taglibs.standard.tag.rt.core.ForEachTag) _jspx_tagPool_c_forEach_var_items.get(org.apache.taglibs.standard.tag.rt.core.ForEachTag.class);
    _jspx_th_c_forEach_0.setPageContext(_jspx_page_context);
    _jspx_th_c_forEach_0.setParent(null);
    _jspx_th_c_forEach_0.setItems((java.lang.Object) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${info.listAnimalsInfo()}", java.lang.Object.class, (PageContext)_jspx_page_context, null));
    _jspx_th_c_forEach_0.setVar("in4");
    int[] _jspx_push_body_count_c_forEach_0 = new int[] { 0 };
    try {
      int _jspx_eval_c_forEach_0 = _jspx_th_c_forEach_0.doStartTag();
      if (_jspx_eval_c_forEach_0 != javax.servlet.jsp.tagext.Tag.SKIP_BODY) {
        do {
          out.write("\n");
          out.write("                                    <article class=\"mix portfolio_category_17 portfolio_category_5  mix_all\" style=\"display: inline-block; opacity: 1;\"><div class=\"image_holder\"><a class=\"portfolio_link_for_touch\" href=\"viewServlet?ProductID=");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.id}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("\" target=\"_self\"><span class=\"image\"><img width=\"1100\" height=\"825\" src=\"image/");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.image}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("\" class=\"attachment-full wp-post-image\" alt=\"qode interactive strata\"></span></a><span class=\"text_holder\"><span class=\"text_outer\"><span class=\"text_inner\"><span class=\"feature_holder\"><span class=\"feature_holder_icons\"><a class=\"lightbox qbutton small white\" title=\"Golden\" href=\"image/");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.image}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("\" data-rel=\"prettyPhoto[pretty_photo_gallery]\" rel=\"prettyPhoto[pretty_photo_gallery]\">zoom</a><a class=\"preview qbutton small white\" href=\"viewServlet?ProductID=");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.id}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("\" target=\"_self\">view</a></span></span></span></span></span></div><div class=\"portfolio_description \"><h5 class=\"portfolio_title\"><a href=\"viewServlet?ProductID=");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.id}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("\" target=\"_self\">");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.name}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("</a></h5><span class=\"project_category\">Price: ");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${in4.price}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("$</span></div></article>\n");
          out.write("                                                ");
          int evalDoAfterBody = _jspx_th_c_forEach_0.doAfterBody();
          if (evalDoAfterBody != javax.servlet.jsp.tagext.BodyTag.EVAL_BODY_AGAIN)
            break;
        } while (true);
      }
      if (_jspx_th_c_forEach_0.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
        return true;
      }
    } catch (Throwable _jspx_exception) {
      while (_jspx_push_body_count_c_forEach_0[0]-- > 0)
        out = _jspx_page_context.popBody();
      _jspx_th_c_forEach_0.doCatch(_jspx_exception);
    } finally {
      _jspx_th_c_forEach_0.doFinally();
      _jspx_tagPool_c_forEach_var_items.reuse(_jspx_th_c_forEach_0);
    }
    return false;
  }
}
