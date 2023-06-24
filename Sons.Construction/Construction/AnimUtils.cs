using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	internal static class AnimUtils
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2D5F280", Offset = "0x2D5D880", VA = "0x182D5F280")]
		public static GameObject GetFakeAnimInstance(GameObject originalRendererHierarchy)
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2D5F360", Offset = "0x2D5D960", VA = "0x182D5F360")]
		public static void ReturnFakeAnimInstance(GameObject animInstance)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2D5F420", Offset = "0x2D5DA20", VA = "0x182D5F420")]
		public static bool TryCopyRendererToFakeAnimInstance(GameObject original, GameObject fakeAnimInstance)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2D5FE70", Offset = "0x2D5E470", VA = "0x182D5FE70")]
		[CompilerGenerated]
		internal static bool <GetFakeAnimInstance>g__TryGetFakeAnimInstance|5_0(out GameObject fakeAnimGo)
		{
			return default(bool);
		}

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Queue<GameObject> _pool;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x8")]
		private static MaterialPropertyBlock _mtp;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int EnableSnowSparkles;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int EnableRainRipples;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int EnableSnow;
	}
}
