using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2907C60", Offset = "0x2906260", VA = "0x182907C60")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2907CF0", Offset = "0x29062F0", VA = "0x182907CF0", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2907D80", Offset = "0x2906380", VA = "0x182907D80", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2901040", Offset = "0x28FF640", VA = "0x182901040", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2907E10", Offset = "0x2906410", VA = "0x182907E10")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2907F00", Offset = "0x2906500", VA = "0x182907F00")]
		private void Update()
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2908020", Offset = "0x2906620", VA = "0x182908020")]
		private void Initiate()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x29083E0", Offset = "0x29069E0", VA = "0x1829083E0")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2908890", Offset = "0x2906E90", VA = "0x182908890")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x29089D0", Offset = "0x2906FD0", VA = "0x1829089D0")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2908FA0", Offset = "0x29075A0", VA = "0x182908FA0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x29092D0", Offset = "0x29078D0", VA = "0x1829092D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x29095D0", Offset = "0x2907BD0", VA = "0x1829095D0")]
		public GrounderVRIK()
		{
		}

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x50")]
		private Transform[] feet;
	}
}
