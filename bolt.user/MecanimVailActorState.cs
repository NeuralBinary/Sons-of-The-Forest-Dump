using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
internal class MecanimVailActorState : NetworkState, IMecanimVailActorState, IWorldCharacter, IState, IDisposable
{
	// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x80FD90", Offset = "0x80E390", VA = "0x18080FD90")]
	public MecanimVailActorState()
	{
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00003888 File Offset: 0x00001A88
	// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700025B")]
	public float CharacterScale
	{
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70", Slot = "78")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x7C3CD0", Offset = "0x7C22D0", VA = "0x1807C3CD0", Slot = "79")]
		set
		{
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700025C")]
	public NetworkArray_Integer MecanimLayerHashes
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x80FDF0", Offset = "0x80E3F0", VA = "0x18080FDF0", Slot = "80")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700025D")]
	public NetworkArray_Float MecanimLayerWeights
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x80FEB0", Offset = "0x80E4B0", VA = "0x18080FEB0", Slot = "81")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700025E")]
	public NetworkArray_Float MecanimLayerTimes
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x80FF70", Offset = "0x80E570", VA = "0x18080FF70", Slot = "82")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000038A0 File Offset: 0x00001AA0
	// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700025F")]
	public float MecanimSpeed
	{
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x7C3FF0", Offset = "0x7C25F0", VA = "0x1807C3FF0", Slot = "83")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x7C4050", Offset = "0x7C2650", VA = "0x1807C4050", Slot = "84")]
		set
		{
		}
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000260")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x810030", Offset = "0x80E630", VA = "0x180810030", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x060004B8 RID: 1208 RVA: 0x000038B8 File Offset: 0x00001AB8
	// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000261")]
	public int BloodMask
	{
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x810090", Offset = "0x80E690", VA = "0x180810090", Slot = "32")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x8100F0", Offset = "0x80E6F0", VA = "0x1808100F0", Slot = "33")]
		set
		{
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x060004BA RID: 1210 RVA: 0x000038D0 File Offset: 0x00001AD0
	// (set) Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000262")]
	public int VailState
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x8101F0", Offset = "0x80E7F0", VA = "0x1808101F0", Slot = "34")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x810250", Offset = "0x80E850", VA = "0x180810250", Slot = "35")]
		set
		{
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x060004BC RID: 1212 RVA: 0x000038E8 File Offset: 0x00001AE8
	// (set) Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000263")]
	public int VariationSeed
	{
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x810350", Offset = "0x80E950", VA = "0x180810350", Slot = "36")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x8103B0", Offset = "0x80E9B0", VA = "0x1808103B0", Slot = "37")]
		set
		{
		}
	}

	// Token: 0x17000264 RID: 612
	// (get) Token: 0x060004BE RID: 1214 RVA: 0x00003900 File Offset: 0x00001B00
	// (set) Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000264")]
	public int Ragdoll
	{
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x8104A0", Offset = "0x80EAA0", VA = "0x1808104A0", Slot = "38")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x810500", Offset = "0x80EB00", VA = "0x180810500", Slot = "39")]
		set
		{
		}
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00003918 File Offset: 0x00001B18
	// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000265")]
	public float Direction
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x810600", Offset = "0x80EC00", VA = "0x180810600", Slot = "40")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x810660", Offset = "0x80EC60", VA = "0x180810660", Slot = "41")]
		set
		{
		}
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00003930 File Offset: 0x00001B30
	// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000266")]
	public float DirectionX
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x810770", Offset = "0x80ED70", VA = "0x180810770", Slot = "42")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x8107D0", Offset = "0x80EDD0", VA = "0x1808107D0", Slot = "43")]
		set
		{
		}
	}

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00003948 File Offset: 0x00001B48
	// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000267")]
	public float DirectionZ
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x7D6420", Offset = "0x7D4A20", VA = "0x1807D6420", Slot = "44")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x8108E0", Offset = "0x80EEE0", VA = "0x1808108E0", Slot = "45")]
		set
		{
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00003960 File Offset: 0x00001B60
	// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000268")]
	public int OutfitId
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x8109F0", Offset = "0x80EFF0", VA = "0x1808109F0", Slot = "46")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x810A50", Offset = "0x80F050", VA = "0x180810A50", Slot = "47")]
		set
		{
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00003978 File Offset: 0x00001B78
	// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000269")]
	public int DismemberMask
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x810B50", Offset = "0x80F150", VA = "0x180810B50", Slot = "48")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x810BB0", Offset = "0x80F1B0", VA = "0x180810BB0", Slot = "49")]
		set
		{
		}
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x060004CA RID: 1226 RVA: 0x00003990 File Offset: 0x00001B90
	// (set) Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026A")]
	public float ArmorLevel
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x810CB0", Offset = "0x80F2B0", VA = "0x180810CB0", Slot = "50")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x810D10", Offset = "0x80F310", VA = "0x180810D10", Slot = "51")]
		set
		{
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x060004CC RID: 1228 RVA: 0x000039A8 File Offset: 0x00001BA8
	// (set) Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026B")]
	public bool Burning
	{
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x810E20", Offset = "0x80F420", VA = "0x180810E20", Slot = "52")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x810E80", Offset = "0x80F480", VA = "0x180810E80", Slot = "53")]
		set
		{
		}
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x060004CE RID: 1230 RVA: 0x000039C0 File Offset: 0x00001BC0
	// (set) Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026C")]
	public bool InCave
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x810F70", Offset = "0x80F570", VA = "0x180810F70", Slot = "54")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x810FD0", Offset = "0x80F5D0", VA = "0x180810FD0", Slot = "55")]
		set
		{
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000039D8 File Offset: 0x00001BD8
	// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026D")]
	public Vector3 RagdollPosition
	{
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x8110C0", Offset = "0x80F6C0", VA = "0x1808110C0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x811140", Offset = "0x80F740", VA = "0x180811140", Slot = "57")]
		set
		{
		}
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000039F0 File Offset: 0x00001BF0
	// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026E")]
	public int VariationSubSet
	{
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x8112F0", Offset = "0x80F8F0", VA = "0x1808112F0", Slot = "58")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x811350", Offset = "0x80F950", VA = "0x180811350", Slot = "59")]
		set
		{
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00003A08 File Offset: 0x00001C08
	// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026F")]
	public bool Skinned
	{
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x811450", Offset = "0x80FA50", VA = "0x180811450", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x8114B0", Offset = "0x80FAB0", VA = "0x1808114B0", Slot = "61")]
		set
		{
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00003A20 File Offset: 0x00001C20
	// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000270")]
	public int Expression
	{
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x8115A0", Offset = "0x80FBA0", VA = "0x1808115A0", Slot = "62")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x811600", Offset = "0x80FC00", VA = "0x180811600", Slot = "63")]
		set
		{
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00003A38 File Offset: 0x00001C38
	// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000271")]
	public int EquippedMask
	{
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x811700", Offset = "0x80FD00", VA = "0x180811700", Slot = "64")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x811760", Offset = "0x80FD60", VA = "0x180811760", Slot = "65")]
		set
		{
		}
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x060004DA RID: 1242 RVA: 0x00003A50 File Offset: 0x00001C50
	// (set) Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000272")]
	public int ItemCarryTypeCount
	{
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x811850", Offset = "0x80FE50", VA = "0x180811850", Slot = "66")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x8118B0", Offset = "0x80FEB0", VA = "0x1808118B0", Slot = "67")]
		set
		{
		}
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x060004DC RID: 1244 RVA: 0x00003A68 File Offset: 0x00001C68
	// (set) Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000273")]
	public int PlayerSentimentLevel
	{
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x8119A0", Offset = "0x80FFA0", VA = "0x1808119A0", Slot = "68")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x811A00", Offset = "0x810000", VA = "0x180811A00", Slot = "69")]
		set
		{
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x060004DE RID: 1246 RVA: 0x00003A80 File Offset: 0x00001C80
	// (set) Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000274")]
	public bool BodyBurning
	{
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x811B00", Offset = "0x810100", VA = "0x180811B00", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x811B60", Offset = "0x810160", VA = "0x180811B60", Slot = "71")]
		set
		{
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00003A98 File Offset: 0x00001C98
	// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000275")]
	public int GpsLocatorId
	{
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x811C50", Offset = "0x810250", VA = "0x180811C50", Slot = "72")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x811CB0", Offset = "0x8102B0", VA = "0x180811CB0", Slot = "73")]
		set
		{
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00003AB0 File Offset: 0x00001CB0
	// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000276")]
	public float Wetness
	{
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x811DB0", Offset = "0x8103B0", VA = "0x180811DB0", Slot = "74")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x811E10", Offset = "0x810410", VA = "0x180811E10", Slot = "75")]
		set
		{
		}
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00003AC8 File Offset: 0x00001CC8
	// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000277")]
	public bool HelicopterHeld
	{
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x811F20", Offset = "0x810520", VA = "0x180811F20", Slot = "76")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x811F80", Offset = "0x810580", VA = "0x180811F80", Slot = "77")]
		set
		{
		}
	}
}
