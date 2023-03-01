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
	// (get) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000007")]
	private List<string> GetMenuDropdown
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x299E950", Offset = "0x299D950", VA = "0x18299E950")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x299E7F0", Offset = "0x299D7F0", VA = "0x18299E7F0")]
	private void Start()
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x299E210", Offset = "0x299D210", VA = "0x18299E210")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x299E1F0", Offset = "0x299D1F0", VA = "0x18299E1F0")]
	public void EventTriggered()
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2921DA0", Offset = "0x2920DA0", VA = "0x182921DA0")]
	public void EnableTrigger()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x5E65D0", Offset = "0x5E55D0", VA = "0x1805E65D0")]
	public void SetObserverTransform(Transform mainCamTr)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x299E820", Offset = "0x299D820", VA = "0x18299E820")]
	public CutsceneTrigger()
	{
	}

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("range")]
	[SerializeField]
	private float _range;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("MyPickUp")]
	[SerializeField]
	private GameObject _myPickUp;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _triggerInput;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _consoleInput;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("_keyboardImput")]
	[SerializeField]
	private GameObject _keyboardInput;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform _observerTransform;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<GameObject> _disableTargets;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<GameObject> _enableTargets;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("EventTriggered")]
	private UnityEvent _eventTriggered;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x68")]
	private InputSystem.Action _triggerInputActionCache;
}
