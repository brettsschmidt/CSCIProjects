import java.text.DecimalFormat;
import java.util.Scanner;

//By Brett Schmidt

public class Program {

	public static void main(String[] args) {
		
		
		DecimalFormat numberFormat = new DecimalFormat("#.00"); // To make the numbers look nicer.
		DecimalFormat pointFormat = new DecimalFormat("#");
		
		
		// Test the inherited constructor
		Circle c = new Circle(3, 4, 5);
		System.out.println("Circle c has been instantiated and set with default values.");
		System.out.println(c.toString());
		
		//byte[] input = new System.in.read(input, 9, 9);
		
		// Test the setRadius method with user input. The setRadius should also set the circumference and area
		System.out.println("Please input integer to set Circle c's radius: ");
		Scanner dark = new Scanner(System.in);
		float i = dark.nextFloat();
		c.setRadius(i);
		System.out.println(c.toString());
		
		// Test the inherited constructor again
		Circle d = new Circle(2, 3, 10);
		System.out.println("Circle d has been instantiated and set with default values.");
		System.out.println(d.toString());
		
		// Test the setRadius method with manual input
		d.setRadius(5);
		System.out.println("Circle d's radius has been changed.");
		System.out.println(d.toString());
		
		// Test the setX and setY methods
		d.setY(8);
		d.setX(1);
		System.out.println("Circle d's center has been changed.");
		System.out.println(d.toString());
		
		
	}

}
