using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x290EC40", Offset = "0x290D240", VA = "0x18290EC40", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x290ECD0", Offset = "0x290D2D0", VA = "0x18290ECD0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x290ED60", Offset = "0x290D360", VA = "0x18290ED60")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x290EDF0", Offset = "0x290D3F0", VA = "0x18290EDF0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x290EE80", Offset = "0x290D480", VA = "0x18290EE80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x290EF10", Offset = "0x290D510", VA = "0x18290EF10")]
		public AimIK()
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverAim solver;
	}
}
