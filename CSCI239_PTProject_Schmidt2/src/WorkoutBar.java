

import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentListener;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.util.LinkedList;

import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JMenuBar;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.MutableComboBoxModel;
import javax.swing.SwingUtilities;

//TODO: Add Exercise view for workouts

public class WorkoutBar extends JMenuBar implements ActionListener, WindowListener
{
	// TODO: Turn Name into a combo box that changed based off Category
	// Make mnuCat pull from Code Table in Database.
	
	private JMenuBar catBar;
	private JButton WorkoutSelector;
	private Workout m_Workout;
	public JButton delBtn;
	private JLabel statusLabel;
	private JTextField statText;
	
	
	public static LinkedList<String> cats = WorkoutDB.Categories("Exercise", "Workout");
	
	public static String[] cat()
	{
	String[] cat = cats.toArray(new String[cats.size()]);
	
		
	return cat;
	}
	
	
	
	public WorkoutBar(Workout workout)
	{
	super();
	m_Workout = workout;
	
	
	
	this.setLayout(new GridLayout(1,9));
	JMenuBar nameBar = new JMenuBar();
	catBar = new JMenuBar();
	JMenuBar catBar = new JMenuBar();
	//addBar.setLayout(new BoxLayout(addBar, BoxLayout.Y_AXIS));
	JMenuBar descBar = new JMenuBar();
	JMenuBar commBar = new JMenuBar();
	
	JLabel mnuName = new JLabel("Workout:");
	JLabel mnuCat = new JLabel("Category:");
	JLabel mnuDesc = new JLabel("Description:");
	JLabel mnuComm = new JLabel("Comments:");
	JTextField wkoutName = new JTextField(m_Workout.getWKOUT_NAME());
	JTextField wkoutCat = new JTextField(m_Workout.getWKOUT_CAT());
	JTextField wkoutDesc = new JTextField(m_Workout.getWKOUT_DESC());
	JTextField wkoutComm = new JTextField(m_Workout.getWKOUT_COMM());
	WorkoutSelector = new JButton("Select");
	
	
	wkoutName.setEditable(false);
	wkoutCat.setEditable(false);
	wkoutDesc.setEditable(false);
	wkoutComm.setEditable(false);
	
	WorkoutSelector.setActionCommand("SELECT");
	WorkoutSelector.addActionListener(this);
	
	
	nameBar.add(mnuName);
	nameBar.add(wkoutName);
	catBar.add(mnuCat);
	catBar.add(wkoutCat);
	descBar.add(mnuDesc);
	descBar.add(wkoutDesc);
	commBar.add(mnuComm);
	commBar.add(wkoutComm);
	
	
	
	this.add(nameBar);
	this.add(catBar);
	this.add(descBar);
	this.add(commBar);
	this.add(WorkoutSelector);
	
	if(workout.getWKOUT_STAT_CD() == 'I')
	{
		this.addUndelete();
	}
	else
	{
		this.addDelete();
	}
	
	
	
	}
	public WorkoutBar(Workout workout, long number)
	{
	super();
	m_Workout = workout;
	
	
	
	this.setLayout(new GridLayout(1,9));
	JMenuBar nameBar = new JMenuBar();
	catBar = new JMenuBar();
	JMenuBar catBar = new JMenuBar();
	//addBar.setLayout(new BoxLayout(addBar, BoxLayout.Y_AXIS));
	JMenuBar descBar = new JMenuBar();
	JMenuBar commBar = new JMenuBar();
	
	JLabel mnuName = new JLabel("Workout:");
	JLabel mnuCat = new JLabel("Category:");
	JLabel mnuDesc = new JLabel("Description:");
	JLabel mnuComm = new JLabel("Comments:");
	JTextField wkoutName = new JTextField(m_Workout.getWKOUT_NAME());
	JTextField wkoutCat = new JTextField(m_Workout.getWKOUT_CAT());
	JTextField wkoutDesc = new JTextField(m_Workout.getWKOUT_DESC());
	JTextField wkoutComm = new JTextField(m_Workout.getWKOUT_COMM());
	WorkoutSelector = new JButton("Select");
	
	
	wkoutName.setEditable(false);
	wkoutCat.setEditable(false);
	wkoutDesc.setEditable(false);
	wkoutComm.setEditable(false);
	
	WorkoutSelector.setActionCommand("SELECT");
	WorkoutSelector.addActionListener(this);
	
	
	nameBar.add(mnuName);
	nameBar.add(wkoutName);
	catBar.add(mnuCat);
	catBar.add(wkoutCat);
	descBar.add(mnuDesc);
	descBar.add(wkoutDesc);
	commBar.add(mnuComm);
	commBar.add(wkoutComm);
	
	
	
	this.add(nameBar);
	this.add(catBar);
	this.add(descBar);
	this.add(commBar);
	this.add(WorkoutSelector);
	
	
	
	
	
	}
	public Workout getWorkout()
	{
		return m_Workout;
	}
	
	public void addDelete()
	{
		
		this.setLayout(new GridLayout(1,12));
		statusLabel = new JLabel("Status:");
		statText = new JTextField();
		statText.setText(String.valueOf(m_Workout.getWKOUT_STAT_CD()));
		statText.setEditable(false);
		delBtn = new JButton("Delete");
		delBtn.setActionCommand("DELETE");
		delBtn.addActionListener(this);
		this.add(statusLabel);
		this.add(statText);
		
		this.add(delBtn);
	}
	
	public void addUndelete()
	{
		this.setLayout(new GridLayout(1,12));
		statusLabel = new JLabel("Status:");
		statText = new JTextField();
		statText.setText(String.valueOf(m_Workout.getWKOUT_STAT_CD()));
		statText.setEditable(false);
		delBtn = new JButton("UnDelete");
		delBtn.setActionCommand("UNDELETE");
		delBtn.addActionListener(this);
		this.add(statusLabel);
		this.add(statText);
		this.add(delBtn);
	}
	
	
	@Override
	public void actionPerformed(ActionEvent e) 
	{
		//JOptionPane.showMessageDialog(this, e.getActionCommand());
		
		switch( e.getActionCommand() )
		{
			
			case "SELECT":
				CSCI239_PTProject.MasterUI.setWorkout(m_Workout);
				break;
		
			case "DELETE":
				WorkoutDB.Delete(m_Workout);
				CSCI239_PTProject.MasterUI.researchWorkoutBrowser();
				break;
				
			case "UNDELETE":
				WorkoutDB.UnDelete(m_Workout);
				CSCI239_PTProject.MasterUI.researchWorkoutBrowser();
				break;
				
			
				
			default:
				JOptionPane.showMessageDialog(this, 
						String.format("Unknown Action Command %s", e.getActionCommand()));
		}
		
	}
	

	@Override
	public void windowActivated(WindowEvent arg0) {
		// TODO Auto-generated method stub
		
	}



	@Override
	public void windowClosed(WindowEvent arg0) {
		// TODO Auto-generated method stub
		
	}



	@Override
	public void windowClosing(WindowEvent arg0) {
		// TODO Auto-generated method stub
		
	}



	@Override
	public void windowDeactivated(WindowEvent arg0) {
		// TODO Auto-generated method stub
		
	}



	@Override
	public void windowDeiconified(WindowEvent arg0) {
		// TODO Auto-generated method stub
		
	}



	@Override
	public void windowIconified(WindowEvent arg0) {
		// TODO Auto-generated method stub
		
	}



	@Override
	public void windowOpened(WindowEvent arg0) {
		// TODO Auto-generated method stub
		
	}



	
	
}
