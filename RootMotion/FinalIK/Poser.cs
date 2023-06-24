using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public abstract class Poser : SolverManager
	{
		// Token: 0x0600054E RID: 1358
		[Token(Token = "0x600054E")]
		public abstract void AutoMapping();

		// Token: 0x0600054F RID: 1359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x26E1890", Offset = "0x26DFE90", VA = "0x1826E1890")]
		public void UpdateManual()
		{
		}

		// Token: 0x06000550 RID: 1360
		[Token(Token = "0x6000550")]
		protected abstract void InitiatePoser();

		// Token: 0x06000551 RID: 1361
		[Token(Token = "0x6000551")]
		protected abstract void UpdatePoser();

		// Token: 0x06000552 RID: 1362
		[Token(Token = "0x6000552")]
		protected abstract void FixPoserTransforms();

		// Token: 0x06000553 RID: 1363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2983CE0", Offset = "0x29822E0", VA = "0x182983CE0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x2983D30", Offset = "0x2982330", VA = "0x182983D30", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2983D60", Offset = "0x2982360", VA = "0x182983D60", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x29828C0", Offset = "0x2980EC0", VA = "0x1829828C0")]
		protected Poser()
		{
		}

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x40")]
		public Transform poseRoot;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x54")]
		private bool initiated;
	}
}
