using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	public abstract class ObiExternalForce : MonoBehaviour
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x27F4F60", Offset = "0x27F3560", VA = "0x1827F4F60")]
		public void OnEnable()
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x27F50D0", Offset = "0x27F36D0", VA = "0x1827F50D0")]
		public void OnDisable()
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x27F5240", Offset = "0x27F3840", VA = "0x1827F5240")]
		private void Solver_OnStepBegin(ObiSolver solver, float stepTime)
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x27F5440", Offset = "0x27F3A40", VA = "0x1827F5440")]
		protected float GetTurbulence(float turbulenceIntensity)
		{
			return 0f;
		}

		// Token: 0x060008A7 RID: 2215
		[Token(Token = "0x60008A7")]
		public abstract void ApplyForcesToActor(ObiActor actor);

		// Token: 0x060008A8 RID: 2216 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
		protected ObiExternalForce()
		{
		}

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x20")]
		public float intensity;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x24")]
		public float turbulence;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x28")]
		public float turbulenceFrequency;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x2C")]
		public float turbulenceSeed;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x30")]
		public ObiSolver[] affectedSolvers;
	}
}
