using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	public class HitReaction : OffsetModifier
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x1700009E")]
		public bool inProgress
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x29902A0", Offset = "0x298E8A0", VA = "0x1829902A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2990350", Offset = "0x298E950", VA = "0x182990350", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2990430", Offset = "0x298EA30", VA = "0x182990430")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public HitReaction()
		{
		}

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReaction.HitPointEffector[] effectorHitPoints;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReaction.HitPointBone[] boneHitPoints;

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		[Serializable]
		public abstract class HitPoint
		{
			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0000443C File Offset: 0x0000263C
			[Token(Token = "0x1700009F")]
			public bool inProgress
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x2990830", Offset = "0x298EE30", VA = "0x182990830")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00004454 File Offset: 0x00002654
			// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A0")]
			private protected float crossFader
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				[CompilerGenerated]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060005DA RID: 1498 RVA: 0x0000446C File Offset: 0x0000266C
			// (set) Token: 0x060005DB RID: 1499 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A1")]
			private protected float timer
			{
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				[CompilerGenerated]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060005DC RID: 1500 RVA: 0x00004484 File Offset: 0x00002684
			// (set) Token: 0x060005DD RID: 1501 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A2")]
			private protected Vector3 force
			{
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x28D1490", Offset = "0x28CFA90", VA = "0x1828D1490")]
				[CompilerGenerated]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x200AC50", Offset = "0x2009250", VA = "0x18200AC50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060005DE RID: 1502 RVA: 0x0000449C File Offset: 0x0000269C
			// (set) Token: 0x060005DF RID: 1503 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A3")]
			private protected Vector3 point
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30")]
				[CompilerGenerated]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x290B4F0", Offset = "0x2909AF0", VA = "0x18290B4F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x2990840", Offset = "0x298EE40", VA = "0x182990840")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x2990960", Offset = "0x298EF60", VA = "0x182990960")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x060005E2 RID: 1506
			[Token(Token = "0x60005E2")]
			protected abstract float GetLength();

			// Token: 0x060005E3 RID: 1507
			[Token(Token = "0x60005E3")]
			protected abstract void CrossFadeStart();

			// Token: 0x060005E4 RID: 1508
			[Token(Token = "0x60005E4")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			// Token: 0x060005E5 RID: 1509 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x2990AB0", Offset = "0x298F0B0", VA = "0x182990AB0")]
			protected HitPoint()
			{
			}

			// Token: 0x04000539 RID: 1337
			[Token(Token = "0x4000539")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x0400053A RID: 1338
			[Token(Token = "0x400053A")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x0400053B RID: 1339
			[Token(Token = "0x400053B")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			// Token: 0x04000540 RID: 1344
			[Token(Token = "0x4000540")]
			[FieldOffset(Offset = "0x44")]
			private float length;

			// Token: 0x04000541 RID: 1345
			[Token(Token = "0x4000541")]
			[FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			// Token: 0x04000542 RID: 1346
			[Token(Token = "0x4000542")]
			[FieldOffset(Offset = "0x4C")]
			private float lastTime;
		}

		// Token: 0x020000AF RID: 175
		[Token(Token = "0x20000AF")]
		[Serializable]
		public class HitPointEffector : HitReaction.HitPoint
		{
			// Token: 0x060005E6 RID: 1510 RVA: 0x000044B4 File Offset: 0x000026B4
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x2990AC0", Offset = "0x298F0C0", VA = "0x182990AC0", Slot = "4")]
			protected override float GetLength()
			{
				return 0f;
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x2990D70", Offset = "0x298F370", VA = "0x182990D70", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x2990DD0", Offset = "0x298F3D0", VA = "0x182990DD0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x2990AB0", Offset = "0x298F0B0", VA = "0x182990AB0")]
			public HitPointEffector()
			{
			}

			// Token: 0x04000543 RID: 1347
			[Token(Token = "0x4000543")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			// Token: 0x04000544 RID: 1348
			[Token(Token = "0x4000544")]
			[FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			// Token: 0x04000545 RID: 1349
			[Token(Token = "0x4000545")]
			[FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public HitReaction.HitPointEffector.EffectorLink[] effectorLinks;

			// Token: 0x020000B0 RID: 176
			[Token(Token = "0x20000B0")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x060005EA RID: 1514 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x2991130", Offset = "0x298F730", VA = "0x182991130")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				// Token: 0x060005EB RID: 1515 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x2991260", Offset = "0x298F860", VA = "0x182991260")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x060005EC RID: 1516 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60005EC")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public EffectorLink()
				{
				}

				// Token: 0x04000546 RID: 1350
				[Token(Token = "0x4000546")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				// Token: 0x04000547 RID: 1351
				[Token(Token = "0x4000547")]
				[FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x04000548 RID: 1352
				[Token(Token = "0x4000548")]
				[FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				// Token: 0x04000549 RID: 1353
				[Token(Token = "0x4000549")]
				[FieldOffset(Offset = "0x24")]
				private Vector3 current;
			}
		}

		// Token: 0x020000B1 RID: 177
		[Token(Token = "0x20000B1")]
		[Serializable]
		public class HitPointBone : HitReaction.HitPoint
		{
			// Token: 0x060005ED RID: 1517 RVA: 0x000044CC File Offset: 0x000026CC
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x2991280", Offset = "0x298F880", VA = "0x182991280", Slot = "4")]
			protected override float GetLength()
			{
				return 0f;
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x29913D0", Offset = "0x298F9D0", VA = "0x1829913D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x2991420", Offset = "0x298FA20", VA = "0x182991420", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x2990AB0", Offset = "0x298F0B0", VA = "0x182990AB0")]
			public HitPointBone()
			{
			}

			// Token: 0x0400054A RID: 1354
			[Token(Token = "0x400054A")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			// Token: 0x0400054B RID: 1355
			[Token(Token = "0x400054B")]
			[FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReaction.HitPointBone.BoneLink[] boneLinks;

			// Token: 0x0400054C RID: 1356
			[Token(Token = "0x400054C")]
			[FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			// Token: 0x020000B2 RID: 178
			[Token(Token = "0x20000B2")]
			[Serializable]
			public class BoneLink
			{
				// Token: 0x060005F1 RID: 1521 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x2991800", Offset = "0x298FE00", VA = "0x182991800")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				// Token: 0x060005F2 RID: 1522 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x2991B40", Offset = "0x2990140", VA = "0x182991B40")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x060005F3 RID: 1523 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x2991B50", Offset = "0x2990150", VA = "0x182991B50")]
				public BoneLink()
				{
				}

				// Token: 0x0400054D RID: 1357
				[Token(Token = "0x400054D")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				// Token: 0x0400054E RID: 1358
				[Token(Token = "0x400054E")]
				[FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				// Token: 0x0400054F RID: 1359
				[Token(Token = "0x400054F")]
				[FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				// Token: 0x04000550 RID: 1360
				[Token(Token = "0x4000550")]
				[FieldOffset(Offset = "0x2C")]
				private Quaternion current;
			}
		}
	}
}
