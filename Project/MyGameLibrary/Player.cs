using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : Character {
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        private float strength;

        public event Action<int> AttackEvent;
        public event Action<int> HealEvent;
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public Image Img { get; set; }
        public Color Color { get; set; }
        public int maxExp;
        public void UpdateExp(int v)
        {
            Experience += v;
            if (Experience >= maxExp){
                Level++;
                Experience = Experience-maxExp;
                maxExp += 5;
                MaxHealth = 30 + Level * 5;
                strength = 2 + Level * 0.25f;
            }
        }
        public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
            MaxHealth = 30+Level*5;
            maxExp = 20;
            Level = 0;
            Experience = 0;
            strength = 2+Level*0.25f;
            Health = MaxHealth;
        }
        public void OnAttack(int amount)
        {
            AttackEvent((int)(amount * strength));
        }

        public void AlterHealth(int amount)
        {
            Health += amount;
            if (Health >= MaxHealth)
            {
                Health = MaxHealth;
            }
        }
        public void OnHeal(int amount)
        {
            HealEvent((int)amount);
        }
    }
}
