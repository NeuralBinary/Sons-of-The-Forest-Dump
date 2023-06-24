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
	// Token: 0x0600017C RID: 380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2F7EFF0", Offset = "0x2F7D5F0", VA = "0x182F7EFF0")]
	private void Awake()
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2F7F050", Offset = "0x2F7D650", VA = "0x182F7F050")]
	private void OnEnable()
	{
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2F7F1D0", Offset = "0x2F7D7D0", VA = "0x182F7F1D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2F7F340", Offset = "0x2F7D940", VA = "0x182F7F340")]
	private void Update()
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2F7F380", Offset = "0x2F7D980", VA = "0x182F7F380")]
	private bool IsPlayerIdle()
	{
		return default(bool);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x2F7F440", Offset = "0x2F7DA40", VA = "0x182F7F440")]
	[UsedImplicitly]
	private void GrabEnter()
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x2F7F4F0", Offset = "0x2F7DAF0", VA = "0x182F7F4F0")]
	[UsedImplicitly]
	private void GrabExit(GameObject grabber)
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x2F7F550", Offset = "0x2F7DB50", VA = "0x182F7F550")]
	private void OnPickupBody(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2F7F760", Offset = "0x2F7DD60", VA = "0x182F7F760")]
	private void ResetIcons()
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x2F7F950", Offset = "0x2F7DF50", VA = "0x182F7F950")]
	public void ToggleIcons(bool enable)
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public PickUpBody()
	{
	}

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject _icon;

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject _interactionElement;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[FormerlySerializedAs("parentGo")]
	private GameObject _parentGo;
}
