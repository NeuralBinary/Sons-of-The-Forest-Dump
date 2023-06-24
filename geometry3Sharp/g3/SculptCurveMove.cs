using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public class SculptCurveMove : StandardSculptCurveDeformation
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1FE1D70", Offset = "0x1FE0370", VA = "0x181FE1D70")]
		public SculptCurveMove()
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000069A4 File Offset: 0x00004BA4
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1FE1D90", Offset = "0x1FE0390", VA = "0x181FE1D90", Slot = "6")]
		public override SculptCurveDeformation.DeformInfo Apply(Frame3f vNextPos)
		{
			return default(SculptCurveDeformation.DeformInfo);
		}
	}
}
