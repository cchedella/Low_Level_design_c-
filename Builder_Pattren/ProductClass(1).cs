using system;
using system.Collections.Generic;

//The target product (complex object we want to build)

public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }

    //constructor is internal/private so that we can intiate onl via the builder class

    internal computer(string cpu,string gpu,string ram,string storage)
    {
        this.CPU = cpu;
        this.GPU = gpu;
        this.RAM = ram;
        this.Storage = storage;
    }

    public void DisplayConfiguration()
    {
        Console.WriteLine($"Computer configuration : CPU :{CPU},RAM:{RAM},GPU;{GPU},Storage :{Storage}");
    }
}

