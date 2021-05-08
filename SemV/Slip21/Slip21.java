/*Write a Java program to design a screen using Swing that will create four
TextFields. First for the text, second for what to find and third for replace.
Display result in the fourth TextField. Display the count of total no. of
replacements made. The button clear to clear the TextFields.*/

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Slip21 extends JFrame implements ActionListener {
    // Variables declared
    JLabel textLabel, findLabel, replaceLabel, occurrenceLabel;
    JTextArea text;
    JTextField findText, replaceText, occurrencesText;
    JButton find, replace, exit;
    JPanel panel1, panel2;
    int occurrence = 0, i = 0;

    // Constructor Created.
    public Slip21(){
        textLabel = new JLabel("Enter Text:", JLabel.CENTER); // Align the label to the Center.
        findLabel = new JLabel("Text to Find:",JLabel.CENTER); //
        replaceLabel = new JLabel("Text to Replace:",JLabel.CENTER);
        occurrenceLabel = new JLabel("No.of Occurrences:", JLabel.CENTER);

        text = new JTextArea(1,5); // Creates TextArea with specified number of rows and columns.
        findText = new JTextField(5); // The text area does not display no text initially.
        replaceText = new JTextField(5); // Empty text fields with the specified number of columns.
        occurrencesText = new JTextField(5);
        panel1 = new JPanel();
        panel1.setLayout(new GridLayout(5,2)); // Setting grid layout of 5 rows and 2 columns.
        // Use add() method to add elements into the Set
        panel1.add(textLabel);
        panel1.add(text);
        text.setBounds(50,100,200,30);
        panel1.add(findLabel);
        panel1.add(findText);
        panel1.add(replaceLabel);
        panel1.add(replaceText);
        panel1.add(occurrenceLabel);
        panel1.add(occurrencesText);

        // Button created and named.
        find = new JButton("Find");
        replace = new JButton("Replace");
        exit = new JButton("Exit");


        find.addActionListener(this); // Receive action events from the text field.
        replace.addActionListener(this);
        exit.addActionListener(this);


        panel2 = new JPanel();
        panel2.setLayout(new FlowLayout(FlowLayout.CENTER)); // Setting flow layout to Center alignment.
        panel2.add(find);
        panel2.add(replace);
        panel2.add(exit);

        // Panels Added
        add(panel1,"North");
        add(panel2,"South");

        setTitle("Find And Replace");
        setSize(500,500);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // Default windows close operation
        setVisible(true);
    }

    public static void main(String[] args)
    {
        new Slip21();
    }

    public void actionPerformed(ActionEvent e)
    {
        JButton btn = (JButton)e.getSource();
        // Find the text which needs to be replaced
        if(btn == find)
        {
            String s = text.getText();
            String f = findText.getText();
            i = s.indexOf(f);
            if(i!=-1)
            {
                occurrence++;
                occurrencesText.setText(Integer.toString(occurrence));
                text.select(i,i+f.length()); // Select the text between start and the end position.
                text.requestFocus(); // Requests that this component gets the input Focus.
            }
        }
        // text replaced when clicked on the button (REPLACE)
        if(btn == replace)
        {
            if(text.getSelectedText().length() != 0)
            {
                String r = replaceText.getText();
                text.replaceSelection(r);
            }
        }
        // Exit the program
        if(btn == exit)
        {
            System.exit(0);
        }
    }
}