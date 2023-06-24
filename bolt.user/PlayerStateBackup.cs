using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000091 RID: 145
[Token(Token = "0x2000091")]
internal class PlayerStateBackup : NetworkState, IPlayerStateBackup, IWorldCharacter, IState, IDisposable
{
	// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x8160C0", Offset = "0x8146C0", VA = "0x1808160C0")]
	public PlayerStateBackup()
	{
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x060005BC RID: 1468 RVA: 0x00003BA0 File Offset: 0x00001DA0
	// (set) Token: 0x060005BD RID: 1469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000311")]
	public float CharacterScale
	{
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70", Slot = "202")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x7C3CD0", Offset = "0x7C22D0", VA = "0x1807C3CD0", Slot = "203")]
		set
		{
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x060005BE RID: 1470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000312")]
	public NetworkArray_Integer MecanimLayerHashes
	{
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x816120", Offset = "0x814720", VA = "0x180816120", Slot = "204")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x060005BF RID: 1471 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000313")]
	public NetworkArray_Float MecanimLayerWeights
	{
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x8161E0", Offset = "0x8147E0", VA = "0x1808161E0", Slot = "205")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000314")]
	public NetworkArray_Float MecanimLayerTimes
	{
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x8162A0", Offset = "0x8148A0", VA = "0x1808162A0", Slot = "206")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00003BB8 File Offset: 0x00001DB8
	// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000315")]
	public float MecanimSpeed
	{
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x7C3FF0", Offset = "0x7C25F0", VA = "0x1807C3FF0", Slot = "207")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x7C4050", Offset = "0x7C2650", VA = "0x1807C4050", Slot = "208")]
		set
		{
		}
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x17000316")]
	public float _Layer0
	{
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x816360", Offset = "0x814960", VA = "0x180816360", Slot = "31")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x17000317")]
	public float _Layer1
	{
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x80CF00", Offset = "0x80B500", VA = "0x18080CF00", Slot = "32")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00003C00 File Offset: 0x00001E00
	[Token(Token = "0x17000318")]
	public float _Layer2
	{
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x80D070", Offset = "0x80B670", VA = "0x18080D070", Slot = "33")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00003C18 File Offset: 0x00001E18
	[Token(Token = "0x17000319")]
	public float _Layer3
	{
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x8163C0", Offset = "0x8149C0", VA = "0x1808163C0", Slot = "34")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x1700031A")]
	public float _Layer4
	{
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x816420", Offset = "0x814A20", VA = "0x180816420", Slot = "35")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00003C48 File Offset: 0x00001E48
	// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700031B")]
	public int itemInLeftHand
	{
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x810350", Offset = "0x80E950", VA = "0x180810350", Slot = "36")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x816480", Offset = "0x814A80", VA = "0x180816480", Slot = "37")]
		set
		{
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x060005CA RID: 1482 RVA: 0x00003C60 File Offset: 0x00001E60
	// (set) Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700031C")]
	public int itemInRightHand
	{
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8104A0", Offset = "0x80EAA0", VA = "0x1808104A0", Slot = "38")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x816570", Offset = "0x814B70", VA = "0x180816570", Slot = "39")]
		set
		{
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x060005CC RID: 1484 RVA: 0x00003C78 File Offset: 0x00001E78
	[Token(Token = "0x1700031D")]
	public bool stickHeld
	{
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x816660", Offset = "0x814C60", VA = "0x180816660", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x060005CD RID: 1485 RVA: 0x00003C90 File Offset: 0x00001E90
	[Token(Token = "0x1700031E")]
	public bool attack
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x8166C0", Offset = "0x814CC0", VA = "0x1808166C0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x060005CE RID: 1486 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x1700031F")]
	public int randInt1
	{
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x816720", Offset = "0x814D20", VA = "0x180816720", Slot = "42")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x060005CF RID: 1487 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x17000320")]
	public float hSpeed
	{
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x816780", Offset = "0x814D80", VA = "0x180816780", Slot = "43")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x17000321")]
	public float vSpeed
	{
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x7D6590", Offset = "0x7D4B90", VA = "0x1807D6590", Slot = "44")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x17000322")]
	public float overallSpeed
	{
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x810CB0", Offset = "0x80F2B0", VA = "0x180810CB0", Slot = "45")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x17000323")]
	public bool AxeAttack
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x810E20", Offset = "0x80F420", VA = "0x180810E20", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x17000324")]
	public float weaponHit
	{
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x8167E0", Offset = "0x814DE0", VA = "0x1808167E0", Slot = "47")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x17000325")]
	public bool gunAttack
	{
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x816840", Offset = "0x814E40", VA = "0x180816840", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x17000326")]
	public bool itemHeld
	{
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x8168A0", Offset = "0x814EA0", VA = "0x1808168A0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00003D68 File Offset: 0x00001F68
	[Token(Token = "0x17000327")]
	public bool axeHeld
	{
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x811450", Offset = "0x80FA50", VA = "0x180811450", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00003D80 File Offset: 0x00001F80
	[Token(Token = "0x17000328")]
	public bool stickAttack
	{
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x816900", Offset = "0x814F00", VA = "0x180816900", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00003D98 File Offset: 0x00001F98
	[Token(Token = "0x17000329")]
	public int hitDirection
	{
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x811700", Offset = "0x80FD00", VA = "0x180811700", Slot = "52")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00003DB0 File Offset: 0x00001FB0
	[Token(Token = "0x1700032A")]
	public bool stickShove
	{
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x816960", Offset = "0x814F60", VA = "0x180816960", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x060005DA RID: 1498 RVA: 0x00003DC8 File Offset: 0x00001FC8
	[Token(Token = "0x1700032B")]
	public bool smallTree
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x8169C0", Offset = "0x814FC0", VA = "0x1808169C0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x060005DB RID: 1499 RVA: 0x00003DE0 File Offset: 0x00001FE0
	[Token(Token = "0x1700032C")]
	public bool stickBlock
	{
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x811B00", Offset = "0x810100", VA = "0x180811B00", Slot = "55")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x060005DC RID: 1500 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[Token(Token = "0x1700032D")]
	public bool nextHit
	{
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x816A20", Offset = "0x815020", VA = "0x180816A20", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x060005DD RID: 1501 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x1700032E")]
	public bool flaregunHeld
	{
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x816A80", Offset = "0x815080", VA = "0x180816A80", Slot = "57")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x060005DE RID: 1502 RVA: 0x00003E28 File Offset: 0x00002028
	[Token(Token = "0x1700032F")]
	public bool lighterHeld
	{
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x811F20", Offset = "0x810520", VA = "0x180811F20", Slot = "58")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x060005DF RID: 1503 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x17000330")]
	public bool checkArms
	{
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x816AE0", Offset = "0x8150E0", VA = "0x180816AE0", Slot = "59")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00003E58 File Offset: 0x00002058
	[Token(Token = "0x17000331")]
	public bool pedHeld
	{
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x816B40", Offset = "0x815140", VA = "0x180816B40", Slot = "60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x17000332")]
	public bool lighterIgnite
	{
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x816BA0", Offset = "0x8151A0", VA = "0x180816BA0", Slot = "61")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00003E88 File Offset: 0x00002088
	[Token(Token = "0x17000333")]
	public bool flashLightHeld
	{
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x816C00", Offset = "0x815200", VA = "0x180816C00", Slot = "62")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x17000334")]
	public bool batteryDead
	{
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x816C60", Offset = "0x815260", VA = "0x180816C60", Slot = "63")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x17000335")]
	public float normCamX
	{
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x816CC0", Offset = "0x8152C0", VA = "0x180816CC0", Slot = "64")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x17000336")]
	public bool crouchIdle
	{
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x816D20", Offset = "0x815320", VA = "0x180816D20", Slot = "65")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x17000337")]
	public float normCamY
	{
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x816D80", Offset = "0x815380", VA = "0x180816D80", Slot = "66")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x17000338")]
	public float pedIdleBlend
	{
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x816DE0", Offset = "0x8153E0", VA = "0x180816DE0", Slot = "67")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x17000339")]
	public float breatheFloat
	{
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x7C5580", Offset = "0x7C3B80", VA = "0x1807C5580", Slot = "68")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x1700033A")]
	public float tiredFloat
	{
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x816E40", Offset = "0x815440", VA = "0x180816E40", Slot = "69")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x060005EA RID: 1514 RVA: 0x00003F48 File Offset: 0x00002148
	[Token(Token = "0x1700033B")]
	public bool rockHeld
	{
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x816EA0", Offset = "0x8154A0", VA = "0x180816EA0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x060005EB RID: 1515 RVA: 0x00003F60 File Offset: 0x00002160
	[Token(Token = "0x1700033C")]
	public bool smashBool
	{
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x816F00", Offset = "0x815500", VA = "0x180816F00", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x060005EC RID: 1516 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x1700033D")]
	public float aimAtTarget
	{
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x816F60", Offset = "0x815560", VA = "0x180816F60", Slot = "72")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x060005ED RID: 1517 RVA: 0x00003F90 File Offset: 0x00002190
	// (set) Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700033E")]
	public float Gravity
	{
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x7C59B0", Offset = "0x7C3FB0", VA = "0x1807C59B0", Slot = "73")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x816FC0", Offset = "0x8155C0", VA = "0x180816FC0", Slot = "74")]
		set
		{
		}
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x060005EF RID: 1519 RVA: 0x00003FA8 File Offset: 0x000021A8
	[Token(Token = "0x1700033F")]
	public bool onHand
	{
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x8170D0", Offset = "0x8156D0", VA = "0x1808170D0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00003FC0 File Offset: 0x000021C0
	[Token(Token = "0x17000340")]
	public bool leanForward
	{
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x817130", Offset = "0x815730", VA = "0x180817130", Slot = "76")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00003FD8 File Offset: 0x000021D8
	[Token(Token = "0x17000341")]
	public float crouch
	{
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x817190", Offset = "0x815790", VA = "0x180817190", Slot = "77")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x17000342")]
	public bool comboBool
	{
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x8171F0", Offset = "0x8157F0", VA = "0x1808171F0", Slot = "78")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00004008 File Offset: 0x00002208
	[Token(Token = "0x17000343")]
	public bool bigTree
	{
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x817250", Offset = "0x815850", VA = "0x180817250", Slot = "79")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00004020 File Offset: 0x00002220
	[Token(Token = "0x17000344")]
	public bool attackHighBool
	{
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x8172B0", Offset = "0x8158B0", VA = "0x1808172B0", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00004038 File Offset: 0x00002238
	[Token(Token = "0x17000345")]
	public bool spearHeld
	{
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x817310", Offset = "0x815910", VA = "0x180817310", Slot = "81")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00004050 File Offset: 0x00002250
	[Token(Token = "0x17000346")]
	public bool ballHeld
	{
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x817370", Offset = "0x815970", VA = "0x180817370", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00004068 File Offset: 0x00002268
	[Token(Token = "0x17000347")]
	public bool molotovHeld
	{
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x8173D0", Offset = "0x8159D0", VA = "0x1808173D0", Slot = "83")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00004080 File Offset: 0x00002280
	[Token(Token = "0x17000348")]
	public bool parryBool
	{
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x817430", Offset = "0x815A30", VA = "0x180817430", Slot = "84")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000349")]
	public Action OnknockBackTrigger
	{
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x817490", Offset = "0x815A90", VA = "0x180817490", Slot = "85")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x817530", Offset = "0x815B30", VA = "0x180817530", Slot = "86")]
		set
		{
		}
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x060005FB RID: 1531 RVA: 0x00004098 File Offset: 0x00002298
	[Token(Token = "0x1700034A")]
	public bool spearRaiseBool
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x8175E0", Offset = "0x815BE0", VA = "0x1808175E0", Slot = "87")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x060005FC RID: 1532 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x1700034B")]
	public bool walkmanHeld
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x817640", Offset = "0x815C40", VA = "0x180817640", Slot = "88")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x060005FD RID: 1533 RVA: 0x000040C8 File Offset: 0x000022C8
	[Token(Token = "0x1700034C")]
	public bool walkmanPlayBool
	{
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x8176A0", Offset = "0x815CA0", VA = "0x1808176A0", Slot = "89")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x060005FE RID: 1534 RVA: 0x000040E0 File Offset: 0x000022E0
	[Token(Token = "0x1700034D")]
	public float connectFloat
	{
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x7C5DC0", Offset = "0x7C43C0", VA = "0x1807C5DC0", Slot = "90")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x060005FF RID: 1535 RVA: 0x000040F8 File Offset: 0x000022F8
	[Token(Token = "0x1700034E")]
	public bool movingBool
	{
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x817700", Offset = "0x815D00", VA = "0x180817700", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06000600 RID: 1536 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x1700034F")]
	public bool deathBool
	{
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x7C5E20", Offset = "0x7C4420", VA = "0x1807C5E20", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06000601 RID: 1537 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000350")]
	public Action OndeathTrigger
	{
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x817760", Offset = "0x815D60", VA = "0x180817760", Slot = "93")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x817800", Offset = "0x815E00", VA = "0x180817800", Slot = "94")]
		set
		{
		}
	}

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x06000603 RID: 1539 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000351")]
	public Action OnresetTrigger
	{
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x8178B0", Offset = "0x815EB0", VA = "0x1808178B0", Slot = "95")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x817950", Offset = "0x815F50", VA = "0x180817950", Slot = "96")]
		set
		{
		}
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x06000605 RID: 1541 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x17000352")]
	public float groundHeight
	{
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x7C6140", Offset = "0x7C4740", VA = "0x1807C6140", Slot = "97")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x06000606 RID: 1542 RVA: 0x00004140 File Offset: 0x00002340
	[Token(Token = "0x17000353")]
	public bool flareHeld
	{
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x817A00", Offset = "0x816000", VA = "0x180817A00", Slot = "98")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x06000607 RID: 1543 RVA: 0x00004158 File Offset: 0x00002358
	[Token(Token = "0x17000354")]
	public bool oculusDemoBool
	{
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x817A60", Offset = "0x816060", VA = "0x180817A60", Slot = "99")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x06000608 RID: 1544 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x17000355")]
	public bool swimmingBool
	{
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x817AC0", Offset = "0x8160C0", VA = "0x180817AC0", Slot = "100")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x06000609 RID: 1545 RVA: 0x00004188 File Offset: 0x00002388
	[Token(Token = "0x17000356")]
	public bool genericHeld
	{
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x7C6200", Offset = "0x7C4800", VA = "0x1807C6200", Slot = "101")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x0600060A RID: 1546 RVA: 0x000041A0 File Offset: 0x000023A0
	[Token(Token = "0x17000357")]
	public bool genericWideHeld
	{
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x817B20", Offset = "0x816120", VA = "0x180817B20", Slot = "102")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x0600060B RID: 1547 RVA: 0x000041B8 File Offset: 0x000023B8
	[Token(Token = "0x17000358")]
	public bool sittingBool
	{
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x817B80", Offset = "0x816180", VA = "0x180817B80", Slot = "103")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x0600060C RID: 1548 RVA: 0x000041D0 File Offset: 0x000023D0
	[Token(Token = "0x17000359")]
	public bool birdResetBool
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x817BE0", Offset = "0x8161E0", VA = "0x180817BE0", Slot = "104")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x0600060D RID: 1549 RVA: 0x000041E8 File Offset: 0x000023E8
	[Token(Token = "0x1700035A")]
	public bool logHeld
	{
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x817C40", Offset = "0x816240", VA = "0x180817C40", Slot = "105")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x0600060E RID: 1550 RVA: 0x00004200 File Offset: 0x00002400
	[Token(Token = "0x1700035B")]
	public bool bowHeld
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x817CA0", Offset = "0x8162A0", VA = "0x180817CA0", Slot = "106")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x0600060F RID: 1551 RVA: 0x00004218 File Offset: 0x00002418
	[Token(Token = "0x1700035C")]
	public bool drawBowBool
	{
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x7C6650", Offset = "0x7C4C50", VA = "0x1807C6650", Slot = "107")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x06000610 RID: 1552 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700035D")]
	public Action OncancelBowTrigger
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x817D00", Offset = "0x816300", VA = "0x180817D00", Slot = "108")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x817DA0", Offset = "0x8163A0", VA = "0x180817DA0", Slot = "109")]
		set
		{
		}
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x06000612 RID: 1554 RVA: 0x00004230 File Offset: 0x00002430
	[Token(Token = "0x1700035E")]
	public bool bowFireBool
	{
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x817E50", Offset = "0x816450", VA = "0x180817E50", Slot = "110")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x06000613 RID: 1555 RVA: 0x00004248 File Offset: 0x00002448
	[Token(Token = "0x1700035F")]
	public bool smallAxe
	{
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x817EB0", Offset = "0x8164B0", VA = "0x180817EB0", Slot = "111")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x06000614 RID: 1556 RVA: 0x00004260 File Offset: 0x00002460
	[Token(Token = "0x17000360")]
	public bool paddleIdleBool
	{
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x817F10", Offset = "0x816510", VA = "0x180817F10", Slot = "112")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x06000615 RID: 1557 RVA: 0x00004278 File Offset: 0x00002478
	[Token(Token = "0x17000361")]
	public bool paddleBool
	{
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x817F70", Offset = "0x816570", VA = "0x180817F70", Slot = "113")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x06000616 RID: 1558 RVA: 0x00004290 File Offset: 0x00002490
	[Token(Token = "0x17000362")]
	public bool groundAxeChopBool
	{
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x817FD0", Offset = "0x8165D0", VA = "0x180817FD0", Slot = "114")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000363")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x818030", Offset = "0x816630", VA = "0x180818030", Slot = "115")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x06000618 RID: 1560 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000364")]
	public string name
	{
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x818090", Offset = "0x816690", VA = "0x180818090", Slot = "116")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x818130", Offset = "0x816730", VA = "0x180818130", Slot = "117")]
		set
		{
		}
	}

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x0600061A RID: 1562 RVA: 0x000042A8 File Offset: 0x000024A8
	// (set) Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000365")]
	public int logsHeld
	{
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x8182C0", Offset = "0x8168C0", VA = "0x1808182C0", Slot = "118")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x818320", Offset = "0x816920", VA = "0x180818320", Slot = "119")]
		set
		{
		}
	}

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x0600061C RID: 1564 RVA: 0x000042C0 File Offset: 0x000024C0
	// (set) Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000366")]
	public int CurrentView
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x818420", Offset = "0x816A20", VA = "0x180818420", Slot = "120")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x818480", Offset = "0x816A80", VA = "0x180818480", Slot = "121")]
		set
		{
		}
	}

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x0600061E RID: 1566 RVA: 0x000042D8 File Offset: 0x000024D8
	// (set) Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000367")]
	public bool BatteryTorchEnabled
	{
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x7C6920", Offset = "0x7C4F20", VA = "0x1807C6920", Slot = "122")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x818580", Offset = "0x816B80", VA = "0x180818580", Slot = "123")]
		set
		{
		}
	}

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x06000620 RID: 1568 RVA: 0x000042F0 File Offset: 0x000024F0
	// (set) Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000368")]
	public Color BatteryTorchColor
	{
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x818670", Offset = "0x816C70", VA = "0x180818670", Slot = "124")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x8186E0", Offset = "0x816CE0", VA = "0x1808186E0", Slot = "125")]
		set
		{
		}
	}

	// Token: 0x17000369 RID: 873
	// (get) Token: 0x06000622 RID: 1570 RVA: 0x00004308 File Offset: 0x00002508
	// (set) Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000369")]
	public float BatteryTorchIntensity
	{
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x818830", Offset = "0x816E30", VA = "0x180818830", Slot = "126")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x818890", Offset = "0x816E90", VA = "0x180818890", Slot = "127")]
		set
		{
		}
	}

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x06000624 RID: 1572 RVA: 0x00004320 File Offset: 0x00002520
	// (set) Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700036A")]
	public int PlayerVariation
	{
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x818980", Offset = "0x816F80", VA = "0x180818980", Slot = "128")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x8189E0", Offset = "0x816FE0", VA = "0x1808189E0", Slot = "129")]
		set
		{
		}
	}

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x06000626 RID: 1574 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700036B")]
	public Action OninjuredTrigger
	{
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x818AD0", Offset = "0x8170D0", VA = "0x180818AD0", Slot = "130")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x818B70", Offset = "0x817170", VA = "0x180818B70", Slot = "131")]
		set
		{
		}
	}

	// Token: 0x1700036C RID: 876
	// (get) Token: 0x06000628 RID: 1576 RVA: 0x00004338 File Offset: 0x00002538
	[Token(Token = "0x1700036C")]
	public bool injuredBool
	{
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x818C20", Offset = "0x817220", VA = "0x180818C20", Slot = "132")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700036D RID: 877
	// (get) Token: 0x06000629 RID: 1577 RVA: 0x00004350 File Offset: 0x00002550
	[Token(Token = "0x1700036D")]
	public bool genericHoldPouch
	{
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x818C80", Offset = "0x817280", VA = "0x180818C80", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x0600062A RID: 1578 RVA: 0x00004368 File Offset: 0x00002568
	[Token(Token = "0x1700036E")]
	public bool setClimbBool
	{
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x818CE0", Offset = "0x8172E0", VA = "0x180818CE0", Slot = "134")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x0600062B RID: 1579 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700036F")]
	public Action OnsetClimbTrigger
	{
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x818D40", Offset = "0x817340", VA = "0x180818D40", Slot = "135")]
		get
		{
			return null;
		}
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x818DE0", Offset = "0x8173E0", VA = "0x180818DE0", Slot = "136")]
		set
		{
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x0600062D RID: 1581 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000370")]
	public Action OnsetClimbTopTrigger
	{
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x818E90", Offset = "0x817490", VA = "0x180818E90", Slot = "137")]
		get
		{
			return null;
		}
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x818F30", Offset = "0x817530", VA = "0x180818F30", Slot = "138")]
		set
		{
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x0600062F RID: 1583 RVA: 0x00004380 File Offset: 0x00002580
	[Token(Token = "0x17000371")]
	public int climbDirInt
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x818FE0", Offset = "0x8175E0", VA = "0x180818FE0", Slot = "139")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06000630 RID: 1584 RVA: 0x00004398 File Offset: 0x00002598
	[Token(Token = "0x17000372")]
	public bool pushSledBool
	{
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x819040", Offset = "0x817640", VA = "0x180819040", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06000631 RID: 1585 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000373")]
	public Action OnresetClimbTrigger
	{
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x8190A0", Offset = "0x8176A0", VA = "0x1808190A0", Slot = "141")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x819140", Offset = "0x817740", VA = "0x180819140", Slot = "142")]
		set
		{
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06000633 RID: 1587 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x17000374")]
	public bool exitClimbTopBool
	{
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x8191F0", Offset = "0x8177F0", VA = "0x1808191F0", Slot = "143")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x06000634 RID: 1588 RVA: 0x000043C8 File Offset: 0x000025C8
	[Token(Token = "0x17000375")]
	public bool lookAtItem
	{
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x819250", Offset = "0x817850", VA = "0x180819250", Slot = "144")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06000635 RID: 1589 RVA: 0x000043E0 File Offset: 0x000025E0
	[Token(Token = "0x17000376")]
	public bool lookAtItemRight
	{
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x8192B0", Offset = "0x8178B0", VA = "0x1808192B0", Slot = "145")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06000636 RID: 1590 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x17000377")]
	public bool bodyHeld
	{
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x819310", Offset = "0x817910", VA = "0x180819310", Slot = "146")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x06000637 RID: 1591 RVA: 0x00004410 File Offset: 0x00002610
	[Token(Token = "0x17000378")]
	public int climbTypeInt
	{
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x819370", Offset = "0x817970", VA = "0x180819370", Slot = "147")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06000638 RID: 1592 RVA: 0x00004428 File Offset: 0x00002628
	[Token(Token = "0x17000379")]
	public bool swimDiveBool
	{
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x7C7520", Offset = "0x7C5B20", VA = "0x1807C7520", Slot = "148")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x06000639 RID: 1593 RVA: 0x00004440 File Offset: 0x00002640
	[Token(Token = "0x1700037A")]
	public bool shellHeld
	{
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x7C7670", Offset = "0x7C5C70", VA = "0x1807C7670", Slot = "149")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x0600063A RID: 1594 RVA: 0x00004458 File Offset: 0x00002658
	[Token(Token = "0x1700037B")]
	public bool pointAtMap
	{
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x7C77C0", Offset = "0x7C5DC0", VA = "0x1807C77C0", Slot = "150")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x0600063B RID: 1595 RVA: 0x00004470 File Offset: 0x00002670
	[Token(Token = "0x1700037C")]
	public bool mapHeld
	{
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x8193D0", Offset = "0x8179D0", VA = "0x1808193D0", Slot = "151")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x0600063C RID: 1596 RVA: 0x00004488 File Offset: 0x00002688
	[Token(Token = "0x1700037D")]
	public int knockBackInt
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x819430", Offset = "0x817A30", VA = "0x180819430", Slot = "152")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x0600063D RID: 1597 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x1700037E")]
	public float coldFloat
	{
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x819490", Offset = "0x817A90", VA = "0x180819490", Slot = "153")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x0600063E RID: 1598 RVA: 0x000044B8 File Offset: 0x000026B8
	[Token(Token = "0x1700037F")]
	public bool jumpBool
	{
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x8194F0", Offset = "0x817AF0", VA = "0x1808194F0", Slot = "154")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x0600063F RID: 1599 RVA: 0x000044D0 File Offset: 0x000026D0
	[Token(Token = "0x17000380")]
	public int jumpType
	{
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x819550", Offset = "0x817B50", VA = "0x180819550", Slot = "155")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x06000640 RID: 1600 RVA: 0x000044E8 File Offset: 0x000026E8
	// (set) Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000381")]
	public float sledRotation
	{
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x8195B0", Offset = "0x817BB0", VA = "0x1808195B0", Slot = "156")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x819610", Offset = "0x817C10", VA = "0x180819610", Slot = "157")]
		set
		{
		}
	}

	// Token: 0x17000382 RID: 898
	// (get) Token: 0x06000642 RID: 1602 RVA: 0x00004500 File Offset: 0x00002700
	// (set) Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000382")]
	public bool FX_Fire
	{
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x819700", Offset = "0x817D00", VA = "0x180819700", Slot = "158")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x819760", Offset = "0x817D60", VA = "0x180819760", Slot = "159")]
		set
		{
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06000644 RID: 1604 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000383")]
	public NetworkArray_Integer Leaves
	{
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x819850", Offset = "0x817E50", VA = "0x180819850", Slot = "160")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06000645 RID: 1605 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000384")]
	public NetworkArray_Integer Armors
	{
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x819910", Offset = "0x817F10", VA = "0x180819910", Slot = "161")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06000646 RID: 1606 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000385")]
	public NetworkArray_Integer MapPieces
	{
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x8199D0", Offset = "0x817FD0", VA = "0x1808199D0", Slot = "162")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000386 RID: 902
	// (get) Token: 0x06000647 RID: 1607 RVA: 0x00004518 File Offset: 0x00002718
	[Token(Token = "0x17000386")]
	public bool attackHeavyBool
	{
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x819A90", Offset = "0x818090", VA = "0x180819A90", Slot = "163")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000387 RID: 903
	// (get) Token: 0x06000648 RID: 1608 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x17000387")]
	public float inWaterBlend
	{
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x819AF0", Offset = "0x8180F0", VA = "0x180819AF0", Slot = "164")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000388 RID: 904
	// (get) Token: 0x06000649 RID: 1609 RVA: 0x00004548 File Offset: 0x00002748
	[Token(Token = "0x17000388")]
	public float spineBlendX
	{
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x819B50", Offset = "0x818150", VA = "0x180819B50", Slot = "165")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000389 RID: 905
	// (get) Token: 0x0600064A RID: 1610 RVA: 0x00004560 File Offset: 0x00002760
	[Token(Token = "0x17000389")]
	public bool drinkWater
	{
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x7C0060", Offset = "0x7BE660", VA = "0x1807C0060", Slot = "166")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700038A RID: 906
	// (get) Token: 0x0600064B RID: 1611 RVA: 0x00004578 File Offset: 0x00002778
	// (set) Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700038A")]
	public int PlayerVariationBody
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x819BB0", Offset = "0x8181B0", VA = "0x180819BB0", Slot = "167")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x819C10", Offset = "0x818210", VA = "0x180819C10", Slot = "168")]
		set
		{
		}
	}

	// Token: 0x1700038B RID: 907
	// (get) Token: 0x0600064D RID: 1613 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x1700038B")]
	public int turnLegInt
	{
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x819D00", Offset = "0x818300", VA = "0x180819D00", Slot = "169")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700038C RID: 908
	// (get) Token: 0x0600064E RID: 1614 RVA: 0x000045A8 File Offset: 0x000027A8
	[Token(Token = "0x1700038C")]
	public bool blockColdBool
	{
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x819D60", Offset = "0x818360", VA = "0x180819D60", Slot = "170")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700038D RID: 909
	// (get) Token: 0x0600064F RID: 1615 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x1700038D")]
	public bool spearThrowBool
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x819DC0", Offset = "0x8183C0", VA = "0x180819DC0", Slot = "171")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700038E RID: 910
	// (get) Token: 0x06000650 RID: 1616 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700038E")]
	public NetworkArray_Integer ClothWeapons
	{
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x819E20", Offset = "0x818420", VA = "0x180819E20", Slot = "172")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700038F RID: 911
	// (get) Token: 0x06000651 RID: 1617 RVA: 0x000045D8 File Offset: 0x000027D8
	// (set) Token: 0x06000652 RID: 1618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700038F")]
	public bool Rebreater
	{
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x819EE0", Offset = "0x8184E0", VA = "0x180819EE0", Slot = "173")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x819F40", Offset = "0x818540", VA = "0x180819F40", Slot = "174")]
		set
		{
		}
	}

	// Token: 0x17000390 RID: 912
	// (get) Token: 0x06000653 RID: 1619 RVA: 0x000045F0 File Offset: 0x000027F0
	// (set) Token: 0x06000654 RID: 1620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000390")]
	public int ArmSkin
	{
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x81A030", Offset = "0x818630", VA = "0x18081A030", Slot = "175")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x81A090", Offset = "0x818690", VA = "0x18081A090", Slot = "176")]
		set
		{
		}
	}

	// Token: 0x17000391 RID: 913
	// (get) Token: 0x06000655 RID: 1621 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x17000391")]
	public bool dragAwayBool
	{
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x81A180", Offset = "0x818780", VA = "0x18081A180", Slot = "177")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x06000656 RID: 1622 RVA: 0x00004620 File Offset: 0x00002820
	// (set) Token: 0x06000657 RID: 1623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000392")]
	public int Layer0Hash
	{
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x81A1E0", Offset = "0x8187E0", VA = "0x18081A1E0", Slot = "178")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x81A240", Offset = "0x818840", VA = "0x18081A240", Slot = "179")]
		set
		{
		}
	}

	// Token: 0x17000393 RID: 915
	// (get) Token: 0x06000658 RID: 1624 RVA: 0x00004638 File Offset: 0x00002838
	// (set) Token: 0x06000659 RID: 1625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000393")]
	public int Layer1Hash
	{
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x81A330", Offset = "0x818930", VA = "0x18081A330", Slot = "180")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x81A390", Offset = "0x818990", VA = "0x18081A390", Slot = "181")]
		set
		{
		}
	}

	// Token: 0x17000394 RID: 916
	// (get) Token: 0x0600065A RID: 1626 RVA: 0x00004650 File Offset: 0x00002850
	// (set) Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000394")]
	public int Layer2Hash
	{
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x81A480", Offset = "0x818A80", VA = "0x18081A480", Slot = "182")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x81A4E0", Offset = "0x818AE0", VA = "0x18081A4E0", Slot = "183")]
		set
		{
		}
	}

	// Token: 0x17000395 RID: 917
	// (get) Token: 0x0600065C RID: 1628 RVA: 0x00004668 File Offset: 0x00002868
	// (set) Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000395")]
	public int Layer3Hash
	{
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x81A5D0", Offset = "0x818BD0", VA = "0x18081A5D0", Slot = "184")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x81A630", Offset = "0x818C30", VA = "0x18081A630", Slot = "185")]
		set
		{
		}
	}

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x0600065E RID: 1630 RVA: 0x00004680 File Offset: 0x00002880
	[Token(Token = "0x17000396")]
	public bool lightWeaponBool
	{
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x81A720", Offset = "0x818D20", VA = "0x18081A720", Slot = "186")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000397 RID: 919
	// (get) Token: 0x0600065F RID: 1631 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x17000397")]
	public bool resetClimbBool
	{
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x7C9060", Offset = "0x7C7660", VA = "0x1807C9060", Slot = "187")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000398 RID: 920
	// (get) Token: 0x06000660 RID: 1632 RVA: 0x000046B0 File Offset: 0x000028B0
	[Token(Token = "0x17000398")]
	public bool clampSpine
	{
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x7C91B0", Offset = "0x7C77B0", VA = "0x1807C91B0", Slot = "188")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000399 RID: 921
	// (get) Token: 0x06000661 RID: 1633 RVA: 0x000046C8 File Offset: 0x000028C8
	[Token(Token = "0x17000399")]
	public bool bookHeld
	{
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x81A780", Offset = "0x818D80", VA = "0x18081A780", Slot = "189")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700039A RID: 922
	// (get) Token: 0x06000662 RID: 1634 RVA: 0x000046E0 File Offset: 0x000028E0
	[Token(Token = "0x1700039A")]
	public int bookCloseInt
	{
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x7C9450", Offset = "0x7C7A50", VA = "0x1807C9450", Slot = "190")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x06000663 RID: 1635 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700039B")]
	public NetworkTransform RaftTransform
	{
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x81A7E0", Offset = "0x818DE0", VA = "0x18081A7E0", Slot = "191")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x06000664 RID: 1636 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000665 RID: 1637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700039C")]
	public BoltEntity RaftEntity
	{
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x81A840", Offset = "0x818E40", VA = "0x18081A840", Slot = "192")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x81A8E0", Offset = "0x818EE0", VA = "0x18081A8E0", Slot = "193")]
		set
		{
		}
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000666")]
	[Address(RVA = "0x81AB40", Offset = "0x819140", VA = "0x18081AB40", Slot = "194")]
	public void knockBackTrigger()
	{
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000667")]
	[Address(RVA = "0x81AC80", Offset = "0x819280", VA = "0x18081AC80", Slot = "195")]
	public void deathTrigger()
	{
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000668")]
	[Address(RVA = "0x81ADC0", Offset = "0x8193C0", VA = "0x18081ADC0", Slot = "196")]
	public void resetTrigger()
	{
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000669")]
	[Address(RVA = "0x81AF00", Offset = "0x819500", VA = "0x18081AF00", Slot = "197")]
	public void cancelBowTrigger()
	{
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x81B040", Offset = "0x819640", VA = "0x18081B040", Slot = "198")]
	public void injuredTrigger()
	{
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x81B180", Offset = "0x819780", VA = "0x18081B180", Slot = "199")]
	public void setClimbTrigger()
	{
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x81B2C0", Offset = "0x8198C0", VA = "0x18081B2C0", Slot = "200")]
	public void setClimbTopTrigger()
	{
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066D")]
	[Address(RVA = "0x81B400", Offset = "0x819A00", VA = "0x18081B400", Slot = "201")]
	public void resetClimbTrigger()
	{
	}
}
