using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2916A60", Offset = "0x2915060", VA = "0x182916A60")]
		private void Start()
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x29172B0", Offset = "0x29158B0", VA = "0x1829172B0")]
		private void OnStoreDefaultLocalState()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2917D00", Offset = "0x2916300", VA = "0x182917D00")]
		private void OnFixTransforms()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x29184B0", Offset = "0x2916AB0", VA = "0x1829184B0")]
		private void OnPreRead()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2919320", Offset = "0x2917920", VA = "0x182919320")]
		private void SpineBend()
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x29198F0", Offset = "0x2917EF0", VA = "0x1829198F0")]
		private void CCDPass()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x291A160", Offset = "0x2918760", VA = "0x18291A160")]
		private void Iterate(int iteration)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x291B1D0", Offset = "0x29197D0", VA = "0x18291B1D0")]
		private void OnPostUpdate()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x291B630", Offset = "0x2919C30", VA = "0x18291B630")]
		private void ChestDirection()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x291BB60", Offset = "0x291A160", VA = "0x18291BB60")]
		private void PostStretching()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x291C1B0", Offset = "0x291A7B0", VA = "0x18291C1B0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x291C370", Offset = "0x291A970", VA = "0x18291C370")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x291C4F0", Offset = "0x291AAF0", VA = "0x18291C4F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x291CAE0", Offset = "0x291B0E0", VA = "0x18291CAE0")]
		public FBBIKHeadEffector()
		{
		}

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		public float positionWeight;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x38")]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The bones to use for bending.")]
		public FBBIKHeadEffector.BendBone[] bendBones;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x50")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		public float postStretchWeight;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x80")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x90")]
		public Transform[] chestBones;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x98")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 offset;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 headToBody;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 shoulderCenterToHead;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 headToLeftThigh;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 headToRightThigh;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 leftShoulderPos;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 rightShoulderPos;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0xF4")]
		private float shoulderDist;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0xF8")]
		private float leftShoulderDist;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0xFC")]
		private float rightShoulderDist;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x100")]
		private Quaternion chestRotation;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x110")]
		private Quaternion headRotationRelativeToRoot;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x120")]
		private Quaternion[] ccdDefaultLocalRotations;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x128")]
		private Vector3 headLocalPosition;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x134")]
		private Quaternion headLocalRotation;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x148")]
		private Vector3[] stretchLocalPositions;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x150")]
		private Quaternion[] stretchLocalRotations;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x158")]
		private Vector3[] chestLocalPositions;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x160")]
		private Quaternion[] chestLocalRotations;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x168")]
		private int bendBonesCount;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x16C")]
		private int ccdBonesCount;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x170")]
		private int stretchBonesCount;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x174")]
		private int chestBonesCount;

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000052")]
		[Serializable]
		public class BendBone
		{
			// Token: 0x0600026D RID: 621 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x291CF60", Offset = "0x291B560", VA = "0x18291CF60")]
			public BendBone()
			{
			}

			// Token: 0x0600026E RID: 622 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x291CFB0", Offset = "0x291B5B0", VA = "0x18291CFB0")]
			public BendBone(Transform transform, float weight)
			{
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x291D060", Offset = "0x291B660", VA = "0x18291D060")]
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x291D0E0", Offset = "0x291B6E0", VA = "0x18291D0E0")]
			public void FixTransforms()
			{
			}

			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;
		}
	}
}
