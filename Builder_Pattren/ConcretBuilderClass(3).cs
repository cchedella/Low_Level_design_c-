//Concrete class
public class ComputerBuilder : IcomputerBuilder
{
    private string _CPU;
    private string _GPU;
    private int _RAM;
    private int _Storage;

    public IcomputerBuilder SetCPU(string cpu)
    {
        _CPU=cpu;
        return this;
    }

    public IcomputerBuilder SetGPU(string gpu)
    {
        _GPU=gpu;
    }
    public IcomputerBuilder SetRAM(int ram)
    {
        _RAM = ram;
    }
    public IcomputerBuilder SetStorage(int storage)
    {
        _Storage=storage;
    }

    public computer Build()
    {
         // Validation step before creation
        if (string.IsNullOrEmpty(_CPU)) throw new InvalidOperationException("CPU is required.");
        if (_RAM <= 0) throw new InvalidOperationException("Invalid RAM configuration.");

        return new Computer(_CPU, _RAM, _Storage, _GPU);
    }
}