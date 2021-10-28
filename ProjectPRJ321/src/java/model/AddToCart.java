/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author TISD
 */
public class AddToCart {
    String userName;
    int id;

    public AddToCart() {
    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public AddToCart(String userName, int id) {
        this.userName = userName;
        this.id = id;
    }
    
    
}
