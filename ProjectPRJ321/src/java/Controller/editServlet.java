/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import dal.AccountDAO;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author TISD
 */
@WebServlet(name = "editServlet", urlPatterns = {"/edit"})
public class editServlet extends HttpServlet {

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
            String getId = request.getParameter("id");
            int id = 0;
            try {
                id = Integer.parseInt(getId);
            } catch (Exception ex) {
                request.setAttribute("updateERROR", "failed");
                RequestDispatcher rd = request.getRequestDispatcher("editProduct.jsp");
                rd.forward(request, response);
            }
            String name = request.getParameter("name");
            String origin = request.getParameter("origin");
            String getPrice = request.getParameter("price");
            String description = request.getParameter("description");
            int price = 0;
            try {
                price = Integer.parseInt(getPrice);
            } catch (Exception ex) {
                request.setAttribute("updateERROR", "failed");
                RequestDispatcher rd = request.getRequestDispatcher("editProduct.jsp");
                rd.forward(request, response);
            }
                AccountDAO account = new AccountDAO();
                account.updateInformation(id, name, origin, price, description);
                request.setAttribute("updateSuccess", "success");
                RequestDispatcher rd = request.getRequestDispatcher("manager.jsp");
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
