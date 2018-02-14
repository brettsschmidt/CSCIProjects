
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.GridLayout;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;

import javax.swing.BorderFactory;
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JSeparator;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class AboutUI extends JFrame implements ActionListener, WindowListener
{
	private JPanel contentPane;
	
	private JButton btnExit;
	
	
	// Constructor
	public AboutUI()
	{
		super();
		
		
		setSize(1200, 800);
		
		Toolkit tk = Toolkit.getDefaultToolkit();
		Dimension d = tk.getScreenSize();
		
		
		int x = (d.width - getWidth() ) /2;
		int y = (d.height - getHeight()) /2;
		
		setLocation(x,y);
		setContentPane( getContentPane() );
		setTitle("CSCI239 - Java Programming II");
		setResizable(true);
		setVisible(true);
		//setDefaultCloseOperation(EXIT_ON_CLOSE);
	}
	
	public JPanel getContentPane()
	{
		if( contentPane == null )
		{
			contentPane = new JPanel();
			contentPane.setBackground(Color.CYAN);
			
			
			JTextArea aboutText = new JTextArea();
			
			aboutText.setMaximumSize(contentPane.getSize());
			aboutText.setText("Wecome to the Fitness Tie App!");
			aboutText.append("\nThe only community-driven workout application created by Brett Schmidt!");
			aboutText.append("\n\nCurrent features: Create Workout, Modify Workout, Delete Workout, UnDelete Workout, and Purge those Deleted Workouts");
			aboutText.append("\nTo create your own custom workout, just return the menu you came from, titled: Create Workout, and have fun!");
			aboutText.append("\nAll you need to create a workout is the workout name, description, and exercise.");
			aboutText.append("\nUnderneath that you will see the option to add exercises. For user convience, ComboBoxes are used for all exercise information.");
			aboutText.append("\nBy changing the Category of the exercise, the Exercise ComboBox will automatically update with all available exercises.");
			aboutText.append("\nBut it only shows one exercise right now? The Add Exercise button at the bottom will add more for you!");
			aboutText.append("\nEvery exercise must have sets, reps, and rest that are greater than 0 for your workout to be saved though.");
			aboutText.append("\nClick the Browse Workouts button to check out some awesome workouts you can modify.");
			aboutText.append("\nEither type the Workout name field and click search or select a Category from the drop down menu to browse workouts.");
			aboutText.append("\nWhen you find the one you'd like press select and it'll put that information in the main Create Workout UI for you to update.");
			aboutText.append("\nWhat was originally a Save button, will now be an Update button so you know you're updating.");
			aboutText.append("\nIf you want to view the workouts you created, click the BrowseMyWorkout button on the main Create Workout UI");
			aboutText.append("\nThis will give you all the features of the BrowseWorkout UI, but with the addition of the ability to delete or undelete with the buttons labeled so.");
			aboutText.append("\nTo purge all the deleted files, go to the top menu bar and press File then Purge.");
			aboutText.append("\nDISCLAIMER: The Clear and Browse Exercises buttons do not do anything currently.");
			aboutText.append("\nThe Create Exercise button will bring up a window to create a new exercise, but it doesn't actually do anything either.");
			aboutText.append("\n\nPlease enjoy Fitness Tie!");
			
			aboutText.setFont(aboutText.getFont().deriveFont(16f));
			
			contentPane.add(aboutText);
//			contentPane.add(aboutText1);
//			contentPane.add(aboutText2);
//			contentPane.add(aboutText3);
//			contentPane.add(aboutText4);
//			contentPane.add(aboutText5);
//			contentPane.add(aboutText6);
//			contentPane.add(aboutText7);
//			contentPane.add(aboutText8);
			
			
		}
		return contentPane;
		
	}
	
	//public static void main(String[] args) 
	//{
		//CSCI239_WorkoutUI form2 = new CSCI239_WorkoutUI();
		
		

	//}
	
	private void NewStudent()
	{
		
	}

	// Where UI talks to business logic
	
	@Override
	public void actionPerformed(ActionEvent e) 
	{
		JOptionPane.showMessageDialog(this, e.getActionCommand());
		
		switch( e.getActionCommand() )
		{
			
			case "NEW":
				NewStudent();
				break;
		
			case "EXIT":
				System.exit(0);
				break;
				
			case "ABOUT":
				
				btnExit.setEnabled(!btnExit.isEnabled());
		
			default:
				JOptionPane.showMessageDialog(this, 
						String.format("Unknown Action Command %s", e.getActionCommand()));
		}
		
	}

	@Override
	public void windowActivated(WindowEvent e) {
		// TODO Auto-generated method stub
		
	}

	// e is the secret way to get the program to exit on X click.
	

	@Override
	public void windowClosed(WindowEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void windowClosing(WindowEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void windowDeactivated(WindowEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void windowDeiconified(WindowEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void windowIconified(WindowEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void windowOpened(WindowEvent e) {
		// TODO Auto-generated method stub
		
	}
}
