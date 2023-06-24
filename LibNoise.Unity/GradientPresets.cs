using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LibNoise
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class GradientPresets
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public static Gradient Empty
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x207B750", Offset = "0x2079D50", VA = "0x18207B750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000002")]
		public static Gradient Grayscale
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x207B7A0", Offset = "0x2079DA0", VA = "0x18207B7A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000003")]
		public static Gradient RGB
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x207B7F0", Offset = "0x2079DF0", VA = "0x18207B7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000004")]
		public static Gradient RGBA
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x207B840", Offset = "0x2079E40", VA = "0x18207B840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000005")]
		public static Gradient Terrain
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x207B890", Offset = "0x2079E90", VA = "0x18207B890")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Gradient _empty;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Gradient _grayscale;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Gradient _rgb;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Gradient _rgba;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Gradient _terrain;
	}
}
