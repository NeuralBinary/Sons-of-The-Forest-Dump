using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.DemoContent
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public class CubeGridSpawner : MonoBehaviour
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2732540", Offset = "0x2730B40", VA = "0x182732540")]
		private void Start()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2732750", Offset = "0x2730D50", VA = "0x182732750")]
		public CubeGridSpawner()
		{
		}

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x20")]
		public int xResolution;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x24")]
		public int yResolution;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x28")]
		public int zResolution;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x2C")]
		public float width;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x30")]
		public float height;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x34")]
		public float depth;
	}
}
