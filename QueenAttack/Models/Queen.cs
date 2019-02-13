using System;
namespace QueenAttack
{
  public class Queen
  {
    public bool isAttackLeagal (int attackerX, int attackerY, int defenderX, int defenderY)
    {
      if(attackerX == defenderX)
      {
        return true;
      }
      else if(attackerY == defenderY)
      {
        return true;
      }
      else if(Math.Abs(attackerY - defenderY) == Math.Abs(attackerX - defenderX))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
