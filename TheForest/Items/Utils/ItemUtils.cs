using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Items.Utils
{
	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	public static class ItemUtils
	{
		// Token: 0x06001E6C RID: 7788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x2D11DB0", Offset = "0x2D10DB0", VA = "0x182D11DB0")]
		public static GameObject SpawnItemPickup(ItemData itemData, Vector3 position, Quaternion rotation, Vector3 mpVelocity, bool avoidImpacts = false, bool isDynamic = true, bool shouldDespawn = true, [Optional] ItemInstance itemInstance)
		{
			return null;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x2D11520", Offset = "0x2D10520", VA = "0x182D11520")]
		public static bool ApplyEffectsToPlayerStats(StatEffect effect, bool addEffect)
		{
			return default(bool);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x2D11320", Offset = "0x2D10320", VA = "0x182D11320")]
		public static bool ApplyEffectsToPlayerStats(IEnumerable<StatEffect> effects, bool addEffect, int times = 1)
		{
			return default(bool);
		}
	}
}
