class program
{
    static void Main(string[] args)
    {
        IcomputerBuilder builder = new ComputerBuilder();
        Computer computer = builder.SetCPU("Intel i7")
                                   .SetGPU("NVIDIA RTX 3080")
                                   .SetRAM(16)
                                   .SetStorage(512)
                                   .Build();

        computer.DisplayConfiguration();
        Console.WriteLine($"Computer Specs: CPU: {computer.CPU}, GPU: {computer.GPU}, RAM: {computer.RAM}GB, Storage: {computer.Storage}GB");
    }
}