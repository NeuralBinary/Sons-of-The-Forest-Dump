using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000766 RID: 1894
	[Token(Token = "0x2000766")]
	[Serializable]
	public class MutantFootstepMaterial
	{
		// Token: 0x0600333D RID: 13117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333D")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
		public MutantFootstepMaterial(string inDefaultDefaultPrefix)
		{
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333E")]
		[Address(RVA = "0x34B3FB0", Offset = "0x34B25B0", VA = "0x1834B3FB0")]
		public void SetToDefaults(string prefixStep)
		{
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333F")]
		[Address(RVA = "0x34B4200", Offset = "0x34B2800", VA = "0x1834B4200")]
		public string GetEvent(FootstepManager.SoundType type)
		{
			return null;
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003340")]
		[Address(RVA = "0x34B4290", Offset = "0x34B2890", VA = "0x1834B4290")]
		public void PreloadEvents()
		{
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003341")]
		[Address(RVA = "0x34B43C0", Offset = "0x34B29C0", VA = "0x1834B43C0")]
		public void UnloadEvents()
		{
		}

		// Token: 0x04002C2F RID: 11311
		[Token(Token = "0x4002C2F")]
		[FieldOffset(Offset = "0x10")]
		[EventRef]
		public string SneakEvent;

		// Token: 0x04002C30 RID: 11312
		[Token(Token = "0x4002C30")]
		[FieldOffset(Offset = "0x18")]
		[EventRef]
		public string WalkEvent;

		// Token: 0x04002C31 RID: 11313
		[Token(Token = "0x4002C31")]
		[FieldOffset(Offset = "0x20")]
		[EventRef]
		public string RunEvent;

		// Token: 0x04002C32 RID: 11314
		[Token(Token = "0x4002C32")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		public string LandEvent;

		// Token: 0x04002C33 RID: 11315
		[Token(Token = "0x4002C33")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public string DefaultPrefix;
	}
}
