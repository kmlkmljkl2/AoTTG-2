﻿using System;
using Assets.Scripts.Characters.Humans.Constants;

namespace Assets.Scripts.Characters.Humans.Skills
{
    public class ArminSkill : Skill
    {
        public ArminSkill(Hero hero) : base(hero)
        {
        }

        public override bool Use()
        {
            if (!Hero.IsGrounded())
                return false;

            Hero.AttackAnimation = HeroAnim.SPECIAL_ARMIN;
            Hero.PlayAnimation(HeroAnim.SPECIAL_ARMIN);
            return true;
        }

        public override void OnUpdate()
        {
            throw new NotImplementedException();
        }
    }
}