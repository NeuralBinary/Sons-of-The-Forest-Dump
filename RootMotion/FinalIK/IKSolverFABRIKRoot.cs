using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		// Token: 0x0600034D RID: 845 RVA: 0x00003644 File Offset: 0x00001844
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x293AF30", Offset = "0x2939530", VA = "0x18293AF30", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x293B7C0", Offset = "0x2939DC0", VA = "0x18293B7C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x293B8C0", Offset = "0x2939EC0", VA = "0x18293B8C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x293B9C0", Offset = "0x2939FC0", VA = "0x18293B9C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000365C File Offset: 0x0000185C
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x293BBD0", Offset = "0x293A1D0", VA = "0x18293BBD0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x293BC60", Offset = "0x293A260", VA = "0x18293BC60", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x293BEB0", Offset = "0x293A4B0", VA = "0x18293BEB0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x293BF60", Offset = "0x293A560", VA = "0x18293BF60", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x293C010", Offset = "0x293A610", VA = "0x18293C010")]
		private void AddPointsToArray(ref IKSolver.Point[] array, FABRIKChain chain)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003674 File Offset: 0x00001874
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x293C230", Offset = "0x293A830", VA = "0x18293C230")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x293C610", Offset = "0x293AC10", VA = "0x18293C610")]
		public IKSolverFABRIKRoot()
		{
		}

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x58")]
		public int iterations;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;
	}
}
