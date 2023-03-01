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
	// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x299FBD0", Offset = "0x299EBD0", VA = "0x18299FBD0")]
	private void Start()
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x299FD20", Offset = "0x299ED20", VA = "0x18299FD20")]
	private void Update()
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x299F9E0", Offset = "0x299E9E0", VA = "0x18299F9E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x299FA80", Offset = "0x299EA80", VA = "0x18299FA80", Slot = "4")]
	public void SeasonChanged(SeasonProperties seasonProperties)
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x299FCD0", Offset = "0x299ECD0", VA = "0x18299FCD0", Slot = "6")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x299F9A0", Offset = "0x299E9A0", VA = "0x18299F9A0")]
	private float ConvertWindIntensity(float windIntensity)
	{
		return default(float);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x299FAC0", Offset = "0x299EAC0", VA = "0x18299FAC0")]
	private static void SetGlobalProperty(string propertyName, float value)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x299FC70", Offset = "0x299EC70", VA = "0x18299FC70", Slot = "7")]
	public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
	public bool ShouldRun()
	{
		return default(bool);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "9")]
	public bool ShouldRunTimeSliced()
	{
		return default(bool);
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "10")]
	public void SetLastUpdate(int frame, float time)
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x299FD60", Offset = "0x299ED60", VA = "0x18299FD60")]
	public FMODAtmosphereGlobalParameters()
	{
	}

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x20")]
	[ParamRef]
	[SerializeField]
	private string _seasonsGlobalParameter;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[ParamRef]
	private string _windGlobalParameter;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x30")]
	[ParamRef]
	[SerializeField]
	private string _timeGlobalParameter;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _windRangeMin;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _windRangeMax;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x40")]
	private SeasonsManager.Season _season;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x44")]
	private bool _useDebugSettings;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x48")]
	[Header("Debug")]
	private float _windIntensity;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x50")]
	private TimeOfDay _timeOfDay;
}
