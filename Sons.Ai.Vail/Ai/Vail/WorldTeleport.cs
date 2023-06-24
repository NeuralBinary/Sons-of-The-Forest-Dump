using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	[Serializable]
	public class WorldTeleport : WorldSimAction
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x00006C78 File Offset: 0x00004E78
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x2B8D4D0", Offset = "0x2B8BAD0", VA = "0x182B8D4D0", Slot = "4")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x2B8D4F0", Offset = "0x2B8BAF0", VA = "0x182B8D4F0", Slot = "9")]
		public override bool IsValid(VailWorldSimulation worldSim, WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x2B8D620", Offset = "0x2B8BC20", VA = "0x182B8D620", Slot = "7")]
		public override void Begin(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x2B876A0", Offset = "0x2B85CA0", VA = "0x182B876A0")]
		public WorldTeleport()
		{
		}

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private WorldTeleport.TeleportZone _toZone;

		// Token: 0x02000109 RID: 265
		[Token(Token = "0x2000109")]
		public enum TeleportZone
		{
			// Token: 0x0400081D RID: 2077
			[Token(Token = "0x400081D")]
			CaveZone,
			// Token: 0x0400081E RID: 2078
			[Token(Token = "0x400081E")]
			OutsideZone
		}
	}
}
