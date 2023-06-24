using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Items.Utils
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	public static class ItemUtils
	{
		// Token: 0x06001EBE RID: 7870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x32F4C80", Offset = "0x32F3280", VA = "0x1832F4C80")]
		public static GameObject SpawnItemPickup(ItemData itemData, Vector3 position, Quaternion rotation, Vector3 mpVelocity, bool avoidImpacts = false, bool isDynamic = true, bool shouldDespawn = true, bool usePooling = false, [Optional] ItemInstance itemInstance, [Optional] IProtocolToken protocolToken)
		{
			return null;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x32F5650", Offset = "0x32F3C50", VA = "0x1832F5650")]
		private static bool ApplyEffectsToPlayerStats(StatEffect effect, bool addEffect)
		{
			return default(bool);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x32F61A0", Offset = "0x32F47A0", VA = "0x1832F61A0")]
		public static float SurvivalSettingConsumableNegativeInfluenceModifier()
		{
			return 0f;
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x32F62B0", Offset = "0x32F48B0", VA = "0x1832F62B0")]
		public static float GetSurvivalSettingConsumablePositiveInfluenceModifier()
		{
			return 0f;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x32F63C0", Offset = "0x32F49C0", VA = "0x1832F63C0")]
		public static void ApplyEffectsToPlayerStats(IEnumerable<StatEffect> effects, bool addEffect, int times = 1)
		{
		}

		// Token: 0x04001CAD RID: 7341
		[Token(Token = "0x4001CAD")]
		private const string PickupsPoolId = "PickUps";
	}
}
