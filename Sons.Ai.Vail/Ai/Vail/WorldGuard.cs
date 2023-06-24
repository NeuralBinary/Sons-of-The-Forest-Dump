using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	[Serializable]
	public class WorldGuard : WorldSimAction
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x2B87260", Offset = "0x2B85860", VA = "0x182B87260", Slot = "4")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x2B87280", Offset = "0x2B85880", VA = "0x182B87280", Slot = "9")]
		public override bool IsValid(VailWorldSimulation worldSim, WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x2B873C0", Offset = "0x2B859C0", VA = "0x182B873C0", Slot = "7")]
		public override void Begin(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x2B87590", Offset = "0x2B85B90", VA = "0x182B87590", Slot = "8")]
		public override void End(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x2B876A0", Offset = "0x2B85CA0", VA = "0x182B876A0")]
		public WorldGuard()
		{
		}
	}
}
