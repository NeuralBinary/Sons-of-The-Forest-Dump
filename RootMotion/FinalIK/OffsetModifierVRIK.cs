using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x29957D0", Offset = "0x2993DD0", VA = "0x1829957D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000633 RID: 1587
		[Token(Token = "0x6000633")]
		protected abstract void OnModifyOffset();

		// Token: 0x06000634 RID: 1588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x29964A0", Offset = "0x2994AA0", VA = "0x1829964A0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2996540", Offset = "0x2994B40", VA = "0x182996540")]
		private IEnumerator Initiate()
		{
			return null;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x29965D0", Offset = "0x2994BD0", VA = "0x1829965D0")]
		private void ModifyOffset()
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2996790", Offset = "0x2994D90", VA = "0x182996790", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		protected OffsetModifierVRIK()
		{
		}

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The master weight")]
		public float weight;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x30")]
		private float lastTime;
	}
}
