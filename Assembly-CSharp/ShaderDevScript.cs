using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
[AddComponentMenu("Sons/GraphicsDev/Simulate Environment")]
public class ShaderDevScript : MonoBehaviour
{
	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x5CDAF0", Offset = "0x5CC0F0", VA = "0x1805CDAF0")]
	private void Start()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x5CDB10", Offset = "0x5CC110", VA = "0x1805CDB10")]
	private void OnValidate()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x5CDB20", Offset = "0x5CC120", VA = "0x1805CDB20")]
	private void OnEnable()
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x5CDB40", Offset = "0x5CC140", VA = "0x1805CDB40")]
	private void OnDisable()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x5CDB80", Offset = "0x5CC180", VA = "0x1805CDB80")]
	private void UpdateSettings()
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x5CE320", Offset = "0x5CC920", VA = "0x1805CE320")]
	private void SetupRT()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x5CE890", Offset = "0x5CCE90", VA = "0x1805CE890")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x5CE980", Offset = "0x5CCF80", VA = "0x1805CE980")]
	public ShaderDevScript()
	{
	}

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	public float _wetness;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	public float _staticWetness;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float _RainIntensity;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	[Space(5f)]
	public float _SnowAmount;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x30")]
	public float _SnowMinAngle;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x34")]
	public float _SnowMaxAngle;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 500f)]
	public float _SnowStartHeight;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x3C")]
	[Range(0f, 500f)]
	public float _SnowFadeRange;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x40")]
	public Color GlobalSnowColor;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int GlobalSnowColorPID;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x50")]
	public Texture _RainRipplesBase;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int SnowAmountPID;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int SnowHeightAngleRangePID;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x58")]
	private Material m_material;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x60")]
	public int RenderTextureSize;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x68")]
	private Shader RainRippleCompositeShader;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x70")]
	public float RippleTiling;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x74")]
	public float RippleAnimSpeed;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x78")]
	public float WetnessDetailDistance;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x7C")]
	[Range(0f, 0.5f)]
	public float WetnessRefrectionStrength;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x80")]
	private RenderTexture RainRipplesRenderTexture;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x88")]
	public Texture _SnowAlbedo;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x90")]
	public Texture _SnowNormal;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x98")]
	[Space(5f)]
	[Range(0f, 1f)]
	public float _Burn;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int _SonsDebugBurn;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Texture _terrainHeightNormalMap;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int TerrainHeightNormal;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int TerrainPos;

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int TerrainSize;

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Vector3 _terrainPosition;

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private Vector3 _terrainSize;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0xC0")]
	[Space(5f)]
	public bool debugBillboards;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0xC1")]
	[Space(5f)]
	public bool setTerrainTess;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int _Sons_TerrainTessValue;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int _Sons_TerrainMinTessValue;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0xC4")]
	[Range(1f, 31f)]
	public int TerrainTess;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0xC8")]
	[Range(1f, 31f)]
	public int TerrainMinTess;
}
