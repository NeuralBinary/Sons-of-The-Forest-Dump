using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		// Token: 0x060002CF RID: 719 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2929FC0", Offset = "0x29285C0", VA = "0x182929FC0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x292A060", Offset = "0x2928660", VA = "0x18292A060")]
		public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap)
		{
			return null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x292A180", Offset = "0x2928780", VA = "0x18292A180")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x292AAA0", Offset = "0x29290A0", VA = "0x18292AAA0")]
		public IKMappingLimb()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x292ACF0", Offset = "0x29292F0", VA = "0x18292ACF0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x292AF80", Offset = "0x2929580", VA = "0x18292AF80")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x292B0F0", Offset = "0x29296F0", VA = "0x18292B0F0")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x292B1F0", Offset = "0x29297F0", VA = "0x18292B1F0")]
		public void FixTransforms()
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x292B400", Offset = "0x2929A00", VA = "0x18292B400", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x292BA80", Offset = "0x292A080", VA = "0x18292BA80")]
		public void ReadPose()
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x292BB00", Offset = "0x292A100", VA = "0x18292BB00")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public bool updatePlaneRotations;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IKMapping.BoneMap boneMapParent;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IKMapping.BoneMap boneMap1;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKMapping.BoneMap boneMap2;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKMapping.BoneMap boneMap3;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		[Serializable]
		public enum BoneMapType
		{
			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			Parent,
			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			Bone1,
			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			Bone2,
			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			Bone3
		}
	}
}
