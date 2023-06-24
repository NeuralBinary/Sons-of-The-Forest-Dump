using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	[AddComponentMenu("Sons/Pickup/Story")]
	public class StoryPickUp : PickUp
	{
		// Token: 0x060034E1 RID: 13537 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x34D4280", Offset = "0x34D2880", VA = "0x1834D4280", Slot = "29")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x34C7ED0", Offset = "0x34C64D0", VA = "0x1834C7ED0")]
		public StoryPickUp()
		{
		}

		// Token: 0x04002DA9 RID: 11689
		[Token(Token = "0x4002DA9")]
		protected const string PICKUP_EVENT = "event:/music/toy_pickup";
	}
}
