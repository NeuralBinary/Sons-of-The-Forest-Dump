using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public class Amplifier : OffsetModifier
	{
		// Token: 0x060005C7 RID: 1479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x298F2B0", Offset = "0x298D8B0", VA = "0x18298F2B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public Amplifier()
		{
		}

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The amplified bodies.")]
		public Amplifier.Body[] bodies;

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		[Serializable]
		public class Body
		{
			// Token: 0x060005C9 RID: 1481 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x298F470", Offset = "0x298DA70", VA = "0x18298F470")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0000440C File Offset: 0x0000260C
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x298FAF0", Offset = "0x298E0F0", VA = "0x18298FAF0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x298FB30", Offset = "0x298E130", VA = "0x18298FB30")]
			public Body()
			{
			}

			// Token: 0x04000525 RID: 1317
			[Token(Token = "0x4000525")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			// Token: 0x04000526 RID: 1318
			[Token(Token = "0x4000526")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			// Token: 0x04000527 RID: 1319
			[Token(Token = "0x4000527")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public Amplifier.Body.EffectorLink[] effectorLinks;

			// Token: 0x04000528 RID: 1320
			[Token(Token = "0x4000528")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			// Token: 0x04000529 RID: 1321
			[Token(Token = "0x4000529")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			// Token: 0x0400052A RID: 1322
			[Token(Token = "0x400052A")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			// Token: 0x0400052B RID: 1323
			[Token(Token = "0x400052B")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			// Token: 0x0400052C RID: 1324
			[Token(Token = "0x400052C")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			// Token: 0x0400052D RID: 1325
			[Token(Token = "0x400052D")]
			[FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			// Token: 0x020000AA RID: 170
			[Token(Token = "0x20000AA")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x060005CC RID: 1484 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public EffectorLink()
				{
				}

				// Token: 0x0400052E RID: 1326
				[Token(Token = "0x400052E")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400052F RID: 1327
				[Token(Token = "0x400052F")]
				[FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
