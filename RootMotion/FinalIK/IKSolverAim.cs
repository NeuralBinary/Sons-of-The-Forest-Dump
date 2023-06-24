using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		// Token: 0x06000318 RID: 792 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2931280", Offset = "0x292F880", VA = "0x182931280")]
		public float GetAngle()
		{
			return 0f;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x1700003C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2931390", Offset = "0x292F990", VA = "0x182931390")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2931470", Offset = "0x292FA70", VA = "0x182931470")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2931550", Offset = "0x292FB50", VA = "0x182931550", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2931A30", Offset = "0x2930030", VA = "0x182931A30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2932550", Offset = "0x2930B50", VA = "0x182932550")]
		private void Solve()
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2932690", Offset = "0x2930C90", VA = "0x182932690")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2932C30", Offset = "0x2931230", VA = "0x182932C30")]
		private void RotateToTarget(Vector3 targetPosition, IKSolver.Bone bone, float weight)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x2933690", Offset = "0x2931C90", VA = "0x182933690", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x29337A0", Offset = "0x2931DA0", VA = "0x1829337A0")]
		public IKSolverAim()
		{
		}

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x88")]
		public Transform transform;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0xC8")]
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0xD0")]
		private float step;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;
	}
}
