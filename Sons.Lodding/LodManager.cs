using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lodding
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class LodManager : MonoBehaviour
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x30BEE80", Offset = "0x30BD480", VA = "0x1830BEE80")]
		private void OnValidate()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000001")]
		public static LodManager Instance
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x30BEEF0", Offset = "0x30BD4F0", VA = "0x1830BEEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x30BF010", Offset = "0x30BD610", VA = "0x1830BF010")]
		private static void AddLODManager()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x30BF230", Offset = "0x30BD830", VA = "0x1830BF230")]
		private void Awake()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000002")]
		public float RangeMultiplier
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x30BF510", Offset = "0x30BDB10", VA = "0x1830BF510")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x17000003")]
		public float RangeMultiplierSmall
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x30BF540", Offset = "0x30BDB40", VA = "0x1830BF540")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x17000004")]
		public float StipplingRangeMultiplier
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x30BF570", Offset = "0x30BDB70", VA = "0x1830BF570")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		private static event Action<float> _treeOcclusionUpdaterAction
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x30BF5A0", Offset = "0x30BDBA0", VA = "0x1830BF5A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x30BF760", Offset = "0x30BDD60", VA = "0x1830BF760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x17000005")]
		public static float TreeOcclusionBonusRatio
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x30BF920", Offset = "0x30BDF20", VA = "0x1830BF920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x30BF9C0", Offset = "0x30BDFC0", VA = "0x1830BF9C0")]
		public static void SetTreeOcclusionBonusRatioOverride(float value)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x30BFA90", Offset = "0x30BE090", VA = "0x1830BFA90")]
		public static void SetTreeOcclusionBonusRatio(float value)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x30BFAF0", Offset = "0x30BE0F0", VA = "0x1830BFAF0")]
		private void Update()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x30BFBC0", Offset = "0x30BE1C0", VA = "0x1830BFBC0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x30BFD00", Offset = "0x30BE300", VA = "0x1830BFD00")]
		private void DrawDebug()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x30BFE60", Offset = "0x30BE460", VA = "0x1830BFE60")]
		private void UpdateGroupSettings()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x30C0200", Offset = "0x30BE800", VA = "0x1830C0200")]
		private void InitStippleNameList(int count)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x30C0340", Offset = "0x30BE940", VA = "0x1830C0340")]
		private void UpdateStippleValues(List<float> stippleNearRanges, List<float> stippleFarRanges)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x30C0840", Offset = "0x30BEE40", VA = "0x1830C0840")]
		private static void ValidateStippleArrays()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x30C0B80", Offset = "0x30BF180", VA = "0x1830C0B80")]
		public LodSettings GetLodSettingFromType(LodSettingsTypeEnum settingsType)
		{
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x30C0CD0", Offset = "0x30BF2D0", VA = "0x1830C0CD0")]
		public static string GetDrawDistanceQualitySetting()
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x30C0D20", Offset = "0x30BF320", VA = "0x1830C0D20")]
		public static void SetDrawDistanceQuality(string qualityProfileId)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x30C0DE0", Offset = "0x30BF3E0", VA = "0x1830C0DE0")]
		private static int CalculateDrawDistanceQualitySettingIndex()
		{
			return 0;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x30C1200", Offset = "0x30BF800", VA = "0x1830C1200")]
		public static void ClearDebugRanges()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x30C1580", Offset = "0x30BFB80", VA = "0x1830C1580")]
		public static void ToggleDebugRanges(LodSettingsTypeEnum result)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x30C1950", Offset = "0x30BFF50", VA = "0x1830C1950")]
		public static int GetDrawDistanceQualitySettingIndex()
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x30C19A0", Offset = "0x30BFFA0", VA = "0x1830C19A0")]
		public static void RegisterOcclusionUpdater(Action<float> targetAction)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x30C1A00", Offset = "0x30C0000", VA = "0x1830C1A00")]
		public static void UnregisterOcclusionUpdater(Action<float> targetAction)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x30C1A50", Offset = "0x30C0050", VA = "0x1830C1A50")]
		public LodManager()
		{
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		public const string CustomQualityId = "Custom";

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		public const string UltraQualityId = "Ultra";

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		public const string HighQualityId = "High";

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		public const string MediumQualityId = "Medium";

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		public const string LowQualityId = "Low";

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		public const string UltraLowQualityId = "Ultra Low";

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lod00Guide;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lod01Guide;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lod02Guide;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x38")]
		private List<LodManager.StippleRange> _stippleValues;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<string> _stippleNames;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x48")]
		private float _treeLod2Distance;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		private const string DefaultDrawDistanceQualitySetting = "Ultra Low";

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		private static LodManager instance;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0.01f, 5.5f)]
		public float SidePadding;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x50")]
		[Header("Multiplier: Regular")]
		public float[] RangeMultiplierPerQuality;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x58")]
		public float[] RangeMultiplierPerQualitySmall;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x60")]
		[Header("Multiplier: Stippling Range")]
		public float[] StipplingRangeMultiplierPerQuality;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x68")]
		[Header("LOD Settings")]
		public List<LodSettings> _lodSettings;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x8")]
		private static string _currentDrawDistanceQualitySetting;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x10")]
		private static List<float> _stippleNearRanges;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x18")]
		private static List<float> _stippleFarRanges;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int SonsGlobalStipplingNearId;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int SonsGlobalStipplingFar;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private static int _currentDrawDistanceQualitySettingIndex;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x2C")]
		private static float _treeOcclusionBonusRatio;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x30")]
		private static bool _overrideTreeOcclusionBonusRatio;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x34")]
		private static float _overrideTreeOcclusionBonusRatioValue;

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		[Serializable]
		public struct StippleRange
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x17000006")]
			public string LabelName
			{
				[Token(Token = "0x6000063")]
				[Address(RVA = "0x30C1F70", Offset = "0x30C0570", VA = "0x1830C1F70")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string Name;

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			[FieldOffset(Offset = "0x8")]
			[Header("Near")]
			public float Near;

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[FieldOffset(Offset = "0xC")]
			[Header("Far")]
			public float Far;
		}
	}
}
