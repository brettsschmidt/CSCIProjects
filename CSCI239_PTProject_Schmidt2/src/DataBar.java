

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentListener;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.util.LinkedList;

import javax.swing.BorderFactory;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JMenuBar;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.MutableComboBoxModel;
import javax.swing.SwingUtilities;

public class DataBar extends JMenuBar implements ActionListener, WindowListener
{
	// TODO: Turn Name into a combo box that changed based off Category
	// Make mnuCat pull from Code Table in Database.
	private Exercise[] m_exercises;
	private JComboBox combExercise;
	private JComboBox combCats;
	private JMenuBar catBar;
	private JComboBox comboRest;
	private JComboBox comboSets;
	private JComboBox comboPerMax;
	private JComboBox comboReps;
	
	private Exercise m_exercise;
	
	public static LinkedList<String> cats = WorkoutDB.Categories("Exercise", "Exercise");
	
	public static String[] cat()
	{
	String[] cat = cats.toArray(new String[cats.size()]);
	
		
	return cat;
	}
	
	
	
	public DataBar()
	{
	super();
	
	
	String[] perMax = {"100", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95"};
	String[] rest = {"30", "0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90"};
	String[] sets = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"};
	
	this.setLayout(new GridLayout(1,6));
	
	JMenuBar nameBar = new JMenuBar();
	catBar = new JMenuBar();
	JMenuBar setsBar = new JMenuBar();
	//addBar.setLayout(new BoxLayout(addBar, BoxLayout.Y_AXIS));
	JMenuBar repsBar = new JMenuBar();
	JMenuBar restBar = new JMenuBar();
	JMenuBar maxBar = new JMenuBar();
	
	
	
	JLabel mnuName = new JLabel("Exercise:");
	JLabel mnuCat = new JLabel("Category:");
	JLabel mnuSets = new JLabel("Sets:");
	JLabel mnuReps = new JLabel("Reps:");
	JLabel mnuRest = new JLabel("Rest Time:");
	JLabel mnuMax = new JLabel("Percentage of Max:");
	JLabel percentage = new JLabel("%");
	JLabel seconds = new JLabel("sec ");
	
	combCats = new JComboBox(cat());
	combExercise =  CombExercise();
	
	comboSets = new JComboBox(sets);
	comboReps = new JComboBox(sets);
	comboRest = new JComboBox(rest);
	comboPerMax = new JComboBox(perMax);
	
	
	combCats.setActionCommand("EXERCATCHANGE");
	combCats.addActionListener( (ActionListener) this);
	
	nameBar.add(mnuName);
	nameBar.add(combExercise);
	catBar.add(mnuCat);
	catBar.add(combCats);
	setsBar.add(mnuSets);
	setsBar.add(comboSets);
	repsBar.add(mnuReps);
	repsBar.add(comboReps);
	restBar.add(mnuRest);
	restBar.add(comboRest);
	restBar.add(seconds);
	maxBar.add(mnuMax);
	maxBar.add(comboPerMax);
	maxBar.add(percentage);
	this.add(nameBar);
	this.add(catBar);
	this.add(setsBar);
	this.add(repsBar);
	this.add(restBar);
	this.add(maxBar);
	
	
	}
	
	public String[] Exercises(String category)
	{
		m_exercises = WorkoutDB.Query(category);
		
		String[] exercises = new String[m_exercises.length];
		int counter = 0;
		
		for (Exercise n : m_exercises)
		{
			
			exercises[counter] = m_exercises[counter].getWKOUT_NAME();
			counter++;
		}
				
				
		return exercises;
	}

	private JComboBox CombExercise()
	{
		JComboBox exercises = new JComboBox(Exercises((String)combCats.getSelectedItem()));
		
		
		return exercises;
	}
	
	public void setExercise(Exercise exer)
	{
		m_exercise = exer;
		combCats.setSelectedItem(String.valueOf(exer.getWKOUT_CAT()));
		combExercise.removeAllItems();
		Object o = (Exercises((String)combCats.getSelectedItem()));
		combExercise.setModel(new DefaultComboBoxModel((String[]) o));
		combExercise.setSelectedItem(String.valueOf(exer.getWKOUT_NAME()));
		comboSets.setSelectedItem(String.valueOf(exer.getSets()));
		comboReps.setSelectedItem(String.valueOf(exer.getReps()));
		comboRest.setSelectedItem(String.valueOf(exer.getRest()));
		comboPerMax.setSelectedItem(String.valueOf(exer.getMaxPer()));
	}
	
	public Exercise dataExercise()
	{
		Exercise exercise = null;
		
		for(Exercise exers : m_exercises)
		{
			if(exers.getWKOUT_NAME().contains((String)combExercise.getSelectedItem()))
				{
				exercise = exers;
				exercise.setExerSet((String)comboSets.getSelectedItem(), (String)comboPerMax.getSelectedItem(), (String)comboReps.getSelectedItem(), (String)comboRest.getSelectedItem());
				}
		}
		
		return exercise;
		
	}
	
	@Override
	public void actionPerformed(ActionEvent e) 
	{
		//JOptionPane.showMessageDialog(this, e.getActionCommand());
		
		switch( e.getActionCommand() )
		{
			
			case "EXERCATCHANGE":
				combExercise.removeAllItems();
				Object o = (Exercises((String)combCats.getSelectedItem()));
				combExercise.setModel(new DefaultComboBoxModel((String[]) o));
				//JComboBox newStuff = new JComboBox(Exercises((String)combCats.getSelectedItem()));
				//combExercise.add(newStuff);
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
