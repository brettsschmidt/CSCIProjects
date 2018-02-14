import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Date;

import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.DocumentHelper;

public class Session extends Thread 
{

	private Socket m_socket;
	private BufferedReader m_reader;
	private PrintWriter m_writer;
	private int sid;
	private Boolean isConnected;
	
	private static int session_id;
	
	public Session( Socket socket)
	{
		m_socket = socket;
		try{
		m_reader = new BufferedReader(new InputStreamReader(socket.getInputStream()));
		m_writer = new PrintWriter(socket.getOutputStream(), true);
		isConnected = true;
		sid = ++session_id;
		System.out.format("session %d connected from %s", sid);
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}
	}
	
	public void sendMessage(String message)
	{
		
		//m_writer.println(String.format("session %s:%d\t%s",  new Date().toString(), sid, message));
		m_writer.println("connected");
	}
	
	public void run()
	{
		String request = null;
		String response = null;
		
		Document xmlDoc = DocumentHelper.createDocument();
		
		System.out.println(sid + "Connected. GodBye!");
		try
		{
			while( isConnected)
			{
				request = m_reader.readLine();
				if(request.equals("disconnect"))
					isConnected = false;
				else
					ServerMT.sendMessage(request);
			}
			m_socket.close();
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}
	}
}
