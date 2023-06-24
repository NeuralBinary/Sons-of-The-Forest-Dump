using System;
using System.Collections;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	public class StandardSculptCurveDeformation : SculptCurveDeformation
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1FE0F10", Offset = "0x1FDF510", VA = "0x181FE0F10")]
		public StandardSculptCurveDeformation()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0000698C File Offset: 0x00004B8C
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x1FE10A0", Offset = "0x1FDF6A0", VA = "0x181FE10A0", Slot = "6")]
		public override SculptCurveDeformation.DeformInfo Apply(Frame3f vNextPos)
		{
			return default(SculptCurveDeformation.DeformInfo);
		}

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x48")]
		public Func<int, double, Vector3d> DeformF;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x50")]
		public double SmoothAlpha;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x58")]
		public int SmoothIterations;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x60")]
		public DVector<Vector3d> NewV;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x68")]
		public BitArray ModifiedV;
	}
}
