public Interface IcomputerBuilder
{
  IcomputerBuilder SetCPU(string cpu);
  IcomputerBuilder SetGPU(string gpu);
  IcomputerBuilder SetRAM(int RAM);
  IcomputerBuilder SetStorage(int Storage);
  Computer Build();
}