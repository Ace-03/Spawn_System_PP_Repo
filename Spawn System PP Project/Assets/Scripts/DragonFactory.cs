using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public interface IDragonFactory
{
    IDragon Create(DragonRequirements requirements);
}

public abstract class AbstractDragonFactory
{
    public abstract IDragon Create();
}

public class DragonFactory : AbstractDragonFactory
{
    private readonly IDragonFactory _factory;
    private readonly DragonRequirements _requirements;

    public DragonFactory(DragonRequirements requirements)
    {
        switch (requirements.Element)
        {
            case "Fire":
                _factory = (IDragonFactory)new FireFactory();
                break;
            case "Ice":
                _factory = (IDragonFactory)new IceFactory();
                break;
            case "Lightning":
                _factory = (IDragonFactory)new LightningFactory();
                break;
        }

        _requirements = requirements;
    }

    public class FireFactory : IDragonFactory
    {
        public IDragon Create(DragonRequirements requirements)
        {
            switch (requirements.Mark)
            {
                case "Type1":
                    return new Fire_01();
                case "Type2":
                    return new Fire_02();
                case "Type3":
                    return new Fire_03();
            }
            return new Fire_01();
        }
    }

    public class IceFactory : IDragonFactory
    {
        public IDragon Create(DragonRequirements requirements)
        {
            switch (requirements.Mark)
            {
                case "Type1":
                    return new Ice_01();
                case "Type2":
                    return new Ice_02();
                case "Type3":
                    return new Ice_03();
            }
            return new Ice_01();
        }
    }

    public class LightningFactory : IDragonFactory
    {
        public IDragon Create(DragonRequirements requirements)
        {
            switch (requirements.Mark)
            {
                case "Type1":
                    return new Lightning_01();
                case "Type2":
                    return new Lightning_02();
                case "Type3":
                    return new Lightning_03();
            }
            return new Lightning_01();
        }
    }

    public override IDragon Create()
    {
        return _factory.Create(_requirements);
    }
}