using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[Serializable]
	public class WorldMoveTo : WorldSimAction
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x1700009A")]
		private bool ShouldShowNoFamilyMove
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x2B87BD0", Offset = "0x2B861D0", VA = "0x182B87BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x1700009B")]
		public bool ShouldShowDestRadius
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x2B87BF0", Offset = "0x2B861F0", VA = "0x182B87BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x1700009C")]
		protected override bool ShowStimuli
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x2B87C10", Offset = "0x2B86210", VA = "0x182B87C10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "4")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x2B87C50", Offset = "0x2B86250", VA = "0x182B87C50", Slot = "7")]
		public override void Begin(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x2B88230", Offset = "0x2B86830", VA = "0x182B88230", Slot = "9")]
		public override bool IsValid(VailWorldSimulation worldSim, WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2B88380", Offset = "0x2B86980", VA = "0x182B88380", Slot = "10")]
		public override bool IsFinished(VailWorldSimulation worldSim, WorldSimActor actor, float timeInHours)
		{
			return default(bool);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2B883F0", Offset = "0x2B869F0", VA = "0x182B883F0", Slot = "8")]
		public override void End(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2B88560", Offset = "0x2B86B60", VA = "0x182B88560")]
		public WorldMoveTo()
		{
		}

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private WorldMoveTo.DestinationType _destination;

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _snapToTerrain;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x95")]
		[SerializeField]
		private bool _familyMove;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x96")]
		[SerializeField]
		private bool _useDestRadius;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _destRadius;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private bool _avoidVillages;

		// Token: 0x020000FF RID: 255
		[Token(Token = "0x20000FF")]
		private enum DestinationType
		{
			// Token: 0x040007BD RID: 1981
			[Token(Token = "0x40007BD")]
			WanderRandom,
			// Token: 0x040007BE RID: 1982
			[Token(Token = "0x40007BE")]
			Stimuli
		}
	}
}
