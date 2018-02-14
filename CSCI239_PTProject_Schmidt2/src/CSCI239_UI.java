
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
import javax.swing.JSeparator;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;

public class CSCI239_UI extends JFrame implements ActionListener, WindowListener
{
	private JPanel contentPane;
	private JMenuItem mnuFileNew;
	private JButton btnExit;
	private JPanel dataPanel;
	private JTextField nameText;
	private JComboBox catBox;
	private JPanel exerBar;
	private JTextField commText;
	private JTextField descText;
	private JButton mnuSave;
	private JTextField idText;
	private Workout m_workout;
	private static WorkoutBrowseUI form3;
	public static LinkedList <DataBar> databars = new LinkedList();
	
	// Constructor
	public CSCI239_UI()
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
		setDefaultCloseOperation(EXIT_ON_CLOSE);
	}
	
	public JPanel getContentPane()
	{
		if( contentPane == null )
		{
			contentPane = new JPanel();
			contentPane.setBorder(BorderFactory.createLineBorder(Color.black));
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
			nameBar.setLayout(new GridLayout(5,1));
			//nameBar.setSize(dataPanel.getWidth(), 1066);
			JMenuBar catBar = new JMenuBar();
			catBar.setLayout(new BoxLayout(catBar, BoxLayout.Y_AXIS));
			
			JLabel mnuID = new JLabel("Workout ID: ");
			JLabel mnuName = new JLabel("Workout name:");
			JLabel mnuCat = new JLabel("Category:");
			JLabel commLabel = new JLabel("Comments:");
			JLabel descLabel = new JLabel("Description:");
			
			
			// Stuff that does stuff
			nameText = new JTextField();
			
			idText = new JTextField("System Created");
			idText.setEditable(false);
			catBox = new JComboBox<String>(WorkoutBrowseUI.cat());
			commText = new JTextField();
			descText = new JTextField();
			
			JMenuBar buttBar = new JMenuBar();
			mnuSave = new JButton("Save");
			JButton mnuUpdate = new JButton("Browse Workouts");
			JButton myWorkoutBtn = new JButton("Browse MyWorkouts");
			JButton mnuClear = new JButton("Clear");
			JButton mnuWOCre = new JButton("Create Exercise");
			JButton mnuWOAdd = new JButton("Add Exercise");
			JButton mnuWOBro = new JButton("Browse Exercises");
			//JButton mnuExit = new JButton("Exit");
			
			mnuClear.setActionCommand("CLEAR");
			mnuClear.addActionListener(this);
			
			
			mnuFileNew = new JMenuItem("New");
			mnuFileNew.setActionCommand("NEW");
			mnuFileNew.addActionListener(this);
			mnuFile.add(mnuFileNew);
			
			myWorkoutBtn.setActionCommand("BROWSEMYWORKOUTS");
			myWorkoutBtn.addActionListener(this);
			
			mnuUpdate.setActionCommand("BROWSEWORKOUT");
			mnuUpdate.addActionListener(this);
			
			mnuFile.add(new JSeparator());
			
			mnuSave.setActionCommand("SAVEWORKOUT");
			mnuSave.addActionListener(this);
			
			JMenuItem mnuFileExit = new JMenuItem("Exit");
			mnuFileExit.setActionCommand("EXIT");
			mnuFileExit.addActionListener(this);
			mnuFile.add(mnuFileExit);
			
			mnuWOCre.setActionCommand("CREATEEXERCISE");
			mnuWOCre.addActionListener(this);
			mnuWOCre.setEnabled(false);
			
			mnuWOAdd.setActionCommand("ADDWORKOUT");
			mnuWOAdd.addActionListener(this);
			
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
			buttBar.add(mnuUpdate);
			buttBar.add(myWorkoutBtn);
			buttBar.add(mnuWOAdd);
			buttBar.add(mnuClear);
			buttBar.add(mnuWOCre);
			buttBar.add(mnuWOBro);
			buttBar.add(btnExit);
			
			//menuPanel.add(mnuBar);
			
			buttonPanel.add(buttBar);
			
			nameBar.add(mnuID);
			nameBar.add(mnuName);
			nameBar.add(mnuCat);
			nameBar.add(descLabel);
			nameBar.add(commLabel);
			catBar.add(idText);
			catBar.add(nameText);
			catBar.add(catBox);
			catBar.add(descText);
			catBar.add(commText);
			
			
			JMenuBar spaceBar = new JMenuBar();
			spaceBar.setLayout(new BoxLayout(spaceBar, BoxLayout.X_AXIS));
			spaceBar.add(nameBar);
			spaceBar.add(catBar);
			
			exerBar = new JPanel();
			exerBar.setLayout(new BoxLayout(exerBar, BoxLayout.Y_AXIS));
			
			
			//spaceBar.add(mnuCat);
			//spaceBar.add(mnuStuff2);
			
			dataPanel.add(spaceBar);
			
			databars.add(new DataBar());
			exerBar.add(databars.get(0));
			dataPanel.add(exerBar);
			
			//contentPane.add(btnExit);
			functionPanel.add(menuPanel);
			functionPanel.add(mnuBar);
			functionPanel.add(dataPanel);
			functionPanel.add(buttonPanel);
			
			
			contentPane.add(functionPanel);
			//contentPane.add(menuPanel);
			//contentPane.add(mnuBar);
			//contentPane.add(dataPanel);
			
			//contentPane.add(buttonPanel);
			
		}
		return contentPane;
		
	}
	
	
	// I don't think this does anything, but I'm too scared to delete it
	public JMenuBar dataBar()
	{
		JMenuBar dataBar = new JMenuBar();
		dataBar.setLayout(new FlowLayout(FlowLayout.LEADING));
		JMenuBar nameBar = new JMenuBar();
		JMenuBar addBar = new JMenuBar();
		//addBar.setLayout(new BoxLayout(addBar, BoxLayout.Y_AXIS));
		JMenuBar cityBar = new JMenuBar();
		JMenuBar stateBar = new JMenuBar();
		JLabel mnuName = new JLabel("Workout:");
		JLabel mnuAdd = new JLabel("Sets:");
		JLabel mnuCity = new JLabel("Reps:");
		JTextField mnuStuff = new JTextField(25);
		JTextField mnuStuff2 = new JTextField(5);
		JTextField mnuStuff3 = new JTextField(5);
		nameBar.add(mnuName);
		nameBar.add(mnuStuff);
		addBar.add(mnuAdd);
		addBar.add(mnuStuff2);
		cityBar.add(mnuCity);
		cityBar.add(mnuStuff3);
		dataBar.add(nameBar);
		dataBar.add(addBar);
		dataBar.add(cityBar);
		return dataBar;
	}
	
	//public static void main(String[] args) 
//	{
		//CSCI239_UI form = new CSCI239_UI();
		
		

	//}
	
	private void NewStudent()
	{
		
	}

	// Where UI talks to business logic
	
	@Override
	public void actionPerformed(ActionEvent e) 
	{
		//JOptionPane.showMessageDialog(this, e.getActionCommand());
		
		switch( e.getActionCommand() )
		{
			
			case "NEW":
				JOptionPane.showMessageDialog(this, "Enjoy creating a new workout!");
				NewStudent();
				break;
			case "CLEAR":
				this.clearWorkout();
				break;
		
			case "EXIT":
				JOptionPane.showMessageDialog(this, "Exiting program!");
				System.exit(0);
				break;
			
			case "CREATEEXERCISE":
				CSCI239_WorkoutUI form2 = new CSCI239_WorkoutUI();
				this.setVisible(false);
				break;
				
			case "ADDWORKOUT":
				databars.add(new DataBar());
				exerBar.add(databars.getLast());
				SwingUtilities.updateComponentTreeUI(this);
				break;
			
			case "BROWSEMYWORKOUTS":
				form3 = new WorkoutBrowseUI("MYWORKOUT");
				break;
				
			case "BROWSEWORKOUT":
				form3 = new WorkoutBrowseUI("");
				
				break;
				
			case "UPDATEWORKOUT":
				this.modifyWorkout();
				break;
				
			case "ABOUT":
				AboutUI aboutForm = new AboutUI();
				
				break;
			case "SAVEWORKOUT":
				// TODO: MAKE THIS WORK
				
				this.createWorkout();
				break;
		
			default:
				JOptionPane.showMessageDialog(this, 
						String.format("Unknown Action Command %s", e.getActionCommand()));
		}
		
	}
	public static void closeWorkoutBrowser()
	{
		if(form3.isVisible())
		{
		//form3.setVisible(false);
		form3.dispose();
		}
	}
	
	public static void researchWorkoutBrowser()
	{
		form3.searchMyWorkouts();
	}
	
	public void setWorkout(Workout workout)
	{
		m_workout = workout;
		closeWorkoutBrowser();
		this.idText.setText(String.valueOf(workout.getWKOUT_ID()));
		this.nameText.setText(m_workout.getWKOUT_NAME());
		this.catBox.setSelectedItem(m_workout.getWKOUT_CAT());
		this.commText.setText(m_workout.getWKOUT_COMM());
		this.descText.setText(m_workout.getWKOUT_DESC());
		databars.removeAll(databars);
		exerBar.removeAll();
		SwingUtilities.updateComponentTreeUI(this);
		for(Exercise exers : WorkoutDB.Inquire(m_workout.getWKOUT_ID()))
		{
			databars.add(new DataBar());
			databars.getLast().setExercise(exers);
			exerBar.add(databars.getLast());
		}
		
		mnuSave.setText("Update");
		mnuSave.setActionCommand("UPDATEWORKOUT");
		
		
		
	}
	
	private void modifyWorkout()
	{
		long counter = 1;
		int check = 1;
		if(nameText.getText().length() != 0 && descText.getText().length() != 0)
		{
		Workout curWorkout = new Workout(nameText.getText(), descText.getText() ,  (String)catBox.getSelectedItem(), commText.getText() );
		curWorkout.setWKOUT_ID(m_workout.getWKOUT_ID());
		for(DataBar datas : databars)
		{
			
			if(datas.dataExercise().getReps() == 0 )
			{
				JOptionPane.showMessageDialog(this, "No repitions given. Workout not saved.");
				check = 0;
			}
			else if(datas.dataExercise().getSets() == 0)
			{
				JOptionPane.showMessageDialog(this, "No sets given. Workout not saved.");
				check = 0;
			}
		}
		if(check == 1)
		{
		for(DataBar datas : databars)
		{
			datas.dataExercise().setSeq(counter);
			//curWorkout.addExercise(datas.dataExercise());
			datas.dataExercise().setWorkout(curWorkout);
			WorkoutDB.Update(datas.dataExercise());
			//WorkoutDB.Update(curWorkout);
			
			counter++;
			
		}
		JOptionPane.showMessageDialog(this, "Workout updated!");
		}}
		else if (nameText.getText().length() == 0)
		{
			JOptionPane.showMessageDialog(this, "Please provide workout name. Workout not saved.");
		}
		else if(descText.getText().length() == 0)
		{
			JOptionPane.showMessageDialog(this, "Please provide workout description. Workout not saved.");
		}
		else
		{
			JOptionPane.showMessageDialog(this, "Workout not saved.");
		}
	}
	
	private void clearWorkout()
	{
		databars.removeAll(databars);
		databars.add(new DataBar());
		exerBar.removeAll();
		exerBar.add(databars.getLast());
		this.idText.setText("System Created");
		this.nameText.setText("");
		
		this.commText.setText("");
		this.descText.setText("");
		mnuSave.setActionCommand("SAVEWORKOUT");
		mnuSave.setText("Save");
		SwingUtilities.updateComponentTreeUI(this);
	}
	
	private void createWorkout()
	{
		long counter = 1;
		int check = 1;
		if(nameText.getText().length() != 0 && descText.getText().length() != 0)
		{
		Workout curWorkout = new Workout(nameText.getText(), descText.getText() ,  (String)catBox.getSelectedItem(), commText.getText() );
		idText.setText(String.valueOf(curWorkout.getWKOUT_ID()));
		for(DataBar datas : databars)
		{
			
			if(datas.dataExercise().getReps() == 0 )
			{
				JOptionPane.showMessageDialog(this, "No repitions given. Workout not saved.");
				check = 0;
			}
			else if(datas.dataExercise().getSets() == 0)
			{
				JOptionPane.showMessageDialog(this, "No sets given. Workout not saved.");
				check = 0;
			}
		}
		if(check == 1)
		{
		for(DataBar datas : databars)
		{
			datas.dataExercise().setSeq(counter);
			datas.dataExercise().setWorkout(curWorkout);
			WorkoutDB.Add(datas.dataExercise());
			counter++;
			
		}
		JOptionPane.showMessageDialog(this, "Workout saved!");
		}}
		else if (nameText.getText().length() == 0)
		{
			JOptionPane.showMessageDialog(this, "Please provide workout name. Workout not saved.");
		}
		else if(descText.getText().length() == 0)
		{
			JOptionPane.showMessageDialog(this, "Please provide workout description. Workout not saved.");
		}
		else
		{
			JOptionPane.showMessageDialog(this, "Workout not saved.");
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
