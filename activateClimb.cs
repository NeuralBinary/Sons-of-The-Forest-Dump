using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

// Token: 0x020000F6 RID: 246
[Token(Token = "0x20000F6")]
public class activateClimb : MonoBehaviour
{
	// Token: 0x06000729 RID: 1833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000729")]
	[Address(RVA = "0x2E8C010", Offset = "0x2E8B010", VA = "0x182E8C010")]
	private void Awake()
	{
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x2E8C770", Offset = "0x2E8B770", VA = "0x182E8C770")]
	private void Start()
	{
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x2E8C590", Offset = "0x2E8B590", VA = "0x182E8C590")]
	private void OnEnable()
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x2E8C470", Offset = "0x2E8B470", VA = "0x182E8C470")]
	private void OnDisable()
	{
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x2E8CBA0", Offset = "0x2E8BBA0", VA = "0x182E8CBA0")]
	private void Update()
	{
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00004098 File Offset: 0x00002298
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x2E8BE40", Offset = "0x2E8AE40", VA = "0x182E8BE40")]
	private static bool PlayerIsBusy()
	{
		return default(bool);
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x2E8C6A0", Offset = "0x2E8B6A0", VA = "0x182E8C6A0")]
	private bool PlayerIsAligned()
	{
		return default(bool);
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x2E8C3A0", Offset = "0x2E8B3A0", VA = "0x182E8C3A0")]
	private void OnClimbRope(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x000040C8 File Offset: 0x000022C8
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x2E8C1E0", Offset = "0x2E8B1E0", VA = "0x182E8C1E0")]
	private bool IsRopeLongEnough()
	{
		return default(bool);
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x2E8C020", Offset = "0x2E8B020", VA = "0x182E8C020")]
	private void GrabEnter(GameObject grabber)
	{
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
	private void GrabExit(GameObject grabber)
	{
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x2E8C7F0", Offset = "0x2E8B7F0", VA = "0x182E8C7F0")]
	public void ToggleIcons(bool enable)
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x2E8C890", Offset = "0x2E8B890", VA = "0x182E8C890")]
	private void UpdateIconPosition()
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x2E8BF60", Offset = "0x2E8AF60", VA = "0x182E8BF60")]
	public activateClimb()
	{
	}

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject _interactionElement;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("closeTriggerThreshhold")]
	private float _minimumRopeLength;

	// Token: 0x040005DE RID: 1502
	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x30")]
	private activateClimbTop _topClimb;
}
