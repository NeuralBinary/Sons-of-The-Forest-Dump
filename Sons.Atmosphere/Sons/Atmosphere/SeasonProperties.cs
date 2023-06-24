using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[CreateAssetMenu(fileName = "NewSeasonProperties", menuName = "Sons/SeasonProperties")]
	public class SeasonProperties : ScriptableObject
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x1700001B")]
		public Vector2 DaytimeTemperatureMinMax
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xA7FDE0", Offset = "0xA7E3E0", VA = "0x180A7FDE0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x1700001C")]
		public Vector2 NighttimeTemperatureMinMax
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2D475D0", Offset = "0x2D45BD0", VA = "0x182D475D0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x1700001D")]
		public SeasonsManager.Season Season
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return SeasonsManager.Season.Spring;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x1700001E")]
		public float DurationDays
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x1700001F")]
		public float BerriesChance
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x17000020")]
		public float LightRainChance
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2D475F0", Offset = "0x2D45BF0", VA = "0x182D475F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x17000021")]
		public float MediumRainChance
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2D47620", Offset = "0x2D45C20", VA = "0x182D47620")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x17000022")]
		public float HeavyRainChance
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2D47650", Offset = "0x2D45C50", VA = "0x182D47650")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x17000023")]
		public Vector2 PrecipitationDurationInMinutes
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2D47680", Offset = "0x2D45C80", VA = "0x182D47680")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x17000024")]
		public float CheckForRainEveryXMinutes
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2D476A0", Offset = "0x2D45CA0", VA = "0x182D476A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x17000025")]
		public float SnowfallChance
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x17000026")]
		public float LightSnowChance
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2D476C0", Offset = "0x2D45CC0", VA = "0x182D476C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x17000027")]
		public float MediumSnowChance
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2D476E0", Offset = "0x2D45CE0", VA = "0x182D476E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x17000028")]
		public float HeavySnowChance
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x2D47700", Offset = "0x2D45D00", VA = "0x182D47700")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x17000029")]
		public float OverallWindIntensityMultiplier
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x1700002A")]
		public float LightRainWindIntensityMultiplier
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x1700002B")]
		public float MediumRainWindIntensityMultiplier
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x1700002C")]
		public float HeavyRainWindIntensityMultiplier
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x1700002D")]
		public float OceanWaveIntensityMultiplier
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700002E")]
		public OceanWaveSpectrum OceanWaveSpectrum
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700002F")]
		public float FogAttenuationDistance
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x728340", Offset = "0x726940", VA = "0x180728340")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x17000030")]
		private bool AnyChanceOfRain
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2D47720", Offset = "0x2D45D20", VA = "0x182D47720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2D47740", Offset = "0x2D45D40", VA = "0x182D47740")]
		private string LightRainLabel()
		{
			return null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2D477C0", Offset = "0x2D45DC0", VA = "0x182D477C0")]
		private string MediumRainLabel()
		{
			return null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2D47840", Offset = "0x2D45E40", VA = "0x182D47840")]
		private string HeavyRainLabel()
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2D478C0", Offset = "0x2D45EC0", VA = "0x182D478C0")]
		private void LightRainStrengthChanged()
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2D47900", Offset = "0x2D45F00", VA = "0x182D47900")]
		private void MediumRainStrengthChanged()
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2D47950", Offset = "0x2D45F50", VA = "0x182D47950")]
		private void HeavyRainStrengthChanged()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2D47990", Offset = "0x2D45F90", VA = "0x182D47990")]
		private string LightSnowLabel()
		{
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2D47A10", Offset = "0x2D46010", VA = "0x182D47A10")]
		private string MediumSnowLabel()
		{
			return null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2D47A90", Offset = "0x2D46090", VA = "0x182D47A90")]
		private string HeavySnowLabel()
		{
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2D47B10", Offset = "0x2D46110", VA = "0x182D47B10")]
		private void LightSnowStrengthChanged()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2D47B60", Offset = "0x2D46160", VA = "0x182D47B60")]
		private void MediumSnowStrengthChanged()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2D47BC0", Offset = "0x2D461C0", VA = "0x182D47BC0")]
		private void HeavySnowStrengthChanged()
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2D47C10", Offset = "0x2D46210", VA = "0x182D47C10")]
		public float GetGlobalPrecipitationChance()
		{
			return 0f;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2D47C40", Offset = "0x2D46240", VA = "0x182D47C40")]
		public float GetLightPrecipitationChance()
		{
			return 0f;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2D47C90", Offset = "0x2D46290", VA = "0x182D47C90")]
		public float GetMediumPrecipitationChance()
		{
			return 0f;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2D47CE0", Offset = "0x2D462E0", VA = "0x182D47CE0")]
		public float GetHeavyPrecipitationChance()
		{
			return 0f;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2D47D30", Offset = "0x2D46330", VA = "0x182D47D30")]
		public SeasonProperties()
		{
		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SeasonsManager.Season _season;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _durationDays;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _daytimeTemperatureMinMax;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _nighttimeTemperatureMinMax;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _berriesChance;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 3f)]
		[SerializeField]
		private float _overallWindIntensityMultiplier;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(1f, 2f)]
		private float _lightRainWindIntensityMultiplier;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x3C")]
		[Range(1f, 2f)]
		[SerializeField]
		private float _mediumRainWindIntensityMultiplier;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x40")]
		[Range(1f, 2f)]
		[SerializeField]
		private float _heavyRainWindIntensityMultiplier;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x44")]
		[Range(2f, 4f)]
		[SerializeField]
		private float _oceanWaveIntensityMultiplier;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private OceanWaveSpectrum _oceanWaveSpectrum;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _precipitationDurationInMinutes;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector2 _checkForRainChanceEveryXMinutes;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 _chanceOfRain;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector2 _lightRainChance2;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector2 _mediumRainChance2;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 _heavyRainChance2;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _snowfallChance;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Vector2 _lightSnowChance2;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector2 _mediumSnowChance2;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Vector2 _heavySnowChance2;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _fogAttenuationDistance;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xA0")]
		private float _heavyRainPercent;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xA4")]
		private float _heavySnowPercent;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xA8")]
		private float _lightRainPercent;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xAC")]
		private float _lightSnowPercent;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xB0")]
		private float _mediumRainPercent;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xB4")]
		private float _mediumSnowPercent;
	}
}
