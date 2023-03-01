using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	[Obsolete]
	public class SurvivalBookArmorNibble : MonoBehaviour
	{
		// Token: 0x06001C72 RID: 7282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x2D04B60", Offset = "0x2D03B60", VA = "0x182D04B60")]
		private void Awake()
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x2D04D40", Offset = "0x2D03D40", VA = "0x182D04D40")]
		private void InitNibble()
		{
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x2D04CA0", Offset = "0x2D03CA0", VA = "0x182D04CA0")]
		private void ChangeNibbleColor(Color color)
		{
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SurvivalBookArmorNibble()
		{
		}

		// Token: 0x04001B1D RID: 6941
		[Token(Token = "0x4001B1D")]
		[FieldOffset(Offset = "0x20")]
		public int _nibbleId;

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x28")]
		private Renderer _renderer;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _propertyBlock;
	}
}
