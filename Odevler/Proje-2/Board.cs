using System;

namespace Proje_2
{
  public class Board
  {
    private Line todo;
    private Line inProgress;
    private Line done;

    public Line Todo { get => todo; set => todo = value; }
    public Line InProgress { get => inProgress; set => inProgress = value; }
    public Line Done { get => done; set => done = value; }

    public Board()
    {
      Kart defaultKart1 = new Kart();
      Kart defaultKart2 = new Kart();  
      Kart defaultKart3 = new Kart();
    }
  }
}