using System;
using Il2CppDummyDll;
using Sons.Gameplay.ZipLines;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007B1 RID: 1969
	[Token(Token = "0x20007B1")]
	public class ZiplinePickup : PickUp
	{
		// Token: 0x06003522 RID: 13602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003522")]
		[Address(RVA = "0x34D9100", Offset = "0x34D7700", VA = "0x1834D9100", Slot = "27")]
		protected override void Collect()
		{
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003523")]
		[Address(RVA = "0x34C7ED0", Offset = "0x34C64D0", VA = "0x1834C7ED0")]
		public ZiplinePickup()
		{
		}

		// Token: 0x04002DD2 RID: 11730
		[Token(Token = "0x4002DD2")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ZipLineController _zipLineController;
	}
}
