
public class AppUser 
{
	private String m_UserName;
	private String m_PW;
	private long m_UserId;
	private Boolean m_Logged;
	
	public AppUser(String UserName, String PW)
	{
		m_UserName = UserName;
		m_PW = PW;
		
	}
	
	public void setUserID(long id)
	{
		m_UserId = id;
	}
	
	public long getUserID()
	{
		return m_UserId;
	}
	
	public void setLogged(Boolean logged)
	{
		m_Logged = logged;
	}
	
	public Boolean Logged()
	{
		
		return m_Logged;
	}
	
	
	
}
