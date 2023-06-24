using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x28FD980", Offset = "0x28FBF80", VA = "0x1828FD980", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x28FDA10", Offset = "0x28FC010", VA = "0x1828FDA10", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x28FDAA0", Offset = "0x28FC0A0", VA = "0x1828FDAA0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x28FDB10", Offset = "0x28FC110", VA = "0x1828FDB10")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x28FDC20", Offset = "0x28FC220", VA = "0x1828FDC20")]
		private void Update()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x28FDD60", Offset = "0x28FC360", VA = "0x1828FDD60")]
		private void Initiate()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x28FE2C0", Offset = "0x28FC8C0", VA = "0x1828FE2C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x28FE320", Offset = "0x28FC920", VA = "0x1828FE320")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x28FED60", Offset = "0x28FD360", VA = "0x1828FED60")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x28FEE80", Offset = "0x28FD480", VA = "0x1828FEE80")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x28FF2C0", Offset = "0x28FD8C0", VA = "0x1828FF2C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x28FF5D0", Offset = "0x28FDBD0", VA = "0x1828FF5D0")]
		public GrounderBipedIK()
		{
		}

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion[] footRotations;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 spineOffset;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x8C")]
		private float lastWeight;
	}
}
