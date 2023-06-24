using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		// Token: 0x06000323 RID: 803 RVA: 0x00003584 File Offset: 0x00001784
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2933850", Offset = "0x2931E50", VA = "0x182933850", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2933EF0", Offset = "0x29324F0", VA = "0x182933EF0")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2934110", Offset = "0x2932710", VA = "0x182934110", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x29342C0", Offset = "0x29328C0", VA = "0x1829342C0", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2934790", Offset = "0x2932D90", VA = "0x182934790", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x29347F0", Offset = "0x2932DF0", VA = "0x1829347F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2934860", Offset = "0x2932E60", VA = "0x182934860", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2934980", Offset = "0x2932F80", VA = "0x182934980", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2934A20", Offset = "0x2933020", VA = "0x182934A20")]
		private void Solve()
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2934AB0", Offset = "0x29330B0", VA = "0x182934AB0")]
		private void Read()
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x29352E0", Offset = "0x29338E0", VA = "0x1829352E0")]
		private void Write()
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2935680", Offset = "0x2933C80", VA = "0x182935680")]
		public IKSolverArm()
		{
		}

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x70")]
		public IKSolver.Point chest;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x78")]
		public IKSolver.Point shoulder;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x80")]
		public IKSolver.Point upperArm;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.Point forearm;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.Point hand;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x98")]
		public bool isLeft;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;
	}
}
