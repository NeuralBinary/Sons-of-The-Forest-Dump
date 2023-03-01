using System;
using Il2CppDummyDll;
using Sons.Gameplay.ZipLines;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000689 RID: 1673
	[Token(Token = "0x2000689")]
	public class ZiplinePickup : PickUp
	{
		// Token: 0x06002AD0 RID: 10960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x2DE1330", Offset = "0x2DE0330", VA = "0x182DE1330", Slot = "25")]
		protected override void Collect()
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x2DC6290", Offset = "0x2DC5290", VA = "0x182DC6290")]
		public ZiplinePickup()
		{
		}

		// Token: 0x04002645 RID: 9797
		[Token(Token = "0x4002645")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ZipLineController _zipLineController;
	}
}
