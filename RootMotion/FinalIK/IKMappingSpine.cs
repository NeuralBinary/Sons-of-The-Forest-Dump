using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x292BD30", Offset = "0x292A330", VA = "0x18292BD30", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x292C490", Offset = "0x292AA90", VA = "0x18292C490")]
		public IKMappingSpine()
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x292C750", Offset = "0x292AD50", VA = "0x18292C750")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x292CA40", Offset = "0x292B040", VA = "0x18292CA40")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x292CC00", Offset = "0x292B200", VA = "0x18292CC00")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x292CD70", Offset = "0x292B370", VA = "0x18292CD70")]
		public void FixTransforms()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x292CE00", Offset = "0x292B400", VA = "0x18292CE00", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x292DA60", Offset = "0x292C060", VA = "0x18292DA60")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x292DA90", Offset = "0x292C090", VA = "0x18292DA90")]
		public void ReadPose()
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x292DEC0", Offset = "0x292C4C0", VA = "0x18292DEC0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x292E560", Offset = "0x292CB60", VA = "0x18292E560")]
		public void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x292E6C0", Offset = "0x292CCC0", VA = "0x18292E6C0")]
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x292E810", Offset = "0x292CE10", VA = "0x18292E810")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x48")]
		private IKMapping.BoneMap[] spine;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x50")]
		private IKMapping.BoneMap leftUpperArm;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x58")]
		private IKMapping.BoneMap rightUpperArm;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x60")]
		private IKMapping.BoneMap leftThigh;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x68")]
		private IKMapping.BoneMap rightThigh;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x70")]
		private bool useFABRIK;
	}
}
