using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		// Token: 0x06000334 RID: 820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2936E80", Offset = "0x2935480", VA = "0x182936E80")]
		public void SolveForward(Vector3 position)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2936F30", Offset = "0x2935530", VA = "0x182936F30")]
		public void SolveBackward(Vector3 position)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000035B4 File Offset: 0x000017B4
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2936FE0", Offset = "0x29355E0", VA = "0x182936FE0", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2937130", Offset = "0x2935730", VA = "0x182937130", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x29376F0", Offset = "0x2935CF0", VA = "0x1829376F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x17000040")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2937BD0", Offset = "0x29361D0", VA = "0x182937BD0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2937D50", Offset = "0x2936350", VA = "0x182937D50")]
		private void OnPreSolve()
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2938480", Offset = "0x2936A80", VA = "0x182938480")]
		private void OnPostSolve()
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2938650", Offset = "0x2936C50", VA = "0x182938650")]
		private void Solve(Vector3 targetPosition)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2938730", Offset = "0x2936D30", VA = "0x182938730")]
		private void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x29389B0", Offset = "0x2936FB0", VA = "0x1829389B0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2938A80", Offset = "0x2937080", VA = "0x182938A80")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2938C70", Offset = "0x2937270", VA = "0x182938C70")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2938E40", Offset = "0x2937440", VA = "0x182938E40")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2939000", Offset = "0x2937600", VA = "0x182939000")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2939290", Offset = "0x2937890", VA = "0x182939290")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000362C File Offset: 0x0000182C
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2939540", Offset = "0x2937B40", VA = "0x182939540")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2939820", Offset = "0x2937E20", VA = "0x182939820")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2939F80", Offset = "0x2938580", VA = "0x182939F80")]
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x293A0F0", Offset = "0x29386F0", VA = "0x18293A0F0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x293A230", Offset = "0x2938830", VA = "0x18293A230")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x293AAB0", Offset = "0x29390B0", VA = "0x18293AAB0")]
		private void MapToSolverPositions()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x293AC90", Offset = "0x2939290", VA = "0x18293AC90")]
		private void MapToSolverPositionsLimited()
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x293AE10", Offset = "0x2939410", VA = "0x18293AE10")]
		public IKSolverFABRIK()
		{
		}

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;
	}
}
