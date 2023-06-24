using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
[CreateAssetMenu(menuName = "Sons/Props/RadioTrackList", fileName = "RadioTrackList", order = 0)]
public class RadioTrackList : ScriptableObject
{
	// Token: 0x06000043 RID: 67 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
	public List<string> GetSongList()
	{
		return null;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
	public List<string> GetAdvertList()
	{
		return null;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2FFCAA0", Offset = "0x2FFB0A0", VA = "0x182FFCAA0")]
	public float GetEventLength(string eventName)
	{
		return 0f;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2FFCCD0", Offset = "0x2FFB2D0", VA = "0x182FFCCD0")]
	private float GetEventLength(string eventName, List<string> names, List<float> lengths)
	{
		return 0f;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2FFCDF0", Offset = "0x2FFB3F0", VA = "0x182FFCDF0")]
	private float GetEventLengthSeconds(FMOD_StudioSystem studioSystemInstance, string eventName)
	{
		return 0f;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void UpdateAllRadioTrackLengths()
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2FFCF80", Offset = "0x2FFB580", VA = "0x182FFCF80")]
	private void UpdateEventLengths(FMOD_StudioSystem studioSystemInstance)
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public RadioTrackList()
	{
	}

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<string> _songEvents;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<float> _songLengths;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<string> _advertEvents;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<float> _advertLengths;
}
