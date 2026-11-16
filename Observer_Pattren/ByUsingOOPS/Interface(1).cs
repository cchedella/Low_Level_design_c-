using system;
using system.Collections.Generic;

// The Observer interface(The Contract)

public interface Iinvestor
{
    void update(string symbol,decimal price);
}

//The subject interface

public interface IstockExchange
{
    void registerInvestor(Iinvestor investor);
    void removeInvestor(Iinvestor investor);
    void notifyInvestors(Iinvestor investor);
}