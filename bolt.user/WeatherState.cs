using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
internal class WeatherState : NetworkState, IWeatherState, IState, IDisposable
{
	// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x80C390", Offset = "0x80A990", VA = "0x18080C390")]
	public WeatherState()
	{
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x00003678 File Offset: 0x00001878
	// (set) Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021F")]
	public float Temp
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70", Slot = "31")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x80C3F0", Offset = "0x80A9F0", VA = "0x18080C3F0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06000435 RID: 1077 RVA: 0x00003690 File Offset: 0x00001890
	// (set) Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000220")]
	public float ElapsedGameTime
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0", Slot = "33")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x7B7940", Offset = "0x7B5F40", VA = "0x1807B7940", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06000437 RID: 1079 RVA: 0x000036A8 File Offset: 0x000018A8
	// (set) Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000221")]
	public int RainType
	{
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0", Slot = "35")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7B9840", Offset = "0x7B7E40", VA = "0x1807B9840", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06000439 RID: 1081 RVA: 0x000036C0 File Offset: 0x000018C0
	// (set) Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000222")]
	public int CloudState
	{
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40", Slot = "37")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x80C4F0", Offset = "0x80AAF0", VA = "0x18080C4F0", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x0600043B RID: 1083 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000223")]
	public NetworkArray_Float Wind
	{
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x80C5F0", Offset = "0x80ABF0", VA = "0x18080C5F0", Slot = "39")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x0600043C RID: 1084 RVA: 0x000036D8 File Offset: 0x000018D8
	// (set) Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000224")]
	public bool Rainbow
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x80C6B0", Offset = "0x80ACB0", VA = "0x18080C6B0", Slot = "40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x80C710", Offset = "0x80AD10", VA = "0x18080C710", Slot = "41")]
		set
		{
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x0600043E RID: 1086 RVA: 0x000036F0 File Offset: 0x000018F0
	// (set) Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000225")]
	public Color RainbowIntensity
	{
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x80C800", Offset = "0x80AE00", VA = "0x18080C800", Slot = "42")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x80C870", Offset = "0x80AE70", VA = "0x18080C870", Slot = "43")]
		set
		{
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003708 File Offset: 0x00001908
	// (set) Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000226")]
	public bool AfterStorm
	{
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x80C9C0", Offset = "0x80AFC0", VA = "0x18080C9C0", Slot = "44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x80CA20", Offset = "0x80B020", VA = "0x18080CA20", Slot = "45")]
		set
		{
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000442 RID: 1090 RVA: 0x00003720 File Offset: 0x00001920
	// (set) Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000227")]
	public bool NightTimeSfx
	{
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x80CB10", Offset = "0x80B110", VA = "0x18080CB10", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x80CB70", Offset = "0x80B170", VA = "0x18080CB70", Slot = "47")]
		set
		{
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06000444 RID: 1092 RVA: 0x00003738 File Offset: 0x00001938
	// (set) Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000228")]
	public bool DayTimeSfx
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x80CC60", Offset = "0x80B260", VA = "0x18080CC60", Slot = "48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x80CCC0", Offset = "0x80B2C0", VA = "0x18080CCC0", Slot = "49")]
		set
		{
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000446 RID: 1094 RVA: 0x00003750 File Offset: 0x00001950
	// (set) Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000229")]
	public bool Lightning
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x80CDB0", Offset = "0x80B3B0", VA = "0x18080CDB0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x80CE10", Offset = "0x80B410", VA = "0x18080CE10", Slot = "51")]
		set
		{
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000448 RID: 1096 RVA: 0x00003768 File Offset: 0x00001968
	// (set) Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700022A")]
	public float TargetStormFactor
	{
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x80CF00", Offset = "0x80B500", VA = "0x18080CF00", Slot = "52")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x80CF60", Offset = "0x80B560", VA = "0x18080CF60", Slot = "53")]
		set
		{
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x0600044A RID: 1098 RVA: 0x00003780 File Offset: 0x00001980
	// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700022B")]
	public float CloudOpacityScaleTarget
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x80D070", Offset = "0x80B670", VA = "0x18080D070", Slot = "54")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x80D0D0", Offset = "0x80B6D0", VA = "0x18080D0D0", Slot = "55")]
		set
		{
		}
	}
}
