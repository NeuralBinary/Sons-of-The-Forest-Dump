using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2991BD0", Offset = "0x29901D0", VA = "0x182991BD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2991CA0", Offset = "0x29902A0", VA = "0x182991CA0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public HitReactionVRIK()
		{
		}

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve[] offsetCurves;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReactionVRIK.PositionOffset[] positionOffsets;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReactionVRIK.RotationOffset[] rotationOffsets;

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000B4")]
		[Serializable]
		public abstract class Offset
		{
			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000044E4 File Offset: 0x000026E4
			// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A4")]
			private protected float crossFader
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				[CompilerGenerated]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000044FC File Offset: 0x000026FC
			// (set) Token: 0x060005FA RID: 1530 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A5")]
			private protected float timer
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				[CompilerGenerated]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x00004514 File Offset: 0x00002714
			// (set) Token: 0x060005FC RID: 1532 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A6")]
			private protected Vector3 force
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x28D1490", Offset = "0x28CFA90", VA = "0x1828D1490")]
				[CompilerGenerated]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x200AC50", Offset = "0x2009250", VA = "0x18200AC50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060005FD RID: 1533 RVA: 0x0000452C File Offset: 0x0000272C
			// (set) Token: 0x060005FE RID: 1534 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A7")]
			private protected Vector3 point
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30")]
				[CompilerGenerated]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x290B4F0", Offset = "0x2909AF0", VA = "0x18290B4F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x29920B0", Offset = "0x29906B0", VA = "0x1829920B0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x29921D0", Offset = "0x29907D0", VA = "0x1829921D0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x06000601 RID: 1537
			[Token(Token = "0x6000601")]
			protected abstract float GetLength(AnimationCurve[] curves);

			// Token: 0x06000602 RID: 1538
			[Token(Token = "0x6000602")]
			protected abstract void CrossFadeStart();

			// Token: 0x06000603 RID: 1539
			[Token(Token = "0x6000603")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			// Token: 0x06000604 RID: 1540 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x2990AB0", Offset = "0x298F0B0", VA = "0x182990AB0")]
			protected Offset()
			{
			}

			// Token: 0x04000554 RID: 1364
			[Token(Token = "0x4000554")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x04000555 RID: 1365
			[Token(Token = "0x4000555")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x04000556 RID: 1366
			[Token(Token = "0x4000556")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			// Token: 0x0400055B RID: 1371
			[Token(Token = "0x400055B")]
			[FieldOffset(Offset = "0x44")]
			private float length;

			// Token: 0x0400055C RID: 1372
			[Token(Token = "0x400055C")]
			[FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			// Token: 0x0400055D RID: 1373
			[Token(Token = "0x400055D")]
			[FieldOffset(Offset = "0x4C")]
			private float lastTime;
		}

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		[Serializable]
		public class PositionOffset : HitReactionVRIK.Offset
		{
			// Token: 0x06000605 RID: 1541 RVA: 0x00004544 File Offset: 0x00002744
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x2992330", Offset = "0x2990930", VA = "0x182992330", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return 0f;
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x2992640", Offset = "0x2990C40", VA = "0x182992640", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x29926A0", Offset = "0x2990CA0", VA = "0x1829926A0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x2992A30", Offset = "0x2991030", VA = "0x182992A30")]
			public PositionOffset()
			{
			}

			// Token: 0x0400055E RID: 1374
			[Token(Token = "0x400055E")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			// Token: 0x0400055F RID: 1375
			[Token(Token = "0x400055F")]
			[FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			// Token: 0x04000560 RID: 1376
			[Token(Token = "0x4000560")]
			[FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks;

			// Token: 0x020000B6 RID: 182
			[Token(Token = "0x20000B6")]
			[Serializable]
			public class PositionOffsetLink
			{
				// Token: 0x06000609 RID: 1545 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000609")]
				[Address(RVA = "0x2992A40", Offset = "0x2991040", VA = "0x182992A40")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				// Token: 0x0600060A RID: 1546 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x2991260", Offset = "0x298F860", VA = "0x182991260")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x0600060B RID: 1547 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600060B")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public PositionOffsetLink()
				{
				}

				// Token: 0x04000561 RID: 1377
				[Token(Token = "0x4000561")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				// Token: 0x04000562 RID: 1378
				[Token(Token = "0x4000562")]
				[FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x04000563 RID: 1379
				[Token(Token = "0x4000563")]
				[FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				// Token: 0x04000564 RID: 1380
				[Token(Token = "0x4000564")]
				[FieldOffset(Offset = "0x24")]
				private Vector3 current;
			}
		}

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		[Serializable]
		public class RotationOffset : HitReactionVRIK.Offset
		{
			// Token: 0x0600060C RID: 1548 RVA: 0x0000455C File Offset: 0x0000275C
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x2992B30", Offset = "0x2991130", VA = "0x182992B30", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return 0f;
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x2992CD0", Offset = "0x29912D0", VA = "0x182992CD0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x2992D20", Offset = "0x2991320", VA = "0x182992D20", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x2990AB0", Offset = "0x298F0B0", VA = "0x182990AB0")]
			public RotationOffset()
			{
			}

			// Token: 0x04000565 RID: 1381
			[Token(Token = "0x4000565")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			// Token: 0x04000566 RID: 1382
			[Token(Token = "0x4000566")]
			[FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks;

			// Token: 0x04000567 RID: 1383
			[Token(Token = "0x4000567")]
			[FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			// Token: 0x020000B8 RID: 184
			[Token(Token = "0x20000B8")]
			[Serializable]
			public class RotationOffsetLink
			{
				// Token: 0x06000610 RID: 1552 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000610")]
				[Address(RVA = "0x2993320", Offset = "0x2991920", VA = "0x182993320")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				// Token: 0x06000611 RID: 1553 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000611")]
				[Address(RVA = "0x29934B0", Offset = "0x2991AB0", VA = "0x1829934B0")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x06000612 RID: 1554 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000612")]
				[Address(RVA = "0x29934C0", Offset = "0x2991AC0", VA = "0x1829934C0")]
				public RotationOffsetLink()
				{
				}

				// Token: 0x04000568 RID: 1384
				[Token(Token = "0x4000568")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				// Token: 0x04000569 RID: 1385
				[Token(Token = "0x4000569")]
				[FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				// Token: 0x0400056A RID: 1386
				[Token(Token = "0x400056A")]
				[FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				// Token: 0x0400056B RID: 1387
				[Token(Token = "0x400056B")]
				[FieldOffset(Offset = "0x28")]
				private Quaternion current;
			}
		}
	}
}
