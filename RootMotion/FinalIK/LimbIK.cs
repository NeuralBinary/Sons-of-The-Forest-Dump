using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x29119C0", Offset = "0x290FFC0", VA = "0x1829119C0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2911A50", Offset = "0x2910050", VA = "0x182911A50", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2911AE0", Offset = "0x29100E0", VA = "0x182911AE0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2911B70", Offset = "0x2910170", VA = "0x182911B70")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2911C00", Offset = "0x2910200", VA = "0x182911C00")]
		public LimbIK()
		{
		}

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverLimb solver;
	}
}
