/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package edu.phystech.vkurse.test;
import edu.phystech.vkurse.model.*;
import java.util.*;

/**
 *
 * @author Дима
 */
public class GroupsTestTable implements GroupsTable
{
    ArrayList<Group> data = new ArrayList<Group>();
    public GroupsTestTable()
    {
        data.add(new Group(0, "791", "3"));
        data.add(new Group(1, "792", "3"));
        data.add(new Group(2, "793", "3"));
        data.add(new Group(3, "794", "3"));
        data.add(new Group(4, "798", "3"));
    }

    public boolean insert(Group item) throws TableException
    {
        data.add(item);
        return true;
    }

    public boolean update(Group item) throws TableException
    {
        int i;
        for (i=0; i<data.size(); ++i)
        {
            if (data.get(i).getID() == item.getID()) data.set(i, item);
        }
        return true;
    }

    public Group get(int ID) throws TableException
    {
        int i;
        for (i=0; i<data.size(); ++i)
        {
            if (data.get(i).getID() == ID) return data.get(i);
        }
        return null;
    }

    public boolean remove(int ID) throws TableException
    {
        int i;
        int r = -1;
        for (i=0; i<data.size(); ++i)
        {
            if (data.get(i).getID() == ID) r = i;
        }
        if (r>=0)
        {
            data.remove(r);
            return true;
        }
        else
        {
            return false;
        }
    }

    public java.util.Vector getAll() throws TableException
    {
        Vector r = new Vector();
        int i;
        for (i=0; i<data.size(); ++i)
        {
            r.add(data.get(i));
        }
        return r;
    }
}