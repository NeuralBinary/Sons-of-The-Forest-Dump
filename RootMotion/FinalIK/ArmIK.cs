using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		// Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x290EFF0", Offset = "0x290D5F0", VA = "0x18290EFF0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x290F080", Offset = "0x290D680", VA = "0x18290F080", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x290F110", Offset = "0x290D710", VA = "0x18290F110")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x290F1A0", Offset = "0x290D7A0", VA = "0x18290F1A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x290F230", Offset = "0x290D830", VA = "0x18290F230")]
		public ArmIK()
		{
		}

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverArm solver;
	}
}
