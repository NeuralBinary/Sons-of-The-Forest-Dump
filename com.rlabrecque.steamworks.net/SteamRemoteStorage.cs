using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public static class SteamRemoteStorage
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00006434 File Offset: 0x00004634
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x93F460", Offset = "0x93DA60", VA = "0x18093F460")]
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000644C File Offset: 0x0000464C
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x93F660", Offset = "0x93DC60", VA = "0x18093F660")]
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			return 0;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00006464 File Offset: 0x00004664
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x93F850", Offset = "0x93DE50", VA = "0x18093F850")]
		public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000647C File Offset: 0x0000467C
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x93FA70", Offset = "0x93E070", VA = "0x18093FA70")]
		public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00006494 File Offset: 0x00004694
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x93FC90", Offset = "0x93E290", VA = "0x18093FC90")]
		public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead)
		{
			return default(bool);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000064AC File Offset: 0x000046AC
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x93FD80", Offset = "0x93E380", VA = "0x18093FD80")]
		public static bool FileForget(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000064C4 File Offset: 0x000046C4
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x93FF70", Offset = "0x93E570", VA = "0x18093FF70")]
		public static bool FileDelete(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000064DC File Offset: 0x000046DC
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x940160", Offset = "0x93E760", VA = "0x180940160")]
		public static SteamAPICall_t FileShare(string pchFile)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000064F4 File Offset: 0x000046F4
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x940370", Offset = "0x93E970", VA = "0x180940370")]
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			return default(bool);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000650C File Offset: 0x0000470C
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x940560", Offset = "0x93EB60", VA = "0x180940560")]
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00006524 File Offset: 0x00004724
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x940770", Offset = "0x93ED70", VA = "0x180940770")]
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000653C File Offset: 0x0000473C
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x940860", Offset = "0x93EE60", VA = "0x180940860")]
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00006554 File Offset: 0x00004754
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x940920", Offset = "0x93EF20", VA = "0x180940920")]
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000656C File Offset: 0x0000476C
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x9409E0", Offset = "0x93EFE0", VA = "0x1809409E0")]
		public static bool FileExists(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00006584 File Offset: 0x00004784
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x940BD0", Offset = "0x93F1D0", VA = "0x180940BD0")]
		public static bool FilePersisted(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000659C File Offset: 0x0000479C
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x940DC0", Offset = "0x93F3C0", VA = "0x180940DC0")]
		public static int GetFileSize(string pchFile)
		{
			return 0;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000065B4 File Offset: 0x000047B4
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x940FB0", Offset = "0x93F5B0", VA = "0x180940FB0")]
		public static long GetFileTimestamp(string pchFile)
		{
			return 0L;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000065CC File Offset: 0x000047CC
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x9411A0", Offset = "0x93F7A0", VA = "0x1809411A0")]
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			return ERemoteStoragePlatform.k_ERemoteStoragePlatformNone;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000065E4 File Offset: 0x000047E4
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x941390", Offset = "0x93F990", VA = "0x180941390")]
		public static int GetFileCount()
		{
			return 0;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x941440", Offset = "0x93FA40", VA = "0x180941440")]
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			return null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000065FC File Offset: 0x000047FC
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x941510", Offset = "0x93FB10", VA = "0x180941510")]
		public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes)
		{
			return default(bool);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00006614 File Offset: 0x00004814
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x9415E0", Offset = "0x93FBE0", VA = "0x1809415E0")]
		public static bool IsCloudEnabledForAccount()
		{
			return default(bool);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000662C File Offset: 0x0000482C
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x941690", Offset = "0x93FC90", VA = "0x180941690")]
		public static bool IsCloudEnabledForApp()
		{
			return default(bool);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x941740", Offset = "0x93FD40", VA = "0x180941740")]
		public static void SetCloudEnabledForApp(bool bEnabled)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00006644 File Offset: 0x00004844
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x941800", Offset = "0x93FE00", VA = "0x180941800")]
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000665C File Offset: 0x0000485C
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x941900", Offset = "0x93FF00", VA = "0x180941900")]
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			return default(bool);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00006674 File Offset: 0x00004874
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9419E0", Offset = "0x93FFE0", VA = "0x1809419E0")]
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			return default(bool);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000668C File Offset: 0x0000488C
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x941B40", Offset = "0x940140", VA = "0x180941B40")]
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			return 0;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000066A4 File Offset: 0x000048A4
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x941C50", Offset = "0x940250", VA = "0x180941C50")]
		public static int GetCachedUGCCount()
		{
			return 0;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000066BC File Offset: 0x000048BC
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x941D00", Offset = "0x940300", VA = "0x180941D00")]
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			return default(UGCHandle_t);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000066D4 File Offset: 0x000048D4
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x941DF0", Offset = "0x9403F0", VA = "0x180941DF0")]
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000066EC File Offset: 0x000048EC
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x942180", Offset = "0x940780", VA = "0x180942180")]
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00006704 File Offset: 0x00004904
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x942270", Offset = "0x940870", VA = "0x180942270")]
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			return default(bool);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000671C File Offset: 0x0000491C
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x942460", Offset = "0x940A60", VA = "0x180942460")]
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00006734 File Offset: 0x00004934
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x942650", Offset = "0x940C50", VA = "0x180942650")]
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			return default(bool);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000674C File Offset: 0x0000494C
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x942840", Offset = "0x940E40", VA = "0x180942840")]
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			return default(bool);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00006764 File Offset: 0x00004964
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x942A30", Offset = "0x941030", VA = "0x180942A30")]
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000677C File Offset: 0x0000497C
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x942B00", Offset = "0x941100", VA = "0x180942B00")]
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00006794 File Offset: 0x00004994
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x942C30", Offset = "0x941230", VA = "0x180942C30")]
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000067AC File Offset: 0x000049AC
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x942D20", Offset = "0x941320", VA = "0x180942D20")]
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000067C4 File Offset: 0x000049C4
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x942E20", Offset = "0x941420", VA = "0x180942E20")]
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000067DC File Offset: 0x000049DC
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x942F10", Offset = "0x941510", VA = "0x180942F10")]
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000067F4 File Offset: 0x000049F4
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x943000", Offset = "0x941600", VA = "0x180943000")]
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000680C File Offset: 0x00004A0C
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9430F0", Offset = "0x9416F0", VA = "0x1809430F0")]
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00006824 File Offset: 0x00004A24
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x9431E0", Offset = "0x9417E0", VA = "0x1809431E0")]
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000683C File Offset: 0x00004A3C
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x9432D0", Offset = "0x9418D0", VA = "0x1809432D0")]
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			return default(bool);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00006854 File Offset: 0x00004A54
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9434C0", Offset = "0x941AC0", VA = "0x1809434C0")]
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000686C File Offset: 0x00004A6C
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9435B0", Offset = "0x941BB0", VA = "0x1809435B0")]
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00006884 File Offset: 0x00004A84
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x9436C0", Offset = "0x941CC0", VA = "0x1809436C0")]
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000689C File Offset: 0x00004A9C
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x9437B0", Offset = "0x941DB0", VA = "0x1809437B0")]
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000068B4 File Offset: 0x00004AB4
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x943940", Offset = "0x941F40", VA = "0x180943940")]
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000068CC File Offset: 0x00004ACC
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x943D60", Offset = "0x942360", VA = "0x180943D60")]
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000068E4 File Offset: 0x00004AE4
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x943E60", Offset = "0x942460", VA = "0x180943E60")]
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000068FC File Offset: 0x00004AFC
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x943F60", Offset = "0x942560", VA = "0x180943F60")]
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00006914 File Offset: 0x00004B14
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x944110", Offset = "0x942710", VA = "0x180944110")]
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000692C File Offset: 0x00004B2C
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x944330", Offset = "0x942930", VA = "0x180944330")]
		public static int GetLocalFileChangeCount()
		{
			return 0;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9443E0", Offset = "0x9429E0", VA = "0x1809443E0")]
		public static string GetLocalFileChange(int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType)
		{
			return null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00006944 File Offset: 0x00004B44
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x9444C0", Offset = "0x942AC0", VA = "0x1809444C0")]
		public static bool BeginFileWriteBatch()
		{
			return default(bool);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000695C File Offset: 0x00004B5C
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x944570", Offset = "0x942B70", VA = "0x180944570")]
		public static bool EndFileWriteBatch()
		{
			return default(bool);
		}
	}
}
