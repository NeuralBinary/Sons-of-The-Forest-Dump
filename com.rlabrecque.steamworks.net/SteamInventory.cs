using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public static class SteamInventory
	{
		// Token: 0x06000272 RID: 626 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x9306B0", Offset = "0x92ECB0", VA = "0x1809306B0")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00004E2C File Offset: 0x0000302C
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x930700", Offset = "0x92ED00", VA = "0x180930700")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x9307D0", Offset = "0x92EDD0", VA = "0x1809307D0")]
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00004E5C File Offset: 0x0000305C
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x930A00", Offset = "0x92F000", VA = "0x180930A00")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return 0U;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00004E74 File Offset: 0x00003074
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x930A50", Offset = "0x92F050", VA = "0x180930A50")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x930AB0", Offset = "0x92F0B0", VA = "0x180930AB0")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00004E8C File Offset: 0x0000308C
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x930B00", Offset = "0x92F100", VA = "0x180930B00")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x930B60", Offset = "0x92F160", VA = "0x180930B60")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x930BE0", Offset = "0x92F1E0", VA = "0x180930BE0")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x930C60", Offset = "0x92F260", VA = "0x180930C60")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x930CF0", Offset = "0x92F2F0", VA = "0x180930CF0")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00004F04 File Offset: 0x00003104
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x930E00", Offset = "0x92F400", VA = "0x180930E00")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00004F1C File Offset: 0x0000311C
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x930E60", Offset = "0x92F460", VA = "0x180930E60")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00004F34 File Offset: 0x00003134
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x930EC0", Offset = "0x92F4C0", VA = "0x180930EC0")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x930F40", Offset = "0x92F540", VA = "0x180930F40")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x930FC0", Offset = "0x92F5C0", VA = "0x180930FC0")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00004F7C File Offset: 0x0000317C
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x931110", Offset = "0x92F710", VA = "0x180931110")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x9311A0", Offset = "0x92F7A0", VA = "0x1809311A0")]
		public static void SendItemDropHeartbeat()
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00004F94 File Offset: 0x00003194
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x9311F0", Offset = "0x92F7F0", VA = "0x1809311F0")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00004FAC File Offset: 0x000031AC
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x931250", Offset = "0x92F850", VA = "0x180931250")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x9313B0", Offset = "0x92F9B0", VA = "0x1809313B0")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00004FDC File Offset: 0x000031DC
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x931400", Offset = "0x92FA00", VA = "0x180931400")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x931540", Offset = "0x92FB40", VA = "0x180931540")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x931760", Offset = "0x92FD60", VA = "0x180931760")]
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00005024 File Offset: 0x00003224
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x9317F0", Offset = "0x92FDF0", VA = "0x1809317F0")]
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x9318C0", Offset = "0x92FEC0", VA = "0x1809318C0")]
		public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x9319F0", Offset = "0x92FFF0", VA = "0x1809319F0")]
		public static SteamAPICall_t RequestPrices()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x931A80", Offset = "0x930080", VA = "0x180931A80")]
		public static uint GetNumItemsWithPrices()
		{
			return 0U;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x931AD0", Offset = "0x9300D0", VA = "0x180931AD0")]
		public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000509C File Offset: 0x0000329C
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x931CF0", Offset = "0x9302F0", VA = "0x180931CF0")]
		public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice)
		{
			return default(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x931D70", Offset = "0x930370", VA = "0x180931D70")]
		public static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x931E00", Offset = "0x930400", VA = "0x180931E00")]
		public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName)
		{
			return default(bool);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x931F40", Offset = "0x930540", VA = "0x180931F40")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue)
		{
			return default(bool);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000050FC File Offset: 0x000032FC
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x932110", Offset = "0x930710", VA = "0x180932110")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue)
		{
			return default(bool);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x932250", Offset = "0x930850", VA = "0x180932250")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue)
		{
			return default(bool);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x932390", Offset = "0x930990", VA = "0x180932390")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue)
		{
			return default(bool);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00005144 File Offset: 0x00003344
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x9324F0", Offset = "0x930AF0", VA = "0x1809324F0")]
		public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000515C File Offset: 0x0000335C
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x932550", Offset = "0x930B50", VA = "0x180932550")]
		public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			return default(bool);
		}
	}
}
