using System;
using System.Drawing;
using System.Windows.Forms;
 
public class MainWindow : Form {
      Button gomb = new Button();
      Panel panel = new Panel();
      
      public MainWindow() {		  
		  this.panel.BackColor = Color.Blue;
		  		  
          gomb.Text = "Kattints ide";
          gomb.Location = new Point(112, 50);
          gomb.Click += new EventHandler(Button_Click);
          
          panel.Controls.Add(gomb);
          Controls.Add(panel);
      }

      private void Button_Click(object sender, EventArgs e) {
          MessageBox.Show("Gomb lenyomva");
      }
}
