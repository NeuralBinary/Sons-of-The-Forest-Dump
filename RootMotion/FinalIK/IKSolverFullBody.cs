using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		// Token: 0x06000358 RID: 856 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x293C6B0", Offset = "0x293ACB0", VA = "0x18293C6B0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x293C850", Offset = "0x293AE50", VA = "0x18293C850")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000368C File Offset: 0x0000188C
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x293C8A0", Offset = "0x293AEA0", VA = "0x18293C8A0")]
		public int GetChainIndex(Transform transform)
		{
			return 0;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x293CA80", Offset = "0x293B080", VA = "0x18293CA80")]
		public IKSolver.Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x293CAD0", Offset = "0x293B0D0", VA = "0x18293CAD0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x293CCB0", Offset = "0x293B2B0", VA = "0x18293CCB0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x293CE60", Offset = "0x293B460", VA = "0x18293CE60", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000036A4 File Offset: 0x000018A4
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x293D070", Offset = "0x293B670", VA = "0x18293D070", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x293D350", Offset = "0x293B950", VA = "0x18293D350", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x293D5C0", Offset = "0x293BBC0", VA = "0x18293D5C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x293D7C0", Offset = "0x293BDC0", VA = "0x18293D7C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x293D950", Offset = "0x293BF50", VA = "0x18293D950", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x293DB50", Offset = "0x293C150", VA = "0x18293DB50", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x293E1E0", Offset = "0x293C7E0", VA = "0x18293E1E0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x293E540", Offset = "0x293CB40", VA = "0x18293E540", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x293E580", Offset = "0x293CB80", VA = "0x18293E580", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x293E6B0", Offset = "0x293CCB0", VA = "0x18293E6B0")]
		public IKSolverFullBody()
		{
		}

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPreRead;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x98")]
		public IKSolver.UpdateDelegate OnPreSolve;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0xA0")]
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0xA8")]
		public IKSolver.IterationDelegate OnPostIteration;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0xB0")]
		public IKSolver.UpdateDelegate OnPreBend;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0xB8")]
		public IKSolver.UpdateDelegate OnPostSolve;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0xC0")]
		public IKSolver.UpdateDelegate OnStoreDefaultLocalState;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0xC8")]
		public IKSolver.UpdateDelegate OnFixTransforms;
	}
}
