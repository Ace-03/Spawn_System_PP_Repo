using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public interface IVehicleFactory
{
    IDragon Create(VehicleRequirements requirements);
}

public abstract class AbstractVehicleFactory
{
    public abstract IDragon Create();
}

public class VehicleFactory : AbstractVehicleFactory
{
    private readonly IVehicleFactory _factory;
    private readonly VehicleRequirements _requirements;

    public VehicleFactory(VehicleRequirements requirements)
    {
        //_factory = requirements.Engine ? (IVehicleFactory)new MotorVehicleFactory() : new CycleFactory();

        switch (requirements.Element)
        {
            case "Fire":
                _factory = (IVehicleFactory)new FireFactory();
                break;
            case "Ice":
                _factory = (IVehicleFactory)new IceFactory();
                break;
            case "Lightning":
                _factory = (IVehicleFactory)new LightningFactory();
                break;
        }

        _requirements = requirements;
    }

    public class FireFactory : IVehicleFactory
    {
        public IDragon Create(VehicleRequirements requirements)
        {
            switch (requirements.Mark)
            {
                case "Circle":
                    return new Fire1();
                case "Square":
                    return new Fire2();
            }
            return new Fire1();
        }
    }

    public class IceFactory : IVehicleFactory
    {
        public IDragon Create(VehicleRequirements requirements)
        {
            switch (requirements.Mark)
            {
                case "Circle":
                    return new Ice1();
                case "Square":
                    return new Ice2();
            }
            return new Ice1();
        }
    }

    public class LightningFactory : IVehicleFactory
    {
        public IDragon Create(VehicleRequirements requirements)
        {
            switch (requirements.Mark)
            {
                case "Circle":
                    return new Lightning1();
                case "Square":
                    return new Lightning2();
            }
            return new Lightning1();
        }
    }

    public override IDragon Create()
    {
        return _factory.Create(_requirements);
    }


    /*
    public class CycleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleRequirements requirements)
        {
            switch (requirements.NumberOfLegs)
            {
                case 1:
                    if (requirements.NumberOfWings == 1) return new Unicycle();
                    return new Bicycle();
                default:
                    return new Bicycle();
            }
        }
    }

    public class MotorVehicleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleRequirements requirements)
        {
            switch (requirements.NumberOfLegs)
            {
                case 1:
                    return new Motorbike();
                default:
                    return new Truck();
            }
        }
    }
    */
}