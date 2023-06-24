using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	public class PenetrationAvoidance : OffsetModifier
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2997300", Offset = "0x2995900", VA = "0x182997300", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public PenetrationAvoidance()
		{
		}

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Definitions of penetration avoidances.")]
		public PenetrationAvoidance.Avoider[] avoiders;

		// Token: 0x020000C5 RID: 197
		[Token(Token = "0x20000C5")]
		[Serializable]
		public class Avoider
		{
			// Token: 0x06000646 RID: 1606 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x2997380", Offset = "0x2995980", VA = "0x182997380")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x0000461C File Offset: 0x0000281C
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x29975F0", Offset = "0x2995BF0", VA = "0x1829975F0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x00004634 File Offset: 0x00002834
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x2997850", Offset = "0x2995E50", VA = "0x182997850")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x2997C70", Offset = "0x2996270", VA = "0x182997C70")]
			public Avoider()
			{
			}

			// Token: 0x040005AC RID: 1452
			[Token(Token = "0x40005AC")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			// Token: 0x040005AD RID: 1453
			[Token(Token = "0x40005AD")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			// Token: 0x040005AF RID: 1455
			[Token(Token = "0x40005AF")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public PenetrationAvoidance.Avoider.EffectorLink[] effectors;

			// Token: 0x040005B0 RID: 1456
			[Token(Token = "0x40005B0")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			// Token: 0x040005B1 RID: 1457
			[Token(Token = "0x40005B1")]
			[FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			// Token: 0x040005B2 RID: 1458
			[Token(Token = "0x40005B2")]
			[FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			// Token: 0x040005B3 RID: 1459
			[Token(Token = "0x40005B3")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			// Token: 0x040005B4 RID: 1460
			[Token(Token = "0x40005B4")]
			[FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x40005B5")]
			[FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			// Token: 0x020000C6 RID: 198
			[Token(Token = "0x20000C6")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x0600064A RID: 1610 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public EffectorLink()
				{
				}

				// Token: 0x040005B6 RID: 1462
				[Token(Token = "0x40005B6")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				// Token: 0x040005B7 RID: 1463
				[Token(Token = "0x40005B7")]
				[FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;
			}
		}
	}
}
