using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[VolumeComponentMenu("Post-processing/Sons/BloodCold Post Process")]
[Serializable]
public sealed class BloodColdPostProcess : CustomPostProcessVolumeComponent, IPostProcessComponent
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3121D40", Offset = "0x3120340", VA = "0x183121D40", Slot = "13")]
	public bool IsActive()
	{
		return default(bool);
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
	[Token(Token = "0x17000001")]
	public override CustomPostProcessInjectionPoint injectionPoint
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980", Slot = "8")]
		get
		{
			return CustomPostProcessInjectionPoint.AfterOpaqueAndSky;
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3121EE0", Offset = "0x31204E0", VA = "0x183121EE0", Slot = "10")]
	public override void Setup()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x31221E0", Offset = "0x31207E0", VA = "0x1831221E0", Slot = "11")]
	public override void Render(CommandBuffer cmd, HDCamera camera, RTHandle source, RTHandle destination)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3122F60", Offset = "0x3121560", VA = "0x183122F60", Slot = "12")]
	public override void Cleanup()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3122FB0", Offset = "0x31215B0", VA = "0x183122FB0")]
	public BloodColdPostProcess()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x40")]
	[Header("Ice")]
	[Space(4f)]
	[Tooltip("Ice Normal(AG) Opacity(B)")]
	public TextureParameter iceTexture;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x48")]
	[Tooltip("Tiling of the Ice texture above.")]
	public Vector2Parameter iceTiling;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("Specifies the amount of distortion added by ice.")]
	public ClampedFloatParameter iceDistortion;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x58")]
	[Tooltip("Specifies the amount of distortion added by ice to blood.")]
	public ClampedFloatParameter iceBloodDistortion;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x60")]
	[Tooltip("Specifies the brightness added by ice.")]
	public ClampedFloatParameter iceBrighten;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x68")]
	[Tooltip("Specifies how much of the Ice alpha gets added to albedo.")]
	public ClampedFloatParameter iceAlbedoContribution;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x70")]
	[Space(5f)]
	[Tooltip("Should be controlled by script.")]
	public ClampedFloatParameter iceIntensity;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x78")]
	[Space(4f)]
	[Tooltip("Blood Normal(AG) Opacity(B) Time Shift(R)")]
	[Space(8f)]
	[Header("Blood")]
	public TextureParameter bloodTexture;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x80")]
	[Tooltip("Specifies the blood color.")]
	public ColorParameter bloodColor;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x88")]
	[Tooltip("Specifies the blood max opacity.")]
	public ClampedFloatParameter bloodMaxOpacity;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x90")]
	[Tooltip("Specifies the amount of distortion added by blood.")]
	public ClampedFloatParameter bloodDistortion;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x98")]
	[Tooltip("Specifies the movement along y of blood.")]
	public ClampedFloatParameter bloodSpeed;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0xA0")]
	[Tooltip("Specifies the time over which drops will appear according to the red value in the 'Blood Normal(AG) Opacity(B) Time Shift(R)' tex and the Blood Intensity.")]
	public ClampedFloatParameter bloodTimeStretch;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0xA8")]
	[Tooltip("Should be controlled by script.")]
	[Space(5f)]
	public ClampedFloatParameter bloodIntensity;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0xB0")]
	[Tooltip("Wet Lense Normal(RG) Mask(B)")]
	[Header("Wet Lense")]
	[Space(8f)]
	[Space(4f)]
	public TextureParameter wetlensTexture;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2Parameter wetlensTiling;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0xC0")]
	[Tooltip("Number of drop columns and row in the source texture.")]
	public Vector2Parameter wetlensGrid;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0xC8")]
	[Tooltip("Speed at which the drops slide down.")]
	public ClampedFloatParameter wetlensMovement;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0xD0")]
	[Tooltip("Scales variation in speed, lifetime and horizonntal side for drop sample A.")]
	public ClampedFloatParameter wetlensVariationA;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0xD8")]
	[Space(5f)]
	public TextureParameter wetlenseBaseNormal;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0xE0")]
	public Vector2Parameter wetlenseBaseNormalTiling;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0xE8")]
	[Tooltip("Speed at which the base texture slides down.")]
	public ClampedFloatParameter wetlensBaseNormalStrength;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0xF0")]
	[Tooltip("Speed at which the base texture slides down.")]
	public ClampedFloatParameter wetlensBaseNormalSpeed;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0xF8")]
	[Space(5f)]
	[Tooltip("Specifies the amount of distortion added by Wet Lens.")]
	public ClampedFloatParameter wetlensDistortion;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x100")]
	[Tooltip("Should be controlled by script.")]
	[Space(5f)]
	public ClampedFloatParameter wetlensProgress;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x108")]
	[Header("Rain")]
	[Space(4f)]
	[Space(8f)]
	public ClampedFloatParameter rainAmount;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x110")]
	public ClampedFloatParameter localRainFactor;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x118")]
	public ClampedFloatParameter rainDropSpeed;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x120")]
	[Space(10f)]
	public BloodColdPostProcess.ShaderParameter _bloodColdShader;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x128")]
	private Material m_Material;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	private const string kShaderName = "Hidden/Shader/BloodColdPostProcessShader";

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _InputTexture;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _IceTexture;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int _IceTiling;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int _IceDistortion;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int _IceBloodDistortion;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int _IceBrighten;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int _IceAlbedoContribution;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int _IceIntensity;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int _BloodTexture;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int _BloodColor;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int _BloodMaxOpacity;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int _BloodDistortion;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int _BloodSpeed;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int _BloodTimeStretch;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int _BloodIntensity;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int _SonsWetLenseTexture;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int _SonsWetLenseTiling;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int _SonsWetLenseGrid;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int _SonsWetLenseMovement;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int _SonsWetLenseProgress;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x50")]
	private static readonly int _SonsWetLenseDistortion;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x54")]
	private static readonly int _SonsWetLenseDynScale;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x58")]
	private static readonly int _SonsWetLenseVariationA;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x5C")]
	private static readonly int _SonsWetLenseBaseNormal;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x60")]
	private static readonly int _SonsWetLenseBaseNormalTiling;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x64")]
	private static readonly int _SonsWetLenseBaseNormalStrength;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x68")]
	private static readonly int _SonsWetLenseBaseNormalSpeed;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int _SonsRainLensIntensity;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int _SonsRainDropSpeed;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	[Serializable]
	public class ShaderParameter : VolumeParameter<Shader>
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3124D20", Offset = "0x3123320", VA = "0x183124D20")]
		public ShaderParameter(Shader value, bool overrideState = false)
		{
		}
	}
}
