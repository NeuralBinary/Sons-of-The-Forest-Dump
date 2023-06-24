using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[AddComponentMenu("Shapes/Disc")]
	[ExecuteAlways]
	public class Disc : ShapeRenderer, IDashable
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x1700000C")]
		public bool HasThickness
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2A20460", Offset = "0x2A1EA60", VA = "0x182A20460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x1700000D")]
		public bool HasSector
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2A20480", Offset = "0x2A1EA80", VA = "0x182A20480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000021D4 File Offset: 0x000003D4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		public DiscType Type
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			get
			{
				return DiscType.Disc;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2A204A0", Offset = "0x2A1EAA0", VA = "0x182A204A0")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000021EC File Offset: 0x000003EC
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public Disc.DiscColorMode ColorMode
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			get
			{
				return Disc.DiscColorMode.Single;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2A204D0", Offset = "0x2A1EAD0", VA = "0x182A204D0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002204 File Offset: 0x00000404
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public override Color Color
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0", Slot = "4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2A204F0", Offset = "0x2A1EAF0", VA = "0x182A204F0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000221C File Offset: 0x0000041C
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000011")]
		public Color ColorInnerStart
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2A20610", Offset = "0x2A1EC10", VA = "0x182A20610")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002234 File Offset: 0x00000434
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000012")]
		public Color ColorOuterStart
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x179CE30", Offset = "0x179B430", VA = "0x18179CE30")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2A206A0", Offset = "0x2A1ECA0", VA = "0x182A206A0")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000224C File Offset: 0x0000044C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000013")]
		public Color ColorInnerEnd
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2A20730", Offset = "0x2A1ED30", VA = "0x182A20730")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2A20740", Offset = "0x2A1ED40", VA = "0x182A20740")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002264 File Offset: 0x00000464
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public Color ColorOuterEnd
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2A207D0", Offset = "0x2A1EDD0", VA = "0x182A207D0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2A207E0", Offset = "0x2A1EDE0", VA = "0x182A207E0")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000015")]
		public Color ColorOuter
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x179CE30", Offset = "0x179B430", VA = "0x18179CE30")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2A20870", Offset = "0x2A1EE70", VA = "0x182A20870")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002294 File Offset: 0x00000494
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public Color ColorInner
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2A20930", Offset = "0x2A1EF30", VA = "0x182A20930")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000017")]
		public Color ColorStart
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2A209F0", Offset = "0x2A1EFF0", VA = "0x182A209F0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000022C4 File Offset: 0x000004C4
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public Color ColorEnd
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2A20730", Offset = "0x2A1ED30", VA = "0x182A20730")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2A20AB0", Offset = "0x2A1F0B0", VA = "0x182A20AB0")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022DC File Offset: 0x000004DC
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000019")]
		public DiscGeometry Geometry
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xAFF420", Offset = "0xAFDA20", VA = "0x180AFF420")]
			get
			{
				return DiscGeometry.Flat2D;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2A20B70", Offset = "0x2A1F170", VA = "0x182A20B70")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public float AngRadiansStart
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2A20C10", Offset = "0x2A1F210", VA = "0x182A20C10")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001B")]
		public float AngRadiansEnd
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2739A50", Offset = "0x2738050", VA = "0x182739A50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2A20C90", Offset = "0x2A1F290", VA = "0x182A20C90")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		public float Radius
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x69B280", Offset = "0x699880", VA = "0x18069B280")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2A20D10", Offset = "0x2A1F310", VA = "0x182A20D10")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000233C File Offset: 0x0000053C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		public ThicknessSpace RadiusSpace
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x67E8E0", Offset = "0x67CEE0", VA = "0x18067E8E0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2A20D90", Offset = "0x2A1F390", VA = "0x182A20D90")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		[Obsolete("this property is obsolete, this was a typo! please use Thickness instead!", true)]
		public float RadiusInner
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x13429E0", Offset = "0x1340FE0", VA = "0x1813429E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2A20E30", Offset = "0x2A1F430", VA = "0x182A20E30")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001F")]
		public float Thickness
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x13429E0", Offset = "0x1340FE0", VA = "0x1813429E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2A20E30", Offset = "0x2A1F430", VA = "0x182A20E30")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000020")]
		public ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xAFF4C0", Offset = "0xAFDAC0", VA = "0x180AFF4C0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2A20EE0", Offset = "0x2A1F4E0", VA = "0x182A20EE0")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		public ArcEndCap ArcEndCaps
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xAFF4E0", Offset = "0xAFDAE0", VA = "0x180AFF4E0")]
			get
			{
				return ArcEndCap.None;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2A20F80", Offset = "0x2A1F580", VA = "0x182A20F80")]
			set
			{
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2A21020", Offset = "0x2A1F620", VA = "0x182A21020", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x17000022")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A214A0", Offset = "0x2A1FAA0", VA = "0x182A214A0", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2A21720", Offset = "0x2A1FD20", VA = "0x182A21720", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000023E4 File Offset: 0x000005E4
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public bool MatchDashSpacingToSize
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2806980", Offset = "0x2804F80", VA = "0x182806980", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2A21890", Offset = "0x2A1FE90", VA = "0x182A21890", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000023FC File Offset: 0x000005FC
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public bool Dashed
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2A21900", Offset = "0x2A1FF00", VA = "0x182A21900", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2A21910", Offset = "0x2A1FF10", VA = "0x182A21910", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000025")]
		public float DashSize
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2739570", Offset = "0x2737B70", VA = "0x182739570", Slot = "25")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2A21980", Offset = "0x2A1FF80", VA = "0x182A21980", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000242C File Offset: 0x0000062C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000026")]
		public float DashSpacing
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2A21A70", Offset = "0x2A20070", VA = "0x182A21A70", Slot = "27")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2A21A90", Offset = "0x2A20090", VA = "0x182A21A90", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000027")]
		public float DashOffset
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2A21B20", Offset = "0x2A20120", VA = "0x182A21B20", Slot = "29")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2A21B30", Offset = "0x2A20130", VA = "0x182A21B30", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000245C File Offset: 0x0000065C
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000028")]
		public DashSpace DashSpace
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xAFF540", Offset = "0xAFDB40", VA = "0x180AFF540", Slot = "31")]
			get
			{
				return DashSpace.Meters;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2A21BB0", Offset = "0x2A201B0", VA = "0x182A21BB0", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002474 File Offset: 0x00000674
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000029")]
		public DashSnapping DashSnap
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xAFF560", Offset = "0xAFDB60", VA = "0x180AFF560", Slot = "33")]
			get
			{
				return DashSnapping.Off;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2A21C90", Offset = "0x2A20290", VA = "0x182A21C90", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000248C File Offset: 0x0000068C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002A")]
		public DashType DashType
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xAFF520", Offset = "0xAFDB20", VA = "0x180AFF520", Slot = "35")]
			get
			{
				return DashType.Basic;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2A21D30", Offset = "0x2A20330", VA = "0x182A21D30", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000024A4 File Offset: 0x000006A4
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		public float DashShapeModifier
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2A21DD0", Offset = "0x2A203D0", VA = "0x182A21DD0", Slot = "37")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2A21DE0", Offset = "0x2A203E0", VA = "0x182A21DE0", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A21E60", Offset = "0x2A20460", VA = "0x182A21E60")]
		private void SetAllDashValues(bool now)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A21ED0", Offset = "0x2A204D0", VA = "0x182A21ED0")]
		private float GetNetDashSpacing()
		{
			return 0f;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A21F70", Offset = "0x2A20570", VA = "0x182A21F70")]
		public Disc()
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DiscType type;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Disc.DiscColorMode colorMode;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x98")]
		[ShapesColorField(true)]
		[SerializeField]
		private Color colorOuterStart;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[ShapesColorField(true)]
		private Color colorInnerEnd;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0xB8")]
		[ShapesColorField(true)]
		[SerializeField]
		private Color colorOuterEnd;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private DiscGeometry geometry;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private AngularUnit angUnitInput;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float angRadiansStart;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float angRadiansEnd;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float radius;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private ThicknessSpace radiusSpace;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float thickness;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private ThicknessSpace thicknessSpace;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private ArcEndCap arcEndCaps;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private bool matchDashSpacingToSize;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xED")]
		[SerializeField]
		private bool dashed;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private DashStyle dashStyle;

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		public enum DiscColorMode
		{
			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			Single,
			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			Radial,
			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			Angular,
			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			Bilinear
		}
	}
}
