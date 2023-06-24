using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
internal class PlayerState : NetworkState, IPlayerState, IWorldCharacter, IState, IDisposable
{
	// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x7C4DE0", Offset = "0x7C33E0", VA = "0x1807C4DE0")]
	public PlayerState()
	{
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600020D RID: 525 RVA: 0x000028E0 File Offset: 0x00000AE0
	// (set) Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000103")]
	public float CharacterScale
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70", Slot = "172")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x7C3CD0", Offset = "0x7C22D0", VA = "0x1807C3CD0", Slot = "173")]
		set
		{
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x0600020F RID: 527 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000104")]
	public NetworkArray_Integer MecanimLayerHashes
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x7C4E40", Offset = "0x7C3440", VA = "0x1807C4E40", Slot = "174")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000210 RID: 528 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000105")]
	public NetworkArray_Float MecanimLayerWeights
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x7C4F00", Offset = "0x7C3500", VA = "0x1807C4F00", Slot = "175")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000211 RID: 529 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000106")]
	public NetworkArray_Float MecanimLayerTimes
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x7C4FC0", Offset = "0x7C35C0", VA = "0x1807C4FC0", Slot = "176")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000212 RID: 530 RVA: 0x000028F8 File Offset: 0x00000AF8
	// (set) Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000107")]
	public float MecanimSpeed
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x7C3FF0", Offset = "0x7C25F0", VA = "0x1807C3FF0", Slot = "177")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x7C4050", Offset = "0x7C2650", VA = "0x1807C4050", Slot = "178")]
		set
		{
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000214 RID: 532 RVA: 0x00002910 File Offset: 0x00000B10
	// (set) Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000108")]
	public int PlayerRace
	{
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x7C5080", Offset = "0x7C3680", VA = "0x1807C5080", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x7C50E0", Offset = "0x7C36E0", VA = "0x1807C50E0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000216 RID: 534 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000109")]
	public NetworkArray_Integer HeldItems
	{
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x7C51E0", Offset = "0x7C37E0", VA = "0x1807C51E0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000217 RID: 535 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700010A")]
	public NetworkArray_Integer PlayerClothingIds
	{
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x7C52A0", Offset = "0x7C38A0", VA = "0x1807C52A0", Slot = "34")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000218 RID: 536 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700010B")]
	public NetworkArray_Integer PlayerArmourIds
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x7C5360", Offset = "0x7C3960", VA = "0x1807C5360", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000219 RID: 537 RVA: 0x00002928 File Offset: 0x00000B28
	// (set) Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700010C")]
	public int PlayerVariationHair
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x7C5420", Offset = "0x7C3A20", VA = "0x1807C5420", Slot = "36")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x7C5480", Offset = "0x7C3A80", VA = "0x1807C5480", Slot = "37")]
		set
		{
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x0600021B RID: 539 RVA: 0x00002940 File Offset: 0x00000B40
	// (set) Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700010D")]
	public float hSpeed
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x7C5580", Offset = "0x7C3B80", VA = "0x1807C5580", Slot = "38")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x7C55E0", Offset = "0x7C3BE0", VA = "0x1807C55E0", Slot = "39")]
		set
		{
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x0600021D RID: 541 RVA: 0x00002958 File Offset: 0x00000B58
	// (set) Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700010E")]
	public int itemAtFeet
	{
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x7C56F0", Offset = "0x7C3CF0", VA = "0x1807C56F0", Slot = "40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x7C5750", Offset = "0x7C3D50", VA = "0x1807C5750", Slot = "41")]
		set
		{
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x0600021F RID: 543 RVA: 0x00002970 File Offset: 0x00000B70
	// (set) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700010F")]
	public float vSpeed
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x7C5840", Offset = "0x7C3E40", VA = "0x1807C5840", Slot = "42")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x7C58A0", Offset = "0x7C3EA0", VA = "0x1807C58A0", Slot = "43")]
		set
		{
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000221 RID: 545 RVA: 0x00002988 File Offset: 0x00000B88
	[Token(Token = "0x17000110")]
	public float overallSpeed
	{
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x7C59B0", Offset = "0x7C3FB0", VA = "0x1807C59B0", Slot = "44")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000222 RID: 546 RVA: 0x000029A0 File Offset: 0x00000BA0
	[Token(Token = "0x17000111")]
	public float weaponHit
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x7C5A10", Offset = "0x7C4010", VA = "0x1807C5A10", Slot = "45")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000223 RID: 547 RVA: 0x000029B8 File Offset: 0x00000BB8
	[Token(Token = "0x17000112")]
	public float normCamX
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x7C5A70", Offset = "0x7C4070", VA = "0x1807C5A70", Slot = "46")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000224 RID: 548 RVA: 0x000029D0 File Offset: 0x00000BD0
	[Token(Token = "0x17000113")]
	public float normCamY
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x7C5AD0", Offset = "0x7C40D0", VA = "0x1807C5AD0", Slot = "47")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000225 RID: 549 RVA: 0x000029E8 File Offset: 0x00000BE8
	// (set) Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000114")]
	public float spineBlendX
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x7C5B30", Offset = "0x7C4130", VA = "0x1807C5B30", Slot = "48")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x7C5B90", Offset = "0x7C4190", VA = "0x1807C5B90", Slot = "49")]
		set
		{
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000227 RID: 551 RVA: 0x00002A00 File Offset: 0x00000C00
	[Token(Token = "0x17000115")]
	public float tiredFloat
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x7C5CA0", Offset = "0x7C42A0", VA = "0x1807C5CA0", Slot = "50")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000228 RID: 552 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x17000116")]
	public float aimAtTarget
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x7C5D00", Offset = "0x7C4300", VA = "0x1807C5D00", Slot = "51")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000229 RID: 553 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x17000117")]
	public float crouch
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x7C5D60", Offset = "0x7C4360", VA = "0x1807C5D60", Slot = "52")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x0600022A RID: 554 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x17000118")]
	public float groundHeight
	{
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x7C5DC0", Offset = "0x7C43C0", VA = "0x1807C5DC0", Slot = "53")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x0600022B RID: 555 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x17000119")]
	public bool logHeld
	{
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x7C5E20", Offset = "0x7C4420", VA = "0x1807C5E20", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x0600022C RID: 556 RVA: 0x00002A78 File Offset: 0x00000C78
	// (set) Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700011A")]
	public int HeldOnlyItemId
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x7C5E80", Offset = "0x7C4480", VA = "0x1807C5E80", Slot = "55")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x7C5EE0", Offset = "0x7C44E0", VA = "0x1807C5EE0", Slot = "56")]
		set
		{
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x0600022E RID: 558 RVA: 0x00002A90 File Offset: 0x00000C90
	// (set) Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700011B")]
	public int HeldOnlyItemCount
	{
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x7C5FE0", Offset = "0x7C45E0", VA = "0x1807C5FE0", Slot = "57")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x7C6040", Offset = "0x7C4640", VA = "0x1807C6040", Slot = "58")]
		set
		{
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000230 RID: 560 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x1700011C")]
	public float coldFloat
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x7C6140", Offset = "0x7C4740", VA = "0x1807C6140", Slot = "59")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000231 RID: 561 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x1700011D")]
	public float inWaterBlend
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x7C61A0", Offset = "0x7C47A0", VA = "0x1807C61A0", Slot = "60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000232 RID: 562 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x1700011E")]
	public bool bodyHeld
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x7C6200", Offset = "0x7C4800", VA = "0x1807C6200", Slot = "61")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000233 RID: 563 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700011F")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7C6260", Offset = "0x7C4860", VA = "0x1807C6260", Slot = "62")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000234 RID: 564 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000120")]
	public string name
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x7C62C0", Offset = "0x7C48C0", VA = "0x1807C62C0", Slot = "63")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x7C6360", Offset = "0x7C4960", VA = "0x1807C6360", Slot = "64")]
		set
		{
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000236 RID: 566 RVA: 0x00002AF0 File Offset: 0x00000CF0
	// (set) Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000121")]
	public int CurrentView
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x7C64F0", Offset = "0x7C4AF0", VA = "0x1807C64F0", Slot = "65")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x7C6550", Offset = "0x7C4B50", VA = "0x1807C6550", Slot = "66")]
		set
		{
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000238 RID: 568 RVA: 0x00002B08 File Offset: 0x00000D08
	// (set) Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000122")]
	public bool FX_Fire
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x7C6650", Offset = "0x7C4C50", VA = "0x1807C6650", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x7C66B0", Offset = "0x7C4CB0", VA = "0x1807C66B0", Slot = "68")]
		set
		{
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600023A RID: 570 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000123")]
	public NetworkArray_Integer MapPieces
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x7C67A0", Offset = "0x7C4DA0", VA = "0x1807C67A0", Slot = "69")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x0600023B RID: 571 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000124")]
	public NetworkArray_Integer ClothWeapons
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x7C6860", Offset = "0x7C4E60", VA = "0x1807C6860", Slot = "70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x0600023C RID: 572 RVA: 0x00002B20 File Offset: 0x00000D20
	// (set) Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000125")]
	public bool Bloody
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7C6920", Offset = "0x7C4F20", VA = "0x1807C6920", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x7C6980", Offset = "0x7C4F80", VA = "0x1807C6980", Slot = "72")]
		set
		{
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x0600023E RID: 574 RVA: 0x00002B38 File Offset: 0x00000D38
	// (set) Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000126")]
	public bool Muddy
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x7C6A70", Offset = "0x7C5070", VA = "0x1807C6A70", Slot = "73")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x7C6AD0", Offset = "0x7C50D0", VA = "0x1807C6AD0", Slot = "74")]
		set
		{
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000240 RID: 576 RVA: 0x00002B50 File Offset: 0x00000D50
	// (set) Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000127")]
	public bool Cold
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x7C6BC0", Offset = "0x7C51C0", VA = "0x1807C6BC0", Slot = "75")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x7C6C20", Offset = "0x7C5220", VA = "0x1807C6C20", Slot = "76")]
		set
		{
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000242 RID: 578 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000128")]
	public NetworkTransform RaftTransform
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x7C6D10", Offset = "0x7C5310", VA = "0x1807C6D10", Slot = "77")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000243 RID: 579 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000129")]
	public BoltEntity RaftEntity
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x7C6D70", Offset = "0x7C5370", VA = "0x1807C6D70", Slot = "78")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x7C6E10", Offset = "0x7C5410", VA = "0x1807C6E10", Slot = "79")]
		set
		{
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000245 RID: 581 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012A")]
	public Action OnknockBackTrigger
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7C7070", Offset = "0x7C5670", VA = "0x1807C7070", Slot = "80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x7C7110", Offset = "0x7C5710", VA = "0x1807C7110", Slot = "81")]
		set
		{
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000247 RID: 583 RVA: 0x00002B68 File Offset: 0x00000D68
	// (set) Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012B")]
	public bool ShowLoadedAmmo
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x7C71C0", Offset = "0x7C57C0", VA = "0x1807C71C0", Slot = "82")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x7C7220", Offset = "0x7C5820", VA = "0x1807C7220", Slot = "83")]
		set
		{
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000249 RID: 585 RVA: 0x00002B80 File Offset: 0x00000D80
	// (set) Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012C")]
	public float TreeDensity
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x7C7310", Offset = "0x7C5910", VA = "0x1807C7310", Slot = "84")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x7C7370", Offset = "0x7C5970", VA = "0x1807C7370", Slot = "85")]
		set
		{
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x0600024B RID: 587 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700012D")]
	public NetworkArray_Integer WeaponUpgrades
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x7C7460", Offset = "0x7C5A60", VA = "0x1807C7460", Slot = "86")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x0600024C RID: 588 RVA: 0x00002B98 File Offset: 0x00000D98
	// (set) Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012E")]
	public bool MolotovFire
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x7C7520", Offset = "0x7C5B20", VA = "0x1807C7520", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7C7580", Offset = "0x7C5B80", VA = "0x1807C7580", Slot = "88")]
		set
		{
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x0600024E RID: 590 RVA: 0x00002BB0 File Offset: 0x00000DB0
	// (set) Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012F")]
	public bool DynamiteFire
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x7C7670", Offset = "0x7C5C70", VA = "0x1807C7670", Slot = "89")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x7C76D0", Offset = "0x7C5CD0", VA = "0x1807C76D0", Slot = "90")]
		set
		{
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000250 RID: 592 RVA: 0x00002BC8 File Offset: 0x00000DC8
	// (set) Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000130")]
	public bool isTargetting
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x7C77C0", Offset = "0x7C5DC0", VA = "0x1807C77C0", Slot = "91")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x7C7820", Offset = "0x7C5E20", VA = "0x1807C7820", Slot = "92")]
		set
		{
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000252 RID: 594 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000131")]
	public NetworkArray_Objects<ItemInfo> SharableStorage
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x7C7910", Offset = "0x7C5F10", VA = "0x1807C7910", Slot = "93")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000253 RID: 595 RVA: 0x00002BE0 File Offset: 0x00000DE0
	[Token(Token = "0x17000132")]
	public float axeBlend1
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7C79D0", Offset = "0x7C5FD0", VA = "0x1807C79D0", Slot = "94")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000254 RID: 596 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[Token(Token = "0x17000133")]
	public float terrainAngle
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x7C7A30", Offset = "0x7C6030", VA = "0x1807C7A30", Slot = "95")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000255 RID: 597 RVA: 0x00002C10 File Offset: 0x00000E10
	[Token(Token = "0x17000134")]
	public float singleArmBlock
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x7C7A90", Offset = "0x7C6090", VA = "0x1807C7A90", Slot = "96")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000256 RID: 598 RVA: 0x00002C28 File Offset: 0x00000E28
	// (set) Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000135")]
	public bool inWater
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7C7AF0", Offset = "0x7C60F0", VA = "0x1807C7AF0", Slot = "97")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x7C7B50", Offset = "0x7C6150", VA = "0x1807C7B50", Slot = "98")]
		set
		{
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000258 RID: 600 RVA: 0x00002C40 File Offset: 0x00000E40
	// (set) Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000136")]
	public bool onRaft
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7C7C40", Offset = "0x7C6240", VA = "0x1807C7C40", Slot = "99")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x7C7CA0", Offset = "0x7C62A0", VA = "0x1807C7CA0", Slot = "100")]
		set
		{
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x0600025A RID: 602 RVA: 0x00002C58 File Offset: 0x00000E58
	// (set) Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000137")]
	public bool IsWaitingToSleep
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x7C7D90", Offset = "0x7C6390", VA = "0x1807C7D90", Slot = "101")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x7C7DF0", Offset = "0x7C63F0", VA = "0x1807C7DF0", Slot = "102")]
		set
		{
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x0600025C RID: 604 RVA: 0x00002C70 File Offset: 0x00000E70
	// (set) Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000138")]
	public Color PlayerColor
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x7C7EE0", Offset = "0x7C64E0", VA = "0x1807C7EE0", Slot = "103")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x7C7F50", Offset = "0x7C6550", VA = "0x1807C7F50", Slot = "104")]
		set
		{
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x0600025E RID: 606 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000139")]
	public NetworkArray_Integer QuickSelectItemIds
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x7C80B0", Offset = "0x7C66B0", VA = "0x1807C80B0", Slot = "105")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x0600025F RID: 607 RVA: 0x00002C88 File Offset: 0x00000E88
	[Token(Token = "0x1700013A")]
	public float climbSpeed
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x7C8170", Offset = "0x7C6770", VA = "0x1807C8170", Slot = "106")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000260 RID: 608 RVA: 0x00002CA0 File Offset: 0x00000EA0
	// (set) Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013B")]
	public int UnderfootSurface
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x7C81D0", Offset = "0x7C67D0", VA = "0x1807C81D0", Slot = "107")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x7C8230", Offset = "0x7C6830", VA = "0x1807C8230", Slot = "108")]
		set
		{
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000262 RID: 610 RVA: 0x00002CB8 File Offset: 0x00000EB8
	// (set) Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013C")]
	public bool UnderfootGore
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x7C8330", Offset = "0x7C6930", VA = "0x1807C8330", Slot = "109")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x7C8390", Offset = "0x7C6990", VA = "0x1807C8390", Slot = "110")]
		set
		{
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000264 RID: 612 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x1700013D")]
	public bool zipLineAttach
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x7C8480", Offset = "0x7C6A80", VA = "0x1807C8480", Slot = "111")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000265 RID: 613 RVA: 0x00002CE8 File Offset: 0x00000EE8
	// (set) Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013E")]
	public int LoopingEventPath
	{
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x7C84E0", Offset = "0x7C6AE0", VA = "0x1807C84E0", Slot = "112")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x7C8540", Offset = "0x7C6B40", VA = "0x1807C8540", Slot = "113")]
		set
		{
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06000267 RID: 615 RVA: 0x00002D00 File Offset: 0x00000F00
	// (set) Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013F")]
	public Vector3 LoopingEventPosition
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x7C8630", Offset = "0x7C6C30", VA = "0x1807C8630", Slot = "114")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x7C86B0", Offset = "0x7C6CB0", VA = "0x1807C86B0", Slot = "115")]
		set
		{
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000269 RID: 617 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x17000140")]
	public float shellBlend
	{
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x7C8860", Offset = "0x7C6E60", VA = "0x1807C8860", Slot = "116")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x0600026A RID: 618 RVA: 0x00002D30 File Offset: 0x00000F30
	// (set) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000141")]
	public bool arrowFire
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x7C88C0", Offset = "0x7C6EC0", VA = "0x1807C88C0", Slot = "117")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x7C8920", Offset = "0x7C6F20", VA = "0x1807C8920", Slot = "118")]
		set
		{
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x0600026C RID: 620 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x17000142")]
	public bool clampSpine
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x7C8A10", Offset = "0x7C7010", VA = "0x1807C8A10", Slot = "119")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x0600026D RID: 621 RVA: 0x00002D60 File Offset: 0x00000F60
	// (set) Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000143")]
	public int SpearedFishType
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x7C8A70", Offset = "0x7C7070", VA = "0x1807C8A70", Slot = "120")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7C8AD0", Offset = "0x7C70D0", VA = "0x1807C8AD0", Slot = "121")]
		set
		{
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x0600026F RID: 623 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x17000144")]
	public float bowSpeed
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x7C8BE0", Offset = "0x7C71E0", VA = "0x1807C8BE0", Slot = "122")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000270 RID: 624 RVA: 0x00002D90 File Offset: 0x00000F90
	// (set) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000145")]
	public bool RightHandItemIsLit
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x7C8C40", Offset = "0x7C7240", VA = "0x1807C8C40", Slot = "123")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x7C8CA0", Offset = "0x7C72A0", VA = "0x1807C8CA0", Slot = "124")]
		set
		{
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000272 RID: 626 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000146")]
	public NetworkTransform HeadVR
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x7C8D90", Offset = "0x7C7390", VA = "0x1807C8D90", Slot = "125")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000273 RID: 627 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000147")]
	public NetworkTransform RightHandVR
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7C8DF0", Offset = "0x7C73F0", VA = "0x1807C8DF0", Slot = "126")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000274 RID: 628 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000148")]
	public NetworkTransform LeftHandVR
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x7C8E50", Offset = "0x7C7450", VA = "0x1807C8E50", Slot = "127")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000275 RID: 629 RVA: 0x00002DA8 File Offset: 0x00000FA8
	// (set) Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000149")]
	public bool VREnabled
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x7C8EB0", Offset = "0x7C74B0", VA = "0x1807C8EB0", Slot = "128")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x7C8F10", Offset = "0x7C7510", VA = "0x1807C8F10", Slot = "129")]
		set
		{
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000277 RID: 631 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x1700014A")]
	public int RightHandHeldItemId
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x7C9000", Offset = "0x7C7600", VA = "0x1807C9000", Slot = "130")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000278 RID: 632 RVA: 0x00002DD8 File Offset: 0x00000FD8
	// (set) Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014B")]
	public bool rightHandActive
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x7C9060", Offset = "0x7C7660", VA = "0x1807C9060", Slot = "131")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x7C90C0", Offset = "0x7C76C0", VA = "0x1807C90C0", Slot = "132")]
		set
		{
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x0600027A RID: 634 RVA: 0x00002DF0 File Offset: 0x00000FF0
	// (set) Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014C")]
	public bool HeadIsUnderwater
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x7C91B0", Offset = "0x7C77B0", VA = "0x1807C91B0", Slot = "133")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x7C9210", Offset = "0x7C7810", VA = "0x1807C9210", Slot = "134")]
		set
		{
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x0600027C RID: 636 RVA: 0x00002E08 File Offset: 0x00001008
	// (set) Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014D")]
	public int caveMask
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x7C9300", Offset = "0x7C7900", VA = "0x1807C9300", Slot = "135")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x7C9360", Offset = "0x7C7960", VA = "0x1807C9360", Slot = "136")]
		set
		{
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x0600027E RID: 638 RVA: 0x00002E20 File Offset: 0x00001020
	// (set) Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014E")]
	public int Dying
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x7C9450", Offset = "0x7C7A50", VA = "0x1807C9450", Slot = "137")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x7C94B0", Offset = "0x7C7AB0", VA = "0x1807C94B0", Slot = "138")]
		set
		{
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000280 RID: 640 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700014F")]
	public NetworkArray_Objects<HeldItemWeaponMods> HeldItemsWeaponMods
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x7C95B0", Offset = "0x7C7BB0", VA = "0x1807C95B0", Slot = "139")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000281 RID: 641 RVA: 0x00002E38 File Offset: 0x00001038
	// (set) Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000150")]
	public int StimuliFlags
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x7C9670", Offset = "0x7C7C70", VA = "0x1807C9670", Slot = "140")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x7C96D0", Offset = "0x7C7CD0", VA = "0x1807C96D0", Slot = "141")]
		set
		{
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000283 RID: 643 RVA: 0x00002E50 File Offset: 0x00001050
	// (set) Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000151")]
	public float VisibilityRangeMult
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x7C97D0", Offset = "0x7C7DD0", VA = "0x1807C97D0", Slot = "142")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x7C9830", Offset = "0x7C7E30", VA = "0x1807C9830", Slot = "143")]
		set
		{
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000285 RID: 645 RVA: 0x00002E68 File Offset: 0x00001068
	// (set) Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000152")]
	public int TiedUpState
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x7C9940", Offset = "0x7C7F40", VA = "0x1807C9940", Slot = "144")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x7C99A0", Offset = "0x7C7FA0", VA = "0x1807C99A0", Slot = "145")]
		set
		{
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000287 RID: 647 RVA: 0x00002E80 File Offset: 0x00001080
	// (set) Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000153")]
	public int MarkerHash
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x7C9AA0", Offset = "0x7C80A0", VA = "0x1807C9AA0", Slot = "146")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x7C9B00", Offset = "0x7C8100", VA = "0x1807C9B00", Slot = "147")]
		set
		{
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000289 RID: 649 RVA: 0x00002E98 File Offset: 0x00001098
	// (set) Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000154")]
	public bool IsInMidAction
	{
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x7C9BF0", Offset = "0x7C81F0", VA = "0x1807C9BF0", Slot = "148")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x7C9C50", Offset = "0x7C8250", VA = "0x1807C9C50", Slot = "149")]
		set
		{
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x0600028B RID: 651 RVA: 0x00002EB0 File Offset: 0x000010B0
	// (set) Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000155")]
	public bool HasBackpack
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x7C9D40", Offset = "0x7C8340", VA = "0x1807C9D40", Slot = "150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x7C9DA0", Offset = "0x7C83A0", VA = "0x1807C9DA0", Slot = "151")]
		set
		{
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x0600028D RID: 653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000156")]
	public PerishableItemInstanceModuleBoltData HeldItemPerishableState
	{
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x7C9E90", Offset = "0x7C8490", VA = "0x1807C9E90", Slot = "152")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x0600028E RID: 654 RVA: 0x00002EC8 File Offset: 0x000010C8
	// (set) Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000157")]
	public bool TactiPenHeld
	{
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x7C9F50", Offset = "0x7C8550", VA = "0x1807C9F50", Slot = "153")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x7C9FB0", Offset = "0x7C85B0", VA = "0x1807C9FB0", Slot = "154")]
		set
		{
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06000290 RID: 656 RVA: 0x00002EE0 File Offset: 0x000010E0
	// (set) Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000158")]
	public bool TactiPadHeld
	{
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x7CA0A0", Offset = "0x7C86A0", VA = "0x1807CA0A0", Slot = "155")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x7CA100", Offset = "0x7C8700", VA = "0x1807CA100", Slot = "156")]
		set
		{
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000292 RID: 658 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000159")]
	public StoredItemsData StoringItems
	{
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x7CA1F0", Offset = "0x7C87F0", VA = "0x1807CA1F0", Slot = "157")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000293 RID: 659 RVA: 0x00002EF8 File Offset: 0x000010F8
	// (set) Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015A")]
	public int Expression
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x7CA2B0", Offset = "0x7C88B0", VA = "0x1807CA2B0", Slot = "158")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x7CA310", Offset = "0x7C8910", VA = "0x1807CA310", Slot = "159")]
		set
		{
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000295 RID: 661 RVA: 0x00002F10 File Offset: 0x00001110
	// (set) Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015B")]
	public bool DisableBodyColliders
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x7CA420", Offset = "0x7C8A20", VA = "0x1807CA420", Slot = "160")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x7CA480", Offset = "0x7C8A80", VA = "0x1807CA480", Slot = "161")]
		set
		{
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000297 RID: 663 RVA: 0x00002F28 File Offset: 0x00001128
	// (set) Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015C")]
	public int StandUpProps
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x7CA570", Offset = "0x7C8B70", VA = "0x1807CA570", Slot = "162")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x7CA5D0", Offset = "0x7C8BD0", VA = "0x1807CA5D0", Slot = "163")]
		set
		{
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000299 RID: 665 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x1700015D")]
	public float treeHeightBlend
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x7CA6D0", Offset = "0x7C8CD0", VA = "0x1807CA6D0", Slot = "164")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x0600029A RID: 666 RVA: 0x00002F58 File Offset: 0x00001158
	// (set) Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015E")]
	public int HeldScrewStructureID
	{
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x7CA730", Offset = "0x7C8D30", VA = "0x1807CA730", Slot = "165")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x7CA790", Offset = "0x7C8D90", VA = "0x1807CA790", Slot = "166")]
		set
		{
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x0600029C RID: 668 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700015F")]
	public HeldItemSlotTransfer HeldItemEquipSlotTransfer
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x7CA890", Offset = "0x7C8E90", VA = "0x1807CA890", Slot = "167")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x0600029D RID: 669 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x17000160")]
	public float RideLeanRightLeft
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x7CA950", Offset = "0x7C8F50", VA = "0x1807CA950", Slot = "168")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x0600029E RID: 670 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x17000161")]
	public float RideLeanForwardBack
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x7CA9B0", Offset = "0x7C8FB0", VA = "0x1807CA9B0", Slot = "169")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x0600029F RID: 671 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000162")]
	public NetworkTransform ConnectedTransform
	{
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x7CAA10", Offset = "0x7C9010", VA = "0x1807CAA10", Slot = "170")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x7CAA70", Offset = "0x7C9070", VA = "0x1807CAA70", Slot = "171")]
	public void knockBackTrigger()
	{
	}
}
