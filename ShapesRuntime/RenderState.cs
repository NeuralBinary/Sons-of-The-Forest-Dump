using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Shapes
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	internal struct RenderState : IEquatable<RenderState>
	{
		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x2A48CF0", Offset = "0x2A472F0", VA = "0x182A48CF0")]
		public RenderState(Material mat)
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x2A49180", Offset = "0x2A47780", VA = "0x182A49180")]
		public Material CreateMaterial()
		{
			return null;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x2A49460", Offset = "0x2A47A60", VA = "0x182A49460")]
		private static bool StrArrEquals(string[] a, string[] b)
		{
			return default(bool);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x2A49500", Offset = "0x2A47B00", VA = "0x182A49500", Slot = "4")]
		public bool Equals(RenderState other)
		{
			return default(bool);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x2A496C0", Offset = "0x2A47CC0", VA = "0x182A496C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x2A49770", Offset = "0x2A47D70", VA = "0x182A49770", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x0")]
		public Shader shader;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x8")]
		public string[] keywords;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x10")]
		public CompareFunction zTest;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x14")]
		public float zOffsetFactor;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x18")]
		public int zOffsetUnits;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x1C")]
		public CompareFunction stencilComp;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x20")]
		public StencilOp stencilOpPass;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x24")]
		public byte stencilRefID;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x25")]
		public byte stencilReadMask;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x26")]
		public byte stencilWriteMask;
	}
}
