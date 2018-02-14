import java.text.DecimalFormat;

public class Circle extends Point
{
	// Variables
	private float m_radius;
	private double m_area;
	private double m_circumference;
	DecimalFormat numberFormat = new DecimalFormat("#.00"); // To make the numbers look nicer.
	DecimalFormat pointFormat = new DecimalFormat("#");
	
	
	public Circle(float x, float y, float radius) {
		super(x, y);
		m_radius = radius;
		m_area = (radius * radius * Math.PI);
		m_circumference = (2f * radius * Math.PI);
	}
	
	public float getRadius() 
	{
		return m_radius;
	}
	
	public double getArea()
	{
		return m_area;
	}
	
	public double getCircumference()
	{
		return m_circumference;
	}
	
	public void setRadius(float NewRadius)
	{
		if(NewRadius >= 0 ){
		m_radius = NewRadius;
		m_area = (NewRadius * NewRadius * Math.PI);
		m_circumference = (2f * NewRadius * Math.PI);}
	}
	
	public String toString(){
		return "The radius is: " + getRadius() + ". The area is: " + numberFormat.format(getArea()) 
		+ ". The circumference is: " + numberFormat.format(getCircumference()) + 
		". The center is: (" + pointFormat.format(getX()) + "," + pointFormat.format(getY()) + ")\n";
		
	}

}
