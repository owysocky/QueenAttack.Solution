using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;
using System;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
   public void isAttackLeagal_AttackHorizontal_True()
   {
     Queen testQueen = new Queen();
     Assert.AreEqual(true, testQueen.isAttackLeagal(2,1,2,5));
   }
   [TestMethod]
  public void isAttackLeagal_AttackVertrical_True()
  {
    Queen testQueen = new Queen();
    Assert.AreEqual(true, testQueen.isAttackLeagal(5,1,2,1));
  }
  [TestMethod]
 public void isAttackLeagal_AttackDiagonal_True()
 {
   Queen testQueen = new Queen();
   Assert.AreEqual(true, testQueen.isAttackLeagal(5,5,4,4));
 }
  }
}
