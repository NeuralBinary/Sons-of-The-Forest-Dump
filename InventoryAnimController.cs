using System;
using Il2CppDummyDll;
using Sons.Crafting;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class InventoryAnimController : MonoBehaviour
{
	// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x29A9A80", Offset = "0x29A8A80", VA = "0x1829A9A80")]
	private void Awake()
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x29A9C60", Offset = "0x29A8C60", VA = "0x1829A9C60")]
	private void OnEnable()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x29A9B70", Offset = "0x29A8B70", VA = "0x1829A9B70")]
	private void OnDisable()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x29A9AB0", Offset = "0x29A8AB0", VA = "0x1829A9AB0")]
	private void OnCraftBegin(CraftingRecipe recipe)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x29A9DE0", Offset = "0x29A8DE0", VA = "0x1829A9DE0")]
	public InventoryAnimController()
	{
	}

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x20")]
	public Animator _playerAnimator;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _camFollowTarget;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _camFollowGroup;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _enableVisPartsTime;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator _tarpAnimator;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _animatedTarp;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject[] _assemblePartsGo;
}
