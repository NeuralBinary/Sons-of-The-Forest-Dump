using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	public class Inertia : OffsetModifier
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2993540", Offset = "0x2991B40", VA = "0x182993540")]
		public void ResetBodies()
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x29935E0", Offset = "0x2991BE0", VA = "0x1829935E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public Inertia()
		{
		}

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The array of Bodies")]
		public Inertia.Body[] bodies;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetModifier.OffsetLimits[] limits;

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		[Serializable]
		public class Body
		{
			// Token: 0x06000616 RID: 1558 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x2993800", Offset = "0x2991E00", VA = "0x182993800")]
			public void Reset()
			{
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x29939F0", Offset = "0x2991FF0", VA = "0x1829939F0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x2993F90", Offset = "0x2992590", VA = "0x182993F90")]
			public Body()
			{
			}

			// Token: 0x0400056E RID: 1390
			[Token(Token = "0x400056E")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			// Token: 0x0400056F RID: 1391
			[Token(Token = "0x400056F")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public Inertia.Body.EffectorLink[] effectorLinks;

			// Token: 0x04000570 RID: 1392
			[Token(Token = "0x4000570")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			// Token: 0x04000571 RID: 1393
			[Token(Token = "0x4000571")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			// Token: 0x04000572 RID: 1394
			[Token(Token = "0x4000572")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			// Token: 0x04000573 RID: 1395
			[Token(Token = "0x4000573")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			// Token: 0x04000574 RID: 1396
			[Token(Token = "0x4000574")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			// Token: 0x04000575 RID: 1397
			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			// Token: 0x04000576 RID: 1398
			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			// Token: 0x04000577 RID: 1399
			[Token(Token = "0x4000577")]
			[FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			// Token: 0x04000578 RID: 1400
			[Token(Token = "0x4000578")]
			[FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			// Token: 0x020000BB RID: 187
			[Token(Token = "0x20000BB")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x06000619 RID: 1561 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public EffectorLink()
				{
				}

				// Token: 0x04000579 RID: 1401
				[Token(Token = "0x4000579")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400057A RID: 1402
				[Token(Token = "0x400057A")]
				[FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
