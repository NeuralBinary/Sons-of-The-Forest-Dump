using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[Serializable]
	public class FABRIKChain
	{
		// Token: 0x06000255 RID: 597 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2914F80", Offset = "0x2913580", VA = "0x182914F80")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x29150F0", Offset = "0x29136F0", VA = "0x1829150F0")]
		public void Initiate()
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2915150", Offset = "0x2913750", VA = "0x182915150")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2915310", Offset = "0x2913910", VA = "0x182915310")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2915530", Offset = "0x2913B30", VA = "0x182915530")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2915810", Offset = "0x2913E10", VA = "0x182915810")]
		public FABRIKChain()
		{
		}

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x20")]
		public int[] children;
	}
}
