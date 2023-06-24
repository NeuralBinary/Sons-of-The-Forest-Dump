using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[CreateAssetMenu(menuName = "Sons/Construction/ConstructionSettings", fileName = "ConstructionSettings", order = 0)]
	public class ConstructionSettings : ScriptableObject
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ConstructionSettings()
		{
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x18")]
		public ConstructionSettings.AnimationData Animation;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x20")]
		public ConstructionSettings.PhysicsData Physics;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x28")]
		public ConstructionSettings.TimerData Timers;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x30")]
		public ConstructionSettings.TargetingData Targeting;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x38")]
		public ConstructionSettings.MiscData Misc;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		[Serializable]
		public class AnimationData
		{
			// Token: 0x1700003B RID: 59
			// (get) Token: 0x0600009F RID: 159 RVA: 0x000025AC File Offset: 0x000007AC
			// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700003B")]
			public float DistanceToPilar
			{
				[Token(Token = "0x600009F")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x000025C4 File Offset: 0x000007C4
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700003C")]
			public float DistanceToLiftBeamPilar
			{
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x000025DC File Offset: 0x000007DC
			// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700003D")]
			public float DistanceToLiftBeamStrut
			{
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A4")]
				[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x000025F4 File Offset: 0x000007F4
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700003E")]
			public float DistanceToStickPilar
			{
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A6")]
				[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000260C File Offset: 0x0000080C
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700003F")]
			public float DistanceToTarpStake
			{
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A8")]
				[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002624 File Offset: 0x00000824
			// (set) Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000040")]
			public float DistanceToPlantHeadOnStick
			{
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000AB RID: 171 RVA: 0x0000263C File Offset: 0x0000083C
			// (set) Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000041")]
			public float GroundPenetration
			{
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000AC")]
				[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2D63550", Offset = "0x2D61B50", VA = "0x182D63550")]
			public AnimationData()
			{
			}
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		[Serializable]
		public class MiscData
		{
			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00002654 File Offset: 0x00000854
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000042")]
			public float RotationSpeed
			{
				[Token(Token = "0x60000AE")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000266C File Offset: 0x0000086C
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000043")]
			public float AutoCancelFailSafeDistance
			{
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002684 File Offset: 0x00000884
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000044")]
			public float CombineItemMaxDistanceToExtremity
			{
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000269C File Offset: 0x0000089C
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000045")]
			public int CascadeRepositioningsMaxAnimatedStructures
			{
				[Token(Token = "0x60000B4")]
				[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0xA7FDD0", Offset = "0xA7E3D0", VA = "0x180A7FDD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x000026B4 File Offset: 0x000008B4
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000046")]
			public float CutPilarMinDistance
			{
				[Token(Token = "0x60000B6")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x000026CC File Offset: 0x000008CC
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000047")]
			public float CutWindowMinDistance
			{
				[Token(Token = "0x60000B8")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000BA RID: 186 RVA: 0x000026E4 File Offset: 0x000008E4
			// (set) Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000048")]
			public float CutDefensiveWallMinDistance
			{
				[Token(Token = "0x60000BA")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000BB")]
				[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000BC RID: 188 RVA: 0x000026FC File Offset: 0x000008FC
			// (set) Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000049")]
			public float CutOffQuartersMinDistance
			{
				[Token(Token = "0x60000BC")]
				[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000BD")]
				[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00002714 File Offset: 0x00000914
			// (set) Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004A")]
			public float CutPilarMaxDistance
			{
				[Token(Token = "0x60000BE")]
				[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000272C File Offset: 0x0000092C
			// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004B")]
			public float CutWindowMaxDistance
			{
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000C1")]
				[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002744 File Offset: 0x00000944
			// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004C")]
			public float CutDefensiveWallMaxDistance
			{
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000C3")]
				[Address(RVA = "0x207C3C0", Offset = "0x207A9C0", VA = "0x18207C3C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000275C File Offset: 0x0000095C
			// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004D")]
			public float CutOffQuartersMaxDistance
			{
				[Token(Token = "0x60000C4")]
				[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000C5")]
				[Address(RVA = "0x2D63590", Offset = "0x2D61B90", VA = "0x182D63590")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002774 File Offset: 0x00000974
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004E")]
			public float MaxDistanceToPlaceAtWallCorner
			{
				[Token(Token = "0x60000C6")]
				[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000C7")]
				[Address(RVA = "0x781580", Offset = "0x77FB80", VA = "0x180781580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000278C File Offset: 0x0000098C
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004F")]
			public float MaxDistanceToPlacePilarAtFloorCorner
			{
				[Token(Token = "0x60000C8")]
				[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000C9")]
				[Address(RVA = "0x2D54950", Offset = "0x2D52F50", VA = "0x182D54950")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060000CA RID: 202 RVA: 0x000027A4 File Offset: 0x000009A4
			// (set) Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000050")]
			public float SideLengthRatioToPlacePilarAtFloorCorner
			{
				[Token(Token = "0x60000CA")]
				[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000CB")]
				[Address(RVA = "0x2D635A0", Offset = "0x2D61BA0", VA = "0x182D635A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060000CC RID: 204 RVA: 0x000027BC File Offset: 0x000009BC
			// (set) Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000051")]
			public float StitchingLookupRadius
			{
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000CD")]
				[Address(RVA = "0x2D635B0", Offset = "0x2D61BB0", VA = "0x182D635B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060000CE RID: 206 RVA: 0x000027D4 File Offset: 0x000009D4
			// (set) Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000052")]
			public float AboveGroundTreeStructureMinHeight
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0x290B500", Offset = "0x2909B00", VA = "0x18290B500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x000027EC File Offset: 0x000009EC
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000053")]
			public float AboveGroundTreeStructureMaxHeight
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0x2B89DD0", Offset = "0x2B883D0", VA = "0x182B89DD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002804 File Offset: 0x00000A04
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000054")]
			public int MaxDestructionPickupSpawn
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000D3")]
				[Address(RVA = "0x22A59E0", Offset = "0x22A3FE0", VA = "0x1822A59E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000281C File Offset: 0x00000A1C
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000055")]
			public int MaxDestructionPickupSpawnResetDelaySeconds
			{
				[Token(Token = "0x60000D4")]
				[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000D5")]
				[Address(RVA = "0x287DC40", Offset = "0x287C240", VA = "0x18287DC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2D635C0", Offset = "0x2D61BC0", VA = "0x182D635C0")]
			public MiscData()
			{
			}
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		[Serializable]
		public class PhysicsData
		{
			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002834 File Offset: 0x00000A34
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000056")]
			public float FallingOffPartTorqueReposition
			{
				[Token(Token = "0x60000D7")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000D8")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000284C File Offset: 0x00000A4C
			// (set) Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000057")]
			public float CutOffPartTorqueLog
			{
				[Token(Token = "0x60000D9")]
				[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000DA")]
				[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060000DB RID: 219 RVA: 0x00002864 File Offset: 0x00000A64
			// (set) Token: 0x060000DC RID: 220 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000058")]
			public float CutOffPartForceLog
			{
				[Token(Token = "0x60000DB")]
				[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000DC")]
				[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060000DD RID: 221 RVA: 0x0000287C File Offset: 0x00000A7C
			// (set) Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000059")]
			public float CutOffPartTorquePilar
			{
				[Token(Token = "0x60000DD")]
				[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000DE")]
				[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060000DF RID: 223 RVA: 0x00002894 File Offset: 0x00000A94
			// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005A")]
			public float CutOffPartForcePilar
			{
				[Token(Token = "0x60000DF")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000E0")]
				[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x000028AC File Offset: 0x00000AAC
			// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005B")]
			public float CutOffPartTorqueWindow
			{
				[Token(Token = "0x60000E1")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x000028C4 File Offset: 0x00000AC4
			// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005C")]
			public float CutOffPartForceWindow
			{
				[Token(Token = "0x60000E3")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x000028DC File Offset: 0x00000ADC
			// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005D")]
			public float CombineItemTorque
			{
				[Token(Token = "0x60000E5")]
				[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000E6")]
				[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x000028F4 File Offset: 0x00000AF4
			// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005E")]
			public float CombineItemForce
			{
				[Token(Token = "0x60000E7")]
				[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000E8")]
				[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000290C File Offset: 0x00000B0C
			// (set) Token: 0x060000EA RID: 234 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005F")]
			public float ExtraElementForce
			{
				[Token(Token = "0x60000E9")]
				[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000EA")]
				[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2D63650", Offset = "0x2D61C50", VA = "0x182D63650")]
			public PhysicsData()
			{
			}
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		[Serializable]
		public class TargetingData
		{
			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060000EC RID: 236 RVA: 0x00002924 File Offset: 0x00000B24
			// (set) Token: 0x060000ED RID: 237 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000060")]
			public float MinCanvasCircleGuideRadius
			{
				[Token(Token = "0x60000EC")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000ED")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060000EE RID: 238 RVA: 0x0000293C File Offset: 0x00000B3C
			// (set) Token: 0x060000EF RID: 239 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000061")]
			public float MaxCanvasCircleGuideRadius
			{
				[Token(Token = "0x60000EE")]
				[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000EF")]
				[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002954 File Offset: 0x00000B54
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000062")]
			public bool RestrictCanvasCircleGuideToInFront
			{
				[Token(Token = "0x60000F0")]
				[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000F1")]
				[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000296C File Offset: 0x00000B6C
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000063")]
			public float MaxDistanceToPlaceDefensiveWall
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000F3")]
				[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002984 File Offset: 0x00000B84
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000064")]
			public float MaxRopeBridgeLength
			{
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000F5")]
				[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2D636A0", Offset = "0x2D61CA0", VA = "0x182D636A0")]
			public TargetingData()
			{
			}
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		[Serializable]
		public class TimerData
		{
			// Token: 0x17000065 RID: 101
			// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000299C File Offset: 0x00000B9C
			// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000065")]
			public float DelayedResetFailSafe
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000F8")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2D636D0", Offset = "0x2D61CD0", VA = "0x182D636D0")]
			public TimerData()
			{
			}
		}
	}
}
