using System.Collections.Generic;

public interface ICommando
{
    Dictionary<string,string> Missions { get; }
    void CompleteMission();
}
