using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Serialization;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class CloudShadows : MonoBehaviour, IWindReceiver, ICloudReceiver, ISunLightReceiver
{
	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x5CBF60", Offset = "0x5CA560", VA = "0x1805CBF60")]
	private void OnEnable()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x5CBFB0", Offset = "0x5CA5B0", VA = "0x1805CBFB0")]
	private void DoOnEnable()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x5CC040", Offset = "0x5CA640", VA = "0x1805CC040")]
	private void OnValidate()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x5CC100", Offset = "0x5CA700", VA = "0x1805CC100")]
	private void UpdateCloudShadows()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x5CC790", Offset = "0x5CAD90", VA = "0x1805CC790")]
	private float Convert01Intensity(float windIntensity)
	{
		return 0f;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x5CC7B0", Offset = "0x5CADB0", VA = "0x1805CC7B0")]
	private void Setup()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x5CCD60", Offset = "0x5CB360", VA = "0x1805CCD60")]
	private void SetupCookie()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x5CCDA0", Offset = "0x5CB3A0", VA = "0x1805CCDA0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x5CD1C0", Offset = "0x5CB7C0", VA = "0x1805CD1C0", Slot = "4")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x5CD1E0", Offset = "0x5CB7E0", VA = "0x1805CD1E0", Slot = "5")]
	public void UpdateCloud(float density)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x5CD1F0", Offset = "0x5CB7F0", VA = "0x1805CD1F0", Slot = "6")]
	public void UpdateSunLight(GameObject sunlightGameObject, Light sunLight, HDAdditionalLightData lightData)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x5CD490", Offset = "0x5CBA90", VA = "0x1805CD490")]
	public CloudShadows()
	{
	}

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x20")]
	[Header("Cloud Settings")]
	public CloudShadows.CloudshadowsRTSize rtResolution;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x28")]
	public Material material;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve _remapIntensity;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	[SerializeField]
	[FormerlySerializedAs("CloudDensity")]
	private float _cloudDensity;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x3C")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _cloudDarkness;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x40")]
	[Header("Light Settings")]
	[FormerlySerializedAs("light")]
	public Light _light;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x48")]
	public float CookieSize;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[FormerlySerializedAs("windStrength")]
	private float _windIntensity;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Vector3 _windDirection;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private Vector2 _windMinMax;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x68")]
	private CustomRenderTexture customRenderTextureCS;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x70")]
	private Transform _lightTransform;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x78")]
	private HDAdditionalLightData _lightData;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 windUV;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x88")]
	private Matrix4x4 virtualProjectionMatrix;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0xC8")]
	private Vector4 virtualPoint;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int CloudShadowDensityPID;

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int CloudShadowUVPID;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int CloudShadowDarknessID;

	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[Serializable]
	public enum CloudshadowsRTSize
	{
		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		_256 = 256,
		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		_512 = 512,
		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		_1024 = 1024
	}
}
