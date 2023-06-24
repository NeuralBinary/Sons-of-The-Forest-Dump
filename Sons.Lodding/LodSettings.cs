using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Lodding
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[CreateAssetMenu(menuName = "Sons/Environment/LodSettingsAsset", fileName = "LodSettingsAsset", order = 0)]
	public class LodSettings : ScriptableObject, ISerializationCallbackReceiver
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x30C21D0", Offset = "0x30C07D0", VA = "0x1830C21D0")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x1700000D")]
		private bool HideGroupTriggerRange
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x30C2240", Offset = "0x30C0840", VA = "0x1830C2240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x1700000E")]
		public bool DontGroup
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x270DEE0", Offset = "0x270C4E0", VA = "0x18270DEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2BAD3E0", Offset = "0x2BAB9E0", VA = "0x182BAD3E0")]
		private void SetOcclusionScale(float value)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x1700000F")]
		public float OcclusionScale
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2403F30", Offset = "0x2402530", VA = "0x182403F30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x30C2250", Offset = "0x30C0850", VA = "0x1830C2250")]
		public float GetGroupTriggerRange()
		{
			return 0f;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000010")]
		public int GroupMaxCount
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x17000011")]
		public float GroupMaxRadius
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000012")]
		public List<CustomBillboard> Billboards
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x17000013")]
		public float StippleNearOffset
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000014")]
		public float StippleFarOffset
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x179D730", Offset = "0x179BD30", VA = "0x18179D730")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000015")]
		public int StippleIndex
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x30C2270", Offset = "0x30C0870", VA = "0x1830C2270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
		public LodSettingsTypeEnum GetLodSettingsType()
		{
			return LodSettingsTypeEnum.Trees;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x30C2280", Offset = "0x30C0880", VA = "0x1830C2280")]
		private void OnDisable()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x30C2290", Offset = "0x30C0890", VA = "0x1830C2290")]
		private void OnValidate()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x30C2320", Offset = "0x30C0920", VA = "0x1830C2320")]
		public void UpdateRanges(float quality, float stipplingMult)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
		private float GetTreeOcclusionBonusMultiplier()
		{
			return 0f;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x30C3280", Offset = "0x30C1880", VA = "0x1830C3280")]
		public void DrawDebug(GameObject lod00Guide, GameObject lod01Guide, GameObject lod02Guide)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x30C3830", Offset = "0x30C1E30", VA = "0x1830C3830")]
		public int GetLOD(Vector3 position, int currentLOD)
		{
			return 0;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x30C3A70", Offset = "0x30C2070", VA = "0x1830C3A70")]
		public void CleanBillboards()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x30C3C60", Offset = "0x30C2260", VA = "0x1830C3C60")]
		public void ToggleDebugRanges()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x620370", Offset = "0x61E970", VA = "0x180620370")]
		public void SetDrawDebug(bool value)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x30C3C70", Offset = "0x30C2270", VA = "0x1830C3C70")]
		public float GetLod2Distance()
		{
			return 0f;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x30C3CF0", Offset = "0x30C22F0", VA = "0x1830C3CF0")]
		public float CalculateLod02EndRange(float occlusionScale, int qualityOverride)
		{
			return 0f;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x30C3D60", Offset = "0x30C2360", VA = "0x1830C3D60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
		public string GetHLodSettingName()
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x30C3D80", Offset = "0x30C2380", VA = "0x1830C3D80")]
		public static void Force3DDistance(bool value)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x30C3E30", Offset = "0x30C2430", VA = "0x1830C3E30")]
		public static void Force2DDistance(bool value)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x30C3EB0", Offset = "0x30C24B0", VA = "0x1830C3EB0")]
		public LodSettings()
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LodSettingsTypeEnum _settingsType;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private LodSettingsType _lodSettingsType;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_logRanges")]
		[SerializeField]
		private LodRange _lodRanges;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("TreeOcclusionBonusMultiplier")]
		[SerializeField]
		private float _treeOcclusionBonusMultiplier;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x34")]
		public bool Use2dDistance;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x38")]
		private List<CustomBillboard> _billboards;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x40")]
		public Material[] StippledMaterials;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x48")]
		public LodSettings.CaveModes CaveMode;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("DrawDebug")]
		public bool _drawDebug;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 lastStippleRange;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x58")]
		private int lastBillboardCount;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x5C")]
		private int lastStippledMaterialCount;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x60")]
		private float[] currentQuality;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x68")]
		private float[] currentRanges;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x70")]
		private int unConstrainedMidLodCount;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int StippleNear;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int StippleFar;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x74")]
		[Header("Auto Gizmo Grouping")]
		[SerializeField]
		private bool _dontGroup;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x75")]
		[FormerlySerializedAs("_groupTriggerDistance")]
		[SerializeField]
		private bool _autoGroupTriggerRange;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("_groupTriggerDistance")]
		[Range(0f, 30000f)]
		[SerializeField]
		private float _groupTriggerRange;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _groupMaxRadius;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int _groupMaxCount;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _stippleNearOffset;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _stippleFarOffset;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _hLodSettingName;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _overrideName;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _nameOverride;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xA8")]
		private float _occlusionScale;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xAC")]
		[NonSerialized]
		private int _lodQualityIndex;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x8")]
		private static bool _force3DDistance;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x9")]
		private static bool _force2DDistance;

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public enum CaveModes
		{
			// Token: 0x0400009C RID: 156
			[Token(Token = "0x400009C")]
			Always,
			// Token: 0x0400009D RID: 157
			[Token(Token = "0x400009D")]
			CaveOnly,
			// Token: 0x0400009E RID: 158
			[Token(Token = "0x400009E")]
			OutsideOnly
		}
	}
}
