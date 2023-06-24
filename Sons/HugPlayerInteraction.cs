using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

// Token: 0x02000059 RID: 89
[Token(Token = "0x2000059")]
[AddComponentMenu("Sons/Ai/Interact/Hug Player Interaction")]
public class HugPlayerInteraction : MonoBehaviour, IVailActorInteract
{
	// Token: 0x06000291 RID: 657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
	private void Awake()
	{
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x31B32D0", Offset = "0x31B18D0", VA = "0x1831B32D0")]
	private void Update()
	{
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x31B33A0", Offset = "0x31B19A0", VA = "0x1831B33A0", Slot = "4")]
	public void BeginInteraction(VailActor actor, Action completedCallback, Action interruptedCallback)
	{
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x31B3450", Offset = "0x31B1A50", VA = "0x1831B3450", Slot = "5")]
	public void DoInteract(VailActor actor, float deltaTime, Action completedCallback, Action interruptedCallback)
	{
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x31B3460", Offset = "0x31B1A60", VA = "0x1831B3460", Slot = "6")]
	public void EndInteraction(VailActor actor, Action completedCallback, Action interruptedCallback)
	{
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x31B3520", Offset = "0x31B1B20", VA = "0x1831B3520")]
	public void InterruptInteraction()
	{
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x31B3550", Offset = "0x31B1B50", VA = "0x1831B3550")]
	private void DisablePlayer(bool disable)
	{
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x31B3960", Offset = "0x31B1F60", VA = "0x1831B3960")]
	public HugPlayerInteraction()
	{
	}

	// Token: 0x0400027B RID: 635
	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _cancelActionDelay;

	// Token: 0x0400027C RID: 636
	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _xRange;

	// Token: 0x0400027D RID: 637
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _yRange;

	// Token: 0x0400027E RID: 638
	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x30")]
	private Action _completedAction;

	// Token: 0x0400027F RID: 639
	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x38")]
	private Action _interruptAction;

	// Token: 0x04000280 RID: 640
	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 _originalCamRotatorRange;

	// Token: 0x04000281 RID: 641
	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 _originalMainRotatorRange;

	// Token: 0x04000282 RID: 642
	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x50")]
	private bool _rotatorValuesStored;
}
