using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000648 RID: 1608
	[Token(Token = "0x2000648")]
	[Serializable]
	public class MutantFootstepMaterial
	{
		// Token: 0x0600295A RID: 10586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295A")]
		[Address(RVA = "0x2DD3D50", Offset = "0x2DD2D50", VA = "0x182DD3D50")]
		public MutantFootstepMaterial(string inDefaultDefaultPrefix)
		{
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x2DD3A70", Offset = "0x2DD2A70", VA = "0x182DD3A70")]
		public void SetToDefaults(string prefixStep)
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x2DD36B0", Offset = "0x2DD26B0", VA = "0x182DD36B0")]
		public string GetEvent(FootstepManager.SoundType type)
		{
			return null;
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x2DD38A0", Offset = "0x2DD28A0", VA = "0x182DD38A0")]
		public void PreloadEvents()
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x2DD3BA0", Offset = "0x2DD2BA0", VA = "0x182DD3BA0")]
		public void UnloadEvents()
		{
		}

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x10")]
		[EventRef]
		public string SneakEvent;

		// Token: 0x040024EA RID: 9450
		[Token(Token = "0x40024EA")]
		[FieldOffset(Offset = "0x18")]
		[EventRef]
		public string WalkEvent;

		// Token: 0x040024EB RID: 9451
		[Token(Token = "0x40024EB")]
		[FieldOffset(Offset = "0x20")]
		[EventRef]
		public string RunEvent;

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		public string LandEvent;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public string DefaultPrefix;
	}
}
