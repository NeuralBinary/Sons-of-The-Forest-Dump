using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public class SolverManager : MonoBehaviour
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x28F43F0", Offset = "0x28F29F0", VA = "0x1828F43F0")]
		public void Disable()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x28F44E0", Offset = "0x28F2AE0", VA = "0x1828F44E0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x28F4570", Offset = "0x28F2B70", VA = "0x1828F4570")]
		private void Start()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x28F4580", Offset = "0x28F2B80", VA = "0x1828F4580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x28F4780", Offset = "0x28F2D80", VA = "0x1828F4780")]
		private void Initiate()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x28F4800", Offset = "0x28F2E00", VA = "0x1828F4800")]
		private void Update()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x28F4840", Offset = "0x28F2E40", VA = "0x1828F4840")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x28F4BF0", Offset = "0x28F31F0", VA = "0x1828F4BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x28F4D50", Offset = "0x28F3350", VA = "0x1828F4D50")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x28F4DA0", Offset = "0x28F33A0", VA = "0x1828F4DA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x28F4DF0", Offset = "0x28F33F0", VA = "0x1828F4DF0")]
		public void UpdateSolverExternal()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public SolverManager()
		{
		}

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x28")]
		private Animator animator;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x30")]
		private Animation legacy;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x38")]
		private bool updateFrame;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x39")]
		private bool componentInitiated;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x3A")]
		private bool skipSolverUpdate;
	}
}
