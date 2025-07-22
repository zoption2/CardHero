
using System;

namespace Characters
{
    public class Stats
    {
        public int Health { get; private set; }
        public int Armor { get; private set; }
        public int BlockChance { get; private set; }
        public int Block { get; private set; }
        public int EvasionChance { get; private set; }
        public int Power { get; private set; }
        public int Accuracy { get; private set; }
        public int CriticalChance { get; private set; }
        public int CriticalMultiplier { get; private set; }

        public void AddHealth(int value)
        {

        }
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

        private readonly int _power;
        private readonly int _accuracy;
        private readonly bool _isCrit;
        public override Type ProcessorType => typeof(AttackProcessor);
        public int Value => _power;
        public bool IsCrit => _isCrit;
        public int Accuracy => _accuracy;

        public Attack(int power, int accuracy, bool isCrit)
        {

        }

    }


    public class AttackProcessor
    {
        public void Process(Attack interaction)
        {

        }
    }
}

