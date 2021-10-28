/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import dal.AccountDAO;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import model.AddToCart;
import model.Information;
import model.Order;

/**
 *
 * @author TISD
 */
@WebServlet(name = "billServlet", urlPatterns = {"/bill"})
public class billServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            String id = request.getParameter("item_id");
            String name = request.getParameter("item_name");
            
            AccountDAO account = new AccountDAO();
            Information info = account.getInformationById(Integer.parseInt(id));
            
            HttpSession session = request.getSession();
            int total;
            
            if (session.getAttribute("order")==null) {
                Order order = new Order();
                List<Information> list = new ArrayList<>();
                
                Information cart = new Information(info.getId(), info.getName(), info.getOrigin(), info.getPrice(), info.getDescription(), info.getImage());
                list.add(cart);
                total = info.getPrice();
                
                order.setItems(list);
                session.setAttribute("order", order);
                session.setAttribute("total", total);
            } else {
                Order order = (Order) session.getAttribute("order");
                List<Information> list = order.getItems();
                total = (int) session.getAttribute("total");
                
                Information cart = new Information(info.getId(), info.getName(), info.getOrigin(), info.getPrice(), info.getDescription(), info.getImage());
                list.add(cart);
                total = total + info.getPrice();
                
                session.setAttribute("order", order);
                session.setAttribute("total", total);
            }
            request.setAttribute("addsuccess", "success");
            RequestDispatcher rd = request.getRequestDispatcher("home.jsp");
            rd.forward(request, response);
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
