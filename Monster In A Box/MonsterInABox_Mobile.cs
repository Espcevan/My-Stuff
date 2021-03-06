using System;
using Server;


namespace Server.Mobiles
{
    public class MonsterInABox_Mobile : BaseCreature
    {
		[Constructable]
		public MonsterInABox_Mobile( 
			string name, 
			int BodyValue,
			int Hue,
			int StrMin, int StrMax,
			int DexMin, int DexMax,
			int IntMin, int IntMax, 
			int Hits,
			int Stam,
			int Mana,
			int Fame,
			int Karma,
			int Damage,
			int DmgPhy, int DmgFire, int DmgCold, int DmgPoison, int DmgEnergy,
			int ResPhy, int ResFire, int ResCold, int ResPoison, int ResEnergy,
			AIType ai,
			int VirtualArmor,
			
			//AIType ai,
            FightMode mode, 
			int RangePerception, 
			int RangeFight,
            double ActiveSpeed, 
			double PassiveSpeed 
		)
		: base( AIType.AI_Melee,FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{
			AI = ai;
			FightMode = mode;
			RangePerception = RangePerception;
			RangeFight = RangeFight;
			ActiveSpeed = ActiveSpeed;
			PassiveSpeed = PassiveSpeed;
			
			Body = BodyValue;
			Name = name;
			Hue = Hue;
			
			SetStr(  StrMin, StrMax );
			SetDex( DexMin, DexMax );
            SetInt( IntMin, IntMax );
			SetHits( Hits );
			SetStam( Stam );
			SetMana( Mana );

            SetDamage( Damage );
			
			SetDamageType(ResistanceType.Physical, DmgPhy);
            SetDamageType(ResistanceType.Fire, DmgFire);
			SetDamageType(ResistanceType.Cold, DmgCold);
            SetDamageType(ResistanceType.Poison, DmgPoison);
			SetDamageType(ResistanceType.Energy, DmgEnergy);
			
			SetResistance(ResistanceType.Physical, ResPhy);
            SetResistance(ResistanceType.Fire, ResFire);
            SetResistance(ResistanceType.Cold, ResCold);
            SetResistance(ResistanceType.Poison, ResPoison);
            SetResistance(ResistanceType.Energy, ResEnergy);
			
			VirtualArmor = VirtualArmor;
			CorpseNameOverride = "test";
		}

        
        public MonsterInABox_Mobile(Serial serial) : base(serial){}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
		}

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
		}
    }
}