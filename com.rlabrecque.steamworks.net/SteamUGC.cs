using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public static class SteamUGC
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x00006A1C File Offset: 0x00004C1C
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x9452D0", Offset = "0x9438D0", VA = "0x1809452D0")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00006A34 File Offset: 0x00004C34
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x9453B0", Offset = "0x9439B0", VA = "0x1809453B0")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x945480", Offset = "0x943A80", VA = "0x180945480")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, [Optional] string pchCursor)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00006A64 File Offset: 0x00004C64
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x945600", Offset = "0x943C00", VA = "0x180945600")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00006A7C File Offset: 0x00004C7C
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x945710", Offset = "0x943D10", VA = "0x180945710")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00006A94 File Offset: 0x00004C94
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x9457A0", Offset = "0x943DA0", VA = "0x1809457A0")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00006AAC File Offset: 0x00004CAC
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x945820", Offset = "0x943E20", VA = "0x180945820")]
		public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x945880", Offset = "0x943E80", VA = "0x180945880")]
		public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00006ADC File Offset: 0x00004CDC
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x945A20", Offset = "0x944020", VA = "0x180945A20")]
		public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00006AF4 File Offset: 0x00004CF4
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x945BC0", Offset = "0x9441C0", VA = "0x180945BC0")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00006B0C File Offset: 0x00004D0C
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x945D40", Offset = "0x944340", VA = "0x180945D40")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00006B24 File Offset: 0x00004D24
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x945EC0", Offset = "0x9444C0", VA = "0x180945EC0")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00006B3C File Offset: 0x00004D3C
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x945F50", Offset = "0x944550", VA = "0x180945F50")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00006B54 File Offset: 0x00004D54
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x945FE0", Offset = "0x9445E0", VA = "0x180945FE0")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00006B6C File Offset: 0x00004D6C
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x946040", Offset = "0x944640", VA = "0x180946040")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00006B84 File Offset: 0x00004D84
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x9462E0", Offset = "0x9448E0", VA = "0x1809462E0")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00006B9C File Offset: 0x00004D9C
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x946340", Offset = "0x944940", VA = "0x180946340")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00006BB4 File Offset: 0x00004DB4
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x9465D0", Offset = "0x944BD0", VA = "0x1809465D0")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00006BCC File Offset: 0x00004DCC
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x946800", Offset = "0x944E00", VA = "0x180946800")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x946850", Offset = "0x944E50", VA = "0x180946850")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00006BFC File Offset: 0x00004DFC
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x946970", Offset = "0x944F70", VA = "0x180946970")]
		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups)
		{
			return default(bool);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00006C14 File Offset: 0x00004E14
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x946A30", Offset = "0x945030", VA = "0x180946A30")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00006C2C File Offset: 0x00004E2C
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x946B50", Offset = "0x945150", VA = "0x180946B50")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00006C44 File Offset: 0x00004E44
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x946BB0", Offset = "0x9451B0", VA = "0x180946BB0")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00006C5C File Offset: 0x00004E5C
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x946C10", Offset = "0x945210", VA = "0x180946C10")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00006C74 File Offset: 0x00004E74
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x946C70", Offset = "0x945270", VA = "0x180946C70")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00006C8C File Offset: 0x00004E8C
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x946CD0", Offset = "0x9452D0", VA = "0x180946CD0")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x946D30", Offset = "0x945330", VA = "0x180946D30")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00006CBC File Offset: 0x00004EBC
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x946D90", Offset = "0x945390", VA = "0x180946D90")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00006CD4 File Offset: 0x00004ED4
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x946DF0", Offset = "0x9453F0", VA = "0x180946DF0")]
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00006CEC File Offset: 0x00004EEC
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x946E50", Offset = "0x945450", VA = "0x180946E50")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00006D04 File Offset: 0x00004F04
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x946F70", Offset = "0x945570", VA = "0x180946F70")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00006D1C File Offset: 0x00004F1C
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x946FD0", Offset = "0x9455D0", VA = "0x180946FD0")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00006D34 File Offset: 0x00004F34
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x9470F0", Offset = "0x9456F0", VA = "0x1809470F0")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00006D4C File Offset: 0x00004F4C
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x947150", Offset = "0x945750", VA = "0x180947150")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00006D64 File Offset: 0x00004F64
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x947270", Offset = "0x945870", VA = "0x180947270")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00006D7C File Offset: 0x00004F7C
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x9472D0", Offset = "0x9458D0", VA = "0x1809472D0")]
		public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00006D94 File Offset: 0x00004F94
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x947350", Offset = "0x945950", VA = "0x180947350")]
		public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00006DAC File Offset: 0x00004FAC
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x9473D0", Offset = "0x9459D0", VA = "0x1809473D0")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x9475A0", Offset = "0x945BA0", VA = "0x1809475A0")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00006DDC File Offset: 0x00004FDC
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x947640", Offset = "0x945C40", VA = "0x180947640")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00006DF4 File Offset: 0x00004FF4
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x9476E0", Offset = "0x945CE0", VA = "0x1809476E0")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00006E0C File Offset: 0x0000500C
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x947780", Offset = "0x945D80", VA = "0x180947780")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00006E24 File Offset: 0x00005024
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x9478A0", Offset = "0x945EA0", VA = "0x1809478A0")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00006E3C File Offset: 0x0000503C
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x9479C0", Offset = "0x945FC0", VA = "0x1809479C0")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00006E54 File Offset: 0x00005054
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x947AE0", Offset = "0x9460E0", VA = "0x180947AE0")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00006E6C File Offset: 0x0000506C
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x947C00", Offset = "0x946200", VA = "0x180947C00")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00006E84 File Offset: 0x00005084
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x947C60", Offset = "0x946260", VA = "0x180947C60")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00006E9C File Offset: 0x0000509C
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x947D20", Offset = "0x946320", VA = "0x180947D20")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00006EB4 File Offset: 0x000050B4
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x947E40", Offset = "0x946440", VA = "0x180947E40")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00006ECC File Offset: 0x000050CC
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x947F60", Offset = "0x946560", VA = "0x180947F60")]
		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
		{
			return default(bool);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00006EE4 File Offset: 0x000050E4
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x947FC0", Offset = "0x9465C0", VA = "0x180947FC0")]
		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00006EFC File Offset: 0x000050FC
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x948010", Offset = "0x946610", VA = "0x180948010")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00006F14 File Offset: 0x00005114
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x948130", Offset = "0x946730", VA = "0x180948130")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00006F2C File Offset: 0x0000512C
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x948300", Offset = "0x946900", VA = "0x180948300")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00006F44 File Offset: 0x00005144
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x948430", Offset = "0x946A30", VA = "0x180948430")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00006F5C File Offset: 0x0000515C
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x948550", Offset = "0x946B50", VA = "0x180948550")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00006F74 File Offset: 0x00005174
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x948680", Offset = "0x946C80", VA = "0x180948680")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00006F8C File Offset: 0x0000518C
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x9487B0", Offset = "0x946DB0", VA = "0x1809487B0")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00006FA4 File Offset: 0x000051A4
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x948810", Offset = "0x946E10", VA = "0x180948810")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00006FBC File Offset: 0x000051BC
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x948960", Offset = "0x946F60", VA = "0x180948960")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return EItemUpdateStatus.k_EItemUpdateStatusInvalid;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00006FD4 File Offset: 0x000051D4
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x9489E0", Offset = "0x946FE0", VA = "0x1809489E0")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00006FEC File Offset: 0x000051EC
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x948A80", Offset = "0x947080", VA = "0x180948A80")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00007004 File Offset: 0x00005204
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x948B10", Offset = "0x947110", VA = "0x180948B10")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000701C File Offset: 0x0000521C
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x948BB0", Offset = "0x9471B0", VA = "0x180948BB0")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00007034 File Offset: 0x00005234
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x948C50", Offset = "0x947250", VA = "0x180948C50")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000704C File Offset: 0x0000524C
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x948CE0", Offset = "0x9472E0", VA = "0x180948CE0")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00007064 File Offset: 0x00005264
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x948D70", Offset = "0x947370", VA = "0x180948D70")]
		public static uint GetNumSubscribedItems()
		{
			return 0U;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000707C File Offset: 0x0000527C
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x948DC0", Offset = "0x9473C0", VA = "0x180948DC0")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return 0U;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00007094 File Offset: 0x00005294
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x948EA0", Offset = "0x9474A0", VA = "0x180948EA0")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return 0U;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000070AC File Offset: 0x000052AC
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x948EF0", Offset = "0x9474F0", VA = "0x180948EF0")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000070C4 File Offset: 0x000052C4
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x949070", Offset = "0x947670", VA = "0x180949070")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000070DC File Offset: 0x000052DC
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x9490F0", Offset = "0x9476F0", VA = "0x1809490F0")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000070F4 File Offset: 0x000052F4
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x949150", Offset = "0x947750", VA = "0x180949150")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x949270", Offset = "0x947870", VA = "0x180949270")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000710C File Offset: 0x0000530C
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x9492C0", Offset = "0x9478C0", VA = "0x1809492C0")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00007124 File Offset: 0x00005324
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x9493D0", Offset = "0x9479D0", VA = "0x1809493D0")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000713C File Offset: 0x0000533C
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x9494E0", Offset = "0x947AE0", VA = "0x1809494E0")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00007154 File Offset: 0x00005354
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x949560", Offset = "0x947B60", VA = "0x180949560")]
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000716C File Offset: 0x0000536C
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x949600", Offset = "0x947C00", VA = "0x180949600")]
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00007184 File Offset: 0x00005384
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x9496A0", Offset = "0x947CA0", VA = "0x1809496A0")]
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000719C File Offset: 0x0000539C
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x949740", Offset = "0x947D40", VA = "0x180949740")]
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000071B4 File Offset: 0x000053B4
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x9497E0", Offset = "0x947DE0", VA = "0x1809497E0")]
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000071CC File Offset: 0x000053CC
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x949870", Offset = "0x947E70", VA = "0x180949870")]
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000071E4 File Offset: 0x000053E4
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x949900", Offset = "0x947F00", VA = "0x180949900")]
		public static bool ShowWorkshopEULA()
		{
			return default(bool);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000071FC File Offset: 0x000053FC
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x949950", Offset = "0x947F50", VA = "0x180949950")]
		public static SteamAPICall_t GetWorkshopEULAStatus()
		{
			return default(SteamAPICall_t);
		}
	}
}
