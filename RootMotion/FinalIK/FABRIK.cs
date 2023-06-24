using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x290F630", Offset = "0x290DC30", VA = "0x18290F630", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x290F6C0", Offset = "0x290DCC0", VA = "0x18290F6C0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x290F750", Offset = "0x290DD50", VA = "0x18290F750")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x290F7E0", Offset = "0x290DDE0", VA = "0x18290F7E0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x290F870", Offset = "0x290DE70", VA = "0x18290F870")]
		public FABRIK()
		{
		}

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverFABRIK solver;
	}
}
