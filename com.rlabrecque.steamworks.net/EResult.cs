using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public enum EResult
	{
		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		k_EResultNone,
		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		k_EResultOK,
		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		k_EResultFail,
		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		k_EResultNoConnection,
		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		k_EResultInvalidPassword = 5,
		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		k_EResultLoggedInElsewhere,
		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		k_EResultInvalidProtocolVer,
		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		k_EResultInvalidParam,
		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		k_EResultFileNotFound,
		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		k_EResultBusy,
		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		k_EResultInvalidState,
		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		k_EResultInvalidName,
		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		k_EResultInvalidEmail,
		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		k_EResultDuplicateName,
		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		k_EResultAccessDenied,
		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		k_EResultTimeout,
		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		k_EResultBanned,
		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		k_EResultAccountNotFound,
		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		k_EResultInvalidSteamID,
		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		k_EResultServiceUnavailable,
		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		k_EResultNotLoggedOn,
		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		k_EResultPending,
		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		k_EResultEncryptionFailure,
		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		k_EResultInsufficientPrivilege,
		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		k_EResultLimitExceeded,
		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		k_EResultRevoked,
		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		k_EResultExpired,
		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		k_EResultAlreadyRedeemed,
		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		k_EResultDuplicateRequest,
		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		k_EResultAlreadyOwned,
		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		k_EResultIPNotFound,
		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		k_EResultPersistFailed,
		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		k_EResultLockingFailed,
		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		k_EResultLogonSessionReplaced,
		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		k_EResultConnectFailed,
		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		k_EResultHandshakeFailed,
		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		k_EResultIOFailure,
		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		k_EResultRemoteDisconnect,
		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		k_EResultShoppingCartNotFound,
		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		k_EResultBlocked,
		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		k_EResultIgnored,
		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		k_EResultNoMatch,
		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		k_EResultAccountDisabled,
		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		k_EResultServiceReadOnly,
		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		k_EResultAccountNotFeatured,
		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		k_EResultAdministratorOK,
		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		k_EResultContentVersion,
		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		k_EResultTryAnotherCM,
		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		k_EResultPasswordRequiredToKickSession,
		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		k_EResultAlreadyLoggedInElsewhere,
		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		k_EResultSuspended,
		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		k_EResultCancelled,
		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		k_EResultDataCorruption,
		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		k_EResultDiskFull,
		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		k_EResultRemoteCallFailed,
		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		k_EResultPasswordUnset,
		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		k_EResultExternalAccountUnlinked,
		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		k_EResultPSNTicketInvalid,
		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		k_EResultExternalAccountAlreadyLinked,
		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		k_EResultRemoteFileConflict,
		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		k_EResultIllegalPassword,
		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		k_EResultSameAsPreviousValue,
		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		k_EResultAccountLogonDenied,
		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		k_EResultCannotUseOldPassword,
		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		k_EResultInvalidLoginAuthCode,
		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		k_EResultAccountLogonDeniedNoMail,
		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		k_EResultHardwareNotCapableOfIPT,
		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		k_EResultIPTInitError,
		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		k_EResultParentalControlRestricted,
		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		k_EResultFacebookQueryError,
		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		k_EResultExpiredLoginAuthCode,
		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		k_EResultIPLoginRestrictionFailed,
		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		k_EResultAccountLockedDown,
		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		k_EResultAccountLogonDeniedVerifiedEmailRequired,
		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		k_EResultNoMatchingURL,
		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		k_EResultBadResponse,
		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		k_EResultRequirePasswordReEntry,
		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		k_EResultValueOutOfRange,
		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		k_EResultUnexpectedError,
		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		k_EResultDisabled,
		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		k_EResultInvalidCEGSubmission,
		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		k_EResultRestrictedDevice,
		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		k_EResultRegionLocked,
		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		k_EResultRateLimitExceeded,
		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		k_EResultAccountLoginDeniedNeedTwoFactor,
		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		k_EResultItemDeleted,
		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		k_EResultAccountLoginDeniedThrottle,
		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		k_EResultTwoFactorCodeMismatch,
		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		k_EResultTwoFactorActivationCodeMismatch,
		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		k_EResultAccountAssociatedToMultiplePartners,
		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		k_EResultNotModified,
		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		k_EResultNoMobileDevice,
		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		k_EResultTimeNotSynced,
		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		k_EResultSmsCodeFailed,
		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		k_EResultAccountLimitExceeded,
		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		k_EResultAccountActivityLimitExceeded,
		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		k_EResultPhoneActivityLimitExceeded,
		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		k_EResultRefundToWallet,
		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		k_EResultEmailSendFailure,
		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		k_EResultNotSettled,
		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		k_EResultNeedCaptcha,
		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		k_EResultGSLTDenied,
		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		k_EResultGSOwnerDenied,
		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		k_EResultInvalidItemType,
		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		k_EResultIPBanned,
		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		k_EResultGSLTExpired,
		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		k_EResultInsufficientFunds,
		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		k_EResultTooManyPending,
		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		k_EResultNoSiteLicensesFound,
		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		k_EResultWGNetworkSendExceeded,
		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		k_EResultAccountNotFriends,
		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		k_EResultLimitedUserAccount,
		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		k_EResultCantRemoveItem,
		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		k_EResultAccountDeleted,
		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		k_EResultExistingUserCancelledLicense,
		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		k_EResultCommunityCooldown,
		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		k_EResultNoLauncherSpecified,
		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		k_EResultMustAgreeToSSA,
		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		k_EResultLauncherMigrated,
		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		k_EResultSteamRealmMismatch,
		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		k_EResultInvalidSignature,
		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		k_EResultParseFailure,
		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		k_EResultNoVerifiedPhone
	}
}
