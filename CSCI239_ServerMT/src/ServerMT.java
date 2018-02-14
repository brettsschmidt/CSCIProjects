import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.LinkedList;

public class ServerMT {

	private static ServerSocket m_socket;
	private static BufferedReader m_reader;
	private static PrintWriter m_writer;
	public static Boolean isRunning = true;
	
	private static LinkedList<Session> clients = new LinkedList<Session>();
	
	public static void sendMessage(String message)
	{
		
			for( Session s : clients)
			{
				try
				{
				s.sendMessage(message);
				}
				catch ( Exception ex)
				{
					clients.remove(s);
					System.out.println(ex.getMessage());
				}
			}
		
	}
	
	public static void main(String[] args) 
	{
		try
		{
		
			m_socket = new ServerSocket(5000);
			
			while(isRunning)
			{
				Socket client = m_socket.accept();
				Session session = new Session(client);
				clients.addLast(session);
				session.start();
			}
		 
			m_socket.close();
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}

	}

}
