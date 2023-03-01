using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
[AddComponentMenu("Sons/PickUpBody")]
public class PickUpBody : MonoBehaviour
{
	// Token: 0x06000173 RID: 371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x29AB1D0", Offset = "0x29AA1D0", VA = "0x1829AB1D0")]
	private void Awake()
	{
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x29AB500", Offset = "0x29AA500", VA = "0x1829AB500")]
	private void OnEnable()
	{
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x29AB3F0", Offset = "0x29AA3F0", VA = "0x1829AB3F0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x29AB850", Offset = "0x29AA850", VA = "0x1829AB850")]
	private void Update()
	{
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x29AB300", Offset = "0x29AA300", VA = "0x1829AB300")]
	private bool IsPlayerIdle()
	{
		return default(bool);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x29AB290", Offset = "0x29AA290", VA = "0x1829AB290")]
	[UsedImplicitly]
	private void GrabEnter()
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x29AB2D0", Offset = "0x29AA2D0", VA = "0x1829AB2D0")]
	[UsedImplicitly]
	private void GrabExit(GameObject grabber)
	{
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x29AB620", Offset = "0x29AA620", VA = "0x1829AB620")]
	private void OnPickupBody(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x29AB6A0", Offset = "0x29AA6A0", VA = "0x1829AB6A0")]
	private void ResetIcons()
	{
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x29AB750", Offset = "0x29AA750", VA = "0x1829AB750")]
	public void ToggleIcons(bool enable)
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public PickUpBody()
	{
	}

	// Token: 0x0400017A RID: 378
	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject _icon;

	// Token: 0x0400017B RID: 379
	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject _interactionElement;

	// Token: 0x0400017C RID: 380
	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("parentGo")]
	[SerializeField]
	private GameObject _parentGo;
}
