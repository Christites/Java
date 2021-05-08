/* Q1. Write a java program to display “Hello Java” with settings Font- Georgia, Foreground color-
Red, background color – Blue on the Frame. */


import java.awt.*;

class Slip7 extends Frame
{
    Label l;
    Slip7() // Constructor Created.
    {
        l=new Label("Hello java"); // Label 
        l.setFont(new Font("Georgia",Font.BOLD,14));
        l.setForeground(Color.RED);
        add(l); // Add specific (Label in this case) element into a Set Collection.
        setBackground(Color.BLUE);
        setSize(500,800); // Frame size set to 500 width and 800 height.
        setLayout(new FlowLayout()); // Constructs a new Layout with the specified alignment and a default 5-unit horizontal and vertical gap.
        setVisible(true); // Shows the window depending on the value of the parameter.

    }
    public static void main(String args[])
    {
        new Slip7(); // Constructor Called.
    }
}
