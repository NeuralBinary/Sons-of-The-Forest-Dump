using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public class Recoil : OffsetModifier
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x170000AF")]
		public bool isFinished
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x2997C80", Offset = "0x2996280", VA = "0x182997C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2997CE0", Offset = "0x29962E0", VA = "0x182997CE0")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2997D10", Offset = "0x2996310", VA = "0x182997D10")]
		public void Fire(float magnitude)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x29980A0", Offset = "0x29966A0", VA = "0x1829980A0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2999810", Offset = "0x2997E10", VA = "0x182999810")]
		private void AfterFBBIK()
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2999A10", Offset = "0x2998010", VA = "0x182999A10")]
		private void AfterAimIK()
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000B0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x2999A60", Offset = "0x2998060", VA = "0x182999A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000B1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x2999AD0", Offset = "0x29980D0", VA = "0x182999AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000B2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2999B40", Offset = "0x2998140", VA = "0x182999B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000B3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x2999B60", Offset = "0x2998160", VA = "0x182999B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2999B80", Offset = "0x2998180", VA = "0x182999B80", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2999ED0", Offset = "0x29984D0", VA = "0x182999ED0")]
		public Recoil()
		{
		}

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Which hand is holding the weapon?")]
		public Recoil.Handedness handedness;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x78")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public Recoil.RecoilOffset[] offsets;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x94")]
		private float endTime;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0xC8")]
		private float length;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0xCC")]
		private bool initiated;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0xD4")]
		private float w;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000C8")]
		[Serializable]
		public class RecoilOffset
		{
			// Token: 0x06000657 RID: 1623 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x2999FB0", Offset = "0x29985B0", VA = "0x182999FB0")]
			public void Start()
			{
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x299A040", Offset = "0x2998640", VA = "0x18299A040")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x299A300", Offset = "0x2998900", VA = "0x18299A300")]
			public RecoilOffset()
			{
			}

			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			// Token: 0x040005D1 RID: 1489
			[Token(Token = "0x40005D1")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public Recoil.RecoilOffset.EffectorLink[] effectorLinks;

			// Token: 0x040005D3 RID: 1491
			[Token(Token = "0x40005D3")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			// Token: 0x040005D4 RID: 1492
			[Token(Token = "0x40005D4")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			// Token: 0x020000C9 RID: 201
			[Token(Token = "0x20000C9")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x0600065A RID: 1626 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600065A")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public EffectorLink()
				{
				}

				// Token: 0x040005D5 RID: 1493
				[Token(Token = "0x40005D5")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040005D6 RID: 1494
				[Token(Token = "0x40005D6")]
				[FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}

		// Token: 0x020000CA RID: 202
		[Token(Token = "0x20000CA")]
		[Serializable]
		public enum Handedness
		{
			// Token: 0x040005D8 RID: 1496
			[Token(Token = "0x40005D8")]
			Right,
			// Token: 0x040005D9 RID: 1497
			[Token(Token = "0x40005D9")]
			Left
		}
	}
}
