using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[AddComponentMenu("Sons/Ai/MaeSequencePool")]
	public class MaeSequencePool : MonoBehaviour
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2D251F0", Offset = "0x2D237F0", VA = "0x182D251F0")]
		public static void Clear()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2D25290", Offset = "0x2D23890", VA = "0x182D25290")]
		public static MaeSequence GetActionInstance(MaeSequence sequenceAsset)
		{
			return null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2D257F0", Offset = "0x2D23DF0", VA = "0x182D257F0")]
		public static void ReturnToPool(MaeSequence sequenceAsset, MaeSequence sequenceInstance)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MaeSequencePool()
		{
		}

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x0")]
		private static bool _debugLog;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<MaeSequence, List<MaeSequence>> _pool;
	}
}
