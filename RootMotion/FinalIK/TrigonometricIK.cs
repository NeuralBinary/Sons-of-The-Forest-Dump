using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2912000", Offset = "0x2910600", VA = "0x182912000", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2912090", Offset = "0x2910690", VA = "0x182912090", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2912120", Offset = "0x2910720", VA = "0x182912120")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x29121B0", Offset = "0x29107B0", VA = "0x1829121B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2912240", Offset = "0x2910840", VA = "0x182912240")]
		public TrigonometricIK()
		{
		}

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverTrigonometric solver;
	}
}
