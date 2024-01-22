
# Guided Assignment - Aggregation and Containment

--- 

## Introduction

### Watching portions of the lecture is required for this assignment. Time stamps to appropriate sections are provided


In object-oriented programming (OOP), "aggregation" and "containment" are two concepts related to the way objects are structured and composed within a program.

1. Aggregation:
    - Aggregation is a relationship between two classes where one class contains a reference to another class, but the contained class can exist independently.
    - It represents a "has-a" relationship, indicating that one class is part of another class, but it doesn't own the objects it refers to.
    - In aggregation, the lifecycle of the contained object is not dependent on the container object. It can exist before and after the container object.
    - Aggregation is typically represented using a simple association between classes, and it's often depicted with a diamond-shaped line connecting the container class to the contained class.

Example: A university contains multiple departments. Each department is an object, and the university has a collection of departments. However, if the university ceases to exist, the departments can still exist independently.

2. Containment (Composition):
    - Containment, also known as composition, is a stronger form of aggregation where one class is composed of one or more objects of other classes.
    - In containment, the contained objects are considered an integral part of the containing object, and their lifecycle is tightly coupled.
    - When the containing object is created or destroyed, the contained objects are created and destroyed as well.
    - Containment is often represented using a filled diamond-shaped line connecting the container class to the contained class.

Example: A car is composed of an engine, wheels, and other components. If the car is destroyed, its engine, wheels, and other parts are also no longer usable.

Following the lecture, we implement multiple classes that have different relationships with Aggregation and Containment. We also discuss how we allow access to individual components and how to validate values assigned to them.

---
## Requirements

### Assignment Requirements

1. **Project Setup**:
   - Create a console project named `GA_AggregateAndContainment_YourName`.
   - Include your name in comments at the top of the main program file.
   - Ensure no compile errors in the final submission.

2. **Computer Class with Aggregation**:
   - Implement a `Computer` class that uses aggregation to incorporate component objects like `GraphicsCard`.
   - Demonstrate the use of appropriate fields, properties, constructors, and methods.

3. **Graphics Card Class**:
   - Create a `GraphicsCard` class with an enumeration for different brands and appropriate properties.

4. **Car and Engine Classes for Racing Game**:
   - Implement `Car` and `Engine` classes to simulate a racing game scenario.
   - The `Car` class should aggregate the `Engine` and potentially other components like `Suspension`.

5. **GoKart Class with Containment**:
   - Create a `GoKart` class for a game scenario like Mario Kart, demonstrating the concept of containment.
   - The `GoKart` class should contain an `Engine` that is not swappable.

6. **Interacting with Contained Objects**:
   - Implement methods in `GoKart` for controlled interaction with the contained `Engine`, such as tweaking engine power.
   - Include validation logic and exception handling.

7. **Overall Code Quality and Documentation**:
   - Code should be well-documented with comments explaining aggregation and containment concepts.
   - Follow best practices for code readability and efficiency.

--- 

## Step By Step

---

### Step 1 - Aggregation : Computer

### Follow the Lecture: https://www.youtube.com/watch?v=IqAHRBOuOiw&t=749s

**1. Components of a Computer as Objects (12:36 - 13:45)**
   - The lecture begins by identifying a computer as an object made up of other objects like CPU, power supply, fan, hard drive, and graphics card.
   - It's noted that peripherals like monitors are related to but not part of the computer object.

**2. Discussion on Graphics Cards and Cryptocurrency (13:45 - 15:06)**
   - The instructor explains the recent high prices of graphics cards due to their use in cryptocurrency mining.
   - This detour emphasizes the real-world context of computer components.

**3. Building a Computer Object with Component Objects (15:16 - 16:05)**
   - The concept of building a computer object with more detailed components is introduced.
   - Instead of using primitive data types (like strings for CPU, motherboard), the instructor suggests using objects to represent these components, reflecting real-world complexity.

**Example Code (Computer Class with Aggregation):**
```csharp
 internal class Computer
    {
        // computer
        // cpu
        // motherboard
        // ram
        // power supply
        // fan
        // hard drive
        // graphics card

        string _cpu;
        string _mother;
        GraphicsCard _graphicsCard;

        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard = graphicsCard;
        }

        // Difference Between Containment and Aggregation

    }
```

**4. Creating a Graphics Card Class (16:36 - 17:53)**
   - A `GraphicsCard` class is created to demonstrate how a specific component of a computer can be represented as an object.
   - An enumeration (`enum`) for graphics card brands (NVIDIA, AMD, Intel) is defined.

**Example Code (Graphics Card Class):**
```csharp
    public class GraphicsCard
    {
        public enum Brand { Nvidia, AMD, Intel }

        Brand _graphicsCardBrand;

        public GraphicsCard(Brand graphicsCardBrand)
        {
            _graphicsCardBrand = graphicsCardBrand;
        }
    }
```

**5. Accessibility Modifiers and Constructors (17:53 - 20:13)**
   - The lecture highlights the importance of accessibility modifiers (`public`, `private`, `internal`) in classes and enums.
   - A constructor for the `GraphicsCard` class is created, and the need to synchronize accessibility levels between the constructor and the enum is emphasized.

**6. Aggregation in the Computer Class (20:29 - 20:41)**
   - Finally, it's discussed how these individual component objects (like `GraphicsCard`) can be aggregated into a `Computer` class.
   - This demonstrates the concept of aggregation, where a complex object is composed of several smaller objects, each representing a specific part of the whole.

```csharp
public static void Main(stringp[] args) {
	ComputerExample(); // Display our example
}

public void ComputerExample() {
    // Create a GraphicsCard object with brand Intel
    GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Intel);

    // Create a Computer object and initialize it with the GraphicsCard
    Computer comp = new Computer(gc);

    // Display information about the GraphicsCard from the Computer
    Console.WriteLine("Computer Information:");
    Console.WriteLine("Graphics Card Brand: " + comp.GraphicsCard.Brand);
    
    // You can also access and display other components of the Computer here if needed
}
```


The key themes of this lecture are understanding object-oriented programming concepts like classes, objects, and aggregation, and applying these concepts in a practical context, such as building a computer with various components.


---
### Step 2 - Aggregation : Car and Engine

### Follow The Lecture: https://www.youtube.com/watch?v=IqAHRBOuOiw&t=1366s

This transcription is from a programming lecture discussing object-oriented programming concepts, particularly in the context of a racing video game. Here's a summary of key concepts with associated time stamps and relevant code examples:

**1. Object Aggregation and Components (22:46 - 24:19)**
   - The concept of aggregation in object-oriented programming is introduced using the example of a racing game.
   - In such a game, a car is an object composed of different components (e.g., engine, wheels, suspension), each of which can be represented as a separate object.
   - This allows for component swapping, like changing engines in the game.

**Example Code (Engine Class):**
```csharp
class Engine {
    public int HP { get; set; }

    public Engine(int hp) {
        HP = hp;
    }
}
```

**2. Game Simulation and Realism (24:19 - 25:08)**
   - Discussion on how games simulate real-life physics and mechanics.
   - Engines in games are not just about horsepower but involve complex calculations to mimic real-world behavior.

**3. Coding an Engine and Car Class (26:04 - 27:04)**
   - Demonstrates coding an `Engine` class and a `Car` class.
   - The `Car` class contains properties like `Make`, `Model`, and an `Engine` object.

**Example Code (Car Class):**
```csharp
class Car {
    public string Make { get; set; }
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public Car(string make, string model, Engine engine) {
        Make = make;
        Model = model;
        Engine = engine;
    }

    public override string ToString() {
        return $"{Make} {Model}, HP: {Engine.HP}";
    }
}
```

**4. Null Reference Exception and Debugging (35:19 - 36:05)**
   - Discusses a common programming error, the null reference exception, and demonstrates debugging to find the root cause.
   - Emphasizes the importance of initializing objects before use.

**5. List of Engines and Car Customization (30:01 - 31:07)**
   - The concept of having a list of different engine types in a game, allowing the player to choose and swap engines for their car.
   - This illustrates the use of collections in programming to store multiple objects.

**Example Code (List of Engines):**
```csharp

public static void Main(string[] args) {
	List<Engine> engines = new List<Engine>();
	engines.Add(new Engine(120)); // Slow engine
	engines.Add(new Engine(250)); // Fast engine
	
	Car myCar = new Car("Ford", "Escort", engines[1]); // Using the fast engine
}
```

**6. Suspension Class and Data Validation (44:14 - 44:20)**
   - Introduction of a `Suspension` class as another component of a car.
   - Demonstrates data validation within the class to ensure values are within a realistic range.

**Example Code (Suspension Class):**
```csharp
class Suspension {
    public float FrontBalance { get; set; }
    public float RearBalance { get; set; }
    public float Springiness { get; set; }

    public Suspension(float frontBalance, float rearBalance, float springiness) {
        FrontBalance = frontBalance;
        RearBalance = rearBalance;
        Springiness = springiness;
    }
}
```

**7. String Formatting and Output (53:14 - 53:55)**
   - Shows how to format strings for output, like displaying car information in a readable format.

**Example Code (String Formatting):**
```csharp
public override string ToString() {
    return $"{Make} {Model}, HP: {Engine.HP}\nFront Balance: {Suspension.FrontBalance}\nRear Balance: {Suspension.RearBalance}";
}
```

8. Displaying the information for our contained Engine in our Car class

```csharp
   public static void Main(string[] args) {
	    Engine fastEngine = new Engine(250);
		Engine slowerEngine = new Engine(120);
		
		_engines.Add(fastEngine);
		_engines.Add(slowerEngine);
		
		Suspension suspension = new Suspension(-.4f, 5, .5f);
		
		Car car = new Car("Ford", "Escort", fastEngine, suspension);
		Console.WriteLine(car.ToString());
   }
```

---
### Step 3 - Containment: Mario Kart 

### Follow The Lecture : https://www.youtube.com/watch?v=IqAHRBOuOiw&t=3481s

**1. Aggregation vs. Containment in Car Games (58:06 - 59:29)**
   - The instructor differentiates between games that use aggregation (like Forza, where components like engines can be swapped in cars) and games that use containment (like Mario Kart, where the car's components are fixed).
   - In Mario Kart, the engine is a part of the car and cannot be changed, demonstrating the concept of containment.

**2. Implementation of Containment in a Car Game (59:42 - 1:00:07)**
   - A `GoKart` class is proposed to illustrate the concept of containment.
   - Unlike in aggregation, where components like engines exist independently and can be swapped, in containment, the engine is built into the `GoKart` and cannot be removed or replaced.

**Example Code (GoKart Class with Containment):**
```csharp
class GoKart {
    public string Make { get; set; }
    public string Model { get; set; }
    private Engine engine;

    public GoKart(string make, string model) {
        Make = make;
        Model = model;
        engine = new Engine(250); // Engine is contained and not swappable
    }
}
```

**3. Influence of Character Choice on Game Mechanics (1:00:07 - 1:07:01)**
   - The instructor discusses how, in Mario Kart, the choice of character (like Donkey Kong or Toad) affects the performance of the kart, such as speed and resilience.
   - This illustrates how different properties of an object (like the weight of a character) can influence other aspects (like the speed of the kart).

**Example Code (Character Influence):**
```csharp
class Character {
    public string Name { get; set; }
    public int Weight { get; set; }

    public Character(string name, int weight) {
        Name = name;
        Weight = weight;
    }
}

class GoKart {
    public Character Driver { get; set; }
    private Engine engine;

    public GoKart(Character driver) {
        Driver = driver;
        engine = new Engine(250 - driver.Weight / 2); // Engine power influenced by driver's weight
    }
}
```

**4. Game Design Mechanics and Balance (1:07:01 - 1:15:15)**
   - The concept of game mechanics and balance is explored, emphasizing how different characters' attributes (like weight) affect gameplay dynamics.
   - This part of the lecture underscores the importance of careful design in game development to achieve a balanced and engaging experience.


5. ***Displaying Kart Information in `Program.cs`***

```csharp
	// Add this code to our main in program.cs
	Character donkeyKong = new Character(150, "Donkey Kong");
	GoKart goKart = new GoKart(donkeyKong);

	Console.WriteLine(goKart);

	Character toad = new Character(50, "Toad");
	GoKart goKartToad = new GoKart(toad);
	Console.WriteLine(goKartToad);
```


---

### Step 4 - Interacting with Contained Objects ( Builds on our GoKart.cs class )

### Follow The Lecture: https://www.youtube.com/watch?v=IqAHRBOuOiw&t=5073s

This segment of the lecture delves into advanced concepts in object-oriented programming, focusing on giving access to contained objects, implementing validation logic, and utilizing try-catch blocks for exception handling. Here's a summary of the key concepts discussed, along with associated timestamps and relevant code examples:

**1. Controlling Access to Contained Objects with Properties (1:24:39 - 1:25:42)**
   - The instructor discusses how to control access to a contained object, such as an `Engine` in a `GoKart` class, using properties.
   - A read-only property for `Engine` is created in `GoKart`, allowing external code to view but not modify the engine.

**Example Code (Read-Only Property):**
```csharp
class GoKart {
    private Engine engine = new Engine(250);
    public Engine Engine {
        get { return engine; }
    }
}
```

**2. Method for Tweakable Access to Contained Objects (1:25:49 - 1:26:28)**
   - The instructor creates a method `TweakEngine` in the `GoKart` class to allow controlled modifications to the `Engine` object without directly exposing it for replacement.

**Example Code (Tweakable Access Method):**
```csharp
class GoKart {
    private Engine engine = new Engine(250);

    public void TweakEngine(int newHP) {
        engine.HP = newHP;
    }
}
```

**3. Validation Logic in Setter Methods (1:27:28 - 1:29:01)**
   - Validation logic is introduced to ensure that the engine's horsepower remains within acceptable limits. This is done within the `Engine` class itself, demonstrating encapsulation.

**Example Code (Validation in Setter):**
```csharp
class Engine {
    private int hp;
    public int HP {
        get { return hp; }
        set {
            if (value >= 50) {
                hp = value;
            } else {
                throw new Exception("Invalid horsepower value");
            }
        }
    }
}
```

**4. Using Try-Catch for Exception Handling (1:29:01 - 1:38:04)**
   - The lecture illustrates how to use try-catch blocks to gracefully handle exceptions that may occur when the `TweakEngine` method is called with invalid input.

**Example Code (Try-Catch for Exception Handling):**
```csharp
try {
    goKart.TweakEngine(-50); // Invalid value
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
```

**5. Explanation of Reference vs. Value Types (1:41:16 - 1:51:01)**
   - The instructor explains the difference between passing by reference and passing by value. Objects are passed by reference, meaning changes to an object inside a method affect the original object. Primitive types (like int) are passed by value, meaning they are copied and changes don't affect the original variable.

**6. Implementing Overloaded Methods (1:52:05 - 1:53:05)**
   - The concept of method overloading is shown. For example, the `GoKart` class has two `SwapEngine` methods: one accepting an `Engine` object and the other accepting horsepower as an integer.

**Example Code (Overloaded Methods):**
```csharp
class GoKart {
    private Engine engine;

    public void SwapEngine(Engine newEngine) {
        engine = newEngine;
    }

    public void SwapEngine(int hp) {
        engine = new Engine(hp);
    }
}
```


7. Demonstrating our Validations in `Program.cs`

```csharp
  	// Add this code to our main in program.cs
  
  Console.WriteLine("Before our try catch");
	// Respond to exceptions
	goKartToad.TweakEngine(-50);
	try
	{

		Console.WriteLine("We reached this line of code");
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
	Console.WriteLine("This is after our try catch");
```

---
## Rubric

| Name                                      | Description                                                                                          | Points |
|-------------------------------------------|------------------------------------------------------------------------------------------------------|--------|
| Project Setup                             | Proper setup of the console project with correct naming and no compile errors.                       | 5      |
| Computer Class Implementation             | Implementation of the `Computer` class with correct use of aggregation.                              | 15     |
| Graphics Card Class                       | Creation of a `GraphicsCard` class with enum and appropriate properties.                             | 10     |
| Car and Engine Classes                    | Implementation of `Car` and `Engine` classes with correct aggregation principles.                    | 20     |
| GoKart Class with Containment             | Creation of the `GoKart` class demonstrating containment.                                            | 20     |
| Interacting with Contained Objects        | Correct implementation of interaction methods, validation logic, and exception handling in `GoKart`. | 20     |
| Code Quality and Documentation            | Overall code quality, including readability, efficiency, and documentation.                          | 10     |

Total Points: 100
