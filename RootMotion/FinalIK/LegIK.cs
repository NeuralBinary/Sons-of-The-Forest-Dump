using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x29116A0", Offset = "0x290FCA0", VA = "0x1829116A0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2911730", Offset = "0x290FD30", VA = "0x182911730", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x29117C0", Offset = "0x290FDC0", VA = "0x1829117C0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2911850", Offset = "0x290FE50", VA = "0x182911850")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x29118E0", Offset = "0x290FEE0", VA = "0x1829118E0")]
		public LegIK()
		{
		}

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverLeg solver;
	}
}
