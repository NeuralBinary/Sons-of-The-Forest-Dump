using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
[AddComponentMenu("Sons/Ai/Vail Debug Console")]
public class VailDebugConsole : MonoBehaviour
{
	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2AEAC70", Offset = "0x2AE9270", VA = "0x182AEAC70")]
	private void Update()
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2AEB870", Offset = "0x2AE9E70", VA = "0x182AEB870")]
	private void SpawnPlacedStimuli(VailDebugConsole.StimuliPoint stimuliPoint)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2AEBBB0", Offset = "0x2AEA1B0", VA = "0x182AEBBB0")]
	private void SpawnPlacedStimuli(Vector3 pos, Quaternion rotation, GameObject prefab)
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2AEBD60", Offset = "0x2AEA360", VA = "0x182AEBD60")]
	private void LogPlacedStimuli()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void CreateStimuliFromTextPaste()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000227A File Offset: 0x0000047A
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2AEBFE0", Offset = "0x2AEA5E0", VA = "0x182AEBFE0")]
	private static string GetSubString(string str, string propName, string endProp)
	{
		return null;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2AEC3A0", Offset = "0x2AEA9A0", VA = "0x182AEC3A0")]
	private static Vector3 StringToVector3(string str)
	{
		return default(Vector3);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2AEC4E0", Offset = "0x2AEAAE0", VA = "0x182AEC4E0")]
	private static Quaternion StringToQuaternion(string str)
	{
		return default(Quaternion);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2AEC660", Offset = "0x2AEAC60", VA = "0x182AEC660")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2AEC670", Offset = "0x2AEAC70", VA = "0x182AEC670")]
	public VailDebugConsole()
	{
	}

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform _placedStimuliParent;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<VailDebugConsole.TriggerObject> _triggerObjects;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<VailDebugConsole.ToggleStimuli> _toggleStimuli;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<VailDebugConsole.StimuliPlacement> _placeStimuli;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x40")]
	private List<VailDebugConsole.StimuliPoint> _placedStimuliPoints;

	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[Serializable]
	private struct TriggerObject
	{
		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x0")]
		public KeyCode KeyCode;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x8")]
		public GameObject Prefab;
	}

	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	private class ToggleStimuli
	{
		// Token: 0x06000061 RID: 97 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2AEC900", Offset = "0x2AEAF00", VA = "0x182AEC900")]
		private ValueDropdownList<string> GetStimuliTypes()
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2AEC950", Offset = "0x2AEAF50", VA = "0x182AEC950")]
		public ToggleStimuli()
		{
		}

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x10")]
		public KeyCode KeyCode;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x18")]
		public string StimuliType;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x20")]
		public bool Active;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public GameObject SpawnedObject;
	}

	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Serializable]
	private struct StimuliPlacement
	{
		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x0")]
		public KeyCode KeyCode;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x8")]
		public GameObject Prefab;
	}

	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	private class StimuliPoint
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StimuliPoint()
		{
		}

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 _position;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion _rotation;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _prefab;
	}
}
