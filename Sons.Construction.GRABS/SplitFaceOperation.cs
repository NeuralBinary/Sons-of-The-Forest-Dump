using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class SplitFaceOperation : Operation
	{
		// Token: 0x06000218 RID: 536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2DA6D10", Offset = "0x2DA5310", VA = "0x182DA6D10")]
		public void Init(InteractionPoint ip, SnapAxis splitAxis)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2DA02E0", Offset = "0x2D9E8E0", VA = "0x182DA02E0", Slot = "4")]
		public override bool Update(Transform aimTransform, out bool modifiedFace)
		{
			return default(bool);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2DA6E00", Offset = "0x2DA5400", VA = "0x182DA6E00", Slot = "5")]
		public override void Validate()
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2DA1180", Offset = "0x2D9F780", VA = "0x182DA1180")]
		public SplitFaceOperation()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2DA7770", Offset = "0x2DA5D70", VA = "0x182DA7770")]
		[CompilerGenerated]
		private void <Validate>g__GetSplitData|3_0(out Vector3 from, out Vector3 to, out int axisNum, out int preserveAxisNum)
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x28")]
		private SnapAxis _splitAxis;
	}
}
