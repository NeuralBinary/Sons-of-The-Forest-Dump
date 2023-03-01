using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000041")]
public class HatchBabyTurtle : MonoBehaviour
{
	// Token: 0x060001BA RID: 442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x29A7DB0", Offset = "0x29A6DB0", VA = "0x1829A7DB0")]
	private void Start()
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x29A7AF0", Offset = "0x29A6AF0", VA = "0x1829A7AF0")]
	private void OnEnable()
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x29A7E20", Offset = "0x29A6E20", VA = "0x1829A7E20")]
	private void Update()
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x29A7BF0", Offset = "0x29A6BF0", VA = "0x1829A7BF0")]
	private void Spawn()
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x29A7B20", Offset = "0x29A6B20", VA = "0x1829A7B20")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x29A7B90", Offset = "0x29A6B90", VA = "0x1829A7B90")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x29A7F30", Offset = "0x29A6F30", VA = "0x1829A7F30")]
	public HatchBabyTurtle()
	{
	}

	// Token: 0x040001AE RID: 430
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 _hatchDelay;

	// Token: 0x040001AF RID: 431
	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _hatchableTurtleEggPrefab;

	// Token: 0x040001B0 RID: 432
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _usedInInventory;

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x34")]
	[ItemIdPicker(true)]
	[SerializeField]
	private int _turtleEggItemId;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x38")]
	private bool _isTriggered;

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x3C")]
	private float _waitTime;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x40")]
	private float _startTime;
}
