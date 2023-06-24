using System;
using Endnight.Utilities.PropertyAttributes;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class ItemLocatorTag : MonoBehaviour
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600001B RID: 27 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x1700000C")]
	public int ItemId
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600001C RID: 28 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700000D")]
	public string ItemName
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x30ADC90", Offset = "0x30AC290", VA = "0x1830ADC90")]
	public void SetItemId(int itemId)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ItemLocatorTag()
	{
	}

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ItemIdPicker(true)]
	private int _itemId;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[ReadOnly]
	private string _name;
}
