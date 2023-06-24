using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x290F950", Offset = "0x290DF50", VA = "0x18290F950", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x290F9E0", Offset = "0x290DFE0", VA = "0x18290F9E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x290FA70", Offset = "0x290E070", VA = "0x18290FA70")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x290FB00", Offset = "0x290E100", VA = "0x18290FB00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x290FB90", Offset = "0x290E190", VA = "0x18290FB90")]
		public FABRIKRoot()
		{
		}

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverFABRIKRoot solver;
	}
}
