using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2948B50", Offset = "0x2947150", VA = "0x182948B50")]
		public void MaintainRotation()
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2948BF0", Offset = "0x29471F0", VA = "0x182948BF0")]
		public void MaintainBend()
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2948C40", Offset = "0x2947240", VA = "0x182948C40", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x29493C0", Offset = "0x29479C0", VA = "0x1829493C0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2949520", Offset = "0x2947B20", VA = "0x182949520", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x29496D0", Offset = "0x2947CD0", VA = "0x1829496D0")]
		public IKSolverLimb()
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x29497F0", Offset = "0x2947DF0", VA = "0x1829497F0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000059")]
		private IKSolverLimb.AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x2949920", Offset = "0x2947F20", VA = "0x182949920")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2949940", Offset = "0x2947F40", VA = "0x182949940")]
		private void StoreAxisDirections(ref IKSolverLimb.AxisDirection[] axisDirections)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2949F60", Offset = "0x2948560", VA = "0x182949F60")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0xAC")]
		public IKSolverLimb.BendModifier bendModifier;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x130")]
		private IKSolverLimb.AxisDirection[] axisDirectionsLeft;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x138")]
		private IKSolverLimb.AxisDirection[] axisDirectionsRight;

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000070")]
		[Serializable]
		public enum BendModifier
		{
			// Token: 0x04000319 RID: 793
			[Token(Token = "0x4000319")]
			Animation,
			// Token: 0x0400031A RID: 794
			[Token(Token = "0x400031A")]
			Target,
			// Token: 0x0400031B RID: 795
			[Token(Token = "0x400031B")]
			Parent,
			// Token: 0x0400031C RID: 796
			[Token(Token = "0x400031C")]
			Arm,
			// Token: 0x0400031D RID: 797
			[Token(Token = "0x400031D")]
			Goal
		}

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		[Serializable]
		public struct AxisDirection
		{
			// Token: 0x060003BF RID: 959 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x294B320", Offset = "0x2949920", VA = "0x18294B320")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}

			// Token: 0x0400031E RID: 798
			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			[FieldOffset(Offset = "0x18")]
			public float dot;
		}
	}
}
