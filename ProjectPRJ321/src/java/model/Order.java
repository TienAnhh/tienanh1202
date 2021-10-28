/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.util.List;

/**
 *
 * @author TISD
 */
public class Order {
    private int id;
    private String name;
    private List<Information> items;

    public Order(int id, String name, List<Information> items) {
        this.id = id;
        this.name = name;
        this.items = items;
    }

    public Order() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public List<Information> getItems() {
        return items;
    }

    public void setItems(List<Information> items) {
        this.items = items;
    }

}
