import java.util.LinkedList;
import java.util.Random;

public class Workout implements DatabaseExercises
{
	private long m_WKOUT_ID;
	private String m_WKOUT_NAME;
	private String m_WKOUT_VIDEO;
	private String m_WKOUT_DESC;
	private String m_WKOUT_CAT;
	private long m_WKOUT_ADD_USER_ID;
	private java.sql.Timestamp m_WKOUT_ADD_DTM;
	private long m_WKOUT_CHG_USER_ID;
	private java.sql.Timestamp m_WKOUT_CHG_DTM;
	private char m_WKOUT_STAT_CD;
	private String m_WKOUT_COMM;
	
	private LinkedList<Exercise> m_Exercises;
	
	public Workout ()
	{
		super();
		m_WKOUT_ID = 0;
		m_WKOUT_NAME = null;
		m_WKOUT_VIDEO = null;
		m_WKOUT_DESC = null;
		m_WKOUT_CAT = null;
		m_WKOUT_ADD_USER_ID = 0;
		m_WKOUT_ADD_DTM = null;
		m_WKOUT_CHG_USER_ID = 0;
		m_WKOUT_CHG_DTM = null;
		m_WKOUT_STAT_CD = '\0';
		m_WKOUT_COMM = null;
	}
	
	public Workout(String WKOUT_NAME, String WKOUT_DESC, String WKOUT_CAT, String Comments)
	{
		super();
		this.setWKOUT_ID();
		m_WKOUT_NAME = WKOUT_NAME;
		m_WKOUT_VIDEO = null;
		m_WKOUT_DESC = WKOUT_DESC;
		m_WKOUT_CAT = WKOUT_CAT;
		m_WKOUT_ADD_USER_ID = 0;
		m_WKOUT_ADD_DTM = null;
		m_WKOUT_CHG_USER_ID = 0;
		m_WKOUT_CHG_DTM = null;
		m_WKOUT_STAT_CD = '\0';
		m_WKOUT_COMM = Comments;
		
	}
	
	public void addExercise(Exercise exercise)
	{
		m_Exercises.add(exercise);
	}
	
	public Exercise getLastExercise()
	{
		return m_Exercises.getLast();
	}
	
	public LinkedList<Exercise> getExercises()
	{
		return m_Exercises;
	}
	
	private void setWKOUT_ID()
	{
		Random number = new Random();
		long numbers = number.nextInt(1000 - 1) + 1;
		if(WorkoutDB.CheckNum(numbers, 1) == 1)
		{
		while(WorkoutDB.CheckNum(numbers, 1) == 1)
				{
		m_WKOUT_ID = numbers;
		numbers = number.nextInt(1000 - 1) + 1;
				}
		}
		else
		{
			m_WKOUT_ID = numbers;
		}
	}
	
	@Override
	public String getWKOUT_COMM()
	{
		return m_WKOUT_COMM;
	}
	
	@Override
	public long getWKOUT_ID() {
		return m_WKOUT_ID;
	}

	
	@Override
	public String getWKOUT_NAME() {
		return m_WKOUT_NAME;
	}

	
	@Override
	public String getWKOUT_VIDEO() {
		return m_WKOUT_VIDEO;
	}

	
	@Override
	public String getWKOUT_DESC() {
		return m_WKOUT_DESC;
	}

	
	@Override
	public String getWKOUT_CAT() {
		return m_WKOUT_CAT;
	}

	
	@Override
	public long getWKOUT_ADD_USER_ID() {
		return m_WKOUT_ADD_USER_ID;
	}

	
	@Override
	public java.sql.Timestamp getWKOUT_ADD_DTM() {
		return m_WKOUT_ADD_DTM;
	}

	
	@Override
	public long getWKOUT_CHG_USER_ID() {
		return m_WKOUT_CHG_USER_ID;
	}

	
	@Override
	public java.sql.Timestamp getWKOUT_CHG_DTM() {
		return m_WKOUT_CHG_DTM;
	}

	
	@Override
	public char getWKOUT_STAT_CD() {
		return m_WKOUT_STAT_CD;
	}
	
	

	@Override
	public void setWKOUT_NAME(String value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_NAME = value;
	}

	@Override
	public void setWKOUT_VIDEO(String value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_VIDEO = value;
	}

	@Override
	public void setWKOUT_DESC(String value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_DESC = value;
	}

	@Override
	public void setWKOUT_CAT(String value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_CAT = value;
	}

	@Override
	public void setWKOUT_ADD_USER_ID(long value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_ADD_USER_ID = value;
	}

	@Override
	public void setWKOUT_ADD_DTM(String value) {
		// TODO Auto-generated method stub
		// TODO: Convert string to datetime stamp
		
		//this.m_WKOUT_ADD_DTM = value;
	}

	@Override
	public void setWKOUT_CHG_USER_ID(long value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_CHG_USER_ID = value;
	}

	@Override
	public void setWKOUT_CHG_DTM(String value) {
		// TODO Auto-generated method stub
		//this.m_WKOUT_CHG_DTM = value;
	}

	@Override
	public void setWKOUT_STAT_CD(char value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_STAT_CD = value;
	}

	@Override
	public void setWKOUT_ID(long value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_ID = value;
	}

	@Override
	public void setWKOUT_ID(String value) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void setWKOUT_COMM(String value) {
		m_WKOUT_COMM = value;
		
	}


	@Override
	public void setExerSet(String Set, String MaxPer, String Reps, String Rest) {
		// TODO Auto-generated method stub
		
	}

	

	@Override
	public void setSeq(long value) {
		// TODO Auto-generated method stub
		
	}
	

	
	
}
