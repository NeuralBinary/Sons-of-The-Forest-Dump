using System;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class TreeWindSfx : MonoBehaviour, IWindReceiver
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x315A180", Offset = "0x3158780", VA = "0x18315A180")]
	private void Awake()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x315A480", Offset = "0x3158A80", VA = "0x18315A480")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x315A510", Offset = "0x3158B10", VA = "0x18315A510")]
	private int GetSizeParamIndex()
	{
		return 0;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x315A760", Offset = "0x3158D60", VA = "0x18315A760")]
	private void OnDisable()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x315A7E0", Offset = "0x3158DE0", VA = "0x18315A7E0")]
	public static void StopEvent(EventInstance evt)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x315A870", Offset = "0x3158E70", VA = "0x18315A870")]
	public void Activate()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x315AA70", Offset = "0x3159070", VA = "0x18315AA70")]
	private float GetWindIntensity()
	{
		return 0f;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x315AB90", Offset = "0x3159190", VA = "0x18315AB90")]
	public void Deactivate(float persistTime)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000012 RID: 18 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000001")]
	public bool IsActive
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x315AC10", Offset = "0x3159210", VA = "0x18315AC10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x315AC20", Offset = "0x3159220", VA = "0x18315AC20")]
	public static EventInstance BeginTransfer(Transform source)
	{
		return default(EventInstance);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x315AD90", Offset = "0x3159390", VA = "0x18315AD90")]
	public static void CompleteTransfer(Transform destination, EventInstance windEvent)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x315AF30", Offset = "0x3159530", VA = "0x18315AF30", Slot = "4")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
	public void SetEventPath(string windEventPath)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
	public void SetSize(float size)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
	public string GetEventPath()
	{
		return null;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
	public float GetEventSize()
	{
		return 0f;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x315AF50", Offset = "0x3159550", VA = "0x18315AF50")]
	public TreeWindSfx()
	{
	}

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("EventPath")]
	[Tooltip("Path of FMOD event to play")]
	[SerializeField]
	[EventRef]
	private string _eventPath;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("size")]
	[SerializeField]
	private float _size;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x30")]
	private EventInstance WindEvent;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x38")]
	private int SizeParameterIndex;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x3C")]
	private float Timeout;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x40")]
	private bool WaitingForTimeout;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x0")]
	private static bool _hasThrownAtmosphereNullException;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x44")]
	private float _windIntensity;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 _windDirection;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, int> _cachedSizeParam;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x54")]
	private bool _hasDeactivated;
}
