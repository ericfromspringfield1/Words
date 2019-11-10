public interface IRefuel1<T>
{
    int Capacity { get; set; }

    void Refuel(T vehicles);
}



