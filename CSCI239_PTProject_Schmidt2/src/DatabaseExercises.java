
public interface DatabaseExercises 
{
	public abstract void setWKOUT_ID(String value);
	
	public abstract long getWKOUT_ID();
	public abstract String getWKOUT_NAME();
	public abstract String getWKOUT_VIDEO();
	public abstract String getWKOUT_DESC() ;
	public abstract String getWKOUT_CAT();
	public abstract String getWKOUT_COMM();
	public abstract long getWKOUT_ADD_USER_ID();
	public abstract java.sql.Timestamp getWKOUT_ADD_DTM();
	public abstract long getWKOUT_CHG_USER_ID();
	public abstract java.sql.Timestamp getWKOUT_CHG_DTM();
	public abstract char getWKOUT_STAT_CD();
	
	
	public abstract void setWKOUT_ID(long value);
	public abstract void setWKOUT_NAME(String value);
	public abstract void setWKOUT_VIDEO( String value );
	public abstract void setWKOUT_DESC( String value );
	public abstract void setWKOUT_COMM(String value);
	public abstract void setWKOUT_CAT( String value);
	public abstract void setWKOUT_ADD_USER_ID( long value );
	public abstract void setWKOUT_ADD_DTM(String value  );
	public abstract void setWKOUT_CHG_USER_ID( long value);
	public abstract void setWKOUT_CHG_DTM( String value );
	public abstract void setWKOUT_STAT_CD(char value );
	public abstract void setExerSet(String Set, String MaxPer, String Reps, String Rest);
	public abstract void setSeq(long value);
	
}
