
using System;

namespace Characters
{
    public class Stats
    {
        public int Health { get; }
        public int Armor { get; }
        public int BlockChance { get; }
        public int Block { get; }
        public int EvasionChance { get; }
        public int Power { get; }
        public int Accuracy { get; }
        public int CriticalChance { get; }
        public int CriticalMultiplier { get; }
    }


    public interface IInterctable
    {
        void Interact();
    }

    public abstract class Interaction
    {
        public abstract System.Type ProcessorType { get; }
    }

    public class Attack : Interaction
    {
        public override Type ProcessorType => typeof(AttackProcessor);
    }


    public class AttackProcessor
    {
        public void Process(Attack interaction)
        {

        }
    }
}

