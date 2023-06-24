using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x170000A9")]
		protected float deltaTime
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x29957D0", Offset = "0x2993DD0", VA = "0x1829957D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000621 RID: 1569
		[Token(Token = "0x6000621")]
		protected abstract void OnModifyOffset();

		// Token: 0x06000622 RID: 1570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2995830", Offset = "0x2993E30", VA = "0x182995830", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x29958D0", Offset = "0x2993ED0", VA = "0x1829958D0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2995960", Offset = "0x2993F60", VA = "0x182995960")]
		private void ModifyOffset()
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2995B20", Offset = "0x2994120", VA = "0x182995B20")]
		protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2995C90", Offset = "0x2994290", VA = "0x182995C90", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		protected OffsetModifier()
		{
		}

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The master weight")]
		public float weight;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x30")]
		protected float lastTime;

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		[Serializable]
		public class OffsetLimits
		{
			// Token: 0x06000628 RID: 1576 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x2995E70", Offset = "0x2994470", VA = "0x182995E70")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			// Token: 0x06000629 RID: 1577 RVA: 0x000045A4 File Offset: 0x000027A4
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x29960A0", Offset = "0x29946A0", VA = "0x1829960A0")]
			private float SpringAxis(float value, float min, float max)
			{
				return 0f;
			}

			// Token: 0x0600062A RID: 1578 RVA: 0x000045BC File Offset: 0x000027BC
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2996130", Offset = "0x2994730", VA = "0x182996130")]
			private float Spring(float value, float limit, bool negative)
			{
				return 0f;
			}

			// Token: 0x0600062B RID: 1579 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public OffsetLimits()
			{
			}

			// Token: 0x04000592 RID: 1426
			[Token(Token = "0x4000592")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			// Token: 0x04000593 RID: 1427
			[Token(Token = "0x4000593")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			// Token: 0x04000594 RID: 1428
			[Token(Token = "0x4000594")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			// Token: 0x04000595 RID: 1429
			[Token(Token = "0x4000595")]
			[FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			// Token: 0x04000596 RID: 1430
			[Token(Token = "0x4000596")]
			[FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			// Token: 0x04000597 RID: 1431
			[Token(Token = "0x4000597")]
			[FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			// Token: 0x04000598 RID: 1432
			[Token(Token = "0x4000598")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			// Token: 0x04000599 RID: 1433
			[Token(Token = "0x4000599")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			// Token: 0x0400059A RID: 1434
			[Token(Token = "0x400059A")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			// Token: 0x0400059B RID: 1435
			[Token(Token = "0x400059B")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			// Token: 0x0400059C RID: 1436
			[Token(Token = "0x400059C")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;
		}
	}
}
