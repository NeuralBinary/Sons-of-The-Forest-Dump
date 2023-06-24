using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x02000043 RID: 67
[Token(Token = "0x2000043")]
public class HatchBabyTurtle : MonoBehaviour
{
	// Token: 0x060001D0 RID: 464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x31A6F70", Offset = "0x31A5570", VA = "0x1831A6F70")]
	private void Start()
	{
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x31A70A0", Offset = "0x31A56A0", VA = "0x1831A70A0")]
	private void OnEnable()
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x31A7100", Offset = "0x31A5700", VA = "0x1831A7100")]
	private void Update()
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x31A7220", Offset = "0x31A5820", VA = "0x1831A7220")]
	private void Spawn()
	{
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x31A75C0", Offset = "0x31A5BC0", VA = "0x1831A75C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x31A7660", Offset = "0x31A5C60", VA = "0x1831A7660")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x31A76C0", Offset = "0x31A5CC0", VA = "0x1831A76C0")]
	public HatchBabyTurtle()
	{
	}

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 _hatchDelay;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _hatchableTurtleEggPrefab;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _usedInInventory;

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x34")]
	[ItemIdPicker(true)]
	[SerializeField]
	private int _turtleEggItemId;

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x38")]
	private bool _isTriggered;

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x3C")]
	private float _waitTime;

	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x40")]
	private float _startTime;
}
