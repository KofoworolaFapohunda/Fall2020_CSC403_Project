using System;
using System.Drawing;

namespace Fall2020_CSC403_Project.code {
  /// <summary>
  /// This is the class for an enemy
  /// </summary>
  public class Enemy : Character {
    /// <summary>
    /// THis is the image for an enemy
    /// </summary>
    public Image Img { get; set; }

    /// <summary>
    /// this is the background color for the fight form for this enemy
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initPos">this is the initial position of the enemy</param>
    /// <param name="collider">this is the collider for the enemy</param>
    public Enemy(Vector2 initPos, Collider collider) : base(initPos, collider) {
            MaxHealth = 30;
            strength = 2;
            Health = MaxHealth;
        }
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        private float strength;

        public event Action<int> AttackEvent;
        public event Action<int> HealEvent;
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
