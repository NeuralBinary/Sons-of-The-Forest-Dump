using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class CutsceneTrigger : MonoBehaviour
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000007")]
	private List<string> GetMenuDropdown
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2F67CD0", Offset = "0x2F662D0", VA = "0x182F67CD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2F67D10", Offset = "0x2F66310", VA = "0x182F67D10")]
	private void Start()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2F67D70", Offset = "0x2F66370", VA = "0x182F67D70")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2F68860", Offset = "0x2F66E60", VA = "0x182F68860")]
	public void EventTriggered()
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2E3A120", Offset = "0x2E38720", VA = "0x182E3A120")]
	public void EnableTrigger()
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
	public void SetObserverTransform(Transform mainCamTr)
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2F68880", Offset = "0x2F66E80", VA = "0x182F68880")]
	public CutsceneTrigger()
	{
	}

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("range")]
	private float _range;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("MyPickUp")]
	private GameObject _myPickUp;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _triggerInput;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _consoleInput;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("_keyboardImput")]
	[SerializeField]
	private GameObject _keyboardInput;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform _observerTransform;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<GameObject> _disableTargets;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<GameObject> _enableTargets;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("EventTriggered")]
	[SerializeField]
	private UnityEvent _eventTriggered;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x68")]
	private InputSystem.Action _triggerInputActionCache;
}
