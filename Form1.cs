using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form{

    public Button button1;
    public TextBox inputText;
    public Form1(){
        button1 = new Button();
        inputText = new TextBox();
        this.Size = new Size(700, 500);

        /*
        button1.Size = new Size(200, 40);
        button1.Location = new Point(30, 30);
        button1.Text = "Click Me!!";
        this.Controls.Add(button1);
        button1.Click += new EventHandler(button1_Click);
        */

        inputText.Multiline = true;
        inputText.Size = new Size(200, 500);
        inputText.Location = new Point(20, 20);
        inputText.Text = "Sample String.";
        this.Controls.Add(inputText);
        inputText.TextChanged += new EventHandler(text_TextChanged);
    }

    private void button1_Click(Object sender, EventArgs e){
        MessageBox.Show(inputText.Text);
    }

    private void text_TextChanged(Object sender, EventArgs e){
        button1.Text = "Print: " + inputText.Text;
    }

    [STAThread]
    public static void Main(){
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}