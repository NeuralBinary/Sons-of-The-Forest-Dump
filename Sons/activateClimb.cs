using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

// Token: 0x020000F4 RID: 244
[Token(Token = "0x20000F4")]
public class activateClimb : MonoBehaviour
{
	// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x36764D0", Offset = "0x3674AD0", VA = "0x1836764D0")]
	private void Awake()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x36764E0", Offset = "0x3674AE0", VA = "0x1836764E0")]
	private void Start()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x3676660", Offset = "0x3674C60", VA = "0x183676660")]
	private void OnEnable()
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x36767D0", Offset = "0x3674DD0", VA = "0x1836767D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077A")]
	[Address(RVA = "0x3676950", Offset = "0x3674F50", VA = "0x183676950")]
	private void Update()
	{
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x000042A8 File Offset: 0x000024A8
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x3676A00", Offset = "0x3675000", VA = "0x183676A00")]
	private static bool PlayerIsBusy()
	{
		return default(bool);
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x000042C0 File Offset: 0x000024C0
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x3676A30", Offset = "0x3675030", VA = "0x183676A30")]
	private bool PlayerIsAligned()
	{
		return default(bool);
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x3676B30", Offset = "0x3675130", VA = "0x183676B30")]
	private void OnClimbRope(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000042D8 File Offset: 0x000024D8
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x3676C40", Offset = "0x3675240", VA = "0x183676C40")]
	private bool IsRopeLongEnough()
	{
		return default(bool);
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x3676F40", Offset = "0x3675540", VA = "0x183676F40")]
	private void GrabEnter(GameObject grabber)
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
	private void GrabExit(GameObject grabber)
	{
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x3676FC0", Offset = "0x36755C0", VA = "0x183676FC0")]
	public void ToggleIcons(bool enable)
	{
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x3677100", Offset = "0x3675700", VA = "0x183677100")]
	private void UpdateIconPosition()
	{
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x36777D0", Offset = "0x3675DD0", VA = "0x1836777D0")]
	public activateClimb()
	{
	}

	// Token: 0x040005FB RID: 1531
	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject _interactionElement;

	// Token: 0x040005FC RID: 1532
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("closeTriggerThreshhold")]
	private float _minimumRopeLength;

	// Token: 0x040005FD RID: 1533
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _acessAngleAsDotThreshold;

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x30")]
	private activateClimbTop _topClimb;
}
