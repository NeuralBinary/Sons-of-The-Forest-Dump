using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000687 RID: 1671
	[Token(Token = "0x2000687")]
	[AddComponentMenu("Sons/Pickup/Story")]
	public class StoryPickUp : PickUp
	{
		// Token: 0x06002ACB RID: 10955 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0x2DDFD90", Offset = "0x2DDED90", VA = "0x182DDFD90", Slot = "27")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACC")]
		[Address(RVA = "0x2DC6290", Offset = "0x2DC5290", VA = "0x182DC6290")]
		public StoryPickUp()
		{
		}

		// Token: 0x04002642 RID: 9794
		[Token(Token = "0x4002642")]
		protected const string PICKUP_EVENT = "event:/music/toy_pickup";
	}
}
