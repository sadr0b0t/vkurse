/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package edu.phystech.vkurse.model;

/**
 *
 * @author Дима
 */
public interface GroupsTable
{
    public int insert(Group item) throws TableException;
    public boolean update(Group item) throws TableException;
    public Group get(int ID) throws TableException;
    public boolean remove(int ID) throws TableException;
    public java.util.Vector getAll() throws TableException;
    public java.util.Vector get(int[] ids) throws TableException;
    //public int findFreeID() throws TableException;
    //public boolean insertWithNewID(Group item) throws TableException;
}
