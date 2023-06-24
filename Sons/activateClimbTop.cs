using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

// Token: 0x020000F5 RID: 245
[Token(Token = "0x20000F5")]
public class activateClimbTop : MonoBehaviour
{
	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x000042F0 File Offset: 0x000024F0
	[Token(Token = "0x170000F9")]
	private bool PlayerIsBellowTop
	{
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x3677820", Offset = "0x3675E20", VA = "0x183677820")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x3677980", Offset = "0x3675F80", VA = "0x183677980")]
	private void Awake()
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x3677BB0", Offset = "0x36761B0", VA = "0x183677BB0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x3677D30", Offset = "0x3676330", VA = "0x183677D30")]
	private void OnDisable()
	{
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x3677EB0", Offset = "0x36764B0", VA = "0x183677EB0")]
	private void Update()
	{
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00004308 File Offset: 0x00002508
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x3676A00", Offset = "0x3675000", VA = "0x183676A00")]
	private static bool PlayerIsBusy()
	{
		return default(bool);
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x3677EF0", Offset = "0x36764F0", VA = "0x183677EF0")]
	private void OnClimbRope(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x3678030", Offset = "0x3676630", VA = "0x183678030")]
	private void GrabEnter()
	{
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
	private void GrabExit()
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x3678210", Offset = "0x3676810", VA = "0x183678210")]
	public void ToggleIcons(bool enable)
	{
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00004320 File Offset: 0x00002520
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x3678350", Offset = "0x3676950", VA = "0x183678350")]
	private bool IsRopeLongEnough()
	{
		return default(bool);
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00004338 File Offset: 0x00002538
	[Token(Token = "0x600078F")]
	[Address(RVA = "0x3678650", Offset = "0x3676C50", VA = "0x183678650")]
	private bool CheckForFloor()
	{
		return default(bool);
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000790")]
	[Address(RVA = "0x36777D0", Offset = "0x3675DD0", VA = "0x1836777D0")]
	public activateClimbTop()
	{
	}

	// Token: 0x040005FF RID: 1535
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject _interactionElement;

	// Token: 0x04000600 RID: 1536
	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _minimumRopeLength;

	// Token: 0x04000601 RID: 1537
	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private activateClimb _bottomClimb;

	// Token: 0x04000602 RID: 1538
	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LayerMask _floorLayers;
}
