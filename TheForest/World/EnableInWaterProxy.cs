using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	public class EnableInWaterProxy : MonoBehaviour
	{
		// Token: 0x0600179B RID: 6043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179B")]
		[Address(RVA = "0x2CB2600", Offset = "0x2CB1600", VA = "0x182CB2600")]
		private void OnEnable()
		{
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x2CB2580", Offset = "0x2CB1580", VA = "0x182CB2580")]
		private void OnDisable()
		{
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179D")]
		[Address(RVA = "0x2CB2680", Offset = "0x2CB1680", VA = "0x182CB2680")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x2CB2750", Offset = "0x2CB1750", VA = "0x182CB2750")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public EnableInWaterProxy()
		{
		}

		// Token: 0x040016B5 RID: 5813
		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x20")]
		public Behaviour _target;

		// Token: 0x040016B6 RID: 5814
		[Token(Token = "0x40016B6")]
		[FieldOffset(Offset = "0x28")]
		private bool _inWater;
	}
}
