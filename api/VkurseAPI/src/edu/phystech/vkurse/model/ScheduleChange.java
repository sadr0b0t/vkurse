/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package edu.phystech.vkurse.model;

/**
 *
 * @author Дима
 */
public class ScheduleChange extends DbTableRecord
{
    protected int scheduleID;
    protected int week;
    protected int groupID;
    protected byte day;
    protected int startTime;
    protected int length;
    protected int lectureID;
    protected int roomID;
    protected int teacherID;
    protected int lectureTypeID;
    protected boolean canceled;
    protected String comment;

    public ScheduleChange() {}
    public ScheduleChange(int id, int scheduleID, int week, int groupID, byte day,
            int startTime, int length, int lectureID, int roomID, int teacherID,
            int lectureTypeID, boolean canceled, String comment)
    {
        this.id = id;
        this.scheduleID = scheduleID;
        this.week = week;
        this.groupID = groupID;
        this.day = day;
        this.startTime = startTime;
        this.length = length;
        this.lectureID = lectureID;
        this.roomID = roomID;
        this.teacherID = teacherID;
        this.lectureTypeID = lectureTypeID;
        this.canceled = canceled;
        this.comment = comment;
    }

    public int getScheduleID() {
        return scheduleID;
    }

    public void setScheduleID(int scheduleID) {
        this.scheduleID = scheduleID;
    }

    public int getWeek() {
        return week;
    }

    public void setWeek(int week) {
        this.week = week;
    }

    public int getGroupID() {
        return groupID;
    }

    public void setGroupID(int groupID) {
        this.groupID = groupID;
    }

    public byte getDay() {
        return day;
    }

    public void setDay(byte day) {
        this.day = day;
    }

    public int getStartTime() {
        return startTime;
    }

    public void setStartTime(int startTime) {
        this.startTime = startTime;
    }

    public int getLength() {
        return length;
    }

    public void setLength(int length) {
        this.length = length;
    }

    public int getLectureID() {
        return lectureID;
    }

    public void setLectureID(int lectureID) {
        this.lectureID = lectureID;
    }

    public int getRoomID() {
        return roomID;
    }

    public void setRoomID(int roomID) {
        this.roomID = roomID;
    }

    public int getTeacherID() {
        return teacherID;
    }

    public void setTeacherID(int teacherID) {
        this.teacherID = teacherID;
    }

    public String getComment() {
        return comment;
    }

    public void setComment(String comment) {
        this.comment = comment;
    }

    public boolean getCanceled() {
        return canceled;
    }

    public void setCanceled(boolean canceled) {
        this.canceled = canceled;
    }

    public int getLectureTypeID() {
        return lectureTypeID;
    }

    public void setLectureTypeID(int lectureTypeID) {
        this.lectureTypeID = lectureTypeID;
    }

    //@Override public String toString()
    public String toStringData()
    {
        String r = "ID=" + id + " ";
        r += "scheduleID=" + scheduleID + " ";
        r += "week=" + week + " ";
        r += "groupID=" + groupID + " ";
        r += "day=" + day + " ";
        r += "startTime=" + startTime + " ";
        r += "length=" + length + " ";
        r += "lectureID=" + lectureID + " ";
        r += "roomID=" + roomID + " ";
        r += "teacherID=" + teacherID + " ";
        r += "lectureTypeID=" + lectureTypeID + " ";
        r += "canceled=" + canceled + " ";
        r += "comment='" + replace(comment,"'", "<apostrophe>") + "' ";
        r = r.trim();
        return r;
    }

    void setData(String n, String d)
    {
        if (n.equals("ID")) this.id = Integer.parseInt(d);
        if (n.equals("scheduleID")) this.scheduleID = Integer.parseInt(d);
        if (n.equals("week")) this.week = Integer.parseInt(d);
        if (n.equals("groupID")) this.groupID = Integer.parseInt(d);
        if (n.equals("day")) this.day = (byte)Integer.parseInt(d);
        if (n.equals("startTime")) this.startTime = Integer.parseInt(d);
        if (n.equals("length")) this.length = Integer.parseInt(d);
        if (n.equals("lectureID")) this.lectureID = Integer.parseInt(d);
        if (n.equals("roomID")) this.roomID = Integer.parseInt(d);
        if (n.equals("teacherID")) this.teacherID = Integer.parseInt(d);
        if (n.equals("lectureTypeID")) this.lectureTypeID = Integer.parseInt(d);
        if (n.equals("canceled")) this.canceled = Boolean.parseBoolean(d);
        if (n.equals("comment")) this.comment = d;
    }
}
