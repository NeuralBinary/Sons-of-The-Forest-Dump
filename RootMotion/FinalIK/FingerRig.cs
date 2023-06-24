using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class FingerRig : SolverManager
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002D2C File Offset: 0x00000F2C
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x28FBED0", Offset = "0x28FA4D0", VA = "0x1828FBED0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x28FBF50", Offset = "0x28FA550", VA = "0x1828FBF50")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x28FC4B0", Offset = "0x28FAAB0", VA = "0x1828FC4B0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x28FC7E0", Offset = "0x28FADE0", VA = "0x1828FC7E0")]
		public void RemoveFinger(int index)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x28FC9F0", Offset = "0x28FAFF0", VA = "0x1828FC9F0")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x28FCB40", Offset = "0x28FB140", VA = "0x1828FCB40", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x28FCC40", Offset = "0x28FB240", VA = "0x1828FCC40")]
		public void UpdateFingerSolvers()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x28FCCB0", Offset = "0x28FB2B0", VA = "0x1828FCCB0")]
		public void FixFingerTransforms()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x28FCEF0", Offset = "0x28FB4F0", VA = "0x1828FCEF0")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x28FCC40", Offset = "0x28FB240", VA = "0x1828FCC40", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x28FD110", Offset = "0x28FB710", VA = "0x1828FD110", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x28FD130", Offset = "0x28FB730", VA = "0x1828FD130")]
		public FingerRig()
		{
		}

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Finger[] fingers;
	}
}
