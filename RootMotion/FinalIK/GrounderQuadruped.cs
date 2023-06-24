using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2903780", Offset = "0x2901D80", VA = "0x182903780", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2903810", Offset = "0x2901E10", VA = "0x182903810", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x29038A0", Offset = "0x2901EA0", VA = "0x1829038A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x29038E0", Offset = "0x2901EE0", VA = "0x1829038E0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2903B40", Offset = "0x2902140", VA = "0x182903B40")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2903D50", Offset = "0x2902350", VA = "0x182903D50")]
		private void OnDisable()
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2903DD0", Offset = "0x29023D0", VA = "0x182903DD0")]
		private void Update()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2903E40", Offset = "0x2902440", VA = "0x182903E40")]
		private void Initiate()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x29045C0", Offset = "0x2902BC0", VA = "0x1829045C0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref GrounderQuadruped.Foot[] f, int indexOffset)
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2904CA0", Offset = "0x29032A0", VA = "0x182904CA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2904D80", Offset = "0x2903380", VA = "0x182904D80")]
		private void RootRotation()
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2905620", Offset = "0x2903C20", VA = "0x182905620")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2906710", Offset = "0x2904D10", VA = "0x182906710")]
		private void UpdateForefeetRoot()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2906C80", Offset = "0x2905280", VA = "0x182906C80")]
		private void SetFootIK(GrounderQuadruped.Foot foot, float maxOffset)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2906E80", Offset = "0x2905480", VA = "0x182906E80")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x29075F0", Offset = "0x2905BF0", VA = "0x1829075F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2907630", Offset = "0x2905C30", VA = "0x182907630")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2907900", Offset = "0x2905F00", VA = "0x182907900")]
		public GrounderQuadruped()
		{
		}

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x54")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x90")]
		public IK[] legs;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x98")]
		public IK[] forelegs;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 gravity;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xB0")]
		private GrounderQuadruped.Foot[] feet;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xC4")]
		private Quaternion animatedPelvisLocalRotation;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xD4")]
		private Quaternion animatedHeadLocalRotation;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xE4")]
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xF0")]
		private Quaternion solvedPelvisLocalRotation;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x100")]
		private Quaternion solvedHeadLocalRotation;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x110")]
		private int solvedFeet;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x114")]
		private bool solved;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x118")]
		private float angle;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x120")]
		private Transform forefeetRoot;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x128")]
		private Quaternion headRotation;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x138")]
		private float lastWeight;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x140")]
		private Rigidbody characterRootRigidbody;

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		public struct Foot
		{
			// Token: 0x060001A3 RID: 419 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x2907AE0", Offset = "0x29060E0", VA = "0x182907AE0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}

			// Token: 0x04000168 RID: 360
			[Token(Token = "0x4000168")]
			[FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			// Token: 0x04000169 RID: 361
			[Token(Token = "0x4000169")]
			[FieldOffset(Offset = "0x8")]
			public Transform transform;

			// Token: 0x0400016A RID: 362
			[Token(Token = "0x400016A")]
			[FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			// Token: 0x0400016B RID: 363
			[Token(Token = "0x400016B")]
			[FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;
		}
	}
}
