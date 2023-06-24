using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class MergeAlignedFacesOperation : Operation
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2DA0200", Offset = "0x2D9E800", VA = "0x182DA0200")]
		public void Init(InteractionPoint ip)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2DA02E0", Offset = "0x2D9E8E0", VA = "0x182DA02E0", Slot = "4")]
		public override bool Update(Transform aimTransform, out bool modifiedFace)
		{
			return default(bool);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2DA02F0", Offset = "0x2D9E8F0", VA = "0x182DA02F0", Slot = "5")]
		public override void Validate()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2DA0BC0", Offset = "0x2D9F1C0", VA = "0x182DA0BC0")]
		private bool TryLookupMergeableConnectedFace(out BlueprintFace mergeableFace)
		{
			return default(bool);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2DA1180", Offset = "0x2D9F780", VA = "0x182DA1180")]
		public MergeAlignedFacesOperation()
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2DA1190", Offset = "0x2D9F790", VA = "0x182DA1190")]
		[CompilerGenerated]
		internal static bool <TryLookupMergeableConnectedFace>g__CheckFacesMatchWidth|3_0(BlueprintFace f1, BlueprintFace f2, int alignedAxisNum)
		{
			return default(bool);
		}
	}
}
