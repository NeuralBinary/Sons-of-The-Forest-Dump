using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2912320", Offset = "0x2910920", VA = "0x182912320", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x29123B0", Offset = "0x29109B0", VA = "0x1829123B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2912440", Offset = "0x2910A40", VA = "0x182912440")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x29124D0", Offset = "0x2910AD0", VA = "0x1829124D0")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2912530", Offset = "0x2910B30", VA = "0x182912530")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2912560", Offset = "0x2910B60", VA = "0x182912560", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x29126B0", Offset = "0x2910CB0", VA = "0x1829126B0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2912990", Offset = "0x2910F90", VA = "0x182912990")]
		public VRIK()
		{
		}

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public VRIK.References references;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		[Serializable]
		public class References
		{
			// Token: 0x06000250 RID: 592 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2912AE0", Offset = "0x29110E0", VA = "0x182912AE0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x06000251 RID: 593 RVA: 0x0000314C File Offset: 0x0000134C
			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x29130F0", Offset = "0x29116F0", VA = "0x1829130F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000252 RID: 594 RVA: 0x00003164 File Offset: 0x00001364
			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000252")]
				[Address(RVA = "0x2913A80", Offset = "0x2912080", VA = "0x182913A80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000253 RID: 595 RVA: 0x0000317C File Offset: 0x0000137C
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x29143E0", Offset = "0x29129E0", VA = "0x1829143E0")]
			public static bool AutoDetectReferences(Transform root, out VRIK.References references)
			{
				return default(bool);
			}

			// Token: 0x06000254 RID: 596 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public References()
			{
			}

			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x10")]
			public Transform root;

			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x20")]
			public Transform spine;

			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x38")]
			public Transform head;

			// Token: 0x040001BC RID: 444
			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			// Token: 0x040001BD RID: 445
			[Token(Token = "0x40001BD")]
			[FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			// Token: 0x040001BE RID: 446
			[Token(Token = "0x40001BE")]
			[FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			// Token: 0x040001BF RID: 447
			[Token(Token = "0x40001BF")]
			[FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			// Token: 0x040001C0 RID: 448
			[Token(Token = "0x40001C0")]
			[FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			// Token: 0x040001C1 RID: 449
			[Token(Token = "0x40001C1")]
			[FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40001C2")]
			[FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40001C3")]
			[FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			// Token: 0x040001C7 RID: 455
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			// Token: 0x040001C8 RID: 456
			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			// Token: 0x040001CB RID: 459
			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;
		}
	}
}
