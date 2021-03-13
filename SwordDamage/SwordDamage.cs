using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamage
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int roll;
        public decimal magicMultiplier = 1m;
        public int flamingDamage = 0;
        public int damage;


        public void CalculateDamage()
        {
            damage = (int)(roll * magicMultiplier) + BASE_DAMAGE + flamingDamage;
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                magicMultiplier = 1.75m;
            }
            else
            {
                magicMultiplier = 1m;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                damage += FLAME_DAMAGE;
            }
        }

    }
}
