using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	[Obsolete]
	public class SurvivalBookArmorNibble : MonoBehaviour
	{
		// Token: 0x06001CB0 RID: 7344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x32C6FE0", Offset = "0x32C55E0", VA = "0x1832C6FE0")]
		private void Awake()
		{
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnEnable()
		{
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x32C7270", Offset = "0x32C5870", VA = "0x1832C7270")]
		private void InitNibble()
		{
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x32C73C0", Offset = "0x32C59C0", VA = "0x1832C73C0")]
		private void ChangeNibbleColor(Color color)
		{
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SurvivalBookArmorNibble()
		{
		}

		// Token: 0x04001B41 RID: 6977
		[Token(Token = "0x4001B41")]
		[FieldOffset(Offset = "0x20")]
		public int _nibbleId;

		// Token: 0x04001B42 RID: 6978
		[Token(Token = "0x4001B42")]
		[FieldOffset(Offset = "0x28")]
		private Renderer _renderer;

		// Token: 0x04001B43 RID: 6979
		[Token(Token = "0x4001B43")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _propertyBlock;
	}
}
