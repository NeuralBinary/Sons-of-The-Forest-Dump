using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[Serializable]
	public class RendererSection
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RendererSection()
		{
		}

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x10")]
		public Renderer _renderer;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x18")]
		public int _section;
	}
}
