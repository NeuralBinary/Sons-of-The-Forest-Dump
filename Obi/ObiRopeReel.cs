using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	[RequireComponent(typeof(ObiRopeCursor))]
	public class ObiRopeReel : MonoBehaviour
	{
		// Token: 0x06000AA1 RID: 2721 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x2825C80", Offset = "0x2824280", VA = "0x182825C80")]
		public void Awake()
		{
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2825D90", Offset = "0x2824390", VA = "0x182825D90")]
		public void OnValidate()
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x2825DB0", Offset = "0x28243B0", VA = "0x182825DB0")]
		private void Update()
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x2825E30", Offset = "0x2824430", VA = "0x182825E30")]
		public ObiRopeReel()
		{
		}

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x20")]
		private ObiRopeCursor cursor;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x28")]
		private ObiRope rope;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x30")]
		[Header("Roll out/in thresholds")]
		public float outThreshold;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0x34")]
		public float inThreshold;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0x38")]
		[Header("Roll out/in speeds")]
		public float outSpeed;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x3C")]
		public float inSpeed;
	}
}
