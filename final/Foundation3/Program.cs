using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1050 W Pine Marsh Way", "South Jordan", "UT", "84009");
        Address address2 = new Address("786 S Main St", "Ephraim", "UT", "84627");
        Address address3 = new Address("132 E Lightning Ave", "Riverton", "UT", "84065");

        Lecture lecture = new Lecture("How to manage your stress", "Come listen to a lecture, given by an expert in the field of psychology, on stress management.", "7/19/2024", "6:00PM", "Lecture", address1, "Richard Yates", 350);
        Reception reception = new Reception("The Wedding of Kylee and Mark", "Join us in witnessing and congratulating Kylee and Mark on their big day.", "8/23/2024", "3:00PM", "Reception", address2, "rsvpnow@gmail.com");
        Outdoor outdoorEvent = new Outdoor("Swimmin N' Steak", "Get ready for an awesome pool party, paired with amazing grilled eats.", "9/20/2024", "7:30PM", "Outdoor event", address3, "Cloudy with a possibility of light rain");

        lecture.FullDisplay();
        reception.FullDisplay();
        outdoorEvent.FullDisplay();
    }
}