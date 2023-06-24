using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x28FF700", Offset = "0x28FDD00", VA = "0x1828FF700")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x28FF790", Offset = "0x28FDD90", VA = "0x1828FF790", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x28FF820", Offset = "0x28FDE20", VA = "0x1828FF820", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x28FF8B0", Offset = "0x28FDEB0", VA = "0x1828FF8B0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x28FF910", Offset = "0x28FDF10", VA = "0x1828FF910")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x28FFA00", Offset = "0x28FE000", VA = "0x1828FFA00")]
		private void Update()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x28FFB30", Offset = "0x28FE130", VA = "0x1828FFB30")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x28FFB30", Offset = "0x28FE130", VA = "0x1828FFB30")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x28FFB40", Offset = "0x28FE140", VA = "0x1828FFB40")]
		private void Initiate()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x28FFEE0", Offset = "0x28FE4E0", VA = "0x1828FFEE0")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x29004F0", Offset = "0x28FEAF0", VA = "0x1829004F0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x29008D0", Offset = "0x28FEED0", VA = "0x1829008D0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2900C00", Offset = "0x28FF200", VA = "0x182900C00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2900DE0", Offset = "0x28FF3E0", VA = "0x182900DE0")]
		public GrounderFBBIK()
		{
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x58")]
		public GrounderFBBIK.SpineEffector[] spine;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x60")]
		private Transform[] feet;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 spineOffset;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x74")]
		private bool firstSolve;

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		[Serializable]
		public class SpineEffector
		{
			// Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x6C1AF0", Offset = "0x6C00F0", VA = "0x1806C1AF0")]
			public SpineEffector()
			{
			}

			// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2900F10", Offset = "0x28FF510", VA = "0x182900F10")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}

			// Token: 0x0400013A RID: 314
			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x0400013B RID: 315
			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			// Token: 0x0400013C RID: 316
			[Token(Token = "0x400013C")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;
		}
	}
}
