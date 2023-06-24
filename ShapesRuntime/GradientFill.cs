using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Serializable]
	public struct GradientFill
	{
		// Token: 0x06000BD8 RID: 3032 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x2A481F0", Offset = "0x2A467F0", VA = "0x182A481F0")]
		public static GradientFill Linear(Vector3 start, Vector3 end, Color colorStart, Color colorEnd, FillSpace space = FillSpace.Local)
		{
			return default(GradientFill);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x2A482D0", Offset = "0x2A468D0", VA = "0x182A482D0")]
		public static GradientFill Radial(Vector3 origin, float radius, Color colorInner, Color colorOuter, FillSpace space = FillSpace.Local)
		{
			return default(GradientFill);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x2A483C0", Offset = "0x2A469C0", VA = "0x182A483C0")]
		internal Vector4 GetShaderStartVector()
		{
			return default(Vector4);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x2A48430", Offset = "0x2A46A30", VA = "0x182A48430")]
		internal int GetShaderFillTypeInt(bool use)
		{
			return 0;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x2A48440", Offset = "0x2A46A40", VA = "0x182A48440")]
		[Obsolete("Use GradientFill.Linear instead", true)]
		public static GradientFill CreateLinear(Vector3 start, Vector3 end, Color colorStart, Color colorEnd, FillSpace space)
		{
			return default(GradientFill);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x2A48440", Offset = "0x2A46A40", VA = "0x182A48440")]
		[Obsolete("Use GradientFill.Radial instead", true)]
		public static GradientFill CreateRadial(Vector3 origin, float radius, Color colorInner, Color colorOuter, FillSpace space)
		{
			return default(GradientFill);
		}

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		internal const int FILL_NONE = -1;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GradientFill defaultFill;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x0")]
		public FillType type;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x4")]
		public FillSpace space;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x8")]
		public Color colorStart;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x18")]
		public Color colorEnd;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 linearStart;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 linearEnd;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 radialOrigin;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x4C")]
		public float radialRadius;
	}
}
