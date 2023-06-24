using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.ScratchPad.VFX
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class MaterialParamAnimate : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x312E860", Offset = "0x312CE60", VA = "0x18312E860")]
		private void Start()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x312E910", Offset = "0x312CF10", VA = "0x18312E910")]
		private void Update()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x312EAB0", Offset = "0x312D0B0", VA = "0x18312EAB0")]
		public MaterialParamAnimate()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public Material Mat;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		public float WipeStart;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x2C")]
		public float BeginWipeTime;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		public float WipeDuration;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x34")]
		private float Timer;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x38")]
		private float Wipe;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int WipeRef;
	}
}
