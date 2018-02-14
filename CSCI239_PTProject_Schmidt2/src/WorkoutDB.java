
import java.lang.reflect.Type;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.LinkedList;

public class WorkoutDB 
{
	public static AppUser LoggedUser;

	// Each workout should have a linkedlist of Exercises, not the other way around.
	
	//public static String ConnectionString = "jdbc:ucanaccess://C:\\Users\\brett\\Documents\\STB001_TRAINER_MASTER.accdb; memory=true;";
	public static String ConnectionString = String.format( "jdbc:ucanaccess://%s\\DB\\STB001_TRAINER_MASTER.accdb; memory=true;", System.getProperty("user.dir"));
	
	public static DatabaseExercises Create ( ResultSet rs , String cat )
	{
		String ogCat = cat;
		if(cat == "ExerciseQuery")
		{
			cat = "Exercise";
		}
		
		try
		{
			DatabaseExercises workout = (DatabaseExercises) Class.forName(cat).getConstructor().newInstance();
			workout.setWKOUT_ID( rs.getLong("WKOUT_ID"));
			workout.setWKOUT_NAME( rs.getString("WKOUT_NAME") );
			if(ogCat == "Exercise" || ogCat == "Workout")
			{
			workout.setWKOUT_COMM( rs.getString("WKOUT_COMM") );
			}
			workout.setWKOUT_DESC( rs.getString("WKOUT_DESC") );
			workout.setWKOUT_CAT( rs.getString("WKOUT_CAT") );
			workout.setWKOUT_ADD_USER_ID(( rs.getLong("WKOUT_ADD_USER_ID")) );
			//workout.setWKOUT_ADD_DTM( rs.getTimestamp("WKOUT_ADD_DTM") );
			workout.setWKOUT_CHG_USER_ID( rs.getLong("WKOUT_CHG_USER_ID"));
			//workout.setWKOUT_CHG_DTM( rs.getTimestamp("WKOUT_CHG_DTM") );
			workout.setWKOUT_STAT_CD( rs.getString("WKOUT_STAT_CD").charAt(0) );
			if(ogCat == "Exercise")
			{
				workout.setExerSet(String.valueOf(rs.getLong("WKOUT_SETS")), String.valueOf(rs.getLong("WKOUT_MAXPER")), String.valueOf(rs.getLong("WKOUT_REPS")), String.valueOf(rs.getLong("WKOUT_REST")));
				workout.setSeq(rs.getLong("WKOUT_SEQUENTIAL"));
			}
			
			
			return workout; 
			
			
		}
		catch (SQLException e) 
		{
			e.printStackTrace();
			return null;
		}
		catch (Exception E)
		{
			return null;
		}
		
		
	}
	
	public static int CheckNum (long Workout_ID, long Workout_Seq	)
		{
		int checker;
		
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 

//		Query SQL:
//		SELECT WKOUT_ID
//		FROM STT002_EXER_WKOUT
//		WHERE WKOUT_ID = [S_ID];

		
		
		String strSQL = " { call qryWorkoutIDTester(?, ?) }";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setLong(1, Workout_ID);
			ps.setLong(2, Workout_Seq);
			
		
			rs = ps.executeQuery();
			
			if( rs.next() )
			{
				checker = 1; 
			}
			else
			{
				checker = 0;
			}
			
		}
		catch( Exception ex )
		{
			ex.printStackTrace();
			checker = 0;
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}		
		
		
		return checker;
		}
	
	
	// TODO: Create update qry
	public static void Update( Exercise exercise )
	{
		Connection cn = null;
		PreparedStatement ps = null;
		
//		updateWorkout SQL:
//		UPDATE STT002_EXER_WKOUT SET STT002_EXER_WKOUT.WKOUT_EXER_ID = [E_ID], STT002_EXER_WKOUT.WKOUT_NAME_AK3 = [E_NAME], 
//		STT002_EXER_WKOUT.WKOUT_CAT_CD_AK4 = [CAT], STT002_EXER_WKOUT.WKOUT_CHG_USER_ID = [U_ID], 
//				STT002_EXER_WKOUT.WKOUT_CHG_DTM = Now(), STT002_EXER_WKOUT.WKOUT_DESC = [DESC], STT002_EXER_WKOUT.WKOUT_COMM = [COM], 
//				STT002_EXER_WKOUT.WKOUT_SETS = [SETS], STT002_EXER_WKOUT.WKOUT_REPS = [REPS], STT002_EXER_WKOUT.WKOUT_REST = [REST], 
//				STT002_EXER_WKOUT.WKOUT_MAXPER = [MAXPER]
//				WHERE WKOUT_ID = [W_ID] AND WKOUT_SEQUENTIAL = [SEQ];

		
		StringBuilder strSQL =  new StringBuilder("{ call updateWorkout(?,?,?,?,?,?,?,?,?,?,?,?) }");
       
		if(CheckNum(exercise.getExerWorkout().getWKOUT_ID(), exercise.getSeq()) == 1)
		{
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL.toString());
			
			//ps.setLong(1, exercise.getExerWorkout().getWKOUT_ID());
			//ps.setLong(2, exercise.getSeq());
//			ps.setLong(3, exercise.getWKOUT_ID());
//			ps.setString(4, exercise.getExerWorkout().getWKOUT_NAME());
//			ps.setString(5, exercise.getExerWorkout().getWKOUT_CAT());
//			ps.setLong(6, LoggedUser.getUserID());
//			ps.setString(7,  exercise.getExerWorkout().getWKOUT_DESC());
//			ps.setString(8, exercise.getExerWorkout().getWKOUT_COMM());
//			ps.setLong(9, exercise.getSets());
//			ps.setLong(10, exercise.getReps());
//			ps.setLong(11, exercise.getRest());
//			ps.setLong(12, exercise.getMaxPer());
			
			ps.setLong(1, exercise.getWKOUT_ID());
			ps.setString(2, exercise.getExerWorkout().getWKOUT_NAME());
			ps.setString(3, exercise.getExerWorkout().getWKOUT_CAT());
			
			ps.setLong(4, LoggedUser.getUserID());
			ps.setString(5,  exercise.getExerWorkout().getWKOUT_DESC());
			ps.setString(6, exercise.getExerWorkout().getWKOUT_COMM());
			ps.setLong(7, exercise.getSets());
			ps.setLong(8, exercise.getReps());
			ps.setLong(9, exercise.getRest());
			ps.setLong(10, exercise.getMaxPer());
			ps.setLong(11, exercise.getExerWorkout().getWKOUT_ID());
			ps.setLong(12, exercise.getSeq());
			
		
			
			ps.executeUpdate();
			
			ps.close();	
		}
		catch(Exception ex )
		{
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}
		}}
		else
		{
			Add(exercise);
		}
		       
	}

	
	 
	public static void Delete( Workout workout )
	{
		Connection cn = null;
		PreparedStatement ps = null;
		
//		qryDelete SQL
//		UPDATE STT002_EXER_WKOUT SET STT002_EXER_WKOUT.WKOUT_STAT_CD = "I", WKOUT_CHG_USER_ID = [CHG_USER_ID], WKOUT_CHG_DTM = Now()
//		WHERE WKOUT_STAT_CD<>"I" And WKOUT_ADD_USER_ID = [CHG_USER_ID] AND WKOUT_ID = [W_ID];
		
		String strSQL =  "{ call qryDelete(?, ?) }";
		       
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setLong(1,  LoggedUser.getUserID());
			ps.setLong(2, workout.getWKOUT_ID());
			ps.executeUpdate();
		}
		catch(Exception ex )
		{
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}
		}
		       
	}
	
	
	
	public static void UnDelete( Workout workout )
	{
		Connection cn = null;
		PreparedStatement ps = null;
		
//		qryUndelete SQL:
//			UPDATE STT002_EXER_WKOUT SET STT002_EXER_WKOUT.WKOUT_STAT_CD = "A", WKOUT_CHG_USER_ID = [CHG_USER_ID], WKOUT_CHG_DTM = Now()
//			WHERE WKOUT_STAT_CD<>"A" And WKOUT_ADD_USER_ID = [CHG_USER_ID] AND WKOUT_ID = [W_ID];
		
		String strSQL =  "{ call qryUndelete(?, ?) }";
	
		if(LoggedUser.getUserID() == workout.getWKOUT_ADD_USER_ID())
		{
		       
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setLong(1, LoggedUser.getUserID());
			ps.setLong(2, workout.getWKOUT_ID());
			
			ps.executeUpdate();
		}
		catch(Exception ex )
		{
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}
		}
		       
	}}

	
	public static void Purge( Workout workout )
	{
		Purge(workout.getWKOUT_ID());
	}

	
	public static void Purge( long WKOUT_ID )
	{
		Connection cn = null;
		PreparedStatement ps = null;
		
//		qryPurge SQL:
//			DELETE *
//			FROM STT002_EXER_WKOUT
//			WHERE ((([STT002_EXER_WKOUT].[WKOUT_ID])=[S_ID]) And (([STT002_EXER_WKOUT].[WKOUT_STAT_CD])="I") AND WKOUT_ADD_USER_ID = [U_ID]);	
		
		
		String strSQL =  "{ call qryPurge(?, ?) }";
		
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setLong(1, WKOUT_ID);
			ps.setLong(2, LoggedUser.getUserID());
			
			
			ps.executeUpdate();
		}
		catch(Exception ex )
		{
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}
		}
		       
	}	
	
	
	
	
	// Add some sort of verification.
	// And add comments and descriptions
	
	
	
	public static void Add( Exercise exercise)
	{ 
		Connection cn = null;
		PreparedStatement ps = null;
		
		
		StringBuilder strSQL =  new StringBuilder("{ call insertWorkout(?,?,?,?,?,?,?,?,?,?,?,?,?) }");
		    
		       
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL.toString());
			
			ps.setLong(1, exercise.getExerWorkout().getWKOUT_ID());
			ps.setLong(2, exercise.getSeq());
			ps.setLong(3, exercise.getWKOUT_ID());
			ps.setString(4, exercise.getExerWorkout().getWKOUT_NAME());
			
			
			ps.setString(5, exercise.getExerWorkout().getWKOUT_CAT());
			
			//TODO: Add static USERID from Login to WorkoutDB
			ps.setLong(6, LoggedUser.getUserID());
			ps.setString(7, "A");
			ps.setString(8,  exercise.getExerWorkout().getWKOUT_DESC());
			ps.setString(9, exercise.getExerWorkout().getWKOUT_COMM());
			ps.setLong(10, exercise.getSets());
			ps.setLong(11, exercise.getReps());
			ps.setLong(12, exercise.getRest());
			ps.setLong(13, exercise.getMaxPer());
			
			ps.executeUpdate();
			
			ps.close();	
		}
		catch(Exception ex )
		{
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}
		}
		
		
		
	}
	
	
	//Does nothing, not actually a part of the program. Does not actually incantate.
	public static Workout[] List(String WKOUT_CAT)
	{
		LinkedList<Workout> list = new LinkedList<Workout>(); 
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 

		// TODO:  remove * and list fields needed by the query...
		// 
		String strSQL = "SELECT * FROM STT001_WKOUT_MASTER WHERE WKOUT_CAT = ? ORDER BY WKOUT_NAME, WKOUT_ID;";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setString(1, WKOUT_CAT);
			rs = ps.executeQuery();
			
			while( rs.next() )
			{
				list.add((Workout) WorkoutDB.Create(rs, WKOUT_CAT )); 
			}
			
		}
		catch( Exception ex )
		{
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}		
		
		return list.toArray(new Workout[list.size()]);
	}
	
	
	
	
	//TODO: Fix this
	public static LinkedList<Exercise> Inquire( Exercise exercise )
	{
		return Inquire(exercise.getWKOUT_ID());
	}
	
	public static LinkedList<Exercise> Inquire(Workout workout)
	{
		return Inquire(workout.getWKOUT_ID());
	}
	
	public static LinkedList<Workout> Inquire(String Category)
	{
		LinkedList <Workout> exercises = new LinkedList<Workout>();
		// Change to reflection
		
		Workout workout = null; 
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 
		
//		qryWorkoutByCat SQL:
//			SELECT DISTINCT STT002_EXER_WKOUT.WKOUT_ID, STT002_EXER_WKOUT.WKOUT_NAME_AK3 AS WKOUT_NAME, STT002_EXER_WKOUT.WKOUT_CAT_CD_AK4 AS WKOUT_CAT, STT002_EXER_WKOUT.WKOUT_ADD_USER_ID AS WKOUT_ADD_USER_ID, STT002_EXER_WKOUT.WKOUT_CHG_USER_ID AS WKOUT_CHG_USER_ID, STT002_EXER_WKOUT.WKOUT_STAT_CD AS WKOUT_STAT_CD, STT002_EXER_WKOUT.WKOUT_DESC AS WKOUT_DESC, STT002_EXER_WKOUT.WKOUT_COMM AS WKOUT_COMM
//			FROM STT002_EXER_WKOUT
//			WHERE WKOUT_CAT_CD_AK4 = [CAT];
		
		
		// TODO:  add qryWorkout(WKOUT_ID) Make the Like function work and only allow users to update their own workouts
		String strSQL = "{ call qryWorkoutByCat( ?) }";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setString(1, Category);
			rs = ps.executeQuery();
			
			while( rs.next() == true )
			{
				
				exercises.add( (Workout) WorkoutDB.Create(rs, "Workout")); 
			}
			
		}
		catch( Exception ex )
		{
			ex.printStackTrace();
			workout = null;
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}
		
		
		return exercises; 
		
	}
	
	public static LinkedList<Workout> Inquire(String search, String Category)
	{
		LinkedList <Workout> exercises = new LinkedList<Workout>();
		// Change to reflection
		
		Workout workout = null; 
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 
		
		search = "&" + search + "&";
		
		
		
//		qryWorkoutTest SQL:
//			SELECT DISTINCT STT002_EXER_WKOUT.WKOUT_ID, STT002_EXER_WKOUT.WKOUT_NAME_AK3 AS WKOUT_NAME, STT002_EXER_WKOUT.WKOUT_CAT_CD_AK4 AS WKOUT_CAT, STT002_EXER_WKOUT.WKOUT_ADD_USER_ID AS WKOUT_ADD_USER_ID, STT002_EXER_WKOUT.WKOUT_CHG_USER_ID AS WKOUT_CHG_USER_ID, STT002_EXER_WKOUT.WKOUT_STAT_CD AS WKOUT_STAT_CD, STT002_EXER_WKOUT.WKOUT_DESC AS WKOUT_DESC, STT002_EXER_WKOUT.WKOUT_COMM AS WKOUT_COMM
//			FROM STT002_EXER_WKOUT
//			WHERE WKOUT_NAME_AK3 LIKE [NAME] OR WKOUT_CAT_CD_AK4 = [CAT];
		
		
		
		String strSQL = "{ call qryWorkoutTest(?, ?) }";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setString(1, search);
			ps.setString(2, Category);
			rs = ps.executeQuery();
			
			while( rs.next() == true )
			{
				
				exercises.add( (Workout) WorkoutDB.Create(rs, "Workout")); 
			}
			
		}
		catch( Exception ex )
		{
			ex.printStackTrace();
			workout = null;
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}
		
		
		return exercises; 
		
	}
	public static LinkedList<Workout> Inquire(String search, String Category, long User_ID)
	{
		LinkedList <Workout> exercises = new LinkedList<Workout>();
		// Change to reflection
		
		Workout workout = null; 
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 
		
		search = "%" + search + "%";
		
//		qryMyWorkouts SQL:
//			SELECT DISTINCT STT002_EXER_WKOUT.WKOUT_ID, STT002_EXER_WKOUT.WKOUT_NAME_AK3 AS WKOUT_NAME, STT002_EXER_WKOUT.WKOUT_CAT_CD_AK4 AS WKOUT_CAT, STT002_EXER_WKOUT.WKOUT_ADD_USER_ID AS WKOUT_ADD_USER_ID, STT002_EXER_WKOUT.WKOUT_CHG_USER_ID AS WKOUT_CHG_USER_ID, STT002_EXER_WKOUT.WKOUT_STAT_CD AS WKOUT_STAT_CD, STT002_EXER_WKOUT.WKOUT_DESC AS WKOUT_DESC, STT002_EXER_WKOUT.WKOUT_COMM AS WKOUT_COMM
//			FROM STT002_EXER_WKOUT
//			WHERE WKOUT_NAME_AK3 LIKE [NAME] AND WKOUT_CAT_CD_AK4 = [CAT] AND WKOUT_ADD_USER_ID = [ADD_ID];

		
		String strSQL = "{ call qryMyWorkouts(?, ?, ?) }";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setString(1, search);
			ps.setString(2, Category);
			ps.setLong(3, LoggedUser.getUserID());
			rs = ps.executeQuery();
			
			while( rs.next() == true )
			{
				exercises.add( (Workout) WorkoutDB.Create(rs, "Workout")); 
			}
			
		}
		catch( Exception ex )
		{
			ex.printStackTrace();
			workout = null;
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}
		
		
		return exercises; 
		
	}
	public static LinkedList <Exercise> Inquire(long workout_ID)
	{
		LinkedList <Exercise> exercises = new LinkedList<Exercise>();
		// Change to reflection
		
		
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 

//		qryFullWorkout SQL:
//			SELECT WKOUT_ID, WKOUT_NAME_AK3 AS WKOUT_NAME, WKOUT_CAT_CD_AK4 AS WKOUT_CAT, WKOUT_ADD_USER_ID, WKOUT_CHG_USER_ID, WKOUT_STAT_CD, WKOUT_DESC, WKOUT_COMM, WKOUT_SETS, WKOUT_REPS, WKOUT_REST, WKOUT_MAXPER, WKOUT_SEQUENTIAL
//			FROM STT002_EXER_WKOUT
//			WHERE WKOUT_ID = [W_ID];
		
		
		String strSQL = "{ call qryFullWorkout(?) }";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setLong(1, workout_ID);
			rs = ps.executeQuery();
			
			while( rs.next() )
			{
				exercises.add( (Exercise) WorkoutDB.Create(rs, "Exercise")); 
			}
			
		}
		catch( Exception ex )
		{
			ex.printStackTrace();
			
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}
		
		
		return exercises; 
		
	}
	
	public static AppUser Login(String Username, String PW)
	{
		
		AppUser appUser = new AppUser(Username, PW); 
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 
		long logged = 0;
		Boolean Logged = false;
		
//		qryAppUser SQL:
//			SELECT STT003_USER_MASTER.USER_ID
//			FROM STT003_USER_MASTER
//			WHERE (((STT003_USER_MASTER.USER_NAME)=[uname]) AND ((STT003_USER_MASTER.USER_PW)=[pw]));

		// Encrypt
		String strSQL = "{ call qryAppUser(?, ?) }";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setString(1, Username.toLowerCase());
			ps.setString(2,  PW);
			rs = ps.executeQuery();
			
			
			if( rs.next() )
			{
				
				logged = rs.getLong("USER_ID"); 
				
			}
			
		}
		catch( Exception ex )
		{
			System.out.println("Its catching here!");
			ex.printStackTrace();
			appUser = null;
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}
		System.out.println(logged);
		if(logged != 0)
		{
			Logged = true;
			System.out.println("Logged in success!");
		}
		
		
		appUser.setLogged(Logged);
		appUser.setUserID(logged);
		LoggedUser = appUser;
		
		return appUser; 
		
		
	}
	
	public static LinkedList<String> Categories (String catType, String qry)
	{
		LinkedList cats = new LinkedList<String>();
		
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 
		//String strSQL = null;
		
//		qryCatByCatTable SQL:
//			SELECT STT009_CAT_CODE.CAT_NAME
//			FROM STT010_CAT_CAT INNER JOIN STT009_CAT_CODE ON STT010_CAT_CAT.CAT_CAT_NAME = STT009_CAT_CODE.CAT_CAT
//			WHERE (((STT010_CAT_CAT.CAT_TABLE)=[cat]));
//		qryCats SQL:
//			SELECT STT010_CAT_CAT.CAT_CAT_NAME AS CAT_NAME
//			FROM STT010_CAT_CAT
//			WHERE (((STT010_CAT_CAT.CAT_TABLE)=[cat]));
		
		String strSQL = "{ call qryCatByCatTable(?) }";
		if(qry == "Workout"	)
				{
			strSQL = "{ call qryCats(?) }";
				}
			
		// Encrypt
		/*switch(choice)
		{
			case 1:
			strSQL = "{ call qryCatByCatTable(?) }";
			break;
			case 2:
			strSQL = "{ call qryWorkoutByCatTable(?)";
			break;
			default:
			break;
		}*/
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setString(1, catType);
			
			rs = ps.executeQuery();
			
			while( rs.next() == true )
			{
					cats.add( rs.getString("CAT_NAME")); 
			}
		}
		catch( Exception ex )
		{
			System.out.println("Its catching here!");
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}
		return cats;
	}
	
	public static Exercise[] Query (String Cat)
	{
		LinkedList <Exercise> Exercises  = new LinkedList<Exercise>();
		
		Connection cn = null;
		PreparedStatement ps = null;
		ResultSet rs = null; 
		String Category = "ExerciseQuery";

//		qryExercisesByCat SQL:
//			SELECT STT001_EXER_MASTER.EXER_ID AS WKOUT_ID, STT001_EXER_MASTER.EXER_NAME_AK1 AS WKOUT_NAME, STT001_EXER_MASTER.EXER_DESC AS WKOUT_DESC, STT001_EXER_MASTER.EXER_CAT_CD AS WKOUT_CAT, STT001_EXER_MASTER.EXER_ADD_USER_ID AS WKOUT_ADD_USER_ID, STT001_EXER_MASTER.EXER_CHG_USER_ID AS WKOUT_CHG_USER_ID, STT001_EXER_MASTER.EXER_STAT_CD AS WKOUT_STAT_CD
//			FROM STT001_EXER_MASTER
//			WHERE EXER_CAT_CD = [CAT];

		
		String strSQL = " call qryExercisesByCat( ? ) ";
		
		try
		{
			cn = DriverManager.getConnection(ConnectionString);
			ps = cn.prepareStatement(strSQL);
			ps.setString(1, Cat);
			rs = ps.executeQuery();
			
			while( rs.next() )
			{
				
				Exercises.add( (Exercise)WorkoutDB.Create(rs, Category)); 
			}
			
		}
		catch( Exception ex )
		{
			ex.printStackTrace();
		}
		finally
		{
			try 
			{
				rs.close();
				ps.close();
				cn.close();
			} 
			catch (SQLException e) 
			{
				e.printStackTrace();
			}

		}		
		
		
		return Exercises.toArray(new Exercise[Exercises.size()]);
	}



	
	
}
