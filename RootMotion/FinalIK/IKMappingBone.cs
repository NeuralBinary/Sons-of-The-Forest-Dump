using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2929A50", Offset = "0x2928050", VA = "0x182929A50", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2929B70", Offset = "0x2928170", VA = "0x182929B70")]
		public IKMappingBone()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2929C20", Offset = "0x2928220", VA = "0x182929C20")]
		public IKMappingBone(Transform bone)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2929D40", Offset = "0x2928340", VA = "0x182929D40")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2929D60", Offset = "0x2928360", VA = "0x182929D60")]
		public void FixTransforms()
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2929DE0", Offset = "0x29283E0", VA = "0x182929DE0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2929F70", Offset = "0x2928570", VA = "0x182929F70")]
		public void ReadPose()
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2929F90", Offset = "0x2928590", VA = "0x182929F90")]
		public void WritePose(float solverWeight)
		{
		}

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x20")]
		private IKMapping.BoneMap boneMap;
	}
}
