
public class Program 
{
	int F1;
	int F2;
	int F3;
	int F4;
	int F5;
	
	//Take input how ever
	
	public static void main(String[] args)
	{
		
		int F1;
		int F2;
		int F3;
		int F4;
		int F5;
		int three;
		int two;
		int one;
		
		int counter = 0;
		
		F1 = 10;
		F2 = 10;
		F3 = 12;
		F4 = 20;
		F5 = 60;
		
		if((F1 * F2) > (F3 * 3 ) + (F4 * 2) + F5)
		{
			System.out.println("CAN'T BE DONE");
		}
		else{
		int[][] code = new int[3][F2];
		
		for(int i = 0; i < F2; i++)
		{
			three = 0;
			two = 0;
			one = 0;
			if(F1 >= 6 && F3 > 0)
			{
				for(int o = 0; o < (F1 / 3); o++ )
				{
					if(F3 > 0)
					{
						three++;
						F3--;
					}
				}
				code[0][i] = three;
			}
			else if(F1 >= 3 && F1 < 6 && F3 > 0)
			{
				F3--;
				code[0][i] = 1;
				three++;
			}
			else
			{
				code[0][i] = 0;
			}
			
			for(int o = 0; o < (F1-(3 * three))/2; o++)
			{
				if(F4 > 0 && ((F1 - (3 * three))/ (2)) >= 2)
				{
					two++;
					F4--;
				}
			}
			code[1][i] = two;
			
			for(int o = 0; o < (F1 - (3 * three) - (2 * two)); o++)
			{
				if(F5 > 0 && (F1 - (3 * three) - (2 * two)) >=1)
				{
					one++;
					F5--;
				}
			}
			code[2][i] = one;
		}
		
		int o = 0;
		if((code[1][F2-1] * 2) + code[2][F2-1] + (code[0][F2-1] * 3) != F1)
		{
			System.out.println("CAN'T BE DONE");
		}
		else
		{
		for(int i = 0; i < F2;)
		{
			
			if(o == 0)
			{
				DrawLine((F1 * 6), o);
			}
			else
			{
				System.out.print("\n");
			}
			for(int p = 0; p < code[0][i]; p++)
			{
				Draw3Brick();
			}
			for(int p = 0; p < code[1][i]; p++)
			{
				Draw2Brick();
			}
			for(int p = 0; p < code[2][i]; p++)
			{
				Draw1Brick();
			}
			if(o == 1)
			{
				DrawLine((F1 * 6), o);
				o = 0;
				i++;
				
			}
			else{
			o++;
			}}
		}}
		
	}
	
	static void DrawLine(int F1, int counter)
	{
		System.out.print("\n*");
		for(int u = 0; u < (F1-1); u++)
		{
			System.out.print("*");
		}
		if(counter == 0)
		System.out.print("\n");
		
	}
	
	static void Draw3Brick()
	{
		System.out.print("*                *");
	}
	static void Draw2Brick()
	{
		System.out.print("*          *");
	}
	static void Draw1Brick()
	{
		System.out.print("*    *");
	}

}
