using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public static class SteamGameServerUGC
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00003E84 File Offset: 0x00002084
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x924580", Offset = "0x922B80", VA = "0x180924580")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x924660", Offset = "0x922C60", VA = "0x180924660")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x924730", Offset = "0x922D30", VA = "0x180924730")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, [Optional] string pchCursor)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x9248B0", Offset = "0x922EB0", VA = "0x1809248B0")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00003EE4 File Offset: 0x000020E4
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x9249C0", Offset = "0x922FC0", VA = "0x1809249C0")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x924A50", Offset = "0x923050", VA = "0x180924A50")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x924AD0", Offset = "0x9230D0", VA = "0x180924AD0")]
		public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x924B30", Offset = "0x923130", VA = "0x180924B30")]
		public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x924CD0", Offset = "0x9232D0", VA = "0x180924CD0")]
		public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x924E70", Offset = "0x923470", VA = "0x180924E70")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x924FF0", Offset = "0x9235F0", VA = "0x180924FF0")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x925170", Offset = "0x923770", VA = "0x180925170")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x925200", Offset = "0x923800", VA = "0x180925200")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x925290", Offset = "0x923890", VA = "0x180925290")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x9252F0", Offset = "0x9238F0", VA = "0x1809252F0")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x925590", Offset = "0x923B90", VA = "0x180925590")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x9255F0", Offset = "0x923BF0", VA = "0x1809255F0")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x925880", Offset = "0x923E80", VA = "0x180925880")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x925AB0", Offset = "0x9240B0", VA = "0x180925AB0")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x925B00", Offset = "0x924100", VA = "0x180925B00")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x925C20", Offset = "0x924220", VA = "0x180925C20")]
		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups)
		{
			return default(bool);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x925CE0", Offset = "0x9242E0", VA = "0x180925CE0")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x925E00", Offset = "0x924400", VA = "0x180925E00")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x925E60", Offset = "0x924460", VA = "0x180925E60")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x925EC0", Offset = "0x9244C0", VA = "0x180925EC0")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x925F20", Offset = "0x924520", VA = "0x180925F20")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x925F80", Offset = "0x924580", VA = "0x180925F80")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000410C File Offset: 0x0000230C
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x925FE0", Offset = "0x9245E0", VA = "0x180925FE0")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x926040", Offset = "0x924640", VA = "0x180926040")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x9260A0", Offset = "0x9246A0", VA = "0x1809260A0")]
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x926100", Offset = "0x924700", VA = "0x180926100")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x926220", Offset = "0x924820", VA = "0x180926220")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x926280", Offset = "0x924880", VA = "0x180926280")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x9263A0", Offset = "0x9249A0", VA = "0x1809263A0")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x926400", Offset = "0x924A00", VA = "0x180926400")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x926520", Offset = "0x924B20", VA = "0x180926520")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x926580", Offset = "0x924B80", VA = "0x180926580")]
		public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x926600", Offset = "0x924C00", VA = "0x180926600")]
		public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x926680", Offset = "0x924C80", VA = "0x180926680")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x926850", Offset = "0x924E50", VA = "0x180926850")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x9268F0", Offset = "0x924EF0", VA = "0x1809268F0")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x926990", Offset = "0x924F90", VA = "0x180926990")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x926A30", Offset = "0x925030", VA = "0x180926A30")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x926B50", Offset = "0x925150", VA = "0x180926B50")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x926C70", Offset = "0x925270", VA = "0x180926C70")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x926D90", Offset = "0x925390", VA = "0x180926D90")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x926EB0", Offset = "0x9254B0", VA = "0x180926EB0")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x926F10", Offset = "0x925510", VA = "0x180926F10")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x926FD0", Offset = "0x9255D0", VA = "0x180926FD0")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x9270F0", Offset = "0x9256F0", VA = "0x1809270F0")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x927210", Offset = "0x925810", VA = "0x180927210")]
		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
		{
			return default(bool);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x927270", Offset = "0x925870", VA = "0x180927270")]
		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004364 File Offset: 0x00002564
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x9272C0", Offset = "0x9258C0", VA = "0x1809272C0")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000437C File Offset: 0x0000257C
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x9273E0", Offset = "0x9259E0", VA = "0x1809273E0")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x9275B0", Offset = "0x925BB0", VA = "0x1809275B0")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x9276E0", Offset = "0x925CE0", VA = "0x1809276E0")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x927800", Offset = "0x925E00", VA = "0x180927800")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x927930", Offset = "0x925F30", VA = "0x180927930")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x927A60", Offset = "0x926060", VA = "0x180927A60")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x927AC0", Offset = "0x9260C0", VA = "0x180927AC0")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x927C10", Offset = "0x926210", VA = "0x180927C10")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return EItemUpdateStatus.k_EItemUpdateStatusInvalid;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000443C File Offset: 0x0000263C
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x927C90", Offset = "0x926290", VA = "0x180927C90")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x927D30", Offset = "0x926330", VA = "0x180927D30")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000446C File Offset: 0x0000266C
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x927DC0", Offset = "0x9263C0", VA = "0x180927DC0")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x927E60", Offset = "0x926460", VA = "0x180927E60")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000449C File Offset: 0x0000269C
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x927F00", Offset = "0x926500", VA = "0x180927F00")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x927F90", Offset = "0x926590", VA = "0x180927F90")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x928020", Offset = "0x926620", VA = "0x180928020")]
		public static uint GetNumSubscribedItems()
		{
			return 0U;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x928070", Offset = "0x926670", VA = "0x180928070")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return 0U;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x928150", Offset = "0x926750", VA = "0x180928150")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return 0U;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x9281A0", Offset = "0x9267A0", VA = "0x1809281A0")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x928320", Offset = "0x926920", VA = "0x180928320")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x9283A0", Offset = "0x9269A0", VA = "0x1809283A0")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x928400", Offset = "0x926A00", VA = "0x180928400")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x928520", Offset = "0x926B20", VA = "0x180928520")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x928570", Offset = "0x926B70", VA = "0x180928570")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x928680", Offset = "0x926C80", VA = "0x180928680")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x928790", Offset = "0x926D90", VA = "0x180928790")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x928810", Offset = "0x926E10", VA = "0x180928810")]
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x9288B0", Offset = "0x926EB0", VA = "0x1809288B0")]
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x928950", Offset = "0x926F50", VA = "0x180928950")]
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x9289F0", Offset = "0x926FF0", VA = "0x1809289F0")]
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x928A90", Offset = "0x927090", VA = "0x180928A90")]
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x928B20", Offset = "0x927120", VA = "0x180928B20")]
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x928BB0", Offset = "0x9271B0", VA = "0x180928BB0")]
		public static bool ShowWorkshopEULA()
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00")]
		public static SteamAPICall_t GetWorkshopEULAStatus()
		{
			return default(SteamAPICall_t);
		}
	}
}
