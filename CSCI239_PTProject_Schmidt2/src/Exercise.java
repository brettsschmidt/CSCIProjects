
public class Exercise implements DatabaseExercises
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
	private long m_Reps;
	private long m_Sets;
	private long m_MaxPer;
	private long m_Rest;
	private Workout m_Workout;
	private long m_Sequence;
	
	public void setWorkout(Workout workout)
	{
		m_Workout = workout;
	}
	
	public Workout getExerWorkout()
	{
		return m_Workout;
	}
	
	public Exercise ()
	{
		m_WKOUT_ID = 0;
		m_WKOUT_NAME = null;
		m_WKOUT_VIDEO = null;
		m_WKOUT_DESC = null;
		m_WKOUT_CAT = null;
		m_WKOUT_ADD_USER_ID = 0;
		m_WKOUT_COMM = null;
		m_WKOUT_ADD_DTM = null;
		m_WKOUT_CHG_USER_ID = 0;
		m_WKOUT_CHG_DTM = null;
		m_WKOUT_STAT_CD = '\0';
		m_Reps = 0;
		m_Sets = 0;
		m_MaxPer = 0;
		m_Rest = 0;
		m_Sequence = 0;
		m_Workout = null;
	}
	
	public long getSeq()
	{
		return m_Sequence;
	}
	
	public void setSeq(long sequence)
	{
		m_Sequence = sequence;
	}
	
	public long getReps()
	{
		return m_Reps;
	}
	
	public long getSets()
	{
		return m_Sets;
	}
	
	public long getMaxPer()
	{
		return m_MaxPer;
	}
	
	public long getRest()
	{
		return m_Rest;
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
	public void setWKOUT_ID(long value) {
		// TODO Auto-generated method stub
		this.m_WKOUT_ID = value;
	}
	
	public void setExerSet(String Set, String MaxPer, String Reps, String Rest)
	{
		try
		{
			m_Sets =  Long.valueOf(Set);
			m_MaxPer =  Long.valueOf(MaxPer);
			m_Reps =  Long.valueOf(Reps);
			m_Rest =  Long.valueOf(Rest);
			
			
		}
		catch (Exception E)
		{
			System.out.println("its catching at the setExersET!!");
			E.printStackTrace();
		}
		
		
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
	public void setWKOUT_ID(String value) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public String getWKOUT_COMM() {
		// TODO Auto-generated method stub
		return m_WKOUT_COMM;
	}

	@Override
	public void setWKOUT_COMM(String value) {
		m_WKOUT_COMM = value;
		
	}

	

	
}
