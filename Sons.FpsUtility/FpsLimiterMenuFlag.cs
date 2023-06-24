using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[AddComponentMenu("Sons/FpsUtility/FpsLimiterMenuFlag")]
	public class FpsLimiterMenuFlag : MonoBehaviour
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2FE3F50", Offset = "0x2FE2550", VA = "0x182FE3F50")]
		private void OnEnable()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2FE4000", Offset = "0x2FE2600", VA = "0x182FE4000")]
		private void OnDisable()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FpsLimiterMenuFlag()
		{
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_forceClearRefCounter")]
		private bool _forceClearRefCounterFirst;
	}
}
