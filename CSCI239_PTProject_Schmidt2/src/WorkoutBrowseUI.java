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
import java.util.LinkedList;

import javax.swing.BorderFactory;
	import javax.swing.BoxLayout;
	import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
	import javax.swing.JLabel;
	import javax.swing.JMenu;
	import javax.swing.JMenuBar;
	import javax.swing.JMenuItem;
	import javax.swing.JOptionPane;
	import javax.swing.JPanel;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;
import javax.swing.JSeparator;
	import javax.swing.JTextArea;
	import javax.swing.JTextField;
import javax.swing.SwingUtilities;
	
public class WorkoutBrowseUI  extends JFrame implements ActionListener, WindowListener
	{
		private JPanel contentPane;
		public JMenuItem mnuFileNew;
		private JButton btnExit;
		private JPanel dataPanel;
		private JTextField nameText;
		private JComboBox catBox;
		private JTextField commText;
		private JTextField descText;
		private JButton mnuSave;
		private JButton mnuQuery;
		private JPanel workoutPanel;
		private JScrollPane barscroll;
		public static LinkedList <WorkoutBar> workoutbars = new LinkedList();
		
		public static LinkedList<String> WkoutCats = WorkoutDB.Categories("Exercise", "Workout");
		
		public static String[] cat()
		{
		String[] cat = WkoutCats.toArray(new String[WkoutCats.size()]);
		
			
		return cat;
		}
		
		// Constructor
		public WorkoutBrowseUI(String MyWorkout)
		{
			super();
			
			
			setSize(1400, 800);
			
			Toolkit tk = Toolkit.getDefaultToolkit();
			Dimension d = tk.getScreenSize();
			
			
			int x = (d.width - getWidth() ) /2;
			int y = (d.height - getHeight()) /2;
			
			setLocation(x,y);
			if(MyWorkout == "MYWORKOUT")
			{
				setContentPane( getMyContentPane() );
			}
			else
			{
			setContentPane( getContentPane() );
			}
			setTitle("CSCI239 - Java Programming II");
			setResizable(true);
			setVisible(true);
			//setDefaultCloseOperation(EXIT_ON_CLOSE);
		}
		
		public JPanel getMyContentPane()
		{
			if( contentPane == null )
			{
				contentPane = new JPanel();
				//contentPane.setBackground(Color.CYAN);
				JPanel menuPanel = new JPanel();
				menuPanel.setLayout(new FlowLayout(FlowLayout.LEADING));
				//menuPanel.setBorder(BorderFactory.createLineBorder(Color.black));
				//menuPanel.setBackground(Color.gray);
				dataPanel = new JPanel();
				dataPanel.setLayout(new BoxLayout(dataPanel, BoxLayout.Y_AXIS));
				dataPanel.setBorder(BorderFactory.createLineBorder(Color.black));
				//dataPanel.setBackground(Color.CYAN);
				JPanel buttonPanel = new JPanel();
				buttonPanel.setLayout(new FlowLayout(FlowLayout.LEADING));
				buttonPanel.setBorder(BorderFactory.createLineBorder(Color.black));
				//buttonPanel.setBackground(Color.CYAN);
				JPanel functionPanel = new JPanel();
				functionPanel.setLayout(new BoxLayout(functionPanel, BoxLayout.Y_AXIS));
				
				//contentPane.setLayout(new BoxLayout(contentPane, BoxLayout.Y_AXIS));
				
				JMenuBar mnuBar = new JMenuBar();
				mnuBar.setLayout(new FlowLayout(FlowLayout.LEADING));
				//mnuBar.setBackground(Color.CYAN);
				mnuBar.setBorder(BorderFactory.createLineBorder(Color.black));
				JMenu mnuFile = new JMenu("File", true);
				JMenu mnuHelp = new JMenu("Help", true);
				
				
				//JMenuBar dataBar = new JMenuBar();
				//dataBar.setLayout(new FlowLayout(FlowLayout.LEADING));
				JMenuBar nameBar = new JMenuBar();
				nameBar.setLayout(new GridLayout(2,1));
				//nameBar.setSize(dataPanel.getWidth(), 1066);
				JMenuBar catBar = new JMenuBar();
				catBar.setLayout(new BoxLayout(catBar, BoxLayout.Y_AXIS));
				
				
				JLabel mnuName = new JLabel("Workout name:");
				JLabel mnuCat = new JLabel("Category:");
				//JLabel commLabel = new JLabel("Comments:");
				//JLabel descLabel = new JLabel("Description:");
				
				
				// Stuff that does stuff
				nameText = new JTextField();
				// Change this to be workout cats
				catBox = new JComboBox(this.cat());
				//commText = new JTextField();
				//descText = new JTextField();
				
				JMenuBar buttBar = new JMenuBar();
				mnuSave = new JButton("Search");
				//JButton mnuUpdate = new JButton("Modify");
				JButton mnuClear = new JButton("Clear");
				JButton mnuWOCre = new JButton("Create Exercise");
				//JButton mnuWOAdd = new JButton("Add Exercise");
				JButton mnuWOBro = new JButton("Browse Exercises");
				//JButton mnuExit = new JButton("Exit");
				JMenuItem mnuPurge = new JMenuItem("Purge");
				mnuPurge.setActionCommand("PURGE");
				mnuPurge.addActionListener(this);
				
				mnuFileNew = new JMenuItem("New");
				mnuFileNew.setActionCommand("NEW");
				mnuFileNew.addActionListener(this);
				mnuFile.add(mnuFileNew);
				
				//mnuUpdate.setActionCommand("BROWSEWORKOUT");
				//mnuUpdate.addActionListener(this);
				
				mnuFile.add(new JSeparator());
				
				mnuSave.setActionCommand("SEARCHMYWORKOUT");
				mnuSave.addActionListener(this);
				
				JMenuItem mnuFileExit = new JMenuItem("Exit");
				mnuFileExit.setActionCommand("EXIT");
				mnuFileExit.addActionListener(this);
				mnuFile.add(mnuFileExit);
				mnuFile.add(new JSeparator());
				mnuFile.add(mnuPurge);
				
				mnuWOCre.setActionCommand("CREATEEXERCISE");
				mnuWOCre.addActionListener(this);
				
				//mnuWOAdd.setActionCommand("ADDWORKOUT");
				//mnuWOAdd.addActionListener(this);
				
				JMenuItem mnuHelpAbout = new JMenuItem("About");
				mnuHelpAbout.setActionCommand("ABOUT");
				mnuHelpAbout.addActionListener(this);
				mnuHelp.add(mnuHelpAbout);
				
				btnExit = new JButton("Exit");
				btnExit.setActionCommand("EXIT");
				btnExit.addActionListener(this);
				btnExit.setEnabled(true);
				
				mnuBar.add(mnuFile);
				mnuBar.add(mnuHelp);
				
				buttBar.add(mnuSave);
				//buttBar.add(mnuUpdate);
				//buttBar.add(mnuWOAdd);
				buttBar.add(mnuClear);
				buttBar.add(mnuWOCre);
				buttBar.add(mnuWOBro);
				buttBar.add(btnExit);
				
				//menuPanel.add(mnuBar);
				
				buttonPanel.add(buttBar);
				
				nameBar.add(mnuName);
				nameBar.add(mnuCat);
				//nameBar.add(descLabel);
				//nameBar.add(commLabel);
				catBar.add(nameText);
				catBar.add(catBox);
				//catBar.add(descText);
				//catBar.add(commText);
				catBox.setActionCommand("CATCHANGE");
				catBox.addActionListener( (ActionListener) this);
				
				JMenuBar spaceBar = new JMenuBar();
				spaceBar.setLayout(new BoxLayout(spaceBar, BoxLayout.X_AXIS));
				spaceBar.add(nameBar);
				spaceBar.add(catBar);
				
				//spaceBar.add(mnuCat);
				//spaceBar.add(mnuStuff2);
				workoutPanel = new JPanel();
				workoutPanel.setLayout(new BoxLayout(workoutPanel, BoxLayout.Y_AXIS));
				
				dataPanel.add(spaceBar);
				dataPanel.add(workoutPanel);
				
				
				//dataPanel.add(databars.get(0));
				
		        
				//contentPane.add(btnExit);
				functionPanel.add(menuPanel);
				functionPanel.add(mnuBar);
				functionPanel.add(dataPanel);
				functionPanel.add(buttonPanel);
				
				searchMyWorkouts();
				
				
				contentPane.add(functionPanel);
				
				
				//contentPane.add(barscroll);
				}
			return contentPane;
				
			
		}
		
		public JPanel getContentPane()
		{
			if( contentPane == null )
			{
				contentPane = new JPanel();
				//contentPane.setBackground(Color.CYAN);
				JPanel menuPanel = new JPanel();
				menuPanel.setLayout(new FlowLayout(FlowLayout.LEADING));
				//menuPanel.setBorder(BorderFactory.createLineBorder(Color.black));
				//menuPanel.setBackground(Color.gray);
				dataPanel = new JPanel();
				dataPanel.setLayout(new BoxLayout(dataPanel, BoxLayout.Y_AXIS));
				dataPanel.setBorder(BorderFactory.createLineBorder(Color.black));
				//dataPanel.setBackground(Color.CYAN);
				JPanel buttonPanel = new JPanel();
				buttonPanel.setLayout(new FlowLayout(FlowLayout.LEADING));
				buttonPanel.setBorder(BorderFactory.createLineBorder(Color.black));
				//buttonPanel.setBackground(Color.CYAN);
				JPanel functionPanel = new JPanel();
				functionPanel.setLayout(new BoxLayout(functionPanel, BoxLayout.Y_AXIS));
				
				//contentPane.setLayout(new BoxLayout(contentPane, BoxLayout.Y_AXIS));
				
				JMenuBar mnuBar = new JMenuBar();
				mnuBar.setLayout(new FlowLayout(FlowLayout.LEADING));
				//mnuBar.setBackground(Color.CYAN);
				mnuBar.setBorder(BorderFactory.createLineBorder(Color.black));
				JMenu mnuFile = new JMenu("File", true);
				JMenu mnuHelp = new JMenu("Help", true);
				
				//JMenuBar dataBar = new JMenuBar();
				//dataBar.setLayout(new FlowLayout(FlowLayout.LEADING));
				JMenuBar nameBar = new JMenuBar();
				nameBar.setLayout(new GridLayout(2,1));
				//nameBar.setSize(dataPanel.getWidth(), 1066);
				JMenuBar catBar = new JMenuBar();
				catBar.setLayout(new BoxLayout(catBar, BoxLayout.Y_AXIS));
				
				
				JLabel mnuName = new JLabel("Workout name:");
				JLabel mnuCat = new JLabel("Category:");
				//JLabel commLabel = new JLabel("Comments:");
				//JLabel descLabel = new JLabel("Description:");
				
				
				// Stuff that does stuff
				nameText = new JTextField();
				// Change this to be workout cats
				catBox = new JComboBox(this.cat());
				//commText = new JTextField();
				//descText = new JTextField();
				
				JMenuBar buttBar = new JMenuBar();
				mnuSave = new JButton("Search");
				//JButton mnuUpdate = new JButton("Modify");
				JButton mnuClear = new JButton("Clear");
				JButton mnuWOCre = new JButton("Create Exercise");
				//JButton mnuWOAdd = new JButton("Add Exercise");
				JButton mnuWOBro = new JButton("Browse Exercises");
				//JButton mnuExit = new JButton("Exit");
				
				mnuFileNew = new JMenuItem("New");
				mnuFileNew.setActionCommand("NEW");
				mnuFileNew.addActionListener(this);
				mnuFile.add(mnuFileNew);
				
				//mnuUpdate.setActionCommand("BROWSEWORKOUT");
				//mnuUpdate.addActionListener(this);
				
				mnuFile.add(new JSeparator());
				
				mnuSave.setActionCommand("SEARCHWORKOUT");
				mnuSave.addActionListener(this);
				
				JMenuItem mnuFileExit = new JMenuItem("Exit");
				mnuFileExit.setActionCommand("EXIT");
				mnuFileExit.addActionListener(this);
				mnuFile.add(mnuFileExit);
				
				mnuWOCre.setActionCommand("CREATEEXERCISE");
				mnuWOCre.addActionListener(this);
				
				//mnuWOAdd.setActionCommand("ADDWORKOUT");
				//mnuWOAdd.addActionListener(this);
				
				JMenuItem mnuHelpAbout = new JMenuItem("About");
				mnuHelpAbout.setActionCommand("ABOUT");
				mnuHelpAbout.addActionListener(this);
				mnuHelp.add(mnuHelpAbout);
				
				btnExit = new JButton("Exit");
				btnExit.setActionCommand("EXIT");
				btnExit.addActionListener(this);
				btnExit.setEnabled(true);
				
				mnuBar.add(mnuFile);
				mnuBar.add(mnuHelp);
				
				buttBar.add(mnuSave);
				//buttBar.add(mnuUpdate);
				//buttBar.add(mnuWOAdd);
				buttBar.add(mnuClear);
				buttBar.add(mnuWOCre);
				buttBar.add(mnuWOBro);
				buttBar.add(btnExit);
				
				//menuPanel.add(mnuBar);
				
				buttonPanel.add(buttBar);
				
				nameBar.add(mnuName);
				nameBar.add(mnuCat);
				//nameBar.add(descLabel);
				//nameBar.add(commLabel);
				catBar.add(nameText);
				catBar.add(catBox);
				//catBar.add(descText);
				//catBar.add(commText);
				catBox.setActionCommand("WKCATCHANGE");
				catBox.addActionListener( (ActionListener) this);
				
				JMenuBar spaceBar = new JMenuBar();
				spaceBar.setLayout(new BoxLayout(spaceBar, BoxLayout.X_AXIS));
				spaceBar.add(nameBar);
				spaceBar.add(catBar);
				
				//spaceBar.add(mnuCat);
				//spaceBar.add(mnuStuff2);
				workoutPanel = new JPanel();
				workoutPanel.setLayout(new BoxLayout(workoutPanel, BoxLayout.Y_AXIS));
				
				dataPanel.add(spaceBar);
				dataPanel.add(workoutPanel);
				
				
				//dataPanel.add(databars.get(0));
				
		        
				//contentPane.add(btnExit);
				functionPanel.add(menuPanel);
				functionPanel.add(mnuBar);
				functionPanel.add(dataPanel);
				functionPanel.add(buttonPanel);
				
				
				
				
				contentPane.add(functionPanel);
				
				
				//contentPane.add(barscroll);
				}
			return contentPane;
				
			
		}
		
		public void closeBrowser()
		{
			this.setVisible(false);
		}
		
		//public static void main(String[] args) 
		//{
			//CSCI239_WorkoutUI form2 = new CSCI239_WorkoutUI();
			
			

		//}
		
	

		// Where UI talks to business logic
		
		@Override
		public void actionPerformed(ActionEvent e) 
		{
			
			
			switch( e.getActionCommand() )
			{
				
				case "NEW":
					
					break;
				
				case "SEARCHMYWORKOUT":
					this.searchMyWorkouts();
					break;
					
				case "SEARCHWORKOUT":
					searchWorkouts();
					break;
				case "CATCHANGE":
					
					searchMyWorkouts();
					break;
					
				case "WKCATCHANGE":
					searchWorkouts();
					break;
					
				case "EXIT":
					CSCI239_PTProject.MasterUI.closeWorkoutBrowser();
					break;
					
				case "PURGE":
					this.purgeMyWorkouts();
					this.searchMyWorkouts();
					break;
					
				case "ABOUT":
					
					btnExit.setEnabled(!btnExit.isEnabled());
			
				default:
					JOptionPane.showMessageDialog(this, 
							String.format("Unknown Action Command %s", e.getActionCommand()));
			}
		}
		
		private void purgeMyWorkouts()
		{
			for(WorkoutBar wkoutbars : workoutbars)
			{
				if(wkoutbars.getWorkout().getWKOUT_STAT_CD() == 'I')
				{
				WorkoutDB.Purge(wkoutbars.getWorkout());
				}
			}
		}

		private void searchWorkouts()
		{
			workoutPanel.removeAll();
			SwingUtilities.updateComponentTreeUI(this);
			workoutbars.removeAll(workoutbars);
			
			if(nameText.getText().length() == 0)
			{
			for(Workout workouts : WorkoutDB.Inquire((String)catBox.getSelectedItem()))
			{
				workoutbars.add(new WorkoutBar(workouts, (long)1));
			}
			for(WorkoutBar wkoutbars : workoutbars)
			{
				workoutPanel.add(wkoutbars);
			}
			}
			else
			{
				for(Workout workouts : WorkoutDB.Inquire((String)nameText.getText(), (String)catBox.getSelectedItem()))
				{
					workoutbars.add(new WorkoutBar(workouts, (long)1));
				}
				for(WorkoutBar wkoutbars : workoutbars)
				{
					workoutPanel.add(wkoutbars);
				}
			}
			SwingUtilities.updateComponentTreeUI(this);
		}
		
		public void searchMyWorkouts()
		{
			workoutPanel.removeAll();
			SwingUtilities.updateComponentTreeUI(this);
			workoutbars.removeAll(workoutbars);
			for(Workout workouts : WorkoutDB.Inquire((String)nameText.getText(), (String)catBox.getSelectedItem(), WorkoutDB.LoggedUser.getUserID()))
			{
				workoutbars.add(new WorkoutBar(workouts));
			}
			for(WorkoutBar wkoutbars : workoutbars)
			{
				workoutPanel.add(wkoutbars);
			}
			SwingUtilities.updateComponentTreeUI(this);
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


