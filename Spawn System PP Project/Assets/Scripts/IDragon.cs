using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IDragon { }

public class Fire1 : IDragon 
{
    Resources.Load("Assets/Scripts/MyPrefab") as GameObject;
    
}
public class Fire2 : IDragon { }
public class Ice1 : IDragon { }
public class Ice2 : IDragon { }
public class Lightning1 : IDragon { }
public class Lightning2 : IDragon { }



/*
public class Unicycle : IDragon { }
public class Bicycle : IDragon { }
public class Tandem : IDragon { }
public class Tricycle : IDragon { }
public class GoKart : IDragon { }
public class FamilyBike : IDragon { }
public class Car : IDragon { }
public class Motorbike : IDragon { }
public class Truck : IDragon { }
*/