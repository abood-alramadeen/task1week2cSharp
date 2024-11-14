// See https://aka.ms/new-console-template for more information
//Consider the following tightly coupled code where a Car class
//directly depends on an Engine class, Refactor the code to be
//loosely coupled using interfaces and dependency injection.
//the code 


/*
 public class engine {

public void start (){
console.writeline("engine started")
}


}

public class car {
private Engine_engine;

public car (){

_engine=new Engine();
}
public void start(){
_engine.start();

}



}



public class program{

public static void main(){

Car car =new Car();

car.start();
}
}


 */

///////////////////////////////////////////////////////////////////////////////
///after refactor////
///



public interface IEngine
{
	void Start();
}

public class Engine : IEngine
{
	public void Start()
	{
		Console.WriteLine("Engine started");
	}
}

public class Car
{
	private IEngine _engine;

	public Car(IEngine engine)
	{
		_engine = engine;
	}

	public void Start()
	{
		_engine.Start();
	}
}

public class Program
{
	public static void Main()
	{
		IEngine engine = new Engine();
		Car car = new Car(engine);

		car.Start();
	}
}


