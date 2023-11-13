using System.Collections.Generic;
using UnityEngine;

namespace Core.Characters
{
    public interface ICharacter
    {
        public CharacterType CharacterType { get; }
        public DamageType DamageType { set; get; }
        public float Health { get; set; }
        public float Damage { get; set; }
        public float DamageSpeed { get; set; }
        public float MovementSpeed { get; set; }
        public float TimeLastDamage { get; set; }
        public int KillReward { get; set; }
        public int WeightCharacters { get; set; }
        public CharacterView View { get; set; }
        public List<ICharacter> Targets { get; set; }
        public Vector3 Position { get; set; }
        public ICharacter CurrentTarget { get; set; }

        public void TakeDamage(float value);
        public void Move();
        public void Init(CharacterConfig config);

        public bool CanAttack();
        public bool IsCooldown();
        public bool IsNearTarget();

        public ICharacter FindTarget();
    }
    
    public enum CharacterType
    {
        Fist = 0,
        Stick = 1,
        Cudgel = 2,
        Hammer = 3,
        Shovel = 4,
        Knife = 5,
        TwoKnives = 6,
        Dagger = 7,
        TwoDaggers = 8,
        Mace = 9,
        Saber = 10,
        TwoAxes = 11,
        Spear = 12,
        Sword = 13,
        BigAx = 14,
        BigSword = 15,
        BluePick,
        BlueSword,
        
        SlingshotRange,
        BigSlingshotRange,
        AxeRange,
        SpearRange,
        LittleBowRange,
        BigBowRange,
        CrossbowRange,
        MagicBallRange,
        BigMagicBallRange,
        MagicWandRange,
        BadStaffRange,
        MediumStaffRange,
        GoodStaffRange,
        StaffAndOrbRange,
        FireRange,
        BlueFireRange,
        BowGoldCharacter,
        BowIronCharacter,
        
        FirstCharacterBoss,
        SecondCharacterBoss,
        ThirdCharacterBoss,
        FourthCharacterBoss,
        FifthBossCharacter,
        SixthBossCharacter,
        SeventhBossCharacter,
        EighthBossCharacter
        
    }

    public enum DamageType
    {
        Melee = 0,
        Range = 1
    }
}
