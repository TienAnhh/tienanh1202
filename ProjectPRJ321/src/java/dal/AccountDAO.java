/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dal;

import context.DBContext;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import model.Account;
import model.AddToCart;
import model.Information;

/**
 *
 * @author TISD
 */
public class AccountDAO {

    static Connection con = null;
    static PreparedStatement ps = null;
    static ResultSet rs = null;


    
    public static boolean checkLogin(String userName, String password) throws Exception {
        boolean isValid = false;
        try {
            String query = "select * from Account where userName = ? and password = ?";
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setString(1, userName);
            ps.setString(2, password);
            //thuc thi cau lenh truy van den SQL
            rs = ps.executeQuery();
            //truong hop dang nhap thanh cong
            if (rs.next()) {
                isValid = true;
            } else {
                isValid = false;
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
        return isValid;
    }
    
    public static boolean checkLoginAdmin(String userName, String password) throws Exception{
        boolean isValid = false;
        try{
            String query = "select * from adminController where adminAccount = ? and adminPass = ?";
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setString(1, userName);
            ps.setString(2, password);
            rs = ps.executeQuery();
            if (rs.next()) {
                isValid = true;
            } else {
                isValid = false;
            }
        } catch(Exception ex){
            ex.printStackTrace();
        }
        return isValid;
    }
    
    public static String checkForgotPassword(String email) throws Exception {
        String password = null;
        try {
            String query = "select * from account[a] inner join email[e] on a.userName = e.username where mail = ?";
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setString(1, email);
            rs = ps.executeQuery();
            if (rs.next()) {
                password = rs.getString(2);
            } else {
                password = "Can not find your account!";
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        return password;
    }
    
    public static String getPasswordForgoten(String userName, String email) throws Exception {
        try {
            String query = "select * from ";
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            rs = ps.executeQuery();
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        return userName;
    }
    
    public List<Information> listAnimalsInfo() {
        List<Information> list = new ArrayList<>();
        String query = "select * from information";
        try {
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            rs = ps.executeQuery();
            while (rs.next()) {
                list.add(new Information(rs.getInt(1), rs.getString(2), rs.getString(3), rs.getInt(4), rs.getString(5), rs.getString(6)));
            }
        } catch (Exception e) {
        }
        return list;
    }
    
    public Information getInformationById(int id){
        String query = "select * from information where id=?";
        try {
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setInt(1, id);
            rs = ps.executeQuery();
            while (rs.next()) {
                return new Information(rs.getInt(1), rs.getString(2), rs.getString(3), rs.getInt(4), rs.getString(5), rs.getString(6));
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        return null;
    }
    
    public Account registerAccount(String userName, String password){
        String query = "insert into [dbo].[account] values (?, ?)";
        try {
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setString(1, userName);
            ps.setString(2, password);
            rs = ps.executeQuery();
        } catch(Exception ex){
            ex.printStackTrace();
        }
        return null;
    }
    
    public Account addEmailBaseOnAccountName(String userName, String email){
        String query = "insert into [dbo].[email] values (?, ?)";
        try {
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setString(1, userName);
            ps.setString(2, email);
            rs = ps.executeQuery();
        } catch(Exception ex){
            ex.printStackTrace();
        }
        return null;
    }
    
    public AddToCart addToCart(String userName, int total, String dop){
        String query = "insert into [dbo].[bill] values (?, ?, ?)";
        try{
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setString(1, userName);
            ps.setInt(2, total);
            ps.setString(3, dop);
            rs = ps.executeQuery();
        } catch(Exception ex){
            ex.printStackTrace();
        }
        return null;
    }
    
    public Information updateInformation(int id, String name, String origin, int price, String description){
        String query = "update information set name = ?, origin = ?, price = ?, description = ? where id = ?";
        try {
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setInt(5, id);
            ps.setString(1, name);
            ps.setString(2, origin);
            ps.setInt(3, price);
            ps.setString(4, description);
            rs = ps.executeQuery();
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        return null;
    }
    
    public Information deleteInformationById(int id){
        String query = "delete from information where id = ?";
        try {
            con = new DBContext().getConnection();
            ps = con.prepareStatement(query);
            ps.setInt(1, id);
            rs = ps.executeQuery();
        } catch (Exception ex) {
            
        }
        return null;
    }
    
    public void addToContact(String username, String email, String phone, String contents) {
        
            String sql = "INSERT INTO [Contact]\n"
                    + "           (name, email, phone, contents)"
                    + "     VALUES(?,?,?,?)";
            try {
                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1, username);
                ps.setString(2, email);
                ps.setString(3, phone);
                ps.setString(4, contents);
                ps.executeUpdate();
        } catch (SQLException e) {
            System.out.println(e);
        }
    }
    
    public static void main(String[] args) throws Exception {
        AccountDAO ad = new AccountDAO();
//        List<Account> li = ad.getAllAccount();
    }
}
