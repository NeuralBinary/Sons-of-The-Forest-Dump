using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x290FD00", Offset = "0x290E300", VA = "0x18290FD00", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x290FD90", Offset = "0x290E390", VA = "0x18290FD90", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x290FE20", Offset = "0x290E420", VA = "0x18290FE20")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x290FEB0", Offset = "0x290E4B0", VA = "0x18290FEB0")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x290FF40", Offset = "0x290E540", VA = "0x18290FF40")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x290FFD0", Offset = "0x290E5D0", VA = "0x18290FFD0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2910060", Offset = "0x290E660", VA = "0x182910060")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x29100F0", Offset = "0x290E6F0", VA = "0x1829100F0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2910510", Offset = "0x290EB10", VA = "0x182910510")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2910D30", Offset = "0x290F330", VA = "0x182910D30")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2910DB0", Offset = "0x290F3B0", VA = "0x182910DB0")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2910F70", Offset = "0x290F570", VA = "0x182910F70")]
		public FullBodyBipedIK()
		{
		}

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x40")]
		public BipedReferences references;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x48")]
		public IKSolverFullBodyBiped solver;
	}
}
