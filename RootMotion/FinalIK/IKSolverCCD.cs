using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		// Token: 0x0600032F RID: 815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2935B70", Offset = "0x2934170", VA = "0x182935B70")]
		public void FadeOutBoneWeights()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2935C00", Offset = "0x2934200", VA = "0x182935C00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2935D40", Offset = "0x2934340", VA = "0x182935D40", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2936230", Offset = "0x2934830", VA = "0x182936230")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2936E70", Offset = "0x2935470", VA = "0x182936E70")]
		public IKSolverCCD()
		{
		}

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.IterationDelegate OnPreIteration;
	}
}
