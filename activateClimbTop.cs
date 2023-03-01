using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

// Token: 0x020000F7 RID: 247
[Token(Token = "0x20000F7")]
public class activateClimbTop : MonoBehaviour
{
	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000737 RID: 1847 RVA: 0x000040E0 File Offset: 0x000022E0
	[Token(Token = "0x170000F1")]
	private bool PlayerIsBellowTop
	{
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2E8BF70", Offset = "0x2E8AF70", VA = "0x182E8BF70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x2E8B100", Offset = "0x2E8A100", VA = "0x182E8B100")]
	private void Awake()
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x2E8BD20", Offset = "0x2E8AD20", VA = "0x182E8BD20")]
	private void OnEnable()
	{
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x2E8BC00", Offset = "0x2E8AC00", VA = "0x182E8BC00")]
	private void OnDisable()
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x2E8BF10", Offset = "0x2E8AF10", VA = "0x182E8BF10")]
	private void Update()
	{
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x000040F8 File Offset: 0x000022F8
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x2E8BE40", Offset = "0x2E8AE40", VA = "0x182E8BE40")]
	private static bool PlayerIsBusy()
	{
		return default(bool);
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073D")]
	[Address(RVA = "0x2E8BB40", Offset = "0x2E8AB40", VA = "0x182E8BB40")]
	private void OnClimbRope(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x2E8B740", Offset = "0x2E8A740", VA = "0x182E8B740")]
	private void GrabEnter()
	{
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
	private void GrabExit()
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x2E8BE70", Offset = "0x2E8AE70", VA = "0x182E8BE70")]
	public void ToggleIcons(bool enable)
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x2E8B980", Offset = "0x2E8A980", VA = "0x182E8B980")]
	private bool IsRopeLongEnough()
	{
		return default(bool);
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x2E8B1E0", Offset = "0x2E8A1E0", VA = "0x182E8B1E0")]
	private bool CheckForFloor()
	{
		return default(bool);
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x2E8BF60", Offset = "0x2E8AF60", VA = "0x182E8BF60")]
	public activateClimbTop()
	{
	}

	// Token: 0x040005DF RID: 1503
	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject _interactionElement;

	// Token: 0x040005E0 RID: 1504
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _minimumRopeLength;

	// Token: 0x040005E1 RID: 1505
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private activateClimb _bottomClimb;

	// Token: 0x040005E2 RID: 1506
	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LayerMask _floorLayers;
}
