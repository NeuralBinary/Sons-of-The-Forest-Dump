using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2911CE0", Offset = "0x29102E0", VA = "0x182911CE0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2911D70", Offset = "0x2910370", VA = "0x182911D70", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2911E00", Offset = "0x2910400", VA = "0x182911E00")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2911E90", Offset = "0x2910490", VA = "0x182911E90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2911F20", Offset = "0x2910520", VA = "0x182911F20")]
		public LookAtIK()
		{
		}

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverLookAt solver;
	}
}
