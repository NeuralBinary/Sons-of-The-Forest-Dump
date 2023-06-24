using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Atmosphere;
using Sons.Environment;
using UnityEngine;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class FMODAtmosphereGlobalParameters : MonoBehaviour, ISeasonsReceiver, IWindReceiver, ITimeOfDayReceiver
{
	// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2F69E30", Offset = "0x2F68430", VA = "0x182F69E30")]
	private void Start()
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2F69ED0", Offset = "0x2F684D0", VA = "0x182F69ED0")]
	private void Update()
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2F69F10", Offset = "0x2F68510", VA = "0x182F69F10")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2F69FB0", Offset = "0x2F685B0", VA = "0x182F69FB0", Slot = "4")]
	public void SeasonChanged(SeasonProperties seasonProperties)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2F69FF0", Offset = "0x2F685F0", VA = "0x182F69FF0", Slot = "6")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2F6A040", Offset = "0x2F68640", VA = "0x182F6A040")]
	private float ConvertWindIntensity(float windIntensity)
	{
		return 0f;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2F6A080", Offset = "0x2F68680", VA = "0x182F6A080")]
	private static void SetGlobalProperty(string propertyName, float value)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2F6A190", Offset = "0x2F68790", VA = "0x182F6A190", Slot = "7")]
	public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
	public bool ShouldRun()
	{
		return default(bool);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
	public bool ShouldRunTimeSliced()
	{
		return default(bool);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
	public void SetLastUpdate(int frame, float time)
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2F6A200", Offset = "0x2F68800", VA = "0x182F6A200")]
	public FMODAtmosphereGlobalParameters()
	{
	}

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ParamRef]
	private string _seasonsGlobalParameter;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[ParamRef]
	private string _windGlobalParameter;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x30")]
	[ParamRef]
	[SerializeField]
	private string _timeGlobalParameter;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _windRangeMin;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _windRangeMax;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x40")]
	private SeasonsManager.Season _season;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x44")]
	private bool _useDebugSettings;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x48")]
	[Header("Debug")]
	private float _windIntensity;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x50")]
	private TimeOfDay _timeOfDay;
}
