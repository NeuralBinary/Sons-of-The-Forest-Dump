using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x290F310", Offset = "0x290D910", VA = "0x18290F310", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x290F3A0", Offset = "0x290D9A0", VA = "0x18290F3A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x290F430", Offset = "0x290DA30", VA = "0x18290F430")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x290F4C0", Offset = "0x290DAC0", VA = "0x18290F4C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x290F550", Offset = "0x290DB50", VA = "0x18290F550")]
		public CCDIK()
		{
		}

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverCCD solver;
	}
}
