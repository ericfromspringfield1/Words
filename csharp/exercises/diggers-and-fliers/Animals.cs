using System;

namespace diggers_and_fliers
{
    public class Animals
    {
        public interface IAboveGround
{
    void Walk();
}

public interface IWater
{
    int MaximumDepth {get;}
    void Swim();
}
    }
}